using Ninject;
using Prizm.Data.DAL.Synch;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity.Setup;
using Prizm.Main.Properties;
using Prizm.Main.Synch.SerializableEntities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Security.Cryptography;
using System.IO.Compression;
using Prizm.Domain.Entity.Construction;

namespace Prizm.Main.Synch.Export
{
   public class DataExporter : Exporter, IDisposable
   {
      readonly IExportRepository exportRepo;

      [Inject]
      public DataExporter(IExportRepository exportRepo, IEncryptor encryptor, IHasher hasher) : base(encryptor, hasher)
      {
         this.exportRepo = exportRepo;
      }

      public IList<Portion> GetAllPortions()
      {
         return exportRepo.PortionRepo.GetAll();
      }

      public bool AnyNewDataToExport()
      {
          IList<Pipe> pipesToExport = exportRepo.PipeRepo.GetPipesToExport();
         IList<Joint> jointsToExport = exportRepo.JointRepo.GetJointsToExport();
         IList<Component> componentsToExport = exportRepo.ComponentRepo.GetComponentsToExport();

         return (pipesToExport != null && pipesToExport.Count > 0) || 
                (jointsToExport != null && jointsToExport.Count > 0) || 
                (componentsToExport != null && componentsToExport.Count > 0);
      }

      public override ExportResult Export()
      {
         IList<Pipe> pipesToExport = exportRepo.PipeRepo.GetPipesToExport();
         IList<Joint> jointsToExport = exportRepo.JointRepo.GetJointsToExport();
         IList<Component> componentsToExport = exportRepo.ComponentRepo.GetComponentsToExport();
         
         exportRepo.PortionRepo.BeginTransaction();

         Portion portion = new Portion()
         {
             ExportDateTime = DateTime.Now,
             IsExport = true,
             PortionNumber = exportRepo.PortionRepo.GetPortionNumber(exportRepo.ProjectRepo.GetSingle()),
             Project = exportRepo.ProjectRepo.GetSingle()
         };

         foreach (var pipe in pipesToExport)
         {
            portion.Pipes.Add(pipe);
         }

         foreach (var joint in jointsToExport)
         {
            portion.Joints.Add(joint);
         }

         foreach (var component in componentsToExport)
         {
            portion.Components.Add(component);
         }

         exportRepo.PortionRepo.SaveOrUpdate(portion);
         exportRepo.PortionRepo.Commit();

         return Export(portion);
      }

      Data PrepareData(Portion portion, Project project)
      {
         Data data = new Data();
         data.Pipes = new List<PipeObject>();
         data.Joints = new List<JointObject>();
         data.Components = new List<ComponentObject>();
         data.Project = project;

         foreach (var pipe in portion.Pipes)
         {
            data.Pipes.Add(new PipeObject(pipe));
         }

         foreach (var joint in portion.Joints)
         {
            data.Joints.Add(new JointObject(joint));
         }

         foreach (var component in portion.Components)
         {
            data.Components.Add(new ComponentObject(component));
         }

         return data;
      }

      void WriteAttachments(string tempDir, Data data)
      {
         Directory.CreateDirectory(Path.Combine(tempDir, "Attachments"));

         if (data.Pipes != null)
         {
            foreach (PipeObject pipe in data.Pipes)
            {
               if (pipe.Attachments != null)
               {
                  WriteAttachments(tempDir, pipe.Attachments);
               }
            }
         }


         if (data.Joints != null)
         {
            foreach (JointObject joint in data.Joints)
            {
               if (joint.Attachments != null)
               {
                  WriteAttachments(tempDir, joint.Attachments);
               }
            }
         }

         if (data.Components != null)
         {
            foreach (ComponentObject components in data.Components)
            {
               if (components.Attachments != null)
               {
                  WriteAttachments(tempDir, components.Attachments);
               }
            }
         }
      }

      void WriteAttachments(string tempDir, IList<FileObject> attachments)
      {
         foreach (var att in attachments)
         {
            string destFile = Path.Combine(tempDir, "Attachments", att.NewName);
            System.IO.File.Copy(Path.Combine(Environment.CurrentDirectory, "Data", "Attachments", att.NewName), destFile);
            using (FileStream fs = new FileStream(destFile, FileMode.Open))
            {
               byte[] bytes = new byte[fs.Length];
               fs.Read(bytes, 0, bytes.Length);
               fs.Close();

               System.IO.File.WriteAllText(destFile + ".sha1", hasher.GetHash(bytes));
            }
         }
      }


      string CreateTempDir()
      {
         string tempDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
         Directory.CreateDirectory(tempDir);
         return tempDir;
      }

      public override ExportResult Export(Portion portion)
      {
         try
         {
            FireMessage(Resources.Export_ReadingData);

            Project project = exportRepo.ProjectRepo.GetSingle();
            Data data = PrepareData(portion, project);

            FireMessage(Resources.Export_CreateTempStorage);

            string tempDir = CreateTempDir();

            FireMessage(Resources.Export_WritingData);

            WriteManifest(tempDir, portion.Id, portion.PortionNumber, portion.ExportDateTime, project.WorkstationType);

            WriteData<Data>(tempDir, data);

            WriteAttachments(tempDir, data);

            FireMessage(Resources.Export_CreatingArchive);

            ZipContent(tempDir);

            FireDone();

            exportRepo.PipeRepo.BeginTransaction();

            UnmarkPipes(portion);
            UnmarkJoints(portion);
            UnmarkComponents(portion);

            exportRepo.PipeRepo.Commit();
            
            return ExportResult.Success;
         }
         catch (Exception e)
         {
            return FireError(e);
         }
      }

      private void UnmarkPipes(Portion portion)
      {
         foreach (var p in portion.Pipes)
         {
            p.ToExport = false;
            exportRepo.PipeRepo.SaveOrUpdate(p);
         }
      }

      private void UnmarkJoints(Portion portion)
      {
         foreach (var j in portion.Joints)
         {
            j.ToExport = false;
            exportRepo.JointRepo.SaveOrUpdate(j);
         }
      }

      private void UnmarkComponents(Portion portion)
      {
         foreach (var c in portion.Components)
         {
            c.ToExport = false;
            exportRepo.ComponentRepo.SaveOrUpdate(c);
         }
      }

      public void Dispose()
      {
         exportRepo.Dispose();
      }
   }
}
