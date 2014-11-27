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
using Data.DAL;

namespace PrizmMain.Forms.PipeMill.NewEdit
{
    public class SavePipeCommand: ICommand
    {
        private readonly IMillRepository repo;
        private readonly MillPipeNewEditViewModel viewModel;
        private readonly IUserNotify notify;

        public SavePipeCommand(
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
            if (viewModel.PipeIsDeactivated)
            {
                if (!notify.ShowYesNo(
                    Resources.DLG_PIPE_DEACTIVATION,
                    Resources.DLG_PIPE_DEACTIVATION_HEDER))
                {
                    return;
                }
            }
            try
            {
                repo.BeginTransaction();
                repo.RepoPipe.SaveOrUpdate(viewModel.Pipe);
                repo.Commit();
                repo.RepoPipe.Evict(viewModel.Pipe);
            }
            catch (RepositoryException ex)
            {
                notify.ShowFailure(ex.InnerException.Message, ex.Message);
            }
        }


        public virtual bool IsExecutable { get; set; }

        protected virtual void OnIsExecutableChanged()
        {
            this.RaiseCanExecuteChanged(x => x.Execute());
        }

        public bool CanExecute()
        {
            bool condition = !string.IsNullOrEmpty(viewModel.Heat.Number) &&
                viewModel.PipeMillSizeType != null &&
                viewModel.PipeStatus != null &&
                viewModel.PipePurchaseOrder != null &&
                !string.IsNullOrEmpty(viewModel.Number);

            return condition;
        }
    
    }
}
