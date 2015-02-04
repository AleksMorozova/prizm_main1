using Prizm.Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;
using Prizm.Domain.Entity.Mill;
using Prizm.Main.Commands;
using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Ninject;
using Prizm.Data.DAL;
using Prizm.Main.Security;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.Railcar.NewEdit
{
    public class SaveRailcarCommand : ICommand
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(SaveRailcarCommand));

        private readonly IRailcarRepositories repos;
        private readonly RailcarViewModel viewModel;
        private readonly IUserNotify notify;
        private readonly ISecurityContext ctx;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        [Inject]
        public SaveRailcarCommand(RailcarViewModel viewModel, IRailcarRepositories repo, IUserNotify notify, ISecurityContext ctx)
        {
            this.viewModel = viewModel;
            this.repos = repo;
            this.notify = notify;
            this.ctx = ctx;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if(!viewModel.validatableView.Validate())
            {
                return;
            }

            if(string.IsNullOrWhiteSpace(viewModel.Number))
            {
                notify.ShowError(Program.LanguageManager.GetString(StringResources.ReleaseNoteNewEdit_MissingReleaseNoteNumber), 
                    Program.LanguageManager.GetString(StringResources.Message_ErrorHeader));
                return;
            }


            try
            {

                var notEmpty = viewModel.Railcars.Where(x => x.Pipes.Count == 0).ToList<Domain.Entity.Mill.Railcar>();

                foreach(var item in notEmpty)
                {
                    viewModel.Railcars.Remove(item);
                }

                foreach(var r in viewModel.Railcars)
                {
                    r.ReleaseNote = viewModel.ReleaseNote;
                }

                repos.BeginTransaction();

                repos.ReleaseNoteRepo.SaveOrUpdate(viewModel.ReleaseNote);
                repos.Commit();

                repos.ReleaseNoteRepo.Evict(viewModel.ReleaseNote);
                viewModel.IsNew = false;
                viewModel.ModifiableView.IsModified = false;

                //saving attached documents
                if(viewModel.FilesFormViewModel != null)
                {
                    viewModel.FilesFormViewModel.Item = viewModel.ReleaseNote.Id;
                    viewModel.FilesFormViewModel.AddExternalFileCommand.Execute();
                    viewModel.FilesFormViewModel = null;
                }

                notify.ShowSuccess(Program.LanguageManager.GetString(StringResources.ReleaseNoteNewEdit_SaveSuccess), 
                    Program.LanguageManager.GetString(StringResources.ReleaseNoteNewEdit_SaveSuccessHeader));

                log.Info(string.Format("The entity #{0}, id:{1} has been saved in DB.",
                    viewModel.ReleaseNote.Number,
                    viewModel.ReleaseNote.Id));
            }
            catch(RepositoryException ex)
            {
                log.Error(ex.Message);
                notify.ShowFailure(ex.InnerException.Message, ex.Message);
            }
            RefreshVisualStateEvent();
        }

        public bool CanExecute()
        {
            bool condition = !string.IsNullOrWhiteSpace(viewModel.Number)
                && !viewModel.Shipped;

            bool conditionAndPermission;
            if(viewModel.IsNew)
            {
                conditionAndPermission = condition && ctx.HasAccess(global::Domain.Entity.Security.Privileges.CreateReleaseNote);
            }
            else
            {
                conditionAndPermission = condition && ctx.HasAccess(global::Domain.Entity.Security.Privileges.EditReleaseNote);
            }
            return conditionAndPermission;
        }
    }
}