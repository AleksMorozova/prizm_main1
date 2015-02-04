using Prizm.Data.DAL.Construction;
using Prizm.Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Main.Properties;
using DevExpress.Mvvm.POCO;
using Prizm.Main.Security;
using Ninject;
using Prizm.Main.Languages;
using Prizm.Data.DAL;

namespace Prizm.Main.Forms.Spool
{
    public class SaveSpoolCommand: ICommand
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(SaveSpoolCommand));

        readonly ISpoolRepositories repos;
        readonly SpoolViewModel viewModel;
        readonly IUserNotify notify;
        readonly ISecurityContext ctx;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public SaveSpoolCommand(SpoolViewModel viewModel, ISpoolRepositories repos, IUserNotify notify, ISecurityContext ctx)
        {
            this.viewModel = viewModel;
            this.repos = repos;
            this.notify = notify;
            this.ctx = ctx;
        }

        [Command(UseCommandManager = false)]
        public void Execute() 
        {
            if (viewModel.Spool.Length != 0)
            {
                if (viewModel.CanCut)
                {
                    try
                    {
                        viewModel.Pipe.ToExport = true;
                        viewModel.Pipe.IsCutOnSpool = true;
                        viewModel.Spool.InspectionStatus = viewModel.Spool.GetPartInspectionStatus();
                        repos.BeginTransaction();
                        repos.PipeRepo.SaveOrUpdate(viewModel.Pipe);
                        repos.SpoolRepo.SaveOrUpdate(viewModel.Spool);
                        repos.Commit();
                        repos.PipeRepo.Evict(viewModel.Pipe);
                        repos.SpoolRepo.Evict(viewModel.Spool);

                        //saving attached documents
                        if (viewModel.FilesFormViewModel != null)
                        {
                            viewModel.FilesFormViewModel.Item = viewModel.Spool.Id;
                            viewModel.FilesFormViewModel.AddExternalFileCommand.Execute();
                            viewModel.FilesFormViewModel = null;
                        }
                        viewModel.IsNew = false;
                        viewModel.ModifiableView.IsModified = false;

                        notify.ShowNotify(
                            Program.LanguageManager.GetString(StringResources.Spool_CutSpoolFromPipe),
                            Program.LanguageManager.GetString(StringResources.Spool_CutSpoolFromPipeHeader)
                            );

                        log.Info(string.Format("The entity #{0}, id:{1} has been saved in DB.",
                            viewModel.Spool.Number,
                            viewModel.Spool.Id));

                        string oldPipeNumber = viewModel.Pipe.Number;
                        viewModel.NewSpool();
                        viewModel.PipeNumber = oldPipeNumber;
                        RefreshVisualStateEvent();
                    }
                    catch (RepositoryException ex)
                    {
                        log.Error(ex.Message);
                        notify.ShowFailure(ex.InnerException.Message, ex.Message);
                    }
                }
                else
                {
                    notify.ShowError(
                         Program.LanguageManager.GetString(StringResources.Spool_SpoolLengtBigerThenPipeLength),
                         Program.LanguageManager.GetString(StringResources.Spool_CutSpoolFromPipeHeader));
                    viewModel.ModifiableView.IsEditMode = true;
                }
            }
            else
            {
                notify.ShowError(
                      Program.LanguageManager.GetString(StringResources.Spool_NullSpoolLength),
                         Program.LanguageManager.GetString(StringResources.Spool_CutSpoolFromPipeHeader));
                viewModel.ModifiableView.IsEditMode = true;
            }
            
        }

        public bool CanExecute()
        {
            return viewModel.ModifiableView.IsEditMode 
                &&viewModel.SpoolIsActive
                &&!string.IsNullOrEmpty(viewModel.PipeNumber)
                && ctx.HasAccess(viewModel.IsNew
                    ? global::Domain.Entity.Security.Privileges.CreateSpool
                    : global::Domain.Entity.Security.Privileges.EditSpool);
        }
    }
}
