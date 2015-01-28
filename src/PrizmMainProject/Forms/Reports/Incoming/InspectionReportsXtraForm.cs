using DevExpress.XtraEditors;
using Prizm.Main.Commands;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Languages;
using System;
using System.Collections.Generic;

namespace Prizm.Main.Forms.Reports.Incoming
{
    [System.ComponentModel.DesignerCategory("Form")] 
    public partial class InspectionReportsXtraForm : ChildForm
    {
        private InspectionReportsViewModel viewModel;
        private ICommandManager commandManager = new CommandManager();

        public InspectionReportsXtraForm()
        {
            InitializeComponent();
        }
        private void BindToViewModel()
        {
            inspectionReportsBindingSource.DataSource = viewModel;
            startDate.DataBindings.Add("EditValue", inspectionReportsBindingSource, "StartDate");
            endDate.DataBindings.Add("EditValue", inspectionReportsBindingSource, "EndDate");
            previewReportDocument.DataBindings.Add("DocumentSource", inspectionReportsBindingSource, "PreviewSource");
        }

        private void BindCommands()
        {
           commandManager["CreateReport"].Executor(viewModel.CreateCommand).AttachTo(createReportButton);
           commandManager["PreviewReport"].Executor(viewModel.PreviewCommand).AttachTo(previewButton);
        }

        private void InspectionReportsXtraForm_Load(object sender, EventArgs e)
        {
            viewModel = (InspectionReportsViewModel)Program.Kernel.GetService(typeof(InspectionReportsViewModel));
            BindToViewModel();
            BindCommands();
            viewModel.StartDate = DateTime.Now.Date;
            viewModel.EndDate = DateTime.Now.Date;
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                // layout items
                new LocalizedItem(incomingInspectionDateLabel, "InspectionReport_DateLabel"),
                new LocalizedItem(startDateLayout, "InspectionReport_StartDateLabel"),
                new LocalizedItem(endDateLayout, "InspectionReport_EndDateLabel"),

                new LocalizedItem(createReportLayoutGroup, "InspectionReport_CreateGroup"),
                new LocalizedItem(previewReportLayoutGroup, "InspectionReport_PreviewGroup"),

                new LocalizedItem(previewButton, "InspectionReport_PreviewButton"),
                new LocalizedItem(createReportButton, "InspectionReport_CreateButton")
            };
        }

        #endregion // --- Localization ---

        private void InspectionReportsXtraForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            commandManager.Dispose();
            viewModel = null;
        }
    }
}