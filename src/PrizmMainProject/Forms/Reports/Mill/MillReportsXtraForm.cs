using System;
using System.Collections.Generic;

using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;

using Prizm.Main.DummyData;
using Prizm.Main.Forms.MainChildForm;
using DevExpress.XtraReports.Parameters;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Prizm.Domain.Entity.Mill;
using System.Text;
using DevExpress.XtraEditors.Controls;
using Prizm.Main.Common;
using Prizm.Main.Commands;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.Reports.Mill
{
    [System.ComponentModel.DesignerCategory("Form")] 
    public partial class MillReportsXtraForm : ChildForm
    {
        private MillReportsViewModel viewModel;
        private ICommandManager commandManager = new CommandManager(); 

        public MillReportsXtraForm()
        {
            InitializeComponent();
        }

        private void BindToViewModel()
        {
            millReportsBindingSource.DataSource = viewModel;
            startDate.DataBindings.Add("EditValue", millReportsBindingSource, "StartDate");
            endDate.DataBindings.Add("EditValue", millReportsBindingSource, "EndDate");
            previewReportDocument.DataBindings.Add("DocumentSource", millReportsBindingSource, "PreviewSource");
            testCategories.DataSource = viewModel.InspectionCategories;
            testCategories.DisplayMember = "Name";
            testCategories.ValueMember = "Id";
            statuses.DataSource = viewModel.Statuses;
            statuses.DisplayMember = "Text";
            statuses.ValueMember = "Name";
            foreach (var item in EnumWrapper<MillReportType>.EnumerateItems())
            {
                reportTypes.Properties.Items.Add(new RadioGroupItem(item.Item1, item.Item2));
            }

            reportTypes.DataBindings.Add("EditValue", millReportsBindingSource, "SelectedReportType");

        }

        private void BindCommands()
        {
            commandManager["CreateReport"].Executor(viewModel.CreateCommand).AttachTo(createReportButton);
            commandManager["PreviewButton"].Executor(viewModel.PreviewCommand).AttachTo(previewButton);
        }

        private void MillReportsXtraForm_Load(object sender, EventArgs e)
        {
            viewModel = (MillReportsViewModel)Program.Kernel.GetService(typeof(MillReportsViewModel));
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
                //new LocalizedItem(pipeNumberLayout, "NewEditPipe_PipeNumberLabel"),

                // controls
                //new LocalizedItem(attachmentsButton, "NewEditPipe_AttachmentsButton"),

                // grid column headers
                //new LocalizedItem(weldersGridColumn, "NewEditPipe_WeldersColumnHeader"),

                // layout control groups
                //new LocalizedItem(plateLayoutControlGroup, "NewEditPipe_PlateGroup"),

                // other
            };
        }

        #endregion // --- Localization ---

        private void generalReportTypes_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            List<Guid> checkedItems = new List<Guid>();
            foreach (var item in testCategories.CheckedItems)
            {
                var category = item as Category;
                if (category != null)
                    checkedItems.Add(category.Id);
            }
            viewModel.SearchIds = checkedItems;
        }

        private void reportTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (MillReportType)reportTypes.Properties.Items[reportTypes.SelectedIndex].Value;
            viewModel.SelectedReportType = selected;
            testCategories.Enabled = true;
            statuses.Enabled = true;

            
                if (selected != MillReportType.ByCategories)
                {
                    testCategories.Enabled = false;
                    statuses.Enabled = false;
                }
        

        }

        private void statuses_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            List<string> statusList = new List<string>();
            foreach (var item in statuses.CheckedItems)
            {
                var status = item as EnumWrapper<PipeTestResultStatus>;
                if (status != null)
                    statusList.Add(status.Value.ToString());
            }
            viewModel.SearchStatuses = statusList;
        }

        private void MillReportsXtraForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            commandManager.Dispose();
            viewModel = null;
        }
    }
}