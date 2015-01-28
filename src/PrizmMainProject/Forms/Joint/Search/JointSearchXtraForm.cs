using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Prizm.Domain.Entity.Construction;
using Ninject;
using Ninject.Parameters;
using Prizm.Main.Commands;
using Prizm.Main.Common;
using Prizm.Main.DummyData;
using Prizm.Main.Forms.Joint.NewEdit;
using Prizm.Main.Forms.MainChildForm;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using Prizm.Main.Properties;
using Prizm.Main.Languages;
using System.Collections.Generic;

namespace Prizm.Main.Forms.Joint.Search
{
    [System.ComponentModel.DesignerCategory("Form")] 
    public partial class JointSearchXtraForm : ChildForm
    {
        private JointSearchViewModel viewModel;
        ICommandManager commandManager = new CommandManager();

        [Inject]
        public JointSearchXtraForm(JointSearchViewModel vm)
        {
            viewModel = vm;
            InitializeComponent();
            Bitmap bmp = Resources.search_icon;
            this.Icon = Icon.FromHandle(bmp.GetHicon());
            weldingDateFrom.Properties.NullDate = DateTime.MinValue;
            weldingDateFrom.Properties.NullText = string.Empty;
            weldingDateTo.Properties.NullDate = DateTime.MinValue;
            weldingDateTo.Properties.NullText = string.Empty;
            jointNumber.SetAsIdentifier();

        }

        private void JointSearchXtraForm_Load(object sender, System.EventArgs e)
        {
            BindCommands();
            BindToViewModel();
            foreach (var item in EnumWrapper<ActivityCriteria>.EnumerateItems())
            {
                activity.Properties.Items.Add(item.Item2);
            }
            foreach(var item in EnumWrapper<JointStatus>.EnumerateItems(skip0:true))
            {
                controlState.Properties.Items.Add(item.Item1, item.Item2, CheckState.Checked, enabled: true);
            }
            activity.SelectedIndex = 0;
            viewModel.Activity = ActivityCriteria.StatusActive;
            controlState_CloseUp(controlState, new DevExpress.XtraEditors.Controls.CloseUpEventArgs(true));
        }


        private void BindToViewModel()
        {

            bindingSource.DataSource = viewModel;
            jointNumber.DataBindings.Add("EditValue", bindingSource, "Number");
            pegNumber.DataBindings.Add("EditValue", bindingSource, "PegNumber");
            weldingDateFrom.DataBindings.Add("EditValue", bindingSource, "FromDate");
            weldingDateTo.DataBindings.Add("EditValue", bindingSource, "ToDate");
            gridControlSerchResult.DataBindings.Add("DataSource", bindingSource, "Joints");
            activity.DataBindings.Add("SelectedIndex", bindingSource, "ActivityIndex");
        }

        private void BindCommands()
        {
            commandManager["Search"].Executor(viewModel.SearchCommand).AttachTo(searchButton);
        }

        private void controlState_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            viewModel.Statuses.Clear();

            for (int i = 0; i < controlState.Properties.Items.Count; i++)
            {
                if (controlState.Properties.Items[i].CheckState == CheckState.Checked)
                {
                    viewModel.Statuses.Add((JointStatus)controlState.Properties.Items[i].Value);
                }
            }
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                new LocalizedItem(activity, new string[]{ "JointSearch_ActivityCriteria_StatusActive", "JointSearch_ActivityCriteria_StatusUnactive", "JointSearch_ActivityCriteria_StatusAll"}),
                new LocalizedItem(controlState, new string[]{ "JointSearch_JointStatus_Welded", "JointSearch_JointStatus_Lowered", "JointSearch_JointStatus_Withdrawn"}),
                new LocalizedItem(jointNumberLayout, "JointSearch_JointNumber"),
                new LocalizedItem(controlStateLayout, "JointSearch_ControlStateLayout"),
                new LocalizedItem(weldingDateLabel, "JointSearch_WeldingDateLabel"),
                new LocalizedItem(weldingDateFromLayout, "JointSearch_WeldingDateFromLayout"),
                new LocalizedItem(weldingDateToLayout, "JointSearch_WeldingDateToLayout"),
                new LocalizedItem(KMlayout, "JointSearch_KMlayout"),
                new LocalizedItem(activityLayout, "JointSearch_ActivityLayout"),
                new LocalizedItem(searchLayoutGroup, "JointSearch_SearchLayoutGroup"),
                new LocalizedItem(searchButton, "JointSearch_SearchButton"),
                new LocalizedItem(searchResultLayoutGroup, "JointSearch_SearchResultLayoutGroup"),
                new LocalizedItem(jointNumberGridColumn, "JointSearch_JointNumberGridColumn"),
                new LocalizedItem(joinStatusGridColumn, "JointSearch_JoinStatusGridColumn"),
                new LocalizedItem(numberKPCol, "JointSearch_NumberKPCol"),
                new LocalizedItem(loweringDateCol, "JointSearch_LoweringDateCol"),
                new LocalizedItem(gpsLatCol, "JointSearch_GpsLatCol"),
                new LocalizedItem(gpsLongCol, "JointSearch_GpsLongCol"),
                new LocalizedItem(gpsHeightCol, "JointSearch_GpsHeightCol")
            };
        }

        #endregion // --- Localization ---

        private void resultView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            GridView view = sender as GridView;
            if(e.Column.Name == statusLocalizedCol.Name && e.IsGetData)
            {
                e.Value = LocalizeStatus(view, e.ListSourceRowIndex);
            }
        }

        private string LocalizeStatus(GridView view, int p)
        {
            JointStatus status = (JointStatus)view.GetListSourceRowCellValue(p, "Status");
            var wrp = new EnumWrapper<JointStatus>(status);
            return wrp.Name;
        }

        private void resultView_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo info = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            if(info.InRow || info.InRowCell)
            {
                var id = (Guid)view.GetRowCellValue(info.RowHandle, "Id");
                var parent = this.MdiParent as PrizmApplicationXtraForm;
                parent.OpenChildForm(typeof(JointNewEditXtraForm), id);
            }
        }

        private void JointSearchXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            commandManager.Dispose();
            viewModel.Dispose();
            viewModel = null;
        }

        private void resultView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView v = sender as GridView;
            var data = v.GetRow(e.RowHandle) as Prizm.Domain.Entity.Construction.Joint;
            if (data != null)
            {
                if (!data.IsActive)
                {
                    e.Appearance.ForeColor = Color.Gray;
                }
            }
        }
    }
}