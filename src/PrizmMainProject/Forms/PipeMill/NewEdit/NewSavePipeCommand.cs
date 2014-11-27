using Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// for method RaiseCanExecuteChanged
using DevExpress.Mvvm.POCO;
using PrizmMain.Properties;

namespace PrizmMain.Forms.PipeMill.NewEdit
{
    public class NewSavePipeCommand: ICommand
    {
        private readonly IMillRepository repo;
        private readonly MillPipeNewEditViewModel viewModel;
        private readonly IUserNotify notify;

        public NewSavePipeCommand(
            MillPipeNewEditViewModel viewModel, 
            IMillRepository repo,
            IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repo = repo;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            viewModel.SavePipeCommand.Execute();

            if (viewModel.PipeIsDeactivated)
            {
                if (notify.ShowYesNo(
                    Resources.DLG_PIPE_CREATION,
                    Resources.DLG_PIPE_CREATION_HEDER))
                {
                    return;
                }
            }

            viewModel.NewPipe();
        }


        public virtual bool IsExecutable { get; set; }

        protected virtual void OnIsExecutableChanged()
        {
            this.RaiseCanExecuteChanged(x => x.Execute());
        }


        public bool CanExecute()
        {
            return viewModel.SavePipeCommand.CanExecute();
        }
    }
}
