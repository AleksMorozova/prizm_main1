using DevExpress.Mvvm.DataAnnotations;
using DevExpress.XtraEditors;
using Ninject;
using PrizmMain.Commands;
using PrizmMain.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrizmMain.Forms.Railcar.NewEdit
{
    public class UnshipRailcarCommand : ICommand
    {
        private readonly IRailcarRepositories repos;
        private readonly RailcarViewModel viewModel;
        private readonly IUserNotify notify;

        [Inject]
        public UnshipRailcarCommand(RailcarViewModel viewModel, IRailcarRepositories repo, IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repos = repo;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if (viewModel.Railcar.ShippingDate == DateTime.MinValue)
            {
                notify.ShowError(Resources.DLG_UNSHIP_UNSHIPPED_RAILCAR, Resources.DLG_ERROR_HEADER);
            }
            else
            {
                try
                {
                    var railcar = viewModel.Railcar;
                    foreach (var pipe in railcar.Pipes)
                    {
                        pipe.Status = "Склад";
                    }
                    railcar.ShippingDate = DateTime.MinValue;
                    notify.ShowSuccess(Resources.AlertUnsipRailcar, Resources.AlertInfoHeader);
                    viewModel.SaveCommand.Execute();
                }
                catch (Exception ex)
                {
                    notify.ShowFailure(ex.Message, Resources.AlertFailureHeader);
                    throw ex;
                }
            }
        }
        public bool CanExecute()
        {
            return (viewModel.Railcar.ShippingDate != DateTime.MinValue);
        }
    }
}
