using Prizm.Data.DAL.Mill;
using Prizm.Data.DAL.Setup;
using Prizm.Data.DAL;
using DevExpress.Mvvm.DataAnnotations;
using Prizm.Domain.Entity.Setup;
using Prizm.Main.Commands;
using Prizm.Main.Forms.Settings.ViewTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Main.Properties;
using Prizm.Main.Documents;
using Prizm.Domain.Entity.Security;
using Prizm.Main.Security;
using Ninject;

namespace Prizm.Main.Forms.Settings
{
    public class SaveSettingsCommand : ICommand
    {
        readonly ISettingsRepositories repos;
        readonly SettingsViewModel viewModel;
        readonly IUserNotify notify;
        ISecurityContext ctx = Program.Kernel.Get<ISecurityContext>();

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public SaveSettingsCommand(SettingsViewModel viewModel, ISettingsRepositories repos, IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repos = repos;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if(!viewModel.validatableView.Validate())
            {
                notify.ShowError(Resources.CHECK_VALUES, Resources.DLG_ERROR_HEADER);
                return;
            }

            repos.BeginTransaction();
            SaveWelders();
            SaveInspectors();
            SaveMillSizeTypes();
            SavePlateManufacturers();
            repos.ProjectRepo.SaveOrUpdate(viewModel.CurrentProjectSettings);
            SaveRoles();
            SaveUsers();
            SaveCategories();
            SaveJointOperations();
            SaveComponentryType();
            SaveInspectorCertificateType();
            SaveSeamType();
            repos.Commit();
            EvictMillSizeTypes();
            EvictWelders();
            EvictInspectors();
            EvictPlateManufacturers();
            EvictRoles();
            EvictUsers();
            EvictJointOperations();
            repos.ProjectRepo.Evict(viewModel.CurrentProjectSettings);
            EvictCategories();
            EvictComponentryType();
            EvictInspectorCertificateType();
            EvictSeamType();
            viewModel.ModifiableView.IsModified = false;

            notify.ShowNotify(
                Resources.DLG_SETUP_SAVED,
                Resources.DLG_SETUP_SAVED_HEADER);

            RefreshVisualStateEvent();
        }

        private void EvictUsers()
        {
           if (viewModel.Users != null)
           {
              viewModel.Users.ForEach<User>(_ => repos.UserRepo.Evict(_));
           }
        }

        private void SaveUsers()
        {
           if (viewModel.Users != null)
           {
              viewModel.Users.ForEach<User>(_ => repos.UserRepo.SaveOrUpdate(_));
           }
        }

        private void EvictRoles()
        {
           if (viewModel.Roles != null)
           {
              viewModel.Roles.ForEach<Role>(_ => repos.RoleRepo.Evict(_));
           }
        }

        private void SaveRoles()
        {
           if (viewModel.Roles != null)
           {
              viewModel.Roles.ForEach<Role>(_ => repos.RoleRepo.SaveOrUpdate(_));
           }
        }

        private void EvictWelders()
        {
            if (viewModel.Welders != null)
            {
                viewModel.Welders.ForEach<WelderViewType>(_ => repos.WelderRepo.Evict(_.Welder));
            }
        }

        private void EvictMillSizeTypes()
        {
            foreach (PipeMillSizeType t in viewModel.PipeMillSizeType)
            {
                repos.PipeSizeTypeRepo.Evict(t);
            }
        }

        private void EvictJointOperations()
        {
            foreach (JointOperation o in viewModel.JointOperations)
            {
                repos.JointRepo.Evict(o);
            }
        }

        private void EvictPlateManufacturers()
        {
            foreach (Prizm.Domain.Entity.Mill.PlateManufacturer manufacturer in viewModel.PlateManufacturers)
            {
                repos.PlateManufacturerRepo.Evict(manufacturer);
            }
        }

        public bool CanExecute()
        {
            return ctx.HasAccess(global::Domain.Entity.Security.Privileges.EditSettings);
        }

        void SaveMillSizeTypes()
        {
            foreach (PipeMillSizeType t in viewModel.PipeMillSizeType)
            {
                repos.PipeSizeTypeRepo.SaveOrUpdate(t);
            }
        }

        void SaveJointOperations()
        {
            foreach (JointOperation o in viewModel.JointOperations)
            {
                repos.JointRepo.SaveOrUpdate(o);
            }
        }


        void SaveWelders()
        {
            if (viewModel.Welders != null)
            {
                viewModel.Welders.ForEach<WelderViewType>(_ => repos.WelderRepo.SaveOrUpdate(_.Welder));
           }
        }

        void SaveInspectors()
        {
           if (viewModel.Inspectors != null)
           {
              viewModel.Inspectors.ForEach<InspectorViewType>(_ => repos.InspectorRepo.SaveOrUpdate(_.Inspector));
           }
        }

        void EvictInspectors()
        {
           if (viewModel.Inspectors != null)
           {
              viewModel.Inspectors.ForEach<InspectorViewType>(_ => repos.InspectorRepo.Evict(_.Inspector));
            }
        }

        void SavePlateManufacturers()
        {
            foreach (Prizm.Domain.Entity.Mill.PlateManufacturer manufacturer in viewModel.PlateManufacturers)
            {
                repos.PlateManufacturerRepo.SaveOrUpdate(manufacturer);
            }
        }

        
        private void EvictCategories()
        {
            foreach (var category in viewModel.CategoryTypes)
            {
                repos.СategoryRepo.Evict(category);
            }
        }


        private void SaveCategories()
        {
            foreach (var category in viewModel.CategoryTypes)
            {
                repos.СategoryRepo.SaveOrUpdate(category);
            }
        }


        private void EvictComponentryType()
        {
            foreach (var component in viewModel.ComponentryTypes)
            {
                repos.ComponentTypeRepo.Evict(component);
            }
        }


        private void SaveComponentryType()
        {
            foreach (var component in viewModel.ComponentryTypes)
            {
                repos.ComponentTypeRepo.SaveOrUpdate(component);
            }
        }


        private void EvictInspectorCertificateType()
        {
            foreach (var certificate in viewModel.CertificateTypes)
            {
                repos.CertificateTypeRepo.Evict(certificate);
            }
        }


        private void SaveInspectorCertificateType()
        {
            foreach (var certificate in viewModel.CertificateTypes)
            {
                repos.CertificateTypeRepo.SaveOrUpdate(certificate);
            }
        }


        private void EvictSeamType()
        {
            foreach (var seam in viewModel.SeamTypes)
            {
                repos.SeamTypeRepo.Evict(seam);
            }
        }


        private void SaveSeamType()
        {
            foreach (var seam in viewModel.SeamTypes)
            {
                repos.SeamTypeRepo.SaveOrUpdate(seam);
            }
        }

    }
}
