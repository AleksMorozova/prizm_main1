using Prizm.Data.DAL;
using DevExpress.Mvvm.DataAnnotations;
using Prizm.Main.Commands;
using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.POCO;

namespace Prizm.Main.Forms.Joint.NewEdit
{
    public class SaveJointCommand : ICommand
    {
        private readonly IConstructionRepository repo;
        private readonly JointNewEditViewModel viewModel;
        private readonly IUserNotify notify;

        public SaveJointCommand(IConstructionRepository repo, JointNewEditViewModel viewModel, IUserNotify notify)
        {
            this.repo = repo;
            this.viewModel = viewModel;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if(!viewModel.ValidatableView.Validate())
            {
                return;
            }

            if (viewModel.Joint.LoweringDate == DateTime.MinValue)
            {
                viewModel.Joint.LoweringDate = null;
            }
            var joints = repo.RepoJoint.GetActiveByNumber(viewModel.Joint);
            foreach (var joint in joints)
            {
                repo.RepoJoint.Evict(joint);
            }
            if (joints != null && joints.Count > 0)
            {
                notify.ShowInfo(
                    string.Concat(Resources.DLG_JOINT_DUPLICATE, viewModel.Number),
                    Resources.DLG_JOINT_DUPLICATE_HEADER);
                viewModel.Number = string.Empty;
            }
            else
            {
                if (viewModel.MakeTheConnection())
                {
                    try
                    {
                        repo.BeginTransaction();
                        repo.RepoJoint.SaveOrUpdate(viewModel.Joint);
                        repo.Commit();
                        repo.RepoJoint.Evict(viewModel.Joint);

                        viewModel.ModifiableView.IsModified = false;

                        viewModel.JointDisconnection();

                        //saving attached documents
                        if (viewModel.FilesFormViewModel != null)
                        {
                            viewModel.FilesFormViewModel.Item = viewModel.Joint.Id;
                            viewModel.FilesFormViewModel.AddExternalFileCommand.Execute();
                            viewModel.FilesFormViewModel = null;
                        }

                        notify.ShowNotify(
                            string.Concat(Resources.DLG_JOINT_SAVED, viewModel.Number),
                            Resources.DLG_JOINT_SAVED_HEADER);
                    }
                    catch (RepositoryException ex)
                    {
                        notify.ShowFailure(ex.InnerException.Message, ex.Message);
                    }
                }
                else
                {
                    notify.ShowInfo(
                    Resources.DLG_JOINT_INCORRECT_DIAMETER,
                    Resources.DLG_JOINT_INCORRECT_DIAMETER_HEADER);
                }
            }
            viewModel.CheckDeactivation();
        }

        public virtual bool IsExecutable { get; set; }

        protected virtual void OnIsExecutableChanged()
        {
            this.RaiseCanExecuteChanged(x => x.Execute());
        }

        public bool CanExecute()
        {
             bool condition = !string.IsNullOrEmpty(viewModel.Number) 
                 && viewModel.FirstElement!=null 
                 && viewModel.SecondElement !=null;

             return condition;
        }
    }
}
