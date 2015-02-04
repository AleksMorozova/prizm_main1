using Prizm.Data.DAL;
using Prizm.Main.Commands;
using Prizm.Main.Properties;
using Prizm.Main.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.Joint.NewEdit
{
    public class SaveOrUpdateJointCommand: ICommand
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(SaveOrUpdateJointCommand));

        private readonly IConstructionRepository repo;
        private readonly JointNewEditViewModel viewModel;
        private readonly IUserNotify notify;
        private readonly ISecurityContext ctx;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public SaveOrUpdateJointCommand(
            IConstructionRepository repo, 
            JointNewEditViewModel viewModel, 
            IUserNotify notify,
            ISecurityContext ctx)
        {
            this.repo = repo;
            this.viewModel = viewModel;
            this.notify = notify;
            this.ctx = ctx;
        }

        public void Execute()
        {
            try
            {
                repo.BeginTransaction();
                repo.RepoJoint.SaveOrUpdate(viewModel.Joint);
                repo.Commit();
                repo.RepoJoint.Evict(viewModel.Joint);
                viewModel.IsNew = false;
                viewModel.ModifiableView.IsModified = false;

                //saving attached documents
                if (viewModel.FilesFormViewModel != null)
                {
                    viewModel.FilesFormViewModel.Item = viewModel.Joint.Id;
                    viewModel.FilesFormViewModel.AddExternalFileCommand.Execute();
                    viewModel.FilesFormViewModel = null;
                }

                viewModel.ModifiableView.UpdateState();

                notify.ShowNotify(
                    string.Concat(Program.LanguageManager.GetString(StringResources.Joint_Saved), viewModel.Number),
                    Program.LanguageManager.GetString(StringResources.Joint_SavedHeader));

                log.Info(string.Format("The entity #{0}, id:{1} has been saved in DB.",
                    viewModel.Joint.Number,
                    viewModel.Joint.Id));
            }
            catch (RepositoryException ex)
            {
                log.Error(ex.Message);
                notify.ShowFailure(ex.InnerException.Message, ex.Message);
            }
        }


        public bool CanExecute()
        {
             return 
                 !string.IsNullOrEmpty(viewModel.Number) 
                 &&
                    ((viewModel.FirstElement != null && viewModel.SecondElement != null) 
                    || 
                    viewModel.Joint.Status == Domain.Entity.Construction.JointStatus.Withdrawn)
                 && 
                 viewModel.Joint.IsActive
                 && 
                 ctx.HasAccess(viewModel.IsNew 
                                    ? global::Domain.Entity.Security.Privileges.CreateJoint
                                    : global::Domain.Entity.Security.Privileges.EditJoint);
        }
    }
}
