using Ninject;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Construction;
using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity.Setup;
using Prizm.Main.Common;
using Prizm.Main.Forms.Synch;
using Prizm.Main.Properties;
using Prizm.Main.Synch.Export;
using Prizm.Main.Synch.SerializableEntities;
using Prizm.UnitTests.Synch.SerializableEntities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Prizm.Main.Synch.Import
{
    public class DataImporter : Importer, IDisposable
    {
        readonly IImportRepository importRepo;
        public bool TaskIsCancelled { get; set; }

        [Inject]
        public DataImporter(IImportRepository importRepo, IHasher hasher, IEncryptor encryptor)
            : base(hasher, encryptor)
        {
            this.importRepo = importRepo;
        }

        int progress = 0;

        public override ImportResult Import(string archiveName)
        {
            if (!ArchiveExists(archiveName))
                return ImportResult.Failed;

            progress = 0;

            try
            {
                FireMessage(Resources.Import_TempStorage);
                string tempDir = CreateTempDir();

                FireMessage(Resources.Import_Unzip);
                UnzipContent(archiveName, tempDir);

                progress += 5;
                FireProgress(progress);

                FireMessage(Resources.Import_Checksum);
                ValidateChecksum(Path.Combine(tempDir, "Manifest"));
                ValidateChecksum(Path.Combine(tempDir, "Data"));

                progress += 5;
                FireProgress(progress);

                FireMessage(Resources.Import_Data);
                ImportData(tempDir);
                FireOnDone();
            }
            catch (Exception e)
            {
                return FireError(new ImportException(e.Message, e));
            }


            return ImportResult.Success;
        }

        
        void ImportData(string tempDir)
        {
            Manifest manifest = Deserialize<Manifest>(Path.Combine(tempDir, "Manifest"));

            Data data = Deserialize<Data>(Path.Combine(tempDir, "Data"));

            importRepo.PipeRepo.BeginTransaction();

            CheckPortion(manifest.PortionID);

            Project project = ImportProject(data.Project);
            CheckProjectSequence(project, manifest.PortionNumber);
            if (!TaskIsCancelled)
            {
                IList<Pipe> importedPipes = ImportPipes(manifest, data.Pipes, tempDir);
                IList<Joint> importedJoints = ImportJoints(manifest, data, tempDir);
                IList<Component> importedComponents = ImportComponents(manifest, data, tempDir);

                SavePortionInfo(manifest, importedPipes, importedJoints, importedComponents, project);
            }
            else { tempDir = ""; }
            importRepo.PipeRepo.Commit();
            TaskIsCancelled = false;
            progress = 100;
            FireProgress(progress);
        }


        void CheckPortion(Guid portionId)
        {
            Portion portion = importRepo.PortionRepo.Get(portionId);
            if (portion != null)
                throw new ImportException(Resources.Import_SamePortion);

        }

        /// <summary>
        /// Checks existing portions sequense. If sequences are not equal - generates arrays of existing and missinf elements
        /// portionList - list of existing portions
        /// controlList - list of control values
        /// </summary>
        private void CheckProjectSequence(Project project, int portionNumber)
        {
            List<int> portionList = importRepo.PortionRepo.CheckPortionSequence(project);
            List<int> controlList = (portionNumber == 1) ? new List<int>() { 0 } : Enumerable.Range(1, portionNumber - 1).ToList();
            if (!portionList.SequenceEqual(controlList))
            {          
                MissingEventArgs args = new MissingEventArgs();
                args.MillName = project.MillName;
                args.ExistingPortions= portionList.ToArray<int>();
                args.MissingPortions = (from i in controlList let found = portionList.Any(j => j == i) where !found select i).ToArray<int>();
                FireMissing(args);
            }
        }

        private void SavePortionInfo(Manifest manifest, IList<Pipe> pipes, IList<Joint> joints, IList<Component> components, Project project)
        {
            Portion portion = new Portion();
            portion.ExportDateTime = DateTime.Now;
            portion.Id = manifest.PortionID;
            portion.IsExport = false;
            portion.PortionNumber = manifest.PortionNumber;

            if (pipes != null && pipes.Count > 0)
            {
                foreach (var pipe in pipes)
                {
                    portion.Pipes.Add(pipe);
                }
            }

            if (joints != null && joints.Count > 0)
            {
                foreach (var joint in joints)
                {
                    portion.Joints.Add(joint);
                }
            }

            if (components != null && components.Count > 0)
            {
                foreach (var comp in components)
                {
                    portion.Components.Add(comp);
                }
            }


            if (project != null)
            {
                portion.Project = project;
            }



            importRepo.PortionRepo.Save(portion);
        }

        private void CopyAttachment(string tempDir, Domain.Entity.File file)
        {
            string fileName = Path.Combine(tempDir, "Attachments", file.NewName);
            ValidateChecksum(fileName);
            System.IO.File.Copy(fileName, Path.Combine(System.Environment.CurrentDirectory, "Data", "Attachments", file.NewName), true);
        }

        public void MapSerializableEntityToPipe(string tempDir, PipeObject pipeObj, Pipe pipe)
        {
            pipe.Id = pipeObj.Id;
            pipe.IsActive = pipeObj.IsActive;
            pipe.Number = pipeObj.Number;
            pipe.Length = pipeObj.Length;
            pipe.IsAvailableToJoint = pipeObj.IsAvailableToJoint;
            pipe.ConstructionStatus = pipeObj.ConstructionStatus;
            pipe.InspectionStatus = pipeObj.InspectionStatus;
            pipe.Plate = ImportPlate(pipeObj.Plate);
            pipe.Mill = pipeObj.Mill;
            pipe.Diameter = pipeObj.Diameter;
            pipe.WallThickness = pipeObj.WallThickness;
            pipe.Weight = pipeObj.Weight;
            pipe.ProductionDate = pipeObj.ProductionDate;
            pipe.Type = ImportSizeType(pipeObj.Type);
            pipe.Railcar = ImportRailcar(pipeObj.Railcar);
            pipe.PurchaseOrder = ImportPurchaseOrder(pipeObj.PurchaseOrder);
            pipe.Status = pipeObj.Status;

            if (pipeObj.Spools != null)
            {
                foreach (SpoolObject so in pipeObj.Spools)
                {
                    pipe.Spools.Add(ImportSpool(so, pipe));
                }
            }

            if (pipeObj.Attachments != null)
            {
                if (!Directory.Exists(Directories.TargetPath))
                {
                    Directory.CreateDirectory(Directories.TargetPath);
                    DirectoryInfo directoryInfo = new DirectoryInfo(Directories.TargetPath);
                    directoryInfo.Attributes |= FileAttributes.Hidden;
                }
                pipe.Attachments = new List<Prizm.Domain.Entity.File>();
                foreach (var fileObject in pipeObj.Attachments)
                {
                    Prizm.Domain.Entity.File f = ImportFile(fileObject, pipe.Id);
                    CopyAttachment(tempDir, f);
                }
            }
        }

        private Spool ImportSpool(SpoolObject so, Pipe pipe)
        {
            Spool spool = importRepo.SpoolRepo.Get(so.Id);

            bool isNew = false;

            if (spool == null)
            {
                spool = new Spool();
                isNew = true;
            }

            MapSerializableEntityToSpool(so, spool);
            spool.Pipe = pipe;

            if (isNew)
                importRepo.SpoolRepo.Save(spool);
            else
                importRepo.SpoolRepo.SaveOrUpdate(spool);

            return spool;
        }

        void MapSerializableEntityToSpool(SpoolObject spoolObj, Spool spool)
        {
            spool.Id = spoolObj.Id;
            spool.IsActive = spoolObj.IsActive;
            spool.PipeNumber = spoolObj.PipeNumber;
            spool.Number = spoolObj.Number;
            spool.Length = spoolObj.Length;
            spool.IsAvailableToJoint = spoolObj.IsAvailableToJoint;
            spool.ConstructionStatus = spoolObj.ConstructionStatus;
            spool.InspectionStatus = spoolObj.InspectionStatus;
        }

        private Project ImportProject(ProjectObject projectObj)
        {
            if (projectObj == null)
                return null;

            bool isNew = false;
            Project project = importRepo.ProjectRepo.Get(projectObj.Id);
            if (project == null)
            {
                project = new Project();
                isNew = true;
            }

            project.Id = projectObj.Id;
            project.IsActive = projectObj.IsActive;
            project.Title = projectObj.Title;
            project.Client = projectObj.Client;
            project.MillName = projectObj.MillName;
            project.DocumentSizeLimit = projectObj.DocumentSizeLimit;
            project.WorkstationType = projectObj.WorkstationType;
            project.MillPipeNumberMask = projectObj.MillPipeNumberMask;
            project.MillPipeNumberMaskRegexp = projectObj.MillPipeNumberMaskRegexp;

            if (isNew)
                importRepo.ProjectRepo.Save(project);
            else
                importRepo.ProjectRepo.SaveOrUpdate(project);

            return project;
        }

        private IList<Component> ImportComponents(Manifest manifest, Data data, string tempDir)
        {
            IList<Component> importedComponents = new List<Component>();
            IList<ComponentObject> components = data.Components;

            if (components == null)
                return importedComponents;

            const int PROGRESS_RANGE = 30;

            if (components.Count == 0)
            {
                progress += PROGRESS_RANGE;
                FireProgress(progress);
                return importedComponents;
            }

            int step = PROGRESS_RANGE / components.Count;

            foreach (var compObj in components)
            {
                importedComponents.Add(ImportComponent(tempDir, compObj));
                progress += step;
                FireProgress(progress);
            }

            return importedComponents;
        }

        private IList<Joint> ImportJoints(Manifest manifest, Data data, string tempDir)
        {
            IList<Joint> importedJoints = new List<Joint>();
            List<JointObject> joints = data.Joints;

            if (joints == null)
                return importedJoints;

            const int PROGRESS_RANGE = 30;

            if (joints.Count == 0)
            {
                progress += PROGRESS_RANGE;
                FireProgress(progress);
                return importedJoints;
            }

            int step = PROGRESS_RANGE / joints.Count;

            foreach (var jointObj in joints)
            {
                Joint joint = importRepo.JointRepo.Get(jointObj.Id);
                bool isNew = false;

                if (joint == null)
                {
                    isNew = true;
                    joint = new Joint();
                }

                joint.Id = jointObj.Id;
                joint.IsActive = jointObj.IsActive;
                joint.Number = jointObj.Number;
                joint.NumberKP = jointObj.NumberKP;
                joint.DistanceFromKP = jointObj.DistanceFromKP;

                if (jointObj.LoweringDate != DateTime.MinValue)
                {
                    joint.LoweringDate = jointObj.LoweringDate;
                }
                joint.Status = jointObj.Status;
                joint.GpsLatitude = jointObj.GpsLatitude;
                joint.GpsLongitude = jointObj.GpsLongitude;
                joint.GpsHeight = jointObj.GpsHeight;
                joint.FirstElement = ImportPartData(jointObj.FirstElement, data, tempDir, joint);
                joint.SecondElement = ImportPartData(jointObj.SecondElement, data, tempDir, joint);

                if (jointObj.Attachments != null)
                {
                    joint.Attachments = new List<Domain.Entity.File>();
                    foreach (var file in jointObj.Attachments)
                    {
                        joint.Attachments.Add(ImportFile(file, jointObj.Id));
                    }
                }

                if (isNew)
                    importRepo.JointRepo.Save(joint);
                else
                    importRepo.JointRepo.SaveOrUpdate(joint);

                importedJoints.Add(joint);

                progress += step;
                FireProgress(progress);
            }

            return importedJoints;
        }

        PipeObject FindPipeById(Data data, Guid id)
        {
            PipeObject result = null;
            if (data.Pipes != null)
            {
                foreach (PipeObject po in data.Pipes)
                {
                    if (po.Id == id)
                    {
                        result = po;
                        break;
                    }
                }
            }
            return result;
        }

        ComponentObject FindComponentById(Data data, Guid id)
        {
            ComponentObject result = null;
            if (data.Components != null)
            {
                foreach (ComponentObject c in data.Components)
                {
                    if (c.Id == id)
                    {
                        result = c;
                        break;
                    }
                }
            }
            return result;
        }

        SpoolObject FindSpoolById(Data data, Guid id)
        {
            SpoolObject result = null;
            if (data.Pipes != null)
            {
                foreach (PipeObject po in data.Pipes)
                {
                    if (po.Spools != null)
                    {
                        foreach (var sp in po.Spools)
                        {
                            if (sp.Id == id)
                            {
                                result = sp;
                                break;
                            }
                        }
                    }
                }
            }
            return result;
        }

        private PartData ImportPartData(PartDataObject partDataObj, Data data, string tempDir, Joint joint)
        {
            if (partDataObj == null)
                return null;

            PartType type = partDataObj.PartType;
            Guid partId = partDataObj.Id;

            switch (type)
            {
                case PartType.Pipe:
                    Pipe pipe = importRepo.PipeRepo.Get(partId);

                    bool newPipe = false;
                    if (pipe == null)
                    {
                        PipeObject pipeObj = FindPipeById(data, partId);
                        if (pipeObj != null)
                        {
                            pipe = new Pipe();
                            MapSerializableEntityToPipe(tempDir, pipeObj, pipe);
                            newPipe = true;
                        }
                    }

                    if (pipe != null)
                    {
                        if (newPipe)
                            importRepo.PipeRepo.Save(pipe);
                        else
                            importRepo.PipeRepo.SaveOrUpdate(pipe);
                    }

                    break;
                case PartType.Spool:
                    Spool spool = importRepo.SpoolRepo.Get(partId);

                    bool isNewSpool = false;
                    if (spool == null)
                    {
                        SpoolObject spoolObj = FindSpoolById(data, partId);
                        if (spoolObj != null)
                        {
                            spool = new Spool();
                            MapSerializableEntityToSpool(spoolObj, spool);
                            isNewSpool = true;
                        }
                    }

                    if (spool != null)
                    {
                        if (isNewSpool)
                            importRepo.SpoolRepo.Save(spool);
                        else
                            importRepo.SpoolRepo.SaveOrUpdate(spool);
                    }

                    break;
                case PartType.Component:
                    Component component = importRepo.ComponentRepo.Get(partId);

                    bool isNewComponent = false;
                    if (component == null)
                    {
                        ComponentObject compObj = FindComponentById(data, partId);
                        if (compObj != null)
                        {
                            component = new Component();
                            MapSerializableEntityToComponent(tempDir, compObj, component);
                            isNewComponent = true;
                        }
                    }

                    if (component != null)
                    {
                        if (isNewComponent)
                            importRepo.ComponentRepo.Save(component);
                        else
                            importRepo.ComponentRepo.SaveOrUpdate(component);
                    }

                    break;
            }

            if (partDataObj.Connectors != null)
            {
                foreach (ConnectorObject co in partDataObj.Connectors)
                {
                    ImportConnector(tempDir, co, joint);
                }
            }

            PartData pd = new PartData();
            pd.Id = partId;
            pd.PartType = type;
            return pd;
        }

        void ImportConnector(string tempDir, ConnectorObject co, Joint joint)
        {
            Component component = ImportComponent(tempDir, co.Component);

            Connector connector = new Connector();
            connector.Component = component;
            connector.Joint = joint;
            connector.IsActive = co.IsActive;
            connector.WallThickness = co.WallThickness;
            connector.Diameter = co.Diameter;

            importRepo.ComponentRepo.SaveOrUpdate(component);
        }

        Component ImportComponent(string tempDir, ComponentObject compObj)
        {
            Component component = importRepo.ComponentRepo.Get(compObj.Id);

            bool isNew = false;
            if (component == null)
            {
                isNew = true;
                component = new Component();
            }

            MapSerializableEntityToComponent(tempDir, compObj, component);

            if (isNew)
                importRepo.ComponentRepo.Save(component);
            else
                importRepo.ComponentRepo.SaveOrUpdate(component);

            return component;
        }

        void MapSerializableEntityToComponent(string tempDir, ComponentObject compObj, Component component)
        {
            component.Id = compObj.Id;
            component.IsActive = compObj.IsActive;
            component.Certificate = compObj.Certificate;
            component.Type = ImportComponentType(compObj.Type);
            component.Number = compObj.Number;
            component.Length = compObj.Length;
            component.IsAvailableToJoint = compObj.IsAvailableToJoint;
            component.ConstructionStatus = compObj.ConstructionStatus;
            component.InspectionStatus = compObj.InspectionStatus;

            if (compObj.Attachments != null)
            {
                component.Attachments = new List<Domain.Entity.File>();
                foreach (var file in compObj.Attachments)
                {
                    component.Attachments.Add(ImportFile(file, component.Id));
                }
            }
        }

        private ComponentType ImportComponentType(ComponentTypeObject componentTypeObject)
        {
            if (componentTypeObject == null)
                return null;

            bool isNew = false;
            ComponentType componentType = importRepo.ComponentTypeRepo.Get(componentTypeObject.Id);
            if (componentType == null)
            {
                isNew = true;
                componentType = new ComponentType();
            }

            componentType.Id = componentTypeObject.Id;
            componentType.IsActive = componentTypeObject.IsActive;
            componentType.Name = componentTypeObject.Name;
            componentType.ConnectorsCount = componentTypeObject.ConnectorsCount;


            if (isNew)
                importRepo.ComponentTypeRepo.Save(componentType);
            else
                importRepo.ComponentTypeRepo.SaveOrUpdate(componentType);

            return componentType;
        }

        private IList<Pipe> ImportPipes(Manifest manifest, List<PipeObject> pipes, string tempDir)
        {
            IList<Pipe> importedPipes = new List<Pipe>();
            const int PROGRESS_RANGE = 30;

            if (pipes.Count == 0)
            {
                progress += PROGRESS_RANGE;
                FireProgress(progress);
                return importedPipes;
            }

            int step = PROGRESS_RANGE / pipes.Count;
            ConflictDecision decision = ConflictDecision.Undef;
            bool forAll = false;

            foreach (var pipeObj in pipes)
            {
                Pipe pipe = importRepo.PipeRepo.Get(pipeObj.Id);
                if (pipe == null)
                {
                    pipe = new Pipe();

                    MapSerializableEntityToPipe(tempDir, pipeObj, pipe);

                    Project currentProject = importRepo.ProjectRepo.GetSingle();
                    pipe.ToExport = currentProject.WorkstationType == WorkstationType.Master && manifest.WorkstationType == WorkstationType.Mill;

                    importRepo.PipeRepo.Save(pipe);

                    importedPipes.Add(pipe);

                    progress += step;
                    FireProgress(progress);
                }
                else
                {
                    if (decision == ConflictDecision.Undef || !forAll)
                    {
                        ConflictEventArgs args = new ConflictEventArgs();
                        args.Message = string.Format(Resources.Import_Conflict, pipeObj.Number);
                        FireConflict(args);
                        decision = args.Decision;
                        forAll = args.ForAll;
                    }

                    switch (decision)
                    {
                        case ConflictDecision.Skip:
                            break;
                        case ConflictDecision.Replace:
                            Pipe existingPipe = importRepo.PipeRepo.Get(pipeObj.Id);
                            MapSerializableEntityToPipe(tempDir, pipeObj, existingPipe);
                            importRepo.PipeRepo.SaveOrUpdate(existingPipe);
                            importedPipes.Add(existingPipe);
                            break;
                        case ConflictDecision.Postpone:
                            Dump(pipeObj, manifest.PortionID, tempDir);
                            CreateNotification(pipeObj);
                            break;
                    }
                    progress += step;
                    FireProgress(progress);
                }
            }

            return importedPipes;
        }

        void Dump(PipeObject pipeObj, Guid portionId, string tempDir)
        {
            Conflict conflict = new Conflict();
            conflict.PortionID = portionId;
            conflict.Pipe = pipeObj;

            string conflictDir = Path.Combine(System.Environment.CurrentDirectory, "Conflicts");

            if (!Directory.Exists(conflictDir))
                Directory.CreateDirectory(conflictDir);

            string dumpFilePath = Path.Combine(conflictDir, pipeObj.Id + ".xml");

            if (System.IO.File.Exists(dumpFilePath))
                System.IO.File.Delete(dumpFilePath);

            string attDir = Path.Combine(conflictDir, pipeObj.Id + "_Attachments");
            if (pipeObj.Attachments != null && pipeObj.Attachments.Count > 0)
            {
                if (Directory.Exists(attDir))
                    Directory.Delete(attDir, true);

                Directory.CreateDirectory(attDir);

                foreach (var file in pipeObj.Attachments)
                {
                    string attPathInTemp = Path.Combine(tempDir, "Attachments", file.NewName);
                    string targetPath = Path.Combine(attDir, file.NewName);

                    System.IO.File.Copy(attPathInTemp, targetPath, true);
                }
            }

            XmlSerializer serializer = new XmlSerializer(typeof(Conflict));
            using (FileStream fs = new FileStream(dumpFilePath, FileMode.Create))
            {
                serializer.Serialize(fs, conflict);
            }
        }

        void CreateNotification(PipeObject pipeObj)
        {
            //TODO: Notification should be created here.
        }

        private Plate ImportPlate(PlateObject plateObj)
        {
            if (plateObj == null)
                return null;

            bool isNew = false;
            Plate plate = importRepo.PlateRepo.Get(plateObj.Id);
            if (plate == null)
            {
                plate = new Plate();
                isNew = true;
            }

            plate.Id = plateObj.Id;
            plate.IsActive = plateObj.IsActive;
            plate.Number = plateObj.Number;
            plate.Thickness = plateObj.Thickness;
            plate.Heat = ImportHeat(plateObj.Heat);

            if (isNew)
                importRepo.PlateRepo.Save(plate);
            else
                importRepo.PlateRepo.SaveOrUpdate(plate);

            return plate;
        }

        private Heat ImportHeat(HeatObject heatObj)
        {
            if (heatObj == null)
                return null;

            bool isNew = false;
            Heat heat = importRepo.HeatRepo.Get(heatObj.Id);
            if (heat == null)
            {
                heat = new Heat();
                isNew = true;
            }

            heat.Id = heatObj.Id;
            heat.IsActive = heatObj.IsActive;
            heat.Number = heatObj.Number;
            heat.SteelGrade = heatObj.SteelGrade;
            heat.PlateManufacturer = ImportPlateManifacturer(heatObj.PlateManufacturer);

            if (isNew)
                importRepo.HeatRepo.Save(heat);
            else
                importRepo.HeatRepo.SaveOrUpdate(heat);

            return heat;
        }

        private PlateManufacturer ImportPlateManifacturer(PlateManufacturerObject plateManufacturerObj)
        {
            if (plateManufacturerObj == null)
                return null;

            bool isNew = false;
            PlateManufacturer manufacturer = importRepo.PlateManufacturerRepo.Get(plateManufacturerObj.Id);
            if (manufacturer == null)
            {
                manufacturer = new PlateManufacturer();
                isNew = true;
            }

            manufacturer.Id = plateManufacturerObj.Id;
            manufacturer.Name = plateManufacturerObj.Name;
            manufacturer.IsActive = plateManufacturerObj.IsActive;

            if (isNew)
                importRepo.PlateManufacturerRepo.Save(manufacturer);
            else
                importRepo.PlateManufacturerRepo.SaveOrUpdate(manufacturer);

            return manufacturer;
        }

        private PipeMillSizeType ImportSizeType(SizeTypeObject sizeTypeObj)
        {
            if (sizeTypeObj == null)
                return null;

            bool isNew = false;
            PipeMillSizeType type = importRepo.SizeTypeRepo.Get(sizeTypeObj.Id);
            if (type == null)
            {
                type = new PipeMillSizeType();
                isNew = true;
            }

            type.Id = sizeTypeObj.Id;
            type.IsActive = sizeTypeObj.IsActive;
            type.Type = sizeTypeObj.Type;
            type.Length = sizeTypeObj.Length;
            type.Diameter = sizeTypeObj.Diameter;
            type.Thickness = sizeTypeObj.Thickness;
            type.SeamType = ImportSeamType(sizeTypeObj.SeamType);

            if (isNew)
                importRepo.SizeTypeRepo.Save(type);
            else
                importRepo.SizeTypeRepo.SaveOrUpdate(type);

            return type;
        }

        private SeamType ImportSeamType(SeamTypeObject seamTypeObj)
        {
            if (seamTypeObj == null)
                return null;

            bool isNew = false;
            SeamType seamType = importRepo.SeamTypeRepo.Get(seamTypeObj.Id);
            if (seamType == null)
            {
                seamType = new SeamType();
                isNew = true;
            }

            seamType.Id = seamTypeObj.Id;
            seamType.IsActive = seamTypeObj.IsActive;
            seamType.Name = seamTypeObj.Name;

            if (seamTypeObj.SeamTypes != null)
            {
                foreach (var st in seamTypeObj.SeamTypes)
                {
                    seamType.SeamTypes.Add(ImportSeamType(st));
                }
            }

            if (isNew)
                importRepo.SeamTypeRepo.Save(seamType);
            else
                importRepo.SeamTypeRepo.SaveOrUpdate(seamType);

            return seamType;
        }

        private Railcar ImportRailcar(RailcarObject railcarObj)
        {
            if (railcarObj == null)
                return null;

            bool isNew = false;
            Railcar railcar = importRepo.RailcarRepo.Get(railcarObj.Id);
            if (railcar == null)
            {
                railcar = new Railcar();
                isNew = true;
            }

            railcar.Id = railcarObj.Id;
            railcar.IsActive = railcarObj.IsActive;
            railcar.Number = railcarObj.Number;
            railcar.Certificate = railcarObj.Certificate;
            railcar.Destination = railcarObj.Destination;
            railcar.IsShipped = railcarObj.IsShipped;

            if (isNew)
                importRepo.RailcarRepo.Save(railcar);
            else
                importRepo.RailcarRepo.SaveOrUpdate(railcar);

            return railcar;
        }

        private PurchaseOrder ImportPurchaseOrder(PurchaseOrderObject purchaseOrderObj)
        {
            if (purchaseOrderObj == null)
                return null;

            bool isNew = false;
            PurchaseOrder order = importRepo.PurchaseOrderRepo.Get(purchaseOrderObj.Id);
            if (order == null)
            {
                order = new PurchaseOrder();
                isNew = true;
            }

            order.Id = purchaseOrderObj.Id;
            order.IsActive = purchaseOrderObj.IsActive;
            order.Number = purchaseOrderObj.Number;
            order.Date = purchaseOrderObj.Date;

            if (isNew)
                importRepo.PurchaseOrderRepo.Save(order);
            else
                importRepo.PurchaseOrderRepo.SaveOrUpdate(order);

            return order;
        }

        public T Deserialize<T>(string file, bool encrypted = true)
        {
            byte[] bytes;
            using (FileStream fs = new FileStream(file, FileMode.Open))
            {
                bytes = new byte[fs.Length];
                fs.Read(bytes, 0, bytes.Length);
                fs.Close();
            }

            byte[] decrypted;
            if (encrypted)
            {
                decrypted = encryptor.Decrypt(bytes, "^PRIZM_ENCRYPTION_KEY$");
            }
            else
            {
                decrypted = bytes;
            }


            string xml = Encoding.Unicode.GetString(decrypted);

            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StringReader sr = new StringReader(xml);
            T data = (T)serializer.Deserialize(sr);

            return data;
        }

        private Domain.Entity.File ImportFile(FileObject fileObj, Guid itemId)
        {
            if (fileObj == null)
                return null;

            bool isNew = false;
            Domain.Entity.File file = importRepo.FileRepo.Get(fileObj.Id);
            if (file == null)
            {
                isNew = true;
                file = new Domain.Entity.File();
            }

            file.Id = fileObj.Id;
            file.IsActive = fileObj.IsActive;
            file.FileName = fileObj.FileName;
            file.Description = fileObj.Description;
            file.UploadDate = fileObj.UploadDate;
            file.NewName = fileObj.NewName;
            file.Item = itemId;

            if (isNew)
                importRepo.FileRepo.Save(file);
            else
                importRepo.FileRepo.SaveOrUpdate(file);

            return file;
        }

        string CreateTempDir()
        {
            string tempDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Directory.CreateDirectory(tempDir);
            return tempDir;
        }

        public void Dispose()
        {
            importRepo.Dispose();
        }
    }
}
