using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Commands;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.Reports.Construction.WeldDateReports
{
    [System.ComponentModel.DesignerCategory("Form")] 
    public partial class WeldDateReportXtraForm : ChildForm
    {
        private WeldDateReportViewModel viewModel;
        private ICommandManager commandManager = new CommandManager();

        public WeldDateReportXtraForm()
        {
            InitializeComponent();

            weldDateFrom.Properties.NullDate = DateTime.MinValue;
            weldDateFrom.Properties.NullText = string.Empty;
            weldDateTo.Properties.NullDate = DateTime.MinValue;
            weldDateTo.Properties.NullText = string.Empty;
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;

            weldDateFrom.DataBindings
                .Add("EditValue", bindingSource, "WeldDateFrom");

            weldDateTo.DataBindings
                .Add("EditValue", bindingSource, "WeldDateTo");

            jointReportViewer.DataBindings
                .Add("DocumentSource", bindingSource, "PreviewSource");
        }

        private void BindCommands()
        {
            commandManager["CreateReport"]
                .Executor(viewModel.CreateRepoCommand).AttachTo(createReportButton);

            commandManager["PreviewButton"]
                .Executor(viewModel.PreviewRepoCommand).AttachTo(previewButton);
        }

        private void WeldDateReportXtraForm_Load(object sender, EventArgs e)
        {
            viewModel =
                (WeldDateReportViewModel)
                Program.Kernel.GetService(
                typeof(WeldDateReportViewModel));

            BindToViewModel();
            BindCommands();
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                new LocalizedItem(weldDateFromLayout, "WeldDateReport_WeldDateFromLayout"),
                new LocalizedItem(weldDateToLayout, "WeldDateReport_WeldDateToLayout"),
                new LocalizedItem(previewButton, "WeldDateReport_PreviewButton"),
                new LocalizedItem(createReportButton, "WeldDateReport_CreateReportButton"),
                new LocalizedItem(weldReportParameterGroup, "WeldDateReport_WeldReportParameterGroup"),
                new LocalizedItem(jointReportViewerGroup, "WeldDateReport_JointReportViewerGroup"),
            };
        }

        #endregion // --- Localization ---

    }
}