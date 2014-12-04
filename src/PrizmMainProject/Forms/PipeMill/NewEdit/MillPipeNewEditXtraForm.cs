using System;
using System.ComponentModel;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using Ninject;
using Ninject.Parameters;
using System.Collections.Generic;
using System.Linq;
using Domain.Entity;
using Domain.Entity.Mill;
using DevExpress.XtraGrid.Views.Grid;
using PrizmMain.Controls;
using Domain.Entity.Setup;
using PrizmMain.DummyData;
using PrizmMain.Forms.PipeMill.Heat;
using PrizmMain.Forms.MainChildForm;
using PrizmMain.Properties;
using System.Collections;
using System.Drawing;

using PrizmMain.Common;

namespace PrizmMain.Forms.PipeMill.NewEdit
{
    public partial class MillPipeNewEditXtraForm : ChildForm
    {

        MillPipeNewEditViewModel viewModel;
        WeldersSelectionControl weldersSelectionControl = new WeldersSelectionControl();
        InspectorSelectionControl inspectorSelectionControl = new InspectorSelectionControl();
        Dictionary<CoatingType, string> coatingTypeDict = new Dictionary<CoatingType, string>();
        private PipeTestResult currentTestResult;

        public MillPipeNewEditXtraForm(Guid pipeId)
        {
            InitializeComponent();
            SetControlsTextLength();
            Dummy();
            viewModel = (MillPipeNewEditViewModel)Program
                .Kernel
                .Get<MillPipeNewEditViewModel>(
                new ConstructorArgument("pipeId", pipeId));
            viewModel.ModifiableView = this;
            

            pipeCreationDate.Properties.NullDate = DateTime.MinValue;
            pipeCreationDate.Properties.NullText = string.Empty;

            pipeNumber.SetRequiredText();
            pipeSize.SetRequiredCombo();
            heatNumber.SetRequiredCombo();
            purchaseOrder.SetRequiredCombo();
            pipeCreationDate.SetRequiredText();
        }

        public MillPipeNewEditXtraForm() : this(Guid.Empty) { }


        private void MillPipeNewEditXtraForm_Load(object sender, EventArgs e)
        {
            BindCommands();
            BindToViewModel();
            viewModel.PropertyChanged += (s, eve) => IsModified = true;
            ControlsDeactivation(this);
            CheckRegex();
            IsModified = false;
        }

        private void ControlsDeactivation(Control control)
        {
            if (viewModel.IsNotActive)
            {
                foreach (Control c in control.Controls)
                {
                    if (c is TextEdit)
                    {
                        ((TextEdit)c).Properties.ReadOnly = true;
                    }

                    if (c is SimpleButton && c.Name != "attachmentsButton")
                    {
                        ((SimpleButton)c).Enabled = false;
                    }

                    if (c is DevExpress.XtraGrid.GridControl)
                    {
                        foreach (var v in ((DevExpress.XtraGrid.GridControl)c).Views)
                        {
                            ((GridView)v).OptionsBehavior.Editable = false;
                        }
                    }

                    if (c is DevExpress.XtraEditors.CheckEdit)
                    {
                        ((DevExpress.XtraEditors.CheckEdit)c).Enabled = false;
                    }

                    ControlsDeactivation(c);
                }
            }
        }

        private void BindToViewModel()
        {
            pipeNewEditBindingSource.DataSource = viewModel;

            #region ComboBox filling

            HeatFill();

            PurchaseOrderFill();

            foreach (var t in viewModel.PipeTypes)
            {
                pipeSize.Properties.Items.Add(t);
            }
            #endregion

            #region DataBindings

            pipeNewEditBindingSource.DataSource = viewModel;

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



            heatNumber.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "Heat");
            plateManufacturer.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "PlateManufacturer");

            pipeSize.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "PipeMillSizeType");
            purchaseOrder.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "PipePurchaseOrder");

            purchaseOrderDate.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "PurchaseOrderDate");


            railcarNumber.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "RailcarNumber");
            shippedDate.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "RailcarShippingDate");
            certificateNumber.DataBindings
                .Add("EditValue", pipeNewEditBindingSource, "RailcarCertificate");
            destanation.DataBindings
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

        private void HeatFill() 
        {
            //TODO: FEATURE return heat & purchase order from editform for select in combo

            viewModel.ExtractHeatsCommand.Execute();
            heatNumber.Properties.Items.Clear();
            heatNumber.Properties.Items.Insert(0, Resources.NewHeatCombo);
            heatNumber.SelectedIndex = -1;

            foreach (var h in viewModel.Heats)
            {
                heatNumber.Properties.Items.Add(h);
            }
        }

        private void PurchaseOrderFill()
        {
            viewModel.ExtractPurchaseOrderCommand.Execute();
            purchaseOrder.Properties.Items.Clear();
            purchaseOrder.Properties.Items.Insert(0, Resources.NewOrderCombo);
            purchaseOrder.SelectedIndex = -1;

            foreach (var h in viewModel.PurchaseOrders)
            {
                purchaseOrder.Properties.Items.Add(h);
            }
        }
        private void BindCommands()
        {
            saveAndNewButton.BindCommand(() => viewModel.NewSavePipeCommand.Execute(), viewModel.NewSavePipeCommand);
            saveButton.BindCommand(() => viewModel.SavePipeCommand.Execute(), viewModel.SavePipeCommand);
            SaveCommand = viewModel.SavePipeCommand;
        }


        private void repositoryItemPopupWelders_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
           if (weldingHistoryGridView.IsValidRowHandle(weldingHistoryGridView.FocusedRowHandle))
           {
              IList<Welder> selectedWelders = weldersSelectionControl.SelectedWelders;
              Weld weld = weldingHistoryGridView.GetRow(weldingHistoryGridView.FocusedRowHandle) as Weld;
              if (weld == null)
                 return;


              weld.Welders.Clear();
              foreach (Welder w in selectedWelders)
              {
                 weld.Welders.Add(w);
                 w.Welds.Add(weld);
              }
           }
            
        }

        private void repositoryItemPopupWelders_Popup(object sender, EventArgs e)
        {
           weldingHistoryGridView.ClearSelection();
           if (weldingHistoryGridView.IsValidRowHandle(weldingHistoryGridView.FocusedRowHandle))
           {
              Weld weld = weldingHistoryGridView.GetRow(weldingHistoryGridView.FocusedRowHandle) as Weld;
              if (weld == null)
                 return;

              weldersSelectionControl.SelectWelders(weld.Welders);
           }
        }

        private void repositoryItemPopupWelders_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
           if (e.Value == null)
              e.DisplayText = string.Empty;

           IList<Welder> welders = e.Value as IList<Welder>;
           e.DisplayText = viewModel.FormatWeldersList(welders); 
        }

        private void repositoryItemPopupWelders_QueryPopUp(object sender, CancelEventArgs e)
        {
           Weld weld = weldingHistoryGridView.GetRow(weldingHistoryGridView.FocusedRowHandle) as Weld;
           if (weld == null)
              e.Cancel = true;
        }

        private void heatNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewModel.Heat = heatNumber.SelectedItem as Domain.Entity.Mill.Heat;
            viewModel.SavePipeCommand.IsExecutable ^= true;
            viewModel.NewSavePipeCommand.IsExecutable ^= true;
        }

        private void purchaseOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewModel.PipePurchaseOrder = purchaseOrder.SelectedItem as PurchaseOrder;
            viewModel.SavePipeCommand.IsExecutable ^= true;
            viewModel.NewSavePipeCommand.IsExecutable ^= true;
        }

        private void pipeNumber_EditValueChanged(object sender, EventArgs e)
        {
            viewModel.Number = pipeNumber.Text;
            viewModel.SavePipeCommand.IsExecutable ^= true;
            viewModel.NewSavePipeCommand.IsExecutable ^= true;
        }

        private void pipeCreationDate_EditValueChanged(object sender, EventArgs e)
        {
            viewModel.ProductionDate = pipeCreationDate.DateTime;
            viewModel.SavePipeCommand.IsExecutable ^= true;
            viewModel.NewSavePipeCommand.IsExecutable ^= true;
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
           
           if (!(lookup.EditValue is CoatingType))
           {
              KeyValuePair<CoatingType, string> val = (KeyValuePair<CoatingType, string>)lookup.EditValue;
              lookup.EditValue = val.Key;
           }
        }

        private void repositoryItemLookUpEditCoatType_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
           if (e.Value is CoatingType)
           {
              e.DisplayText = coatingTypeDict[(CoatingType)e.Value];
           }
        }

        private void coatingHistoryGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
           GridView view = sender as GridView;
           if (view.IsValidRowHandle(e.RowHandle))
           {
              Coat coat = view.GetRow(e.RowHandle) as Coat;
              coat.Pipe = viewModel.Pipe;
              coat.Type = CoatingType.Internal;
              coat.Date = DateTime.Now;
           }
        }

        private void inspectorsPopupContainerEdit_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (inspectionsGridView.IsValidRowHandle(inspectionsGridView.FocusedRowHandle))
            {
                IList<Inspector> selectedInspectors = inspectorSelectionControl.SelectedInspectors;
                PipeTestResult pipeTestResult = inspectionsGridView.GetRow(inspectionsGridView.FocusedRowHandle) as PipeTestResult;
                if (pipeTestResult == null)
                    return;

                pipeTestResult.Inspectors.Clear();
                foreach (Inspector i in selectedInspectors)
                {
                    pipeTestResult.Inspectors.Add(i);
                }
            }
        }

        private void inspectorsPopupContainerEdit_Popup(object sender, EventArgs e)
        {
            inspectionsGridView.ClearSelection();
            if (inspectionsGridView.IsValidRowHandle(inspectionsGridView.FocusedRowHandle))
            {
                PipeTestResult pipeTestResult = inspectionsGridView.GetRow(inspectionsGridView.FocusedRowHandle) as PipeTestResult;
                if (pipeTestResult == null)
                    return;

                inspectorSelectionControl.SelectInspectors(pipeTestResult.Inspectors);
            }
        }

        private void inspectorsPopupContainerEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value == null)
                e.DisplayText = string.Empty;

            IList<Inspector> inspectors = e.Value as IList<Inspector>;
            e.DisplayText = viewModel.FormatInspectorList(inspectors);
        }

        /// <summary>
        ///Customizes data shown in Expected result column
        /// </summary>
        private void inspectionsGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column.FieldName == "Expected" && e.IsGetData) e.Value =
              getExpectedValue(view, e.ListSourceRowIndex);
        }

        /// <summary>
        /// Returns data shown in Expected result column depending on expected result type
        /// </summary>
        private string getExpectedValue(GridView view, int listSourceRowIndex)
        {
            PipeTestResult pipeTestResult = view.GetRow(listSourceRowIndex) as PipeTestResult;
            if (pipeTestResult != null && pipeTestResult.Operation != null)
            {
                switch (pipeTestResult.Operation.ResultType)
                {
                    case PipeTestResultType.Boolean:
                        return pipeTestResult.Operation.BoolExpected.ToString();
                    case PipeTestResultType.Diapason:
                        return pipeTestResult.Operation.MinExpected + "-" + pipeTestResult.Operation.MaxExpected;
                    default: return "";
                }
            }
            else return "";
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
           if (view.IsValidRowHandle(e.RowHandle))
           {
              Weld weld = view.GetRow(e.RowHandle) as Weld;
              weld.Pipe = viewModel.Pipe;
           }
        }

        private void heatButton_Click(object sender, EventArgs e)
        {
            var heatForm = (HeatXtraForm)Program.Kernel.Get<HeatXtraForm>(new ConstructorArgument("heatNumber", heatNumber.Text));
            heatForm.ShowDialog();
            HeatFill();
            heatNumber.SelectedIndex = -1;
        }


        private void purchaseOrderButton_Click(object sender, EventArgs e)
        {
            var order = purchaseOrder.EditValue as PurchaseOrder;
            Guid id = Guid.Empty;
            if (order != null)
            {
                id = order.Id;
            }
            PurchaseOrderXtraForm form = new PurchaseOrderXtraForm(id);
            form.ShowDialog();
            PurchaseOrderFill();
            purchaseOrder.SelectedIndex = -1;
        }

        private void SetControlsTextLength()
        {
            pipeNumber.Properties.MaxLength = LengthLimit.MaxPipeNumber;
            plateNumber.Properties.MaxLength = LengthLimit.MaxPlateNumber;
            steelGrade.Properties.MaxLength = LengthLimit.MaxSteelGrade;
            testResultValue.MaxLength = LengthLimit.MaxPipeTestResultValue;
            //TODO: limit fields for Plate and heat parameters tab
        }

        #region DummyData

        private void Dummy()
        {
            
           
            List<ChemicalComposition> chem = new List<ChemicalComposition>()
        {
            new ChemicalComposition(){Parameter = "C",HeatValue = 0.06f, PlateValue = 0.06f,PipeValue = 0.06f},
            new ChemicalComposition(){Parameter = "Mn",HeatValue = 1.64f, PlateValue = 1.64f},
            new ChemicalComposition(){Parameter = "Si",HeatValue = 0.29f ,PlateValue = 0.29f,PipeValue = 0.29f},
            new ChemicalComposition(){Parameter = "P",HeatValue = 0.007f, PlateValue = 0.006f,PipeValue = 0.006f},
            new ChemicalComposition(){Parameter = "S",HeatValue = 0.001f, PlateValue = 0,},
            new ChemicalComposition(){Parameter = "Mo",HeatValue = 0.175f, PlateValue = 0.175f}
        };
            chemicalComposition.DataSource = chem;
            steelGrade.Text = "H18N9T";

            List<TensileTest> tests = new List<TensileTest>()
            {
                new TensileTest()
                {
                    Parameter = "Предел текучести, Rt0.5,",
                    BaseValue = 645f,
                },
                new TensileTest()
                {
                    Parameter = "Временное сопротивление, Rm,МПа",
                    BaseValue = 700f,
                },
                new TensileTest()
                {
                    Parameter = "Удлиннение на 2 дюймах (50,8мм)",
                    BaseValue = 32f,
                },
                new TensileTest()
                {
                    Parameter = "ИПГ при t=0С,ср.,%",
                    BaseValue = 100f,
                },
                new TensileTest()
                {
                    Parameter = "Доля вязкой сост. на ударных образцах при t=-10C,ср.,%",
                    BaseValue = 100f,
                },
            };

            tensileTests.DataSource = tests;



        }



        #endregion

       
        private void inspectionCodeLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit q = sender as LookUpEdit;
            object row = q.Properties.GetDataSourceRowByKeyValue(q.EditValue);
            PipeTest selectedTest = q.Properties.GetDataSourceRowByKeyValue(q.EditValue) as PipeTest;
            if (selectedTest != null)
                currentTestResult.Operation = selectedTest;
        }

        private void inspectionsGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
             GridView view = sender as GridView;
             if (view.IsValidRowHandle(e.RowHandle))
             { 
                 currentTestResult  =  view.GetRow(e.RowHandle) as PipeTestResult;
                 currentTestResult.IsActive = true;
                 currentTestResult.Pipe = viewModel.Pipe;
                 currentTestResult.Order = viewModel.PipeTestResults.Max(test=>test.Order)+1;
                 //currentTestResult.Operation.Order = viewModel.Pipe.PipeTestResult.Max(test => test.Operation.Order) + 1; ;
                 viewModel.Pipe.PipeTestResult = viewModel.PipeTestResults;
             }
        }

        private void MillPipeNewEditXtraForm_Activated(object sender, EventArgs e)
        {
            HeatFill();
            PurchaseOrderFill();
        }

        private void deactivate_Modified(object sender, EventArgs e)
        {
            viewModel.IsNotActive = (bool)deactivate.EditValue;

            if (viewModel.IsNotActive)
            {
                viewModel.PipeDeactivationCommand.Execute();
                ControlsDeactivation(this);
            }
        }

        private void CheckRegex()
        {
            if (viewModel.Regex != null && viewModel.Regex != String.Empty)
            {
                pipeNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                pipeNumber.Properties.Mask.EditMask = viewModel.Regex;
            }
        }

        /// <summary>
        /// Check if it possible to change size type if yes refreshes list of required pipe test results if size type was changed
        /// </summary>
        private void pipeSize_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            PipeMillSizeType currentPipeType;
            if (pipeSize.SelectedIndex>=0)
            {
                currentPipeType = (PipeMillSizeType)e.NewValue;
                if (currentPipeType != null && viewModel.Pipe.Type != currentPipeType)
                {
                    if (viewModel.IsAnyInspectionResult() > 0) 
                    {
                        if (viewModel.IsNew == true)
                        {
                            if (this.MdiParent.ShowYesNo(Resources.DLG_CHANGE_PIPESIZE_ON_NEWPIPE, Resources.PipeSizeChangeHeader)!=true)
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
            if (currentPipeType != null && viewModel.Pipe.Type != currentPipeType)
            {
                viewModel.PipeMillSizeType = currentPipeType;
                viewModel.PipeTestResults = viewModel.GetRequired(currentPipeType);
                viewModel.Pipe.PipeTestResult = viewModel.PipeTestResults;
                inspectionCodeLookUpEdit.DataSource = viewModel.AvailableTests;
                inspections.RefreshDataSource();
            }

            viewModel.PipeMillSizeType = pipeSize.SelectedItem as PipeMillSizeType;
            viewModel.SavePipeCommand.IsExecutable ^= true;
            viewModel.NewSavePipeCommand.IsExecutable ^= true;
        }

        private void pipeSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxEdit cb = sender as ComboBoxEdit;
            Domain.Entity.Setup.PipeMillSizeType currentPipeType
                = cb.SelectedItem as Domain.Entity.Setup.PipeMillSizeType;
            RefreshPipeTest(currentPipeType);
        }
    }
}