using Prizm.Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DevExpress.Mvvm.POCO;
using Prizm.Main.Properties;

namespace Prizm.Main.Forms.PipeMill.NewEdit
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
            DateTime previousProductionDate = viewModel.Pipe.ProductionDate;
            viewModel.SavePipeCommand.Execute();
             if (viewModel.Number != string.Empty)
            {
                viewModel.NewPipe();
                viewModel.ProductionDate = previousProductionDate;
            }
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
