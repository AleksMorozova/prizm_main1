using System;
using System.ComponentModel;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using Ninject;
using Ninject.Parameters;
using System.Collections.Generic;
using System.Linq;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Mill;
using DevExpress.XtraGrid.Views.Grid;
using Prizm.Main.Controls;
using Prizm.Domain.Entity.Setup;
using Prizm.Main.DummyData;
using Prizm.Main.Forms.PipeMill.Heat;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Properties;
using System.Collections;
using System.Drawing;

using Prizm.Main.Common;
using DevExpress.XtraGrid.Columns;
using System.Text.RegularExpressions;
using Prizm.Main.Forms.ExternalFile;
using Prizm.Main.Commands;
using DevExpress.XtraGrid;

namespace Prizm.Main.Forms.PipeMill.NewEdit
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class MillPipeNewEditXtraForm : ChildForm
    {
        ICommandManager commandManager = new CommandManager();
        MillPipeNewEditViewModel viewModel;
        WeldersSelectionControl weldersSelectionControl = new WeldersSelectionControl();
        InspectorSelectionControl inspectorSelectionControl = new InspectorSelectionControl();
        Dictionary<CoatingType, string> coatingTypeDict = new Dictionary<CoatingType, string>();
        private PipeTestResult currentTestResult;

        public MillPipeNewEditXtraForm(Guid id)
        {
            InitializeComponent();
            SetControlsTextLength();
            viewModel = (MillPipeNewEditViewModel)Program
                .Kernel
                .Get<MillPipeNewEditViewModel>(
                new ConstructorArgument("id", id));
            viewModel.ModifiableView = this;


            pipeCreationDate.Properties.NullDate = DateTime.MinValue;
            pipeCreationDate.Properties.NullText = string.Empty;

            #region --- Colouring of required controls ---
            pipeNumber.SetRequiredText();
            pipeSize.SetRequiredCombo();
            pipeCreationDate.SetRequiredText();
            heatsLookUp.SetRequiredGridLookUp();
            ordersLookUp.SetRequiredText();
            #endregion //--- Colouring of required controls ---

            #region --- Read-only controls and edit mode ---
            SetExceptionReadOnly(deactivate);
            SetAlwaysReadOnly(plateManufacturer);
            SetAlwaysReadOnly(purchaseOrderDate);
            SetAlwaysReadOnly(railcarNumber);
            SetAlwaysReadOnly(shippedDate);
            SetAlwaysReadOnly(certificateNumber);
            SetAlwaysReadOnly(destination);
            SetAlwaysReadOnly(steelGrade);
            SetAlwaysReadOnly(weight);
            IsEditMode = true;
            #endregion //--- Read-only controls ---

            #region --- Set Properties.CharacterCasing to Upper ---
            pipeNumber.SetAsIdentifier();
            plateNumber.SetAsIdentifier();
            certificateNumber.SetAsIdentifier();
            #endregion //--- Set Properties.CharacterCasing to Upper ---

            heatsLookUp.ButtonSetup();
            ordersLookUp.ButtonSetup();

            // Allow change focus or close while heatsLookUp or ordersLookUp validation error
            AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        public MillPipeNewEditXtraForm() : this(Guid.Empty) { }


        private void MillPipeNewEditXtraForm_Load(object sender, EventArgs e)
        {
            BindCommands();
            BindToViewModel();
            viewModel.PropertyChanged += (s, eve) => IsModified = true;

            IsEditMode = !viewModel.IsNotActive && !(viewModel.Pipe.Status == PipeMillStatus.Shipped);

            pipeNumber.SetMask(viewModel.Project.MillPipeNumberMaskRegexp);
            if (IsEditMode)
            {
                pipeNumber.Validating += pipeNumber_Validating;
            }
            else
            {
                pipeNumber.Validating -= pipeNumber_Validating;
            }

            IsModified = false;
            pipeNumber.ToolTip = Resources.MillPipeNumber_Mask_Hint + viewModel.Project.MillPipeNumberMask;

        }

        private void BindToViewModel()
        {
            pipeNewEditBindingSource.DataSource = viewModel;

            #region ComboBox filling

            foreach(var t in viewModel.PipeTypes)
            {
                pipeSize.Properties.Items.Add(t);
            }
            #endregion

            #region DataBindings

            ordersLookUp.Properties.DataSource = viewModel.PurchaseOrders;
            heatsLookUp.Properties.DataSource = viewModel.Heats;

            pipeNumber.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "Number");
            length.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "Length");
            weight.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "Weight");
            diameter.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "Diameter");
            thickness.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "WallThickness");


            deactivate.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "IsNotActive");

            deactivate.DataBindings
                .Add("Enabled", pipeNewEditBindingSource, "CanDeactivatePipe");

            plateThickness.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "PlateThickness");
            pipeCreationDate.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "ProductionDate");

            steelGrade.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "SteelGrade");

            plateManufacturer.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "PlateManufacturer");

            pipeSize.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "PipeMillSizeType");

            purchaseOrderDate.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "PurchaseOrderDate");


            railcarNumber.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "RailcarNumber");
            shippedDate.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "RailcarShippingDate");
            certificateNumber.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "RailcarCertificate");
            destination.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "RailcarDestination");

            plateNumber.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "PlateNumber");


            inspections.DataBindings
                .Add("DataSource", pipeNewEditBindingSource, "PipeTestResults");


            coatingHistory.DataBindings
                .Add("DataSource", pipeNewEditBindingSource, "Coats");
            weldingHistory.DataBindings
                .Add("DataSource", pipeNewEditBindingSource, "Welds");


            ResultStatusLookUpEdit.DataSource = viewModel.TestResultStatuses;

            millStatus.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "PipeStatus");

            ordersLookUp.DataBindings.Add("EditValue", pipeNewEditBindingSource, "PipePurchaseOrder");

            heatsLookUp.DataBindings.Add("EditValue", pipeNewEditBindingSource, "Heat");

            inspectionCodeLookUpEdit.DataSource = viewModel.AvailableTests;
            #endregion


            weldBindingSource.DataSource = viewModel.Pipe;
            weldBindingSource.DataMember = "Welds";
            weldBindingSource.ListChanged += (s, eve) => IsModified = true;
            weldersDataSource.DataSource = viewModel.Welders;

            weldersSelectionControl.DataSource = weldersDataSource;
            var weldersPopup = new PopupContainerControl();
            weldersPopup.Controls.Add(weldersSelectionControl);
            weldersSelectionControl.Dock = DockStyle.Fill;
            repositoryItemPopupWelders.PopupControl = weldersPopup;
            repositoryItemPopupWelders.PopupControl.MaximumSize = weldersPopup.MaximumSize;

            inspectorsDataSource.DataSource = viewModel.Inspectors;
            inspectorsDataSource.ListChanged += (s, eve) => IsModified = true;
            inspectorSelectionControl.DataSource = inspectorsDataSource;
            var inspectorsPopup = new PopupContainerControl();
            inspectorsPopup.Controls.Add(inspectorSelectionControl);
            inspectorSelectionControl.Dock = DockStyle.Fill;
            inspectorsPopupContainerEdit.PopupControl = inspectorsPopup;
            inspectorsPopupContainerEdit.PopupControl.MaximumSize = inspectorsPopup.MaximumSize;

            coatingTypeDict.Clear();
            coatingTypeDict.Add(CoatingType.Internal, Resources.COAT_INTERNAL);
            coatingTypeDict.Add(CoatingType.External, Resources.COAT_EXTERNAL);

            repositoryItemLookUpEditCoatType.DataSource = coatingTypeDict;

            coatDataSource.ListChanged += (s, eve) => IsModified = true;

            coatDataSource.DataSource = viewModel.Pipe;

        }

        private void BindCommands()
        {
            commandManager["SaveAndNew"].Executor(viewModel.NewSavePipeCommand).AttachTo(saveAndNewButton);
            commandManager["Save"].Executor(viewModel.SavePipeCommand).AttachTo(saveButton);

            commandManager["SaveAndNew"].RefreshState();
            commandManager["Save"].RefreshState();

            SaveCommand = viewModel.SavePipeCommand;
        }


        private void repositoryItemPopupWelders_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if(weldingHistoryGridView.IsValidRowHandle(weldingHistoryGridView.FocusedRowHandle))
            {
                IList<Welder> selectedWelders = weldersSelectionControl.SelectedWelders;
                Weld weld = weldingHistoryGridView.GetRow(weldingHistoryGridView.FocusedRowHandle) as Weld;
                if(weld == null)
                    return;


                weld.Welders.Clear();
                foreach(Welder w in selectedWelders)
                {
                    weld.Welders.Add(w);
                    w.Welds.Add(weld);
                }
            }

        }

        private void repositoryItemPopupWelders_Popup(object sender, EventArgs e)
        {
            weldingHistoryGridView.ClearSelection();
            if(weldingHistoryGridView.IsValidRowHandle(weldingHistoryGridView.FocusedRowHandle))
            {
                Weld weld = weldingHistoryGridView.GetRow(weldingHistoryGridView.FocusedRowHandle) as Weld;
                if(weld == null)
                    return;

                weldersSelectionControl.SelectWelders(weld.Welders);
            }
        }

        private void repositoryItemPopupWelders_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if(e.Value == null)
                e.DisplayText = string.Empty;

            IList<Welder> welders = e.Value as IList<Welder>;
            if (viewModel != null)
            {
                e.DisplayText = viewModel.FormatWeldersList(welders);
            }
        }

        private void repositoryItemPopupWelders_QueryPopUp(object sender, CancelEventArgs e)
        {
            Weld weld = weldingHistoryGridView.GetRow(weldingHistoryGridView.FocusedRowHandle) as Weld;
            if (weld == null)
                e.Cancel = true;
        }

        private void pipeNumber_EditValueChanged(object sender, EventArgs e)
        {
            this.headerNumberPart = pipeNumber.Text;  // BEFORE set to viewModel
            viewModel.Number = pipeNumber.Text;

            commandManager["SaveAndNew"].RefreshState();
            commandManager["Save"].RefreshState();
        }

        private void pipeCreationDate_EditValueChanged(object sender, EventArgs e)
        {
            viewModel.ProductionDate = pipeCreationDate.DateTime;

            commandManager["SaveAndNew"].RefreshState();
            commandManager["Save"].RefreshState();
        }

        private void weldingHistoryGridView_KeyDown(object sender, KeyEventArgs e)
        {
            GridView view = sender as GridView;
            view.RemoveSelectedItem<Weld>(e, viewModel.Pipe.Welds, (_) => _.IsNew());
            view.RefreshData();
        }

        private void repositoryItemLookUpEditCoatType_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lookup = sender as LookUpEdit;

            if(!(lookup.EditValue is CoatingType))
            {
                KeyValuePair<CoatingType, string> val = (KeyValuePair<CoatingType, string>)lookup.EditValue;
                lookup.EditValue = val.Key;
            }
        }

        private void repositoryItemLookUpEditCoatType_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if(e.Value is CoatingType)
            {
                e.DisplayText = coatingTypeDict[(CoatingType)e.Value];
            }
        }

        private void coatingHistoryGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            if(view.IsValidRowHandle(e.RowHandle))
            {
                Coat coat = view.GetRow(e.RowHandle) as Coat;
                coat.Pipe = viewModel.Pipe;
                coat.Type = CoatingType.Internal;
                coat.Date = DateTime.Now;
            }
        }

        private void inspectorsPopupContainerEdit_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if(inspectionsGridView.IsValidRowHandle(inspectionsGridView.FocusedRowHandle))
            {
                IList<Inspector> selectedInspectors = inspectorSelectionControl.SelectedInspectors;
                PipeTestResult pipeTestResult = inspectionsGridView.GetRow(inspectionsGridView.FocusedRowHandle) as PipeTestResult;
                if(pipeTestResult == null)
                    return;

                pipeTestResult.Inspectors.Clear();
                foreach(Inspector i in selectedInspectors)
                {
                    pipeTestResult.Inspectors.Add(i);
                }
            }
        }

        private void inspectorsPopupContainerEdit_Popup(object sender, EventArgs e)
        {
            inspectionsGridView.ClearSelection();
            if(inspectionsGridView.IsValidRowHandle(inspectionsGridView.FocusedRowHandle))
            {
                PipeTestResult pipeTestResult = inspectionsGridView.GetRow(inspectionsGridView.FocusedRowHandle) as PipeTestResult;
                if(pipeTestResult == null)
                    return;

                inspectorSelectionControl.SelectInspectors(pipeTestResult.Inspectors);
            }
        }

        private void inspectorsPopupContainerEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if(e.Value == null)
                e.DisplayText = string.Empty;

            IList<Inspector> inspectors = e.Value as IList<Inspector>;
            if (viewModel != null)
            {
                e.DisplayText = viewModel.FormatInspectorList(inspectors);
            }
        }

        /// <summary>
        ///Customizes data shown in Expected result column
        /// </summary>
        private void inspectionsGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            GridView view = sender as GridView;
            if(e.Column.FieldName == "Expected" && e.IsGetData)
                e.Value =
                    getExpectedValue(view, e.ListSourceRowIndex);
        }

        /// <summary>
        /// Returns data shown in Expected result column depending on expected result type
        /// </summary>
        private string getExpectedValue(GridView view, int listSourceRowIndex)
        {
            PipeTestResult pipeTestResult = view.GetRow(listSourceRowIndex) as PipeTestResult;
            if(pipeTestResult != null && pipeTestResult.Operation != null)
            {
                switch(pipeTestResult.Operation.ResultType)
                {
                    case PipeTestResultType.Boolean:
                        return pipeTestResult.Operation.BoolExpected.ToString();
                    case PipeTestResultType.Diapason:
                        return pipeTestResult.Operation.MinExpected + "-" + pipeTestResult.Operation.MaxExpected;
                    default:
                        return "";
                }
            }
            else
                return "";
        }

        private void coatingHistoryGridView_KeyDown(object sender, KeyEventArgs e)
        {
            GridView view = sender as GridView;
            view.RemoveSelectedItem<Coat>(e, viewModel.Pipe.Coats, (_) => _.IsNew());
            view.RefreshData();
        }

        private void weldingHistoryGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            if(view.IsValidRowHandle(e.RowHandle))
            {
                Weld weld = view.GetRow(e.RowHandle) as Weld;
                weld.Pipe = viewModel.Pipe;
            }
        }

        private void SetControlsTextLength()
        {
            pipeNumber.Properties.MaxLength = LengthLimit.MaxPipeNumber;
            plateNumber.Properties.MaxLength = LengthLimit.MaxPlateNumber;
            steelGrade.Properties.MaxLength = LengthLimit.MaxSteelGrade;
            testResultValue.MaxLength = LengthLimit.MaxPipeTestResultValue;
            ResultStatusLookUpEdit.MaxLength = LengthLimit.MaxPipeTestResultStatus;
            testResultValue.MaxLength = LengthLimit.MaxPipeTestResultValue;
            //TODO: limit fields for Plate and heat parameters tab
        }

        private void inspectionCodeLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit q = sender as LookUpEdit;
            object row = q.Properties.GetDataSourceRowByKeyValue(q.EditValue);
            PipeTest selectedTest = q.Properties.GetDataSourceRowByKeyValue(q.EditValue) as PipeTest;
            if(selectedTest != null)
                currentTestResult.Operation = selectedTest;
        }

        private void inspectionsGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            if(view.IsValidRowHandle(e.RowHandle))
            {
                currentTestResult = view.GetRow(e.RowHandle) as PipeTestResult;
                currentTestResult.IsActive = true;
                currentTestResult.Pipe = viewModel.Pipe;
                currentTestResult.Order = viewModel.PipeTestResults.Max(test => test.Order) + 1;
                viewModel.Pipe.PipeTestResult = viewModel.PipeTestResults;
            }
        }

        private void MillPipeNewEditXtraForm_Activated(object sender, EventArgs e)
        {

        }

        private void deactivate_Modified(object sender, EventArgs e)
        {
            viewModel.IsNotActive = (bool)deactivate.EditValue;

            if(viewModel.IsNotActive)
            {
                viewModel.PipeDeactivationCommand.Execute();
                IsEditMode = !viewModel.IsNotActive;
            }
        }

        /// <summary>
        /// Check if it possible to change size type if yes refreshes list of required pipe test results if size type was changed
        /// </summary>
        private void pipeSize_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            PipeMillSizeType currentPipeType;
            if(pipeSize.SelectedIndex >= 0)
            {
                currentPipeType = (PipeMillSizeType)e.NewValue;
                if(currentPipeType != null && viewModel.Pipe.Type != currentPipeType)
                {
                    if(viewModel.IsAnyInspectionResult() > 0)
                    {
                        if(viewModel.IsNew == true)
                        {
                            if(this.MdiParent.ShowYesNo(Resources.DLG_CHANGE_PIPESIZE_ON_NEWPIPE, Resources.PipeSizeChangeHeader) != true)
                            {
                                e.Cancel = true;
                            }
                        }
                        else
                        {
                            this.MdiParent.ShowNotify(Resources.DLG_CHANGE_PIPESIZE_ON_EDITPIPE, Resources.PipeSizeChangeHeader);
                            e.Cancel = true;
                        }
                    }
                }
            }
        }

        /// <summary>
        ///Refreshes list of required pipe test 
        /// </summary>
        private void RefreshPipeTest(PipeMillSizeType currentPipeType)
        {
            if(currentPipeType != null && viewModel.Pipe.Type != currentPipeType)
            {
                viewModel.PipeMillSizeType = currentPipeType;
                viewModel.PipeTestResults = viewModel.GetRequired(currentPipeType);
                viewModel.Pipe.PipeTestResult = viewModel.PipeTestResults;
                inspectionCodeLookUpEdit.DataSource = viewModel.AvailableTests;
                inspections.RefreshDataSource();
            }

            viewModel.PipeMillSizeType = pipeSize.SelectedItem as PipeMillSizeType;

            commandManager["SaveAndNew"].RefreshState();
            commandManager["Save"].RefreshState();
        }

        private void pipeSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxEdit cb = sender as ComboBoxEdit;
            Prizm.Domain.Entity.Setup.PipeMillSizeType currentPipeType
                = cb.SelectedItem as Prizm.Domain.Entity.Setup.PipeMillSizeType;
            RefreshPipeTest(currentPipeType);
        }

        private void inspectionsGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView gv = sender as GridView;

            PipeTestResultStatus result = (PipeTestResultStatus)gv.GetRowCellValue(e.RowHandle, inspectionResultGridColumn);
            DateTime? date = (DateTime?)gv.GetRowCellValue(e.RowHandle, controlDateGridColumn);
            var op = (string)gv.GetRowCellValue(e.RowHandle, inspectionCodeGridColumn);
            if(string.IsNullOrWhiteSpace(op))
            {
                gv.SetColumnError(inspectionCodeGridColumn, Resources.VALUE_REQUIRED);
                e.Valid = false;
            }

            switch(result)
            {
                case PipeTestResultStatus.Passed:
                case PipeTestResultStatus.Failed:
                    if(date == null || date > DateTime.Now)
                    {
                        gv.SetColumnError(controlDateGridColumn, Resources.TestResultIncorrectDate);
                        e.Valid = false;
                    }

                    break;
                default:
                    break;
            }
        }

        private void pipeNumber_Validating(object sender, CancelEventArgs e)
        {
            if(!Regex.IsMatch(pipeNumber.EditValue.ToString(), pipeNumber.Properties.Mask.EditMask, RegexOptions.IgnoreCase))
            {
                pipeNumber.ErrorText = Resources.VALUE_DOESNT_MATCH_MASK;
                e.Cancel = true;
            }
        }

        private void attachmentsButton_Click(object sender, EventArgs e)
        {
         ExternalFilesXtraForm filesForm = new ExternalFilesXtraForm(viewModel.Pipe.Id);
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

        private void ShowHeatDialog(string number)
        {
            var dlg = new HeatXtraForm(number);
            dlg.ShowDialog();
            
        }

        private void heatsLookUp_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                var number = ((GridLookUpEdit)sender).Text;
                ShowHeatDialog(number);
            }
        }

        private void heatsLookUp_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(e.DisplayValue.ToString()))
            {
                if(MessageBox.Show("Создать плавку " + e.DisplayValue.ToString(), "Новая плавка", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    ShowHeatDialog(e.DisplayValue.ToString());
                }
            }
            e.Handled = true;
        }

        private void heatsLookUp_QueryPopUp(object sender, CancelEventArgs e)
        {
            viewModel.ExtractHeatsCommand.Execute();
            heatsLookUp.Properties.DataSource = null;
            heatsLookUp.Properties.DataSource = viewModel.Heats;
        }

        private void ShowOrderDialog(string number)
        {
            var dlg = new PurchaseOrderXtraForm(number);
            dlg.ShowDialog();
        }
        
        private void ordersLookUp_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                var number = ((GridLookUpEdit)sender).Text;
                ShowOrderDialog(number);
            }
        }

        private void ordersLookUp_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(e.DisplayValue.ToString()))
            {
                if(MessageBox.Show("Создать наряд-заказ " + e.DisplayValue.ToString(), "Новый наряд-заказ", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    ShowOrderDialog(e.DisplayValue.ToString());
                }
            }
            e.Handled = true;
        }

        private void ordersLookUp_QueryPopUp(object sender, CancelEventArgs e)
        {
            viewModel.ExtractPurchaseOrderCommand.Execute();
            ordersLookUp.Properties.DataSource = null;
            ordersLookUp.Properties.DataSource = viewModel.PurchaseOrders;
        }
        private void MillPipeNewEditXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            commandManager.Dispose();
            viewModel.Dispose();
            viewModel = null;
        }
    
    }
}