using Prizm.Data.DAL;
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
using Prizm.Main.Properties;

namespace Prizm.Main.Forms.ExternalFile
{
    public class ExternalFilesViewModel: ViewModelBase, IDisposable
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(ExternalFilesViewModel));

        private readonly IFileRepository repo;
        private readonly AddExternalFileCommand addExternalFileCommand;
        private readonly DownloadFileCommand downloadFileCommand;
        private readonly ViewFileCommand viewFileCommand;
        private readonly IUserNotify notify;
        private readonly Guid item;
        private BindingList<Prizm.Domain.Entity.File> files;
        private Prizm.Domain.Entity.File selectedFile;
        public Dictionary<string, string> FilesToAttach = new Dictionary<string, string>();
        public Guid Item { get; set; }

        [Inject]
        public ExternalFilesViewModel(IFileRepository repo, Guid item, IUserNotify notify)
        {
            this.repo = repo;
            this.item = item;
            this.notify = notify;
            if (item!= Guid.Empty)
            {
                RefreshFiles();
            }
            else 
            { 
                files = new BindingList<Prizm.Domain.Entity.File>(); 
            }

            addExternalFileCommand =
              ViewModelSource.Create(() => new AddExternalFileCommand(repo, this, notify));
            downloadFileCommand =
              ViewModelSource.Create(() => new DownloadFileCommand(repo, this, notify));
            viewFileCommand =
              ViewModelSource.Create(() => new ViewFileCommand(repo, this, notify));
        }

        public void RefreshFiles()
        {
            var fileList = repo.GetByItem(item);
            if (fileList != null)
            {
                files = new BindingList<Prizm.Domain.Entity.File>(fileList);
            }
            else
            {
                log.Warn(string.Format("List of attached files for Entity id:{0} is NULL", item));
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
            repo.Dispose();
            if (Directory.Exists(Directories.TargetPathForView))
            {
                Directory.Delete(Directories.TargetPathForView, true);
            }
        }

        public bool TrySaveFiles()
        {
            bool result = true;
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
                        result = false;
                        RemoveCopiedFilesIfError();
                        break;
                    }
                }
            }
            return result;
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
        public void PersistFiles(IComponentRepositories repos)
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
                repos.FileRepo.Save(fileEntity);
            }

            notify.ShowNotify(Program.LanguageManager.GetString(StringResources.ExternalFiles_FileAttachSuccess), 
                Program.LanguageManager.GetString(StringResources.ExternalFiles_FileAttachSuccessHeader));
        }
        
    }
}
