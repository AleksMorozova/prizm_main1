using DevExpress.Mvvm.DataAnnotations;
using Prizm.Data.DAL;
using Prizm.Main.Commands;
using Prizm.Main.Common;
using Prizm.Main.Properties;
using Prizm.Main.Forms.ExternalFile;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.ExternalFile
{
    public class ViewFileCommand : ICommand
    {
        private readonly IFileRepository repo;
        private readonly ExternalFilesViewModel viewModel;
        private readonly IUserNotify notify;

        public ViewFileCommand(IFileRepository repo, ExternalFilesViewModel viewModel, IUserNotify notify)
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
                string sourceFile = Path.Combine(viewModel.TargetPath, viewModel.SelectedFile.NewName);
                string tempFile = Path.Combine(viewModel.TargetPathForView, Guid.NewGuid() + viewModel.SelectedFile.FileName.Substring(viewModel.SelectedFile.FileName.LastIndexOf('.')));

                if (!Directory.Exists(viewModel.TargetPathForView))
                {
                    Directory.CreateDirectory(viewModel.TargetPathForView);
                    DirectoryInfo directoryInfo = new DirectoryInfo(viewModel.TargetPathForView);
                    directoryInfo.Attributes |= FileAttributes.Hidden;
                }

                if (File.Exists(sourceFile))
                {
                    File.Copy(sourceFile, tempFile);
                    System.Diagnostics.Process.Start(tempFile);
                }
            }
            else
            {
                notify.ShowInfo(Resources.DLG_FILE_VIEW_DOWMLOAD_FAIL, Resources.DLG_FILE_VIEW_DOWMLOAD_FAIL_HEADER);
            }
        }

        public virtual bool IsExecutable { get; set; }

        public bool CanExecute()
        {
            return viewModel.SelectedFile.Id!= Guid.Empty;
        }
    }
}
