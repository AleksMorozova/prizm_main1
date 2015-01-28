using DevExpress.XtraEditors;
using Ninject.Parameters;
using Ninject;
using Prizm.Main.Forms.ExternalFile;
using Prizm.Main.Forms.MainChildForm;
using System;
using Prizm.Main.Common;
using Prizm.Domain.Entity.Construction;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using Prizm.Main.Properties;
using Prizm.Main.Controls;
using System.Windows.Forms;
using Prizm.Domain.Entity;
using Prizm.Main.Commands;
using Prizm.Main.Documents;
using System.Linq;
using Prizm.Main.Security;
using DevExpress.XtraGrid.Views.Base;
using Prizm.Main.Languages;
using System.Drawing;

namespace Prizm.Main.Forms.Component.NewEdit
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class ComponentNewEditXtraForm : ChildForm, IValidatable, INewEditEntityForm
    {
        private Guid id;
        private ComponentNewEditViewModel viewModel;
        private InspectorSelectionControl inspectorSelectionControl = new InspectorSelectionControl();
        private Dictionary<PartInspectionStatus, string> inspectionStatusDict 
            = new Dictionary<PartInspectionStatus, string>();
        private ICommandManager commandManager = new CommandManager();
        ISecurityContext ctx = Program.Kernel.Get<ISecurityContext>();

        public bool IsMatchedByGuid(Guid id) { return this.id == id; }
       
        public ComponentNewEditXtraForm(Guid id) : this(id, string.Empty) { }
        public ComponentNewEditXtraForm(string number) : this(Guid.Empty, number) {}
        public ComponentNewEditXtraForm() : this(Guid.Empty, string.Empty) { }

        public ComponentNewEditXtraForm(Guid id, string number)
        {
            this.id = id;

            InitializeComponent();

            Bitmap bmp = Resources.components_icon;
            this.Icon = Icon.FromHandle(bmp.GetHicon());

            viewModel = (ComponentNewEditViewModel)Program
               .Kernel
               .Get<ComponentNewEditViewModel>(new ConstructorArgument("id", id));

            viewModel.ModifiableView = this;
            viewModel.ValidatableView = this;
            viewModel.Number = number;
            IsEditMode = true;
            attachmentsButton.Enabled = ctx.HasAccess(global::Domain.Entity.Security.Privileges.AddAttachments);

            #region --- Colouring of required controls ---
            componentNumber.SetRequiredText();
            type.SetRequiredText();
            #endregion //--- Colouring of required controls ---

            #region --- Set Properties.CharacterCasing to Upper ---
            componentNumber.SetAsIdentifier();
            certificateNumber.SetAsIdentifier();
            #endregion //--- Set Properties.CharacterCasing to Upper ---
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                new LocalizedItem(newComponentLayoutGroup, "ComponentNewEdit_NewComponentLayoutGroup"),
                new LocalizedItem(componentNumberLayout, "ComponentNewEdit_ComponentNumberLayout"),
                new LocalizedItem(typeLayoutControl, "ComponentNewEdit_TypeLayoutControl"),
                new LocalizedItem(certificateLayout, "ComponentNewEdit_CertificateLayout"),
                new LocalizedItem(componentLengthLayout, "ComponentNewEdit_ComponentLengthLayout"),
                new LocalizedItem(parametersGridLayout, "ComponentNewEdit_ParametersGridLayout"),
                
                new LocalizedItem(attachmentsButton, "ComponentNewEdit_AttachmentsButton"),
                new LocalizedItem(deactivated, "ComponentNewEdit_Deactivated"),
                new LocalizedItem(newSaveComponentButton, "ComponentNewEdit_NewSaveComponentButton"),
                new LocalizedItem(saveComponentButton, "ComponentNewEdit_SaveComponentButton"),

                new LocalizedItem(inspectionDateColumn, "ComponentNewEdit_InspectionDateColumn"),
                new LocalizedItem(inspectorColumn, "ComponentNewEdit_InspectorColumn"),
                new LocalizedItem(resultColumn, "ComponentNewEdit_ResultColumn"),
                new LocalizedItem(reasonColumn, "ComponentNewEdit_ReasonColumn"),

                new LocalizedItem(diameterGridColumn, "ComponentNewEdit_DiameterGridColumn"),
                new LocalizedItem(wallThicknessGridColumn, "ComponentNewEdit_WallThicknessGridColumn")
            };
        }

        #endregion // --- Localization ---

        private void simpleButton1_Click(object sender, System.EventArgs e)
        {
            ExternalFilesXtraForm filesForm = new ExternalFilesXtraForm(viewModel.Component.Id,IsEditMode);
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

        private void ComponentNewEditXtraForm_Load(object sender, EventArgs e)
        {
            BindCommands();
            BindToViewModel();

            viewModel.PropertyChanged += (s, eve) => IsModified = true;

            IsEditMode = viewModel.ComponentIsActive;

            IsModified = false;
        }

        private void BindToViewModel()
        {
            componentBindingSource.DataSource = viewModel;

            foreach(var t in viewModel.ComponentTypes)
            {
                if (t.IsActive)
                {
                    type.Properties.Items.Add(t);
                }
            }

            #region   ---- Prizm.Data Bindings ----
            componentNumber.DataBindings
                .Add("EditValue", componentBindingSource, "Number");

            certificateNumber.DataBindings
                .Add("EditValue", componentBindingSource, "Certificate");

            componentParameters.DataBindings
                .Add("DataSource", componentBindingSource, "Connectors");

            type.DataBindings
                .Add("EditValue", componentBindingSource, "Type");

            deactivated.DataBindings
                .Add(BindingHelper.CreateCheckEditInverseBinding(
                        "EditValue", componentBindingSource, "ComponentIsActive"));

            inspectionHistoryGrid.DataBindings
                .Add("DataSource", componentBindingSource, "InspectionTestResults");

            componentLength.DataBindings
                .Add("EditValue", componentBindingSource, "Length");
            #endregion

            inspectionStatusDict.Clear();
            inspectionStatusDict.Add(PartInspectionStatus.Accepted, Resources.PartInspectionStatus_Accepted);
            inspectionStatusDict.Add(PartInspectionStatus.Hold, Resources.Hold);
            inspectionStatusDict.Add(PartInspectionStatus.Rejected, Resources.Rejected);
            inspectionStatusDict.Add(PartInspectionStatus.Pending, Resources.Pending);
            repositoryInspectionStatus.DataSource = inspectionStatusDict;

            inspectorsDataSource.DataSource = viewModel.Inspectors;
            inspectorsDataSource.ListChanged += (s, eve) => IsModified = true;
            inspectorSelectionControl.DataSource = inspectorsDataSource;
            var inspectorsPopup = new PopupContainerControl();
            inspectorsPopup.Controls.Add(inspectorSelectionControl);
            inspectorSelectionControl.Dock = DockStyle.Fill;
            inspectorsPopupContainerEdit.PopupControl = inspectorsPopup;
            inspectorsPopupContainerEdit.PopupControl.MaximumSize = inspectorsPopup.MaximumSize;
            
        }

        private void BindCommands()
        {
            commandManager["Save"].Executor(viewModel.SaveCommand).AttachTo(saveComponentButton);
            commandManager["NewSave"].Executor(viewModel.NewSaveCommand).AttachTo(newSaveComponentButton);
            commandManager["Deactivate"].Executor(viewModel.DeactivationCommand).AttachTo(deactivated);

            SaveCommand = viewModel.SaveCommand;

            viewModel.SaveCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;
            viewModel.NewSaveCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;
            viewModel.DeactivationCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;

            commandManager.RefreshVisualState();
        }

        private void componentNumber_EditValueChanged(object sender, EventArgs e)
        {
            this.headerNumberPart = componentNumber.Text;
            viewModel.Number = componentNumber.Text;

            commandManager["NewSave"].RefreshState();
            commandManager["Save"].RefreshState();
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewModel.Type = type.SelectedItem as ComponentType;
            componentParameters.RefreshDataSource();

            commandManager["NewSave"].RefreshState();
            commandManager["Save"].RefreshState();
        }

        private void inspectionHistoryGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView v = sender as GridView;
            InspectionTestResult inspectionTestResult
                = v.GetRow(e.RowHandle) as InspectionTestResult;

            inspectionTestResult.IsActive = true;
            inspectionTestResult.Status = PartInspectionStatus.Pending;
        }

        private void repositoryInspectionStatus_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value is PartInspectionStatus)
            {
                e.DisplayText = inspectionStatusDict[(PartInspectionStatus)e.Value];
            }
        }

        private void repositoryInspectionStatus_EditValueChanged(object sender, EventArgs e)
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
            inspectionHistoryGridView.ClearSelection();
            if (inspectionHistoryGridView.IsValidRowHandle(inspectionHistoryGridView.FocusedRowHandle))
            {
                InspectionTestResult inspectionTestResult
                    = inspectionHistoryGridView.GetRow(inspectionHistoryGridView.FocusedRowHandle) as InspectionTestResult;

                if (inspectionTestResult != null)
                {
                    inspectorSelectionControl.SelectInspectors(inspectionTestResult.Inspectors);
                }
            }
        }

        private void inspectorsPopupContainerEdit_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (inspectionHistoryGridView.IsValidRowHandle(inspectionHistoryGridView.FocusedRowHandle))
            {
                IList<Inspector> selectedInspectors = inspectorSelectionControl.SelectedInspectors;
                InspectionTestResult inspectionTestResult 
                    = inspectionHistoryGridView.GetRow(inspectionHistoryGridView.FocusedRowHandle) as InspectionTestResult;

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

        private void inspectorsPopupContainerEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {

            InspectionTestResult inspectionTestResult
               = inspectionHistoryGridView
               .GetRow(inspectionHistoryGridView.FocusedRowHandle) as InspectionTestResult;

            if (inspectionTestResult == null || (inspectionTestResult != null && inspectionTestResult.Date == null))
            {
                inspectionHistoryGridView.SetColumnError(inspectionHistoryGridView.VisibleColumns[0], Resources.DateFirst);
                e.Cancel = true;
            }
            else
            {
                inspectorSelectionControl.inspectionDate = inspectionTestResult.Date;
            }
        }

        private void inspectionHistoryGridView_KeyDown(object sender, KeyEventArgs e)
        {
            GridView view = sender as GridView;
            view.RemoveSelectedItem<InspectionTestResult>( e, viewModel.InspectionTestResults, (_) => _.IsNew());
            view.RefreshData();
        }

        private void ComponentNewEditXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            commandManager.Dispose();
            viewModel.Dispose();
            viewModel = null;
        }

        #region IValidatable Members

        bool IValidatable.Validate()
        {
            for (int i = 0; i < componentParametersView.RowCount; i++)
            {
                if (Convert.ToInt32(componentParametersView.GetRowCellValue(i, "Diameter")) <= 0)
                {
                    componentParametersView.FocusedRowHandle = i;

                    componentParametersView_ValidateRow(
                        componentParametersView,
                        new DevExpress.XtraGrid.Views.Base
                            .ValidateRowEventArgs(i, componentParametersView.GetDataRow(i)));

                }
            }

            return dxValidationProvider.Validate() &&
                viewModel.Component.Connectors
                .Where<Connector>(x => x.Diameter <= 0)
                .Count<Connector>() <= 0;
        }

        #endregion

        private void componentParametersView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView gv = sender as GridView;

            var diameter = (int)gv.GetRowCellValue(e.RowHandle, diameterGridColumn);

            if (diameter <= 0)
            {
                gv.SetColumnError(diameterGridColumn, Resources.DIAMETER_VALUE_VALIDATION);
                e.Valid = false;
            }
        }

        /// <summary>
        /// Set IsModified for settings after grid data changed. Used not for most grid in settings.
        /// </summary>
        /// <param name="sender">GridView</param>
        /// <param name="e"></param>
        private void CellModifiedGridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            IsModified = true;
        }
    }
}