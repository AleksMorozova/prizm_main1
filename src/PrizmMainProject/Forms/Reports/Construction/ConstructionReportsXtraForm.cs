using System;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Common;
using System.Windows.Forms;
using Prizm.Main.Forms.Common;
using System.ComponentModel;
using Prizm.Domain.Entity.Construction;
using Prizm.Main.Commands;
using Prizm.Main.Properties;
using System.Linq;


using construct = Prizm.Domain.Entity.Construction;
using Prizm.Main.Languages;
using System.Collections.Generic;

namespace Prizm.Main.Forms.Reports.Construction
{
    [System.ComponentModel.DesignerCategory("Form")] 
    public partial class ConstructionReportsXtraForm : ChildForm
    {
        private ConstructionReportViewModel viewModel;
        private ICommandManager commandManager = new CommandManager();

        public ConstructionReportsXtraForm()
        {
            InitializeComponent();
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;

            previewReportDocument.DataBindings
                .Add("DocumentSource", bindingSource, "PreviewSource");

            reportType.DataBindings
                .Add("SelectedIndex", bindingSource, "ReportTypeIndex");

            start.DataBindings
                .Add("EditValue", bindingSource, "StartJoint");

            end.DataBindings
                .Add("EditValue", bindingSource, "EndJoint");

            startKPComboBox.DataBindings
                .Add("EditValue", bindingSource, "StartPK");

            endKPComboBox.DataBindings
                .Add("EditValue", bindingSource, "EndPK");
        }

        private void BindCommands()
        {
            commandManager["CreateReport"]
                .Executor(viewModel.CreateCommand).AttachTo(createReportButton);

            commandManager["PreviewButton"]
                .Executor(viewModel.PreviewCommand).AttachTo(previewButton);
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                new LocalizedItem(reportTypeLayout, "ConstructionReports_ReportTypeLayout"),
                new LocalizedItem(typeLayout, "ConstructionReports_TypeLayout"),
                new LocalizedItem(startJointLayout, "ConstructionReports_StartJointLayout"),
                new LocalizedItem(startKPComboBoxLayoutControl, "ConstructionReports_StartKPComboBoxLayoutControl"),
                new LocalizedItem(endJointLayout, "ConstructionReports_EndJointLayout"),
                new LocalizedItem(endKPLayout, "ConstructionReports_EndKPLayout"),
                new LocalizedItem(previewButton, "ConstructionReports_PreviewButton"),
                new LocalizedItem(createReportButton, "ConstructionReports_CreateReportButton"),
                new LocalizedItem(createReportaLyoutGroup, "ConstructionReports_CreateReportaLyoutGroup"),
                new LocalizedItem(previewLayoutGroup, "ConstructionReports_PreviewLayoutGroup"),
                // radio groups
                new LocalizedItem(tracingModeRadioGroup, 
                    new string[]{ "ConstructionReport_RadioJoints", "ConstructionReport_RadioKP" }),

                // other
            };
        }

        #endregion // --- Localization ---

        private void RefreshTypes()
        {
            BindingList<PartType> selectedTypes = new BindingList<PartType>();
            for (int i = 0; i < type.Properties.Items.Count; i++)
            {
                if (type.Properties.Items[i].CheckState == CheckState.Checked)
                {
                    selectedTypes.Add((PartType)type.Properties.Items[i].Value);
                }
            }
            viewModel.Types.Clear();
            viewModel.Types = selectedTypes;
        }

        private void ConstructionReportsXtraForm_Load(object sender, EventArgs e)
        {
            viewModel = (ConstructionReportViewModel)Program.Kernel.GetService(typeof(ConstructionReportViewModel));

            foreach (var item in EnumWrapper<PartType>.EnumerateItems(skip0:true))
            {
                type.Properties.Items.Add(item.Item1, item.Item2, CheckState.Checked, true);
            }
            foreach(var item in EnumWrapper<ReportType>.EnumerateItems())
            {
                reportType.Properties.Items.Add(item.Item2);
            }

            viewModel.LoadData();

            foreach (var joint in viewModel.Joints)
            {
                start.Properties.Items.Add(joint);
                end.Properties.Items.Add(joint);
            }

            foreach (var kp in viewModel.AllKP)
            {
                startKPComboBox.Properties.Items.Add(kp);
                endKPComboBox.Properties.Items.Add(kp);
            }

            BindToViewModel();
            BindCommands();
            RefreshTypes();

            startKPComboBox.SelectedIndex = 0;
            viewModel.StartPK = (startKPComboBox.EditValue != null) ? (int)startKPComboBox.EditValue: default(int);

            endKPComboBox.SelectedIndex = 0;
            viewModel.EndPK = (endKPComboBox.EditValue != null) ? (int)endKPComboBox.EditValue : default(int);

            viewModel.ReportTypeIndex = reportType.SelectedIndex = 0;

            tracingModeRadioGroup_SelectedIndexChanged(tracingModeRadioGroup, e);
        }

        private void reportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viewModel.ReportType == ReportType.UsedProductReport)
            {
                typeLayout.ContentVisible = true;
            }
            else
            {
                typeLayout.ContentVisible = false;
            }
        }

        private void ConstructionReportsXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            commandManager.Dispose();
            viewModel = null;
        }

        private void type_EditValueChanged(object sender, EventArgs e)
        {
            RefreshTypes();
        }

        private void tracingModeRadioGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadioGroup edit = sender as RadioGroup;

            if (edit.SelectedIndex == 0)
            {
                start.Enabled = true;
                end.Enabled = true;

                startKPComboBox.Enabled = false;
                endKPComboBox.Enabled = false;

                viewModel.TracingMode = TracingModeEnum.TracingByJoints;
            }
            else
            {
                start.Enabled = false;
                end.Enabled = false;

                startKPComboBox.Enabled = true;
                endKPComboBox.Enabled = true;

                viewModel.TracingMode = TracingModeEnum.TracingByKP;
            }
        }
    }
}