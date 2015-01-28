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
using Prizm.Domain.Entity.Construction;
using Prizm.Main.Properties;
using Prizm.Main.Controls;
using Prizm.Domain.Entity;
using DevExpress.XtraGrid.Views.Grid;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.Parts.Inspection
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class PartInspectionXtraForm : ChildForm
    {
        private PartInspectionViewModel viewModel;
        ICommandManager commandManager = new CommandManager();
        private InspectorSelectionControl inspectorSelectionControl = new InspectorSelectionControl();
        private Dictionary<PartInspectionStatus, string> inspectionStatusDict
            = new Dictionary<PartInspectionStatus, string>();
        public PartInspectionXtraForm()
        {
            InitializeComponent();
            SetAlwaysEditable(searchNumber);
            searchNumber.SetAsIdentifier();
            IsEditMode = true;
        }

        private void PartInspectionXtraForm_Load(object sender, EventArgs e)
        {
            viewModel = (PartInspectionViewModel)Program.Kernel.GetService(typeof(PartInspectionViewModel));
            viewModel.CurrentForm = this;
            viewModel.ModifiableView = this;
            BindCommands();
            BindToViewModel();
            IsEditMode = false;
        }

        private void BindCommands()
        {
            commandManager["Search"].Executor(viewModel.SearchCommand).AttachTo(searchButton);
            commandManager["Save"].Executor(viewModel.SaveInspectionTestResultsCommand).AttachTo(saveButton);
            commandManager["SavaAndClear"].Executor(viewModel.SaveAndClearTestResultsCommand).AttachTo(saveAndClearButton);
            commandManager["Save"].RefreshState();
            commandManager["SavaAndClear"].RefreshState();

            viewModel.SaveInspectionTestResultsCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;
            viewModel.SaveAndClearTestResultsCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;
            searchNumber.DataBindings.Add("Editvalue", bindingSource, "SearchNumber");
            elementNumber.DataBindings.Add("Text", bindingSource, "ElementNumber");
            elementType.DataBindings.Add("Text", bindingSource, "ElementType");
            inspections.DataBindings.Add("DataSource", bindingSource, "InspectionTestResults");

            inspectionStatusDict.Clear();
            inspectionStatusDict.Add(PartInspectionStatus.Accepted, Resources.PartInspectionStatus_Accepted);
            inspectionStatusDict.Add(PartInspectionStatus.Hold, Resources.Hold);
            inspectionStatusDict.Add(PartInspectionStatus.Rejected, Resources.Rejected);
            inspectionStatusDict.Add(PartInspectionStatus.Pending, Resources.Pending);
            inspectionStatusDict.Add(PartInspectionStatus.Undefined, string.Empty);
            resultStatusLookUpEdit.DataSource = inspectionStatusDict.Where(x => x.Key != PartInspectionStatus.Undefined);

            inspectorsDataSource.DataSource = viewModel.Inspectors;
            inspectorsDataSource.ListChanged += (s, eve) => IsModified = true;
            inspectorSelectionControl.DataSource = inspectorsDataSource;
            var inspectorsPopup = new PopupContainerControl();
            inspectorsPopup.Controls.Add(inspectorSelectionControl);
            inspectorSelectionControl.Dock = DockStyle.Fill;
            inspectorsPopupContainerEdit.PopupControl = inspectorsPopup;
            inspectorsPopupContainerEdit.PopupControl.MaximumSize = inspectorsPopup.MaximumSize;
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                // layout items
                new LocalizedItem(searchNumberLayout, "PartInspection_SearchNumberLabel"),
                new LocalizedItem(searchNumberLayout, "PartInspection_SearchNumberLabel"),
                new LocalizedItem(elementNumberLayout, "PartInspection_ElementNumberLabel"),
                new LocalizedItem(elementTypeLayout, "PartInspection_ElementTypeLabel"),

                // controls
                new LocalizedItem(searchButton, "PartInspection_SearchButton"),
                new LocalizedItem(saveButton, "PartInspection_SaveButton"),
                new LocalizedItem(saveAndClearButton, "PartInspection_SaveAndClearButton"),

                // grid column headers
                new LocalizedItem(colDate, "PartInspection_DateColumnHeader"),
                new LocalizedItem(colResult, "PartInspection_ResultColumnHeader"),
                new LocalizedItem(colInspector, "PartInspection_InspectorColumnHeader"),
                new LocalizedItem(colReason, "PartInspection_ReasonColumnHeader"),

                // layout control groups
                new LocalizedItem(searchElementGroup, "PartInspection_SearchGroup"),
                new LocalizedItem(inspectionControlGroup, "PartInspection_IncomingInspectionGroup"),
                // other
            };
        }

        #endregion // --- Localization ---

        private void resultStatusLookUpEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value is PartInspectionStatus)
            {
                e.DisplayText = inspectionStatusDict[(PartInspectionStatus)e.Value];
            }
        }

        private void resultStatusLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lookup = sender as LookUpEdit;

            if (!(lookup.EditValue is PartInspectionStatus))
            {
                KeyValuePair<PartInspectionStatus, string> val
                    = (KeyValuePair<PartInspectionStatus, string>)lookup.EditValue;
                lookup.EditValue = val.Key;
            }
        }

        private void inspectorsPopupContainerEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value == null)
                e.DisplayText = string.Empty;

            IList<Inspector> inspectors = e.Value as IList<Inspector>;
            e.DisplayText = viewModel.FormatInspectorList(inspectors);
        }

        private void inspectorsPopupContainerEdit_Popup(object sender, EventArgs e)
        {
            inspectionsView.ClearSelection();
            if (inspectionsView.IsValidRowHandle(inspectionsView.FocusedRowHandle))
            {
                InspectionTestResult inspectionTestResult
                    = inspectionsView.GetRow(inspectionsView.FocusedRowHandle) as InspectionTestResult;

                if (inspectionTestResult != null)
                {
                    inspectorSelectionControl.SelectInspectors(inspectionTestResult.Inspectors);
                }
            }
        }

        private void inspectorsPopupContainerEdit_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (inspectionsView.IsValidRowHandle(inspectionsView.FocusedRowHandle))
            {
                IList<Inspector> selectedInspectors = inspectorSelectionControl.SelectedInspectors;
                InspectionTestResult inspectionTestResult
                    = inspectionsView.GetRow(inspectionsView.FocusedRowHandle) as InspectionTestResult;

                if (inspectionTestResult != null)
                {
                    inspectionTestResult.Inspectors.Clear();
                    foreach (Inspector i in selectedInspectors)
                    {
                        inspectionTestResult.Inspectors.Add(i);
                    }
                }
            }
        }

        private void inspectorsPopupContainerEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            InspectionTestResult inspectionTestResult
                = inspectionsView
                .GetRow(inspectionsView.FocusedRowHandle) as InspectionTestResult;

            if (inspectionTestResult == null || (inspectionTestResult != null && inspectionTestResult.Date == null))
            {
                inspectionsView.SetColumnError(inspectionsView.VisibleColumns[0], Resources.DateFirst);
                e.Cancel = true;
            }
            else
            {
                inspectorSelectionControl.inspectionDate = inspectionTestResult.Date;
            }
        }

        private void inspectionsView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView v = sender as GridView;
            InspectionTestResult inspectionTestResult
                = v.GetRow(e.RowHandle) as InspectionTestResult;

            inspectionTestResult.IsActive = true;
            inspectionTestResult.Status = PartInspectionStatus.Pending;
            inspectionTestResult.Part = viewModel.ConvertedPart;
        }

        private void elementNumber_EditValueChanged(object sender, EventArgs e)
        {
            commandManager["Save"].RefreshState();
            commandManager["SavaAndClear"].RefreshState();
        }            
            
    }
}