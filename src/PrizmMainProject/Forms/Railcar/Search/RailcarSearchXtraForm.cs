using System;
using System.ComponentModel;

using Ninject;
using Ninject.Parameters;

using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

using System.Windows.Forms;

using Prizm.Main.Forms.Railcar.NewEdit;
using Prizm.Main.Forms.MainChildForm;

using Prizm.Main.DummyData;
using Prizm.Main.Commands;
using Prizm.Main.Languages;
using System.Collections.Generic;
using Prizm.Main.Properties;
using System.Drawing;


namespace Prizm.Main.Forms.Railcar.Search
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class RailcarSearchXtraForm : ChildForm
    {
        private ICommandManager commandManager = new CommandManager();
        private RailcarSearchViewModel viewModel;

        public RailcarSearchXtraForm()
        {
            InitializeComponent();
            Bitmap bmp = Resources.search_icon;
            this.Icon = Icon.FromHandle(bmp.GetHicon());
            releaseNoteDate.Properties.NullDate = DateTime.MinValue;
            releaseNoteDate.Properties.NullText = string.Empty;
            this.certificateNumber.SetAsIdentifier();
            this.railcarNumber.SetAsIdentifier();
            this.releaseNoteNumber.SetAsIdentifier();
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

            railcarNumber.DataBindings.Add("EditValue", bindingSource, "RailcarNumber");
            certificateNumber.DataBindings.Add("EditValue", bindingSource, "Certificate");
            destination.DataBindings.Add("EditValue", bindingSource, "Receiver");
            releaseNoteNumber.DataBindings.Add("EditValue", bindingSource, "ReleaseNoteNumber");
            releaseNoteDate.DataBindings.Add("EditValue", bindingSource, "ReleaseNoteDate");
            //releasesGrid.DataSource = viewModel.Projection;
            releasesGrid.DataBindings.Add("DataSource", bindingSource, "Projection");

        }

        private void BindCommands()
        {
            commandManager["Search"].Executor(viewModel.SearchCommand).AttachTo(searchButton);
            viewModel.SearchCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                // layout items
                new LocalizedItem(releaseNoteNumberayout, "ReleaseSearch_NumberLabel"),
                new LocalizedItem(releaseNoteDateLayout, "ReleaseSearch_DateLabel"),
                new LocalizedItem(destinationLayout, "ReleaseSearch_DestinationLabel"),
                new LocalizedItem(railcarNumberLayout, "ReleaseSearch_RailcarLabel"),
                new LocalizedItem(certificateNumberLayout, "ReleaseSearch_CertificateLabel"),

                // controls
                new LocalizedItem(searchButton, "NewEditPipe_SearchButton"),

                // grid column headers
                new LocalizedItem(releaseNoteNumberGridColumn, "ReleaseSearch_ReleaseNumberColumnHeader"),
                new LocalizedItem(releaseNoteDateGridColumn, "ReleaseSearch_ReleaseDateColumnHeader"),
                new LocalizedItem(number, "ReleaseSearch_RailcarNumberColumnHeader"),
                new LocalizedItem(dest, "ReleaseSearch_DestinationColumnHeader"),
                new LocalizedItem(certificate, "ReleaseSearch_CertificateColumnHeader"),
                new LocalizedItem(statusColumn, "ReleaseSearch_RailcarNumberColumnHeader"),

                // layout control groups
                new LocalizedItem(searchParametersLayoutGroup, "ReleaseSearch_SearchGroup"),
                new LocalizedItem(resultParametersLayoutGroup, "ReleaseSearch_ResultGroup")

                // other
            };
        }


        #endregion // --- Localization ---

        private void railcarListView_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo info = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            if(info.InRow || info.InRowCell)
            {

                Guid id = (Guid)view.GetRowCellValue(info.RowHandle, "Id");
                var parent = this.MdiParent as PrizmApplicationXtraForm;
                parent.CreateRailcarForm(id);
            }
        }

        private void railcarListView_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                railcarListView_DoubleClick(sender, e);
            }
        }

        private void RailcarSearchXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            commandManager.Dispose();
            if(viewModel != null)
            {
                viewModel.Dispose();
                viewModel = null;
            }
        }
    }
}