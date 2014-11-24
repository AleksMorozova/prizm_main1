using System;
using System.ComponentModel;

using Ninject;
using Ninject.Parameters;

using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

using System.Windows.Forms;

using PrizmMain.Forms.Railcar.NewEdit;
using PrizmMain.Forms.MainChildForm;

using PrizmMain.DummyData;


namespace PrizmMain.Forms.Railcar.Search
{
    public partial class RailcarSearchXtraForm : ChildForm
    {
        private RailcarSearchViewModel viewModel;

        public RailcarSearchXtraForm()
        {
            InitializeComponent();
            shippedDate.Properties.NullDate = DateTime.MinValue;
            shippedDate.Properties.NullText = string.Empty;
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
                var parent = this.MdiParent as PrizmApplicationXtraForm;
                parent.CreateChildForm(typeof(RailcarNewEditXtraForm), new ConstructorArgument("railcarNumber", number));
            }
        }

        private void railcarListView_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            if (e.Column.FieldName != "ShippingButton")
            {
                return;
            }
            GridView gv = sender as GridView;
            var tmp = (DateTime?)gv.GetRowCellValue(e.RowHandle, "ShippingDate");
            if (tmp == null)
            {
                e.RepositoryItem = shipGridButton;
            }
            else
            {
                e.RepositoryItem = unshipGridButton;
            }
        }

        private void shipGridButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ship");
        }

        private void unshipGridButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unship");
        }

        private void RailcarSearchXtraForm_Activated(object sender, EventArgs e)
        {
            viewModel.SearchCommand.Execute();
        }
    }
}