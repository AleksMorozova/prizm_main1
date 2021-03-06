﻿using Prizm.Data.DAL;
using DevExpress.Mvvm;
using Prizm.Domain.Entity;
using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Prizm.Main.Forms.Component;
using Prizm.Main.Forms.ExternalFile;
using Prizm.Main.Commands;
using DevExpress.Mvvm.POCO;
using Prizm.Main.Forms;
using Prizm.Main.Common;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.ExternalFile
{
    public class ExternalFilesViewModel: ViewModelBase, IDisposable
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(ExternalFilesViewModel));

        private readonly IExternalFilesRepositories repos;
        private readonly AddExternalFileCommand addExternalFileCommand;
        private readonly DownloadFileCommand downloadFileCommand;
        private readonly ViewFileCommand viewFileCommand;
        private readonly IUserNotify notify;
        private BindingList<Prizm.Domain.Entity.File> files;
        private Prizm.Domain.Entity.File selectedFile;
        private int sizeLimit;
        public Dictionary<string, string> FilesToAttach = new Dictionary<string, string>();
        public Guid Item { get; set; }
        public IFileRepository FileRepo  
        {
            get { return repos.FileRepo; }
            set { repos.FileRepo = value; }
        }

        [Inject]
        public ExternalFilesViewModel(IExternalFilesRepositories repos, IUserNotify notify)
        {
            this.repos = repos;
            this.notify = notify;
           
            addExternalFileCommand =
              ViewModelSource.Create(() => new AddExternalFileCommand(repos.FileRepo, this, notify));
            downloadFileCommand =
              ViewModelSource.Create(() => new DownloadFileCommand(repos.FileRepo, this, notify));
            viewFileCommand =
              ViewModelSource.Create(() => new ViewFileCommand(repos.FileRepo, this, notify));
            sizeLimit = repos.ProjectRepo.GetSingle().DocumentSizeLimit;
        }

        public void RefreshFiles(Guid item)
        {
            if (item != Guid.Empty)
            {
                IList<Prizm.Domain.Entity.File> fileList = new List<Prizm.Domain.Entity.File>();
                try
                {
                    fileList = repos.FileRepo.GetByItem(item);
                }
                catch(RepositoryException ex)
                {
                    log.Warn("ExternalFilesViewModel " + ex.ToString());
                    notify.ShowWarning(Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Message),
                Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Header));
                }
                

                foreach (var dictItem in this.FilesToAttach)
                {
                    Prizm.Domain.Entity.File file = new Domain.Entity.File() 
                    { 
                        FileName = dictItem.Value,
                        UploadDate = DateTime.Now,
                        NewName = string.Format("{0}{1}", Directories.FilesToAttachFolder, dictItem.Key)
                    };
                    fileList.Add(file);
                }

                if (fileList != null)
                {
                    files = new BindingList<Prizm.Domain.Entity.File>(fileList);
                }
                else
                {
                    log.Warn(string.Format("List of attached files for Entity id:{0} is NULL", item));
                }
            }
            else
            {
                if (files == null)
                {
                    files = new BindingList<Prizm.Domain.Entity.File>();
                }
            }
           
        }

        public BindingList<Prizm.Domain.Entity.File> Files
        {
            get { return files; }
            set
            {
                if (value != files)
                {
                    files = value;
                    RaisePropertyChanged("Files");
                }
            }
        }


        public Prizm.Domain.Entity.File SelectedFile
        {
            get { return selectedFile; }
            set
            {
                if (value != selectedFile)
                {
                    selectedFile = value;
                    RaisePropertyChanged("SelectedFile");
                }
            }
        }

        public string SelectedPath { get; set; }

         #region Commands
         public ICommand AddExternalFileCommand
        {
            get { return addExternalFileCommand; }
        }

         public ICommand DownloadFileCommand
         {
             get { return downloadFileCommand; }
         }

         public ICommand ViewFileCommand
         {
             get { return viewFileCommand; }
         }
        #endregion

        public void Dispose()
        {
            repos.FileRepo.Dispose();
            if (Directory.Exists(Directories.TargetPathForView))
            {
                Directory.Delete(Directories.TargetPathForView, true);
            }
        }

        public bool TrySaveFiles(Domain.Entity.Item item)
        {
            bool successCopy = true;
            if (FilesToAttach.Count > 0)
            {
                if (!Directory.Exists(Directories.TargetPath))
                {
                    Directory.CreateDirectory(Directories.TargetPath);
                    DirectoryInfo directoryInfo = new DirectoryInfo(Directories.TargetPath);
                    directoryInfo.Attributes |= FileAttributes.Hidden;
                }
                foreach (KeyValuePair<string, string> kvp in FilesToAttach)
                {
                    var newFileName = kvp.Key;
                    try
                    {
                        System.IO.File.Copy(
                          Directories.FilesToAttachFolder + newFileName,
                          Directories.TargetPath + newFileName
                        );
                    }
                    catch (Exception e)
                    {
                        successCopy = false;
                        log.Error(e.Message);
                        RemoveCopiedFilesIfError();
                        break;
                    }
                }
            }

            if (successCopy)
            {
                PersistFiles(item);
            }

            return successCopy;
        }

        private void RemoveCopiedFilesIfError()
        {
            foreach (KeyValuePair<string, string> kvp in FilesToAttach)
            {
                if (System.IO.File.Exists(Directories.TargetPath + kvp.Key))
                {
                    System.IO.File.Delete(Directories.TargetPath + kvp.Key);
                }
                if (System.IO.File.Exists(Directories.FilesToAttachFolder + kvp.Key))
                {
                    System.IO.File.Delete(Directories.FilesToAttachFolder + kvp.Key);
                }
            }
        }

        public void PersistFiles(Domain.Entity.Item item)
        {
           foreach (KeyValuePair<string, string> kvp in FilesToAttach)
           {
                Prizm.Domain.Entity.File fileEntity = new Domain.Entity.File()
                {
                    FileName = kvp.Value,
                    UploadDate = DateTime.Now,
                    Item = Item,
                    IsActive = true,
                    NewName = kvp.Key
                };

                try
                {
                    repos.FileRepo.Save(fileEntity);
                }
                catch(RepositoryException ex)
                {
                    log.Warn("ExternalFilesViewModel " + ex.ToString());
                    notify.ShowWarning(Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Message),
                Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Header));
                }
                

               if(System.IO.File.Exists(Directories.FilesToAttachFolder + kvp.Key))
               {
                   System.IO.File.Delete(Directories.FilesToAttachFolder + kvp.Key);
               }
           }
           
           FilesToAttach.Clear();

           notify.ShowNotify(Program.LanguageManager.GetString(StringResources.ExternalFiles_FileAttachSuccess),
               Program.LanguageManager.GetString(StringResources.ExternalFiles_FileAttachSuccessHeader));
        }

        public void DetachFileEntities()
        {
            if (Files!= null)
            {
                foreach (var file in Files)
                {
                    try
                    {
                        repos.FileRepo.Evict(file);
                    }
                    catch(RepositoryException ex)
                    {
                        log.Warn("ExternalFilesViewModel " + ex.ToString());
                        notify.ShowWarning(Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Message),
                    Program.LanguageManager.GetString(StringResources.Notification_Error_Db_Header));
                    }

                }
            }

        }

        public int SizeLimit
        { get { return sizeLimit; } }
       
        
    }
}
