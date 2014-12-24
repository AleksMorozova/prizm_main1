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
using Prizm.Main.Forms.ExternalFile;
using Prizm.Main.Commands;
using DevExpress.Mvvm.POCO;
using Prizm.Main.Forms;
using Prizm.Main.Common;

namespace Prizm.Main.Forms.ExternalFile
{
    public class ExternalFilesViewModel: ViewModelBase, IDisposable
    {
        private readonly IWorkWithFilesRepository repo;
        private readonly AddExternalFileCommand addExternalFileCommand;
        private readonly DownloadFileCommand downloadFileCommand;
        private readonly ViewFileCommand viewFileCommand;
        private readonly IUserNotify notify;
        private readonly Guid item;
        private BindingList<Prizm.Domain.Entity.File> files;
        private Prizm.Domain.Entity.File selectedFile;
        public Dictionary<string, string> FilesToAttach = new Dictionary<string, string>();
        public Guid Item { get; set; }
        public string FilesToAttachFolder, TargetPath, TargetPathForView;

        [Inject]
        public ExternalFilesViewModel(IWorkWithFilesRepository repo, Guid item, IUserNotify notify)
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
              ViewModelSource.Create(() => new AddExternalFileCommand(repo.RepoFile, this, notify));
            downloadFileCommand =
              ViewModelSource.Create(() => new DownloadFileCommand(repo.RepoFile, this, notify));
            viewFileCommand =
              ViewModelSource.Create(() => new ViewFileCommand(repo.RepoFile, this, notify));

            string externalFilesFolder = repo.RepoProject.GetSingle().ExternalFilesPath;;
            FilesToAttachFolder = Path.Combine(externalFilesFolder, "Attachments\\FilesToAttach\\");
            TargetPath = Path.Combine(externalFilesFolder, "Attachments\\");
            TargetPathForView = Path.Combine(externalFilesFolder, "Attachments\\tmp\\");

        }

        public void RefreshFiles()
        {
            var fileList = repo.RepoFile.GetByItem(item);
            if (fileList != null)
            {
            files = new BindingList<Prizm.Domain.Entity.File>(fileList);
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
            if (Directory.Exists(TargetPathForView))
            {
                Directory.Delete(TargetPathForView, true);
            }
        }
        
    }
}
