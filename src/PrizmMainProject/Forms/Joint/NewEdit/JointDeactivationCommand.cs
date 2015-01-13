using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Commands;
using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.POCO;
using Prizm.Main.Security;
using Ninject;


namespace Prizm.Main.Forms.Joint.NewEdit
{
    public class JointDeactivationCommand : ICommand
    {
        private readonly IConstructionRepository repo;
        private readonly JointNewEditViewModel viewModel;
        private readonly IUserNotify notify;
        ISecurityContext ctx = Program.Kernel.Get<ISecurityContext>();

        public JointDeactivationCommand(IConstructionRepository repo, JointNewEditViewModel viewModel, IUserNotify notify)
        {
            this.repo = repo;
            this.viewModel = viewModel;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if (notify.ShowYesNo(
                   Resources.DLG_JOINT_DEACTIVATION,
                   Resources.DLG_JOINT_DEACTIVATION_HEADER))
            {              
                repo.BeginTransaction();
                repo.RepoJoint.Save(viewModel.Joint);
                repo.Commit();
                repo.RepoJoint.Evict(viewModel.Joint);
            }
            else
            {
                viewModel.IsNotActive = false;
            }
        }

        public virtual bool IsExecutable { get; set; }

        protected virtual void OnIsExecutableChanged()
        {
            this.RaiseCanExecuteChanged(x => x.Execute());
        }

        public bool CanExecute()
        {
            return viewModel.Joint.IsActive && 
                   viewModel.Joint.Id != Guid.Empty &&
                   ctx.HasAccess(global::Domain.Entity.Security.Privileges.DeactivateJoint);
        }
    }
}
