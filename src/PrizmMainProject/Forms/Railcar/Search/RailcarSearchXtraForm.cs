using System;
using System.ComponentModel;
using DevExpress.XtraEditors;
using PrizmMain.DummyData;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Windows.Forms;
using PrizmMain.Forms.Railcar.NewEdit;
using Ninject;
using Ninject.Parameters;
using PrizmMain.Forms.MainChildForm;

namespace PrizmMain.Forms.Railcar.Search
{
    public partial class RailcarSearchXtraForm : XtraForm
    {
        private RailcarSearchViewModel viewModel;

        public RailcarSearchXtraForm()
        {
            InitializeComponent();

        }

        private void RailcarSearchXtraForm_Load(object sender, EventArgs e)
        {
            viewModel = (RailcarSearchViewModel)Program.Kernel.GetService(typeof(RailcarSearchViewModel));
            BindCommands();
            BindToViewModel();
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;
            railcarNumber.DataBindings.Add("Editvalue", bindingSource, "RailcarNumber");
            certificateNumber.DataBindings.Add("EditValue", bindingSource, "Certificate");
            destination.DataBindings.Add("EditValue", bindingSource, "Receiver");
            shippedDate.DataBindings.Add("EditValue", bindingSource, "ShippingDate");
            railcarList.DataBindings.Add("DataSource", bindingSource, "Railcars");
        }

        private void BindCommands()
        {
            searchButton.BindCommand(() => viewModel.SearchCommand.Execute(), viewModel.SearchCommand);
        }


        private void railcarListView_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo info = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            if (info.InRow || info.InRowCell)
            {
                
                string number = (string)view.GetRowCellValue(info.RowHandle, "Number");
                var edit = (XtraForm)Program.Kernel.Get<RailcarNewEditXtraForm>(new ConstructorArgument("railcarNumber", number));
                var parent = this.MdiParent as PrizmApplicationXtraForm;
                parent.CreateFormChild(edit);
            }
        }
    }
}