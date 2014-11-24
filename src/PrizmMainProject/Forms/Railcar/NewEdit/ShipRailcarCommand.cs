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
    public class ShipRailcarCommand : ICommand
    {
        private readonly IRailcarRepositories repos;
        private readonly RailcarViewModel viewModel;
        private readonly IUserNotify notify;

        [Inject]
        public ShipRailcarCommand(RailcarViewModel viewModel, IRailcarRepositories repo, IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repos = repo;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            var railcar = viewModel.Railcar;

            if (railcar.Pipes.Count == 0)
            {
                notify.ShowError(Resources.DLG_SHIP_RAILCAR_VS_PIPES, Resources.DLG_ERROR_HEADER);
                return;
            }

            int distinctSizes = viewModel.Railcar.Pipes.Select(p => p.Type).Distinct().Count();

            if (distinctSizes > 1)
            {
                notify.ShowError(Resources.DLG_RAILCAR_TYPESIZE_ERROR, Resources.DLG_ERROR_HEADER);
            }
            else
            {
                try
                {
                    if (railcar.ShippingDate == DateTime.MinValue)
                    {
                        railcar.ShippingDate = DateTime.Now;
                    }

                    foreach (var pipe in railcar.Pipes)
                    {
                        pipe.Status = "Отгружена";
                    }
                    viewModel.SaveCommand.Execute();
                    notify.ShowSuccess(Resources.AlertShipRailcar + " #" + railcar.Number, Resources.AlertInfoHeader);
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
            return !(viewModel.Railcar.ShippingDate != DateTime.MinValue);
        }
    }
}
