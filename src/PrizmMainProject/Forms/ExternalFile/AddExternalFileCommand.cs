using Prizm.Data.DAL;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataAnnotations;
using System.IO;
using Prizm.Main.Common;
using Prizm.Main.Properties;

namespace Prizm.Main.Forms.ExternalFile
{
    public class AddExternalFileCommand : ICommand
    {
        private readonly IFileRepository repo;
        private readonly ExternalFilesViewModel viewModel;
        private readonly IUserNotify notify;

        public AddExternalFileCommand(IFileRepository repo, ExternalFilesViewModel viewModel, IUserNotify notify)
        {
            this.repo = repo;
            this.viewModel = viewModel;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if (CanExecute())
            {
                if (!Directory.Exists(viewModel.TargetPath))
                {
                    Directory.CreateDirectory(viewModel.TargetPath);
                    DirectoryInfo directoryInfo = new DirectoryInfo(viewModel.TargetPath);
                    directoryInfo.Attributes |= FileAttributes.Hidden;
                }
                foreach (KeyValuePair<string, string> kvp in viewModel.FilesToAttach)
                {
                    Prizm.Domain.Entity.File fileEntity = new Domain.Entity.File()
                    {
                        FileName = kvp.Value,
                        UploadDate = DateTime.Now,
                        Item = viewModel.Item,
                        IsActive = true,
                        NewName = kvp.Key
                    };
                    repo.BeginTransaction();
                    repo.Save(fileEntity);
                    repo.Commit();
                    repo.Evict(fileEntity);
                    System.IO.File.Copy(viewModel.FilesToAttachFolder + fileEntity.NewName, viewModel.TargetPath + fileEntity.NewName);
                }

                Directory.Delete(viewModel.FilesToAttachFolder, true);
                notify.ShowNotify(Resources.DLG_FILE_ATTACH_SUCCESS, Resources.DLG_FILE_ATTACH_SUCCESS_HEADER);
            }
        }

        public virtual bool IsExecutable { get; set; }

        public bool CanExecute()
        {
            return viewModel.FilesToAttach.Count != 0;
        }
    }
}
