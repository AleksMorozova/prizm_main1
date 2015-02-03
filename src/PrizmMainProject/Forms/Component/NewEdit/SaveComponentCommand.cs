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
using Prizm.Main.Security;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.Component.NewEdit
{
    public class SaveComponentCommand: ICommand
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(SaveComponentCommand));

        private readonly IComponentRepositories repos;
        private readonly ComponentNewEditViewModel viewModel;
        private readonly IUserNotify notify;
        private readonly ISecurityContext ctx;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        [Inject]
        public SaveComponentCommand(
            ComponentNewEditViewModel viewModel,
            IComponentRepositories repo, 
            IUserNotify notify,
            ISecurityContext ctx)
        {
            this.viewModel = viewModel;
            this.repos = repo;
            this.notify = notify;
            this.ctx = ctx;
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
                    string.Concat(Program.LanguageManager.GetString(StringResources.ComponentNewEdit_Duplicate), " ", viewModel.Number),
                    Program.LanguageManager.GetString(StringResources.ComponentNewEdit_DuplicateHeader));
                viewModel.Number = string.Empty;
            }
            else
            {
                try
                {
                    viewModel.Component.InspectionStatus = viewModel.Component.GetPartInspectionStatus();
                    repos.BeginTransaction();
                    

                    var filesViewModel = viewModel.FilesFormViewModel;
                    viewModel.FilesFormViewModel.Item = viewModel.Component.Id;

                    
                    //saving attached documents

                    bool fileCopySuccess = true;
                    if ((null != filesViewModel) && (filesViewModel.FilesToAttach.Count != 0))
                    {
                        if (viewModel.FilesFormViewModel.TrySaveFiles())
                        {
                            viewModel.FilesFormViewModel.PersistFiles(repos);
                        }
                        else
                        {
                            fileCopySuccess = false;
                            repos.Rollback();
                        }
                    }


                    if (fileCopySuccess)
                    {
                        repos.ComponentRepo.SaveOrUpdate(viewModel.Component);
                        repos.Commit();
                        repos.ComponentRepo.Evict(viewModel.Component);
                        viewModel.ModifiableView.IsModified = false;
                        viewModel.ModifiableView.UpdateState();

                        if ((null != filesViewModel) && (filesViewModel.Files.Count > 0))
                        {
                            foreach (var file in viewModel.FilesFormViewModel.Files)
                            {
                                repos.FileRepo.Evict(file);
                            }
                            viewModel.FilesFormViewModel = null;
                        }

                        notify.ShowSuccess(
                            string.Concat(Program.LanguageManager.GetString(StringResources.ComponentNewEdit_Saved),viewModel.Number),
                            Program.LanguageManager.GetString(StringResources.ComponentNewEdit_SavedHeader));
                    }
                    else
                    {
                        notify.ShowError(Program.LanguageManager.GetString(StringResources.ExternalFiles_NotCopied),
                            Program.LanguageManager.GetString(StringResources.ExternalFiles_NotCopied_Header));
                    }
   

                }
                catch (RepositoryException ex)
                {
                    log.Error(ex.Message);
                    notify.ShowFailure(ex.InnerException.Message, ex.Message);
                }
            }
            RefreshVisualStateEvent();
        }


        public bool CanExecute()
        {
            return !string.IsNullOrEmpty(viewModel.Number)
                && viewModel.Type != null
                && viewModel.Component.IsActive
                && ctx.HasAccess(viewModel.IsNew
                                    ? global::Domain.Entity.Security.Privileges.CreateComponent
                                    : global::Domain.Entity.Security.Privileges.EditComponent);
        }
               
    }
}
