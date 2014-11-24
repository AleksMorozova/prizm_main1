using Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.XtraEditors;
using Domain.Entity.Mill;
using PrizmMain.Commands;
using PrizmMain.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Ninject;

namespace PrizmMain.Forms.Railcar.NewEdit
{
    public class SaveRailcarCommand : ICommand
    {
        private readonly IRailcarRepositories repos;
        private readonly RailcarViewModel viewModel;
        private readonly IUserNotify notify;

        [Inject]
        public SaveRailcarCommand(RailcarViewModel viewModel, IRailcarRepositories repo, IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repos = repo;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if (string.IsNullOrWhiteSpace(viewModel.Railcar.Number))
            {
                notify.ShowError(Resources.DLG_RAILCAR_NUMBER_EMPTY, Resources.DLG_ERROR_HEADER);
                return;
            }
            
                if (viewModel.Railcar.ShippingDate == DateTime.MinValue)
                {
                    viewModel.Railcar.ShippingDate = null;
                }
                try
                {
                    repos.BeginTransaction();
                    repos.RailcarRepo.SaveOrUpdate(viewModel.Railcar);
                    repos.Commit();
                    repos.RailcarRepo.Evict(viewModel.Railcar);
                    notify.ShowSuccess(Resources.AlertSaveRailcar, Resources.AlertSaveHeader);
                }
                catch (Exception ex)
                {
                    notify.ShowFailure(ex.Message, Resources.AlertFailureHeader);
                    throw ex;
                }
        }

        public bool CanExecute()
        {
            return true;
        }
    }
}