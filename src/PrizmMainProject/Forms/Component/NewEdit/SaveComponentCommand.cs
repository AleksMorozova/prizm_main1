using Prizm.Data.DAL;
using DevExpress.Mvvm.DataAnnotations;
using Ninject;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DevExpress.Mvvm.POCO;
using Prizm.Main.Properties;
using Prizm.Domain.Entity.Construction;

namespace Prizm.Main.Forms.Component.NewEdit
{
    public class SaveComponentCommand: ICommand
    {
        private readonly IComponentRepositories repos;
        private readonly ComponentNewEditViewModel viewModel;
        private readonly IUserNotify notify;

        [Inject]
        public SaveComponentCommand(
            ComponentNewEditViewModel viewModel,
            IComponentRepositories repo, 
            IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repos = repo;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if(!viewModel.ValidatableView.Validate())
            {
                return;
            }

            var c = repos.ComponentRepo.GetActiveByNumber(viewModel.Component);
            foreach (var component in c)
            {
                repos.ComponentRepo.Evict(component);
            }

            if (c != null && c.Count > 0)
            {
                notify.ShowInfo(
                    string.Concat(Resources.DLG_COMPONENT_DUPLICATE, viewModel.Number),
                    Resources.DLG_COMPONENT_DUPLICATE_HEDER);
                viewModel.Number = string.Empty;
            }
            else
            {
                SaveComponent();
            }
        }



        private void SaveComponent()
        {
            try
            {
                repos.BeginTransaction();
                repos.ComponentRepo.SaveOrUpdate(viewModel.Component);
                repos.Commit();
                repos.ComponentRepo.Evict(viewModel.Component);
                viewModel.CanDeactivateComponent = viewModel.DeactivationCommand.CanExecute();
                viewModel.ModifiableView.IsModified = false;

                //saving attached documents
                if (viewModel.FilesFormViewModel != null)
                {
                    viewModel.FilesFormViewModel.Item = viewModel.Component.Id;
                    viewModel.FilesFormViewModel.AddExternalFileCommand.Execute();
                    viewModel.FilesFormViewModel = null;
                }

                notify.ShowSuccess(
                     string.Concat(Resources.DLG_COMPONENT_SAVED, viewModel.Number),
                     Resources.DLG_COMPONENT_SAVED_HEADER);
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
            return 
                !string.IsNullOrEmpty(viewModel.Number) &&
                viewModel.Type != null;
        }
    }
}
