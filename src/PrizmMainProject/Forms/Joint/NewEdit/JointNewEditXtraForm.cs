using System.ComponentModel;
using DevExpress.XtraEditors;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Forms.ExternalFile;
using System;
using Ninject;
using Ninject.Parameters;
using DevExpress.XtraEditors.Controls;
using Prizm.Main.Properties;
using DevExpress.XtraGrid.Views.Grid;
using Prizm.Domain.Entity.Construction;
using Prizm.Domain.Entity.Setup;
using Prizm.Main.Controls;
using System.Windows.Forms;
using System.Collections.Generic;
using Prizm.Domain.Entity;
using Prizm.Main.Common;
using System.Data;
using Prizm.Main.Commands;
using System.Reflection;
using System.Resources;
using System.Collections;
using System.Threading;
using System.Linq;
using Prizm.Main.Documents;

namespace Prizm.Main.Forms.Joint.NewEdit
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class JointNewEditXtraForm : ChildForm, IValidatable
    {
        private JointNewEditViewModel viewModel;
        private JointTestResult currentJointTestResult;
        private JointWeldResult currentJointWeldResult;
        InspectorSelectionControl inspectorSelectionControl = new InspectorSelectionControl();
        WeldersSelectionControl weldersSelectionControl = new WeldersSelectionControl();
        BindingList<EnumWrapper<JointTestResultStatus>> availabeResults = new BindingList<EnumWrapper<JointTestResultStatus>>();
        ICommandManager commandManager = new CommandManager();


        public JointNewEditXtraForm(Guid id)
        {
            InitializeComponent();
            SetControlsTextLength();
            viewModel = (JointNewEditViewModel)Program
               .Kernel
               .Get<JointNewEditViewModel>(
               new ConstructorArgument("id", id));
            viewModel.ModifiableView = this;
            viewModel.ValidatableView = this;
            loweringDate.Properties.NullText = String.Empty;
            loweringDate.Properties.NullDate = DateTime.MinValue;

            #region --- Colouring of required controls, IsEditMode, uppercasing ---
            jointNumber.SetRequiredText();
            firstJointElement.SetRequiredText();
            secondJointElement.SetRequiredText();
            IsEditMode = true;
            jointNumber.SetAsIdentifier();
            #endregion
        }

        public JointNewEditXtraForm() : this(Guid.Empty) { }



        private void extraFiles_Click(object sender, System.EventArgs e)
        {
            ExternalFilesXtraForm filesForm = new ExternalFilesXtraForm(viewModel.Joint.Id);
            if (viewModel.FilesFormViewModel == null)
            {
                viewModel.FilesFormViewModel = filesForm.ViewModel;
            }
            else
            {
                filesForm.ViewModel = viewModel.FilesFormViewModel;
            }
            filesForm.ShowDialog();
        }


        private void BindToViewModel()
        {
            jointNewEditBindingSoure.DataSource = viewModel;

            jointNumber.DataBindings
                .Add("EditValue", jointNewEditBindingSoure, "Number");
            deactivated.DataBindings
               .Add("EditValue", jointNewEditBindingSoure, "IsNotActive");
            deactivated.DataBindings
               .Add("Enabled", jointNewEditBindingSoure, "IsCanDeactivate");
            loweringDate.DataBindings
               .Add("EditValue", jointNewEditBindingSoure, "LoweringDate");
            GPSLat.DataBindings
                .Add("EditValue", jointNewEditBindingSoure, "GpsLatitude");
            GPSLong.DataBindings
                .Add("EditValue", jointNewEditBindingSoure, "GpsLongitude");
            seaLevel.DataBindings
                .Add("EditValue", jointNewEditBindingSoure, "GpsHeight");
            PKNumber.DataBindings
                .Add("EditValue", jointNewEditBindingSoure, "NumberKP");
            distanceFromPK.DataBindings
                .Add("EditValue", jointNewEditBindingSoure, "DistanceFromKP");
            controlOperations.DataBindings
               .Add("DataSource", jointNewEditBindingSoure, "JointTestResults");
            repairOperations.DataBindings
               .Add("DataSource", jointNewEditBindingSoure, "JointWeldResults");

            firstJointElement.DataBindings
                .Add("EditValue", jointNewEditBindingSoure, "FirstElementId");
            secondJointElement.DataBindings
                .Add("EditValue", jointNewEditBindingSoure, "SecondElementId");

            pipelinePiecesBindingSource.DataSource = viewModel.PartDataList;

            SetLookup(firstJointElement);
            SetLookup(secondJointElement);

            ControlOperationLookUpEdit.DataSource = viewModel.ControlOperations;

            repairOperationsLookUpEdit.DataSource = viewModel.RepairOperations;

            inspectorsDataSource.DataSource = viewModel.Inspectors;
            inspectorsDataSource.ListChanged += (s, eve) => IsModified = true;
            inspectorSelectionControl.DataSource = inspectorsDataSource;
            var inspectorsPopup = new PopupContainerControl();
            inspectorsPopup.Controls.Add(inspectorSelectionControl);
            inspectorSelectionControl.Dock = DockStyle.Fill;
            inspectorsPopupContainerEdit.PopupControl = inspectorsPopup;
            inspectorsPopupContainerEdit.PopupControl.MaximumSize = inspectorsPopup.MaximumSize;

            weldersDataSource.DataSource = viewModel.Welders;
            weldersDataSource.ListChanged += (s, eve) => IsModified = true;
            weldersSelectionControl.DataSource = weldersDataSource;
            var weldersPopup = new PopupContainerControl();
            weldersPopup.Controls.Add(weldersSelectionControl);
            weldersSelectionControl.Dock = DockStyle.Fill;
            weldersPopupContainerEdit.PopupControl = weldersPopup;
            weldersPopupContainerEdit.PopupControl.MaximumSize = weldersPopup.MaximumSize;



        }

        /// <summary>
        /// Grid columns lookup setup
        /// </summary>
        private void SetLookup(LookUpEdit lookup)
        {
            lookup.Properties.DataSource = pipelinePiecesBindingSource;
            lookup.Properties.DisplayMember = "Number";
            lookup.Properties.ValueMember = "Id";
        }

        private void BindCommands()
        {
            commandManager["Save"].Executor(viewModel.SaveJointCommand)
                .AttachTo(saveButton).RefreshState();
            commandManager["SaveAndNew"].Executor(viewModel.NewSaveJointCommand)
                .AttachTo(saveAndCreateButton).RefreshState();
 
            SaveCommand = viewModel.SaveJointCommand;
        }

        private void JointNewEditXtraForm_Load(object sender, EventArgs e)
        {
            BindCommands();
            BindToViewModel();
            viewModel.PropertyChanged += (s, eve) => IsModified = true;
            IsEditMode = !viewModel.IsNotActive;
            IsModified = false;
            viewModel.CheckDeactivation();
        }

        private void jointNumber_EditValueChanged(object sender, EventArgs e)
        {
            this.headerNumberPart =jointNumber.Text;
            viewModel.Number = jointNumber.Text;
            commandManager["Save"].RefreshState();
            commandManager["SaveAndNew"].RefreshState();
        }

        private void controlOperationsView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.IsValidRowHandle(e.RowHandle))
            {
                currentJointTestResult = view.GetRow(e.RowHandle) as JointTestResult;
                currentJointTestResult.IsActive = true;
                currentJointTestResult.Joint = viewModel.Joint;
                viewModel.Joint.JointTestResults.Add(currentJointTestResult);
            }
        }

        private void ControlOperationLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit q = sender as LookUpEdit;
            object row = q.Properties.GetDataSourceRowByKeyValue(q.EditValue);
            JointOperation selectedOperation = q.Properties.GetDataSourceRowByKeyValue(q.EditValue) as JointOperation;
            if (selectedOperation != null)
                currentJointTestResult.Operation = selectedOperation;

        }

        private void inspectorsPopupContainerEdit_CloseUp(object sender, CloseUpEventArgs e)
        {
            if (controlOperationsView.IsValidRowHandle(controlOperationsView.FocusedRowHandle))
            {
                IList<Inspector> selectedInspectors = inspectorSelectionControl.SelectedInspectors;
                JointTestResult jointTestResult = controlOperationsView.GetRow(controlOperationsView.FocusedRowHandle) as JointTestResult;
                if (jointTestResult != null)
                {
                    jointTestResult.Inspectors.Clear();
                    foreach (Inspector i in selectedInspectors)
                    {
                        jointTestResult.Inspectors.Add(i);
                    }
                }
            }
        }

        private void inspectorsPopupContainerEdit_Popup(object sender, EventArgs e)
        {
            controlOperationsView.ClearSelection();
            if (controlOperationsView.IsValidRowHandle(controlOperationsView.FocusedRowHandle))
            {
                JointTestResult jointTestResult = controlOperationsView.GetRow(controlOperationsView.FocusedRowHandle) as JointTestResult;
                if (jointTestResult != null)
                {
                    inspectorSelectionControl.SelectInspectors(jointTestResult.Inspectors);
                }
            }
        }

        private void inspectorsPopupContainerEdit_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
        {
            if (e.Value == null)
                e.DisplayText = string.Empty;

            IList<Inspector> inspectors = e.Value as IList<Inspector>;
            e.DisplayText = viewModel.FormatInspectorList(inspectors);
        }

        private void resultStatusLookUpEdit_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
        {
            if (e.Value == null)
            {
                e.DisplayText = string.Empty;
            }
            if (controlOperationsView.IsValidRowHandle(controlOperationsView.FocusedRowHandle))
            {
                JointTestResult jointTestResult = controlOperationsView.GetRow(controlOperationsView.FocusedRowHandle) as JointTestResult;
                if(jointTestResult != null && jointTestResult.Operation != null)
                {
                    availabeResults.Clear();
                    if (jointTestResult.Operation.TestHasAccepted) availabeResults.Add(new EnumWrapper<JointTestResultStatus>() { Value = JointTestResultStatus.Accepted });
                    if (jointTestResult.Operation.TestHasToRepair) availabeResults.Add(new EnumWrapper<JointTestResultStatus>() { Value = JointTestResultStatus.Repair });
                    if (jointTestResult.Operation.TestHasToWithdraw) availabeResults.Add(new EnumWrapper<JointTestResultStatus>() { Value = JointTestResultStatus.Withdraw });
                    resultStatusLookUpEdit.DataSource = availabeResults;
                }
            }
        }

        private void repairOperationsView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.IsValidRowHandle(e.RowHandle))
            {
                currentJointWeldResult = view.GetRow(e.RowHandle) as JointWeldResult;
                currentJointWeldResult.IsActive = true;
                currentJointWeldResult.Joint = viewModel.Joint;
                viewModel.Joint.JointWeldResults.Add(currentJointWeldResult);
            }
        }

        /// <summary>
        /// Assigns to current ActionWeldResult selected operation. If operation is not Weld,  ActionWeldResult is created with empty Welders list
        /// </summary>
        private void RepairOperationsLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit q = sender as LookUpEdit;
            object row = q.Properties.GetDataSourceRowByKeyValue(q.EditValue);
            JointOperation selectedOperationWeld = q.Properties.GetDataSourceRowByKeyValue(q.EditValue) as JointOperation;
            if (selectedOperationWeld != null)
            {
                currentJointWeldResult.Operation = selectedOperationWeld;
                if (selectedOperationWeld.Type != JointOperationType.Weld)
                {
                    currentJointWeldResult.Welders = new BindingList<Welder>();
                }
            }
        }

        private void weldersPopupContainerEdit_CloseUp(object sender, CloseUpEventArgs e)
        {
            if (repairOperationsView.IsValidRowHandle(repairOperationsView.FocusedRowHandle))
            {
                IList<Welder> selectedWelders = weldersSelectionControl.SelectedWelders;
                JointWeldResult jointWeldResult = repairOperationsView.GetRow(repairOperationsView.FocusedRowHandle) as JointWeldResult;
                if (jointWeldResult != null)
                {
                    jointWeldResult.Welders.Clear();
                    foreach (Welder w in selectedWelders)
                    {
                        jointWeldResult.Welders.Add(w);
                    }
                }
            }
        }

        private void weldersPopupContainerEdit_Popup(object sender, EventArgs e)
        {
            repairOperationsView.ClearSelection();
            if (repairOperationsView.IsValidRowHandle(repairOperationsView.FocusedRowHandle))
            {
                JointWeldResult jointWeldResult = repairOperationsView.GetRow(repairOperationsView.FocusedRowHandle) as JointWeldResult;
                if (jointWeldResult != null)
                {
                    weldersSelectionControl.SelectWelders(jointWeldResult.Welders);
                }
            }
        }

        private void weldersPopupContainerEdit_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
        {
            if (e.Value == null)
                e.DisplayText = string.Empty;

            IList<Welder> welders = e.Value as IList<Welder>;
            e.DisplayText = viewModel.FormatWelderList(welders);

        }

        /// <summary>
        /// Disables the ability to edit welders list when not Welding operation is selected
        /// </summary>
        private void repairOperationsView_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            JointOperation selectedOperation = repairOperationsLookUpEdit.GetDataSourceRowByDisplayValue(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["Operation.Name"])) as JointOperation;
            if (selectedOperation != null && selectedOperation.Type != JointOperationType.Weld
                && view.FocusedColumn.FieldName == "Welders")
            {
                e.Cancel = true;
            }
        }

        private void SetControlsTextLength()
        {
            jointNumber.Properties.MaxLength = LengthLimit.MaxJointNumber;
            GPSLat.Properties.MaxLength = LengthLimit.MaxGPSCoordinate;
            GPSLong.Properties.MaxLength = LengthLimit.MaxGPSCoordinate;
            seaLevel.Properties.MaxLength = LengthLimit.MaxSeaLevel;
            distanceFromPK.Properties.MaxLength = LengthLimit.MaxKPDistance;
            ResultValueTextEdit.MaxLength = LengthLimit.MaxJointTestResultValue;
        }

        private void firstJointElement_EditValueChanged(object sender, EventArgs e)
        {
            commandManager["Save"].RefreshState();
            commandManager["SaveAndNew"].RefreshState();
        }

        private void secondJointElement_EditValueChanged(object sender, EventArgs e)
        {
            commandManager["Save"].RefreshState();
            commandManager["SaveAndNew"].RefreshState();
        }

        private void deactivated_Modified(object sender, EventArgs e)
        {
            deactivated.Enabled = viewModel.Joint.Id != Guid.Empty;
            viewModel.IsNotActive = (bool)deactivated.EditValue;
            if (viewModel.IsNotActive)
            {
                viewModel.JointDeactivationCommand.Execute();
                IsEditMode = false;
            }
        }

        private void JointNewEditXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            commandManager.Dispose();
            viewModel.Dispose();
            viewModel = null;
        }

        private void controlOperationsView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView gv = sender as GridView;
            var operation = gv.GetRowCellValue(e.RowHandle, controlTypeGridColumn);
            if(operation == null)
            {
                gv.SetColumnError(controlDateGridColumn, Resources.VALUE_REQUIRED);
                e.Valid = false;
            }
        }

        private void repairOperationsView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView gv = sender as GridView;
            var operation = gv.GetRowCellValue(e.RowHandle, repairTypeGridColumn);
            if(operation == null)
            {
                gv.SetColumnError(repairTypeGridColumn, Resources.VALUE_REQUIRED);
                e.Valid = false;
            }
        }

        #region IValidatable Members

        bool IValidatable.Validate()
        {
            return dxValidationProvider.Validate();
        }

        #endregion
    }
}