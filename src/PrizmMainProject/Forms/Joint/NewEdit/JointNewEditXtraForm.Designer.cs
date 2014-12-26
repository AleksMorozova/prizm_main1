namespace Prizm.Main.Forms.Joint.NewEdit
{
    partial class JointNewEditXtraForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JointNewEditXtraForm));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.jointNumber = new DevExpress.XtraEditors.TextEdit();
            this.newJointLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.saveAndCreateButton = new DevExpress.XtraEditors.SimpleButton();
            this.repairOperations = new DevExpress.XtraGrid.GridControl();
            this.repairOperationsView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repairTypeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repairOperationsLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repairDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repairDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.completedGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CompletedCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.weldersGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.weldersPopupContainerEdit = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.extraFiles = new DevExpress.XtraEditors.SimpleButton();
            this.deactivated = new DevExpress.XtraEditors.CheckEdit();
            this.distanceFromPK = new DevExpress.XtraEditors.TextEdit();
            this.PKNumber = new DevExpress.XtraEditors.TextEdit();
            this.PKLabel = new DevExpress.XtraEditors.LabelControl();
            this.GPSLabel = new DevExpress.XtraEditors.LabelControl();
            this.seaLevel = new DevExpress.XtraEditors.TextEdit();
            this.GPSLat = new DevExpress.XtraEditors.TextEdit();
            this.GPSLong = new DevExpress.XtraEditors.TextEdit();
            this.controlOperations = new DevExpress.XtraGrid.GridControl();
            this.controlOperationsView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.controlTypeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ControlOperationLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.resultGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.resultStatusLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.controlDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.operationDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.inspectorsGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectorsPopupContainerEdit = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.valueGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ResultValueTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.inspectionsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.secondJointElement = new DevExpress.XtraEditors.LookUpEdit();
            this.firstJointElement = new DevExpress.XtraEditors.LookUpEdit();
            this.loweringDate = new DevExpress.XtraEditors.DateEdit();
            this.newJointLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.inspectionLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.repairOperationLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.controlOperationsLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.loweringLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.GPSLatLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.GPSLongLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.elevationLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.PKNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.distanceFromPKLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.loweringEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.PKLabelLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.GPSLabelLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.jointParametersLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.jointNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.loweringDateLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.firstJointElementLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.secondJointElementLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.extraFilesLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.deactivatedLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.saveButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.saveButtonEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.saveAndCreateLayout = new DevExpress.XtraLayout.LayoutControlItem();


            this.jointNewEditBindingSoure = new System.Windows.Forms.BindingSource(this.components);
            this.pipelinePiecesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inspectorsDataSource = new System.Windows.Forms.BindingSource(this.components);
            this.weldersDataSource = new System.Windows.Forms.BindingSource(this.components);
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.jointNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newJointLayoutControl)).BeginInit();
            this.newJointLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repairOperations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairOperationsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairOperationsLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairDateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairDateEdit.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompletedCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldersPopupContainerEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deactivated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceFromPK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PKNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seaLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPSLat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPSLong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlOperations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlOperationsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlOperationLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultStatusLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationDateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationDateEdit.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsPopupContainerEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultValueTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondJointElement.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstJointElement.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loweringDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loweringDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newJointLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairOperationLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlOperationsLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loweringLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPSLatLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPSLongLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevationLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PKNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceFromPKLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loweringEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PKLabelLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPSLabelLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointParametersLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loweringDateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstJointElementLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondJointElementLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraFilesLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deactivatedLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveAndCreateLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointNewEditBindingSoure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipelinePiecesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldersDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // jointNumber
            // 
            this.jointNumber.Location = new System.Drawing.Point(34, 69);
            this.jointNumber.Margin = new System.Windows.Forms.Padding(0);
            this.jointNumber.Name = "jointNumber";
            this.jointNumber.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.jointNumber.Properties.Appearance.Options.UseBackColor = true;
            this.jointNumber.Size = new System.Drawing.Size(239, 20);
            this.jointNumber.StyleController = this.newJointLayoutControl;
            this.jointNumber.TabIndex = 0;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Не может быть пустым";
            this.dxValidationProvider.SetValidationRule(this.jointNumber, conditionValidationRule3);
            this.jointNumber.EditValueChanged += new System.EventHandler(this.jointNumber_EditValueChanged);
            // 
            // newJointLayoutControl
            // 
            this.newJointLayoutControl.Controls.Add(this.saveAndCreateButton);
            this.newJointLayoutControl.Controls.Add(this.repairOperations);
            this.newJointLayoutControl.Controls.Add(this.saveButton);
            this.newJointLayoutControl.Controls.Add(this.extraFiles);
            this.newJointLayoutControl.Controls.Add(this.deactivated);
            this.newJointLayoutControl.Controls.Add(this.distanceFromPK);
            this.newJointLayoutControl.Controls.Add(this.PKNumber);
            this.newJointLayoutControl.Controls.Add(this.PKLabel);
            this.newJointLayoutControl.Controls.Add(this.GPSLabel);
            this.newJointLayoutControl.Controls.Add(this.seaLevel);
            this.newJointLayoutControl.Controls.Add(this.GPSLat);
            this.newJointLayoutControl.Controls.Add(this.GPSLong);
            this.newJointLayoutControl.Controls.Add(this.controlOperations);
            this.newJointLayoutControl.Controls.Add(this.secondJointElement);
            this.newJointLayoutControl.Controls.Add(this.firstJointElement);
            this.newJointLayoutControl.Controls.Add(this.loweringDate);
            this.newJointLayoutControl.Controls.Add(this.jointNumber);
            this.newJointLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newJointLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.newJointLayoutControl.Name = "newJointLayoutControl";
            this.newJointLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(5, 238, 250, 350);
            this.newJointLayoutControl.OptionsView.UseDefaultDragAndDropRendering = false;
            this.newJointLayoutControl.Root = this.newJointLayoutGroup;
            this.newJointLayoutControl.Size = new System.Drawing.Size(1275, 550);
            this.newJointLayoutControl.TabIndex = 15;
            this.newJointLayoutControl.Text = "layoutControl1";
            // 
            // saveAndCreateButton
            // 
            this.saveAndCreateButton.Image = ((System.Drawing.Image)(resources.GetObject("saveAndCreateButton.Image")));
            this.saveAndCreateButton.Location = new System.Drawing.Point(1121, 506);
            this.saveAndCreateButton.Name = "saveAndCreateButton";
            this.saveAndCreateButton.Size = new System.Drawing.Size(132, 22);
            this.saveAndCreateButton.StyleController = this.newJointLayoutControl;
            this.saveAndCreateButton.TabIndex = 14;
            this.saveAndCreateButton.Text = "Сохранить/Создать";
            // 
            // repairOperations
            // 
            this.repairOperations.Cursor = System.Windows.Forms.Cursors.Default;
            this.repairOperations.Location = new System.Drawing.Point(34, 218);
            this.repairOperations.MainView = this.repairOperationsView;
            this.repairOperations.Name = "repairOperations";
            this.repairOperations.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.CompletedCheckEdit,
            this.repairOperationsLookUpEdit,
            this.repairDateEdit,
            this.weldersPopupContainerEdit});
            this.repairOperations.Size = new System.Drawing.Size(532, 261);
            this.repairOperations.TabIndex = 9;
            this.repairOperations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.repairOperationsView});
            // 
            // repairOperationsView
            // 
            this.repairOperationsView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.repairTypeGridColumn,
            this.repairDateGridColumn,
            this.completedGridColumn,
            this.weldersGridColumn});
            this.repairOperationsView.GridControl = this.repairOperations;
            this.repairOperationsView.Name = "repairOperationsView";
            this.repairOperationsView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.repairOperationsView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.repairOperationsView.OptionsView.ShowGroupPanel = false;
            this.repairOperationsView.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.repairOperationsView_ShowingEditor);
            this.repairOperationsView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.repairOperationsView_InitNewRow);
            this.repairOperationsView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.repairOperationsView_ValidateRow);
            // 
            // repairTypeGridColumn
            // 
            this.repairTypeGridColumn.Caption = "Название операции";
            this.repairTypeGridColumn.ColumnEdit = this.repairOperationsLookUpEdit;
            this.repairTypeGridColumn.FieldName = "Operation.Name";
            this.repairTypeGridColumn.Name = "repairTypeGridColumn";
            this.repairTypeGridColumn.Visible = true;
            this.repairTypeGridColumn.VisibleIndex = 0;
            this.repairTypeGridColumn.Width = 134;
            // 
            // repairOperationsLookUpEdit
            // 
            this.repairOperationsLookUpEdit.AutoHeight = false;
            this.repairOperationsLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repairOperationsLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Тип операции")});
            this.repairOperationsLookUpEdit.DisplayMember = "Name";
            this.repairOperationsLookUpEdit.Name = "repairOperationsLookUpEdit";
            this.repairOperationsLookUpEdit.NullText = "";
            this.repairOperationsLookUpEdit.ValueMember = "Name";
            this.repairOperationsLookUpEdit.EditValueChanged += new System.EventHandler(this.RepairOperationsLookUpEdit_EditValueChanged);
            // 
            // repairDateGridColumn
            // 
            this.repairDateGridColumn.Caption = "Дата";
            this.repairDateGridColumn.ColumnEdit = this.repairDateEdit;
            this.repairDateGridColumn.FieldName = "Date";
            this.repairDateGridColumn.Name = "repairDateGridColumn";
            this.repairDateGridColumn.Visible = true;
            this.repairDateGridColumn.VisibleIndex = 1;
            this.repairDateGridColumn.Width = 85;
            // 
            // repairDateEdit
            // 
            this.repairDateEdit.AutoHeight = false;
            this.repairDateEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repairDateEdit.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repairDateEdit.Name = "repairDateEdit";
            // 
            // completedGridColumn
            // 
            this.completedGridColumn.Caption = "Выполнено";
            this.completedGridColumn.ColumnEdit = this.CompletedCheckEdit;
            this.completedGridColumn.FieldName = "IsCompleted";
            this.completedGridColumn.Name = "completedGridColumn";
            this.completedGridColumn.Visible = true;
            this.completedGridColumn.VisibleIndex = 2;
            this.completedGridColumn.Width = 70;
            // 
            // CompletedCheckEdit
            // 
            this.CompletedCheckEdit.AutoHeight = false;
            this.CompletedCheckEdit.Name = "CompletedCheckEdit";
            this.CompletedCheckEdit.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // weldersGridColumn
            // 
            this.weldersGridColumn.Caption = "Сварщики";
            this.weldersGridColumn.ColumnEdit = this.weldersPopupContainerEdit;
            this.weldersGridColumn.FieldName = "Welders";
            this.weldersGridColumn.Name = "weldersGridColumn";
            this.weldersGridColumn.Visible = true;
            this.weldersGridColumn.VisibleIndex = 3;
            this.weldersGridColumn.Width = 299;
            // 
            // weldersPopupContainerEdit
            // 
            this.weldersPopupContainerEdit.AutoHeight = false;
            this.weldersPopupContainerEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weldersPopupContainerEdit.Name = "weldersPopupContainerEdit";
            this.weldersPopupContainerEdit.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.weldersPopupContainerEdit_CloseUp);
            this.weldersPopupContainerEdit.Popup += new System.EventHandler(this.weldersPopupContainerEdit_Popup);
            this.weldersPopupContainerEdit.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.weldersPopupContainerEdit_CustomDisplayText);
            // 
            // saveButton
            // 
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(1010, 506);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(97, 22);
            this.saveButton.StyleController = this.newJointLayoutControl;
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Со&хранить";
            // 
            // extraFiles
            // 
            this.extraFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.extraFiles.Image = ((System.Drawing.Image)(resources.GetObject("extraFiles.Image")));
            this.extraFiles.Location = new System.Drawing.Point(22, 506);
            this.extraFiles.Margin = new System.Windows.Forms.Padding(3, 3, 3, 11);
            this.extraFiles.MinimumSize = new System.Drawing.Size(100, 20);
            this.extraFiles.Name = "extraFiles";
            this.extraFiles.Size = new System.Drawing.Size(100, 22);
            this.extraFiles.StyleController = this.newJointLayoutControl;
            this.extraFiles.TabIndex = 16;
            this.extraFiles.Text = "В&ложения";
            this.extraFiles.Click += new System.EventHandler(this.extraFiles_Click);
            // 
            // deactivated
            // 
            this.deactivated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deactivated.Location = new System.Drawing.Point(151, 506);
            this.deactivated.Name = "deactivated";
            this.deactivated.Properties.Caption = "Стык деактивирован";
            this.deactivated.Size = new System.Drawing.Size(131, 19);
            this.deactivated.StyleController = this.newJointLayoutControl;
            this.deactivated.TabIndex = 12;
            this.deactivated.Modified += new System.EventHandler(this.deactivated_Modified);
            // 
            // distanceFromPK
            // 
            this.distanceFromPK.Location = new System.Drawing.Point(823, 117);
            this.distanceFromPK.Name = "distanceFromPK";
            this.distanceFromPK.Size = new System.Drawing.Size(191, 20);
            this.distanceFromPK.StyleController = this.newJointLayoutControl;
            this.distanceFromPK.TabIndex = 8;
            // 
            // PKNumber
            // 
            this.PKNumber.Location = new System.Drawing.Point(613, 117);
            this.PKNumber.Name = "PKNumber";
            this.PKNumber.Properties.Mask.EditMask = "d";
            this.PKNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.PKNumber.Size = new System.Drawing.Size(191, 20);
            this.PKNumber.StyleController = this.newJointLayoutControl;
            this.PKNumber.TabIndex = 7;
            // 
            // PKLabel
            // 
            this.PKLabel.Location = new System.Drawing.Point(590, 120);
            this.PKLabel.Name = "PKLabel";
            this.PKLabel.Size = new System.Drawing.Size(12, 13);
            this.PKLabel.StyleController = this.newJointLayoutControl;
            this.PKLabel.TabIndex = 25;
            this.PKLabel.Text = "PK";
            // 
            // GPSLabel
            // 
            this.GPSLabel.Location = new System.Drawing.Point(590, 72);
            this.GPSLabel.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.GPSLabel.Name = "GPSLabel";
            this.GPSLabel.Size = new System.Drawing.Size(19, 13);
            this.GPSLabel.StyleController = this.newJointLayoutControl;
            this.GPSLabel.TabIndex = 13;
            this.GPSLabel.Text = "GPS";
            // 
            // seaLevel
            // 
            this.seaLevel.Location = new System.Drawing.Point(1033, 69);
            this.seaLevel.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.seaLevel.MinimumSize = new System.Drawing.Size(100, 20);
            this.seaLevel.Name = "seaLevel";
            this.seaLevel.Size = new System.Drawing.Size(193, 20);
            this.seaLevel.StyleController = this.newJointLayoutControl;
            this.seaLevel.TabIndex = 6;
            // 
            // GPSLat
            // 
            this.GPSLat.Location = new System.Drawing.Point(613, 69);
            this.GPSLat.MinimumSize = new System.Drawing.Size(100, 20);
            this.GPSLat.Name = "GPSLat";
            this.GPSLat.Properties.Mask.EditMask = "f6";
            this.GPSLat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.GPSLat.Size = new System.Drawing.Size(191, 20);
            this.GPSLat.StyleController = this.newJointLayoutControl;
            this.GPSLat.TabIndex = 4;
            // 
            // GPSLong
            // 
            this.GPSLong.Location = new System.Drawing.Point(823, 69);
            this.GPSLong.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.GPSLong.MinimumSize = new System.Drawing.Size(100, 20);
            this.GPSLong.Name = "GPSLong";
            this.GPSLong.Properties.Mask.EditMask = "f6";
            this.GPSLong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.GPSLong.Size = new System.Drawing.Size(191, 20);
            this.GPSLong.StyleController = this.newJointLayoutControl;
            this.GPSLong.TabIndex = 5;
            // 
            // controlOperations
            // 
            this.controlOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlOperations.Cursor = System.Windows.Forms.Cursors.Default;
            this.controlOperations.Location = new System.Drawing.Point(584, 218);
            this.controlOperations.MainView = this.controlOperationsView;
            this.controlOperations.Margin = new System.Windows.Forms.Padding(15);
            this.controlOperations.Name = "controlOperations";
            this.controlOperations.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ControlOperationLookUpEdit,
            this.operationDateEdit,
            this.inspectorsPopupContainerEdit,
            this.resultStatusLookUpEdit,
            this.ResultValueTextEdit});
            this.controlOperations.Size = new System.Drawing.Size(657, 261);
            this.controlOperations.TabIndex = 10;
            this.controlOperations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.controlOperationsView,
            this.inspectionsGridView});
            // 
            // controlOperationsView
            // 
            this.controlOperationsView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.controlTypeGridColumn,
            this.resultGridColumn,
            this.controlDateGridColumn,
            this.inspectorsGridColumn,
            this.valueGridColumn});
            this.controlOperationsView.GridControl = this.controlOperations;
            this.controlOperationsView.Name = "controlOperationsView";
            this.controlOperationsView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.controlOperationsView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.controlOperationsView.OptionsView.ShowGroupPanel = false;
            this.controlOperationsView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.controlOperationsView_InitNewRow);
            this.controlOperationsView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.controlOperationsView_ValidateRow);
            // 
            // controlTypeGridColumn
            // 
            this.controlTypeGridColumn.Caption = "Название операции";
            this.controlTypeGridColumn.ColumnEdit = this.ControlOperationLookUpEdit;
            this.controlTypeGridColumn.FieldName = "Operation.Name";
            this.controlTypeGridColumn.Name = "controlTypeGridColumn";
            this.controlTypeGridColumn.Visible = true;
            this.controlTypeGridColumn.VisibleIndex = 0;
            this.controlTypeGridColumn.Width = 122;
            // 
            // ControlOperationLookUpEdit
            // 
            this.ControlOperationLookUpEdit.AutoHeight = false;
            this.ControlOperationLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ControlOperationLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Название")});
            this.ControlOperationLookUpEdit.DisplayMember = "Name";
            this.ControlOperationLookUpEdit.Name = "ControlOperationLookUpEdit";
            this.ControlOperationLookUpEdit.NullText = "";
            this.ControlOperationLookUpEdit.ValueMember = "Name";
            this.ControlOperationLookUpEdit.EditValueChanged += new System.EventHandler(this.ControlOperationLookUpEdit_EditValueChanged);
            // 
            // resultGridColumn
            // 
            this.resultGridColumn.Caption = "Результат";
            this.resultGridColumn.ColumnEdit = this.resultStatusLookUpEdit;
            this.resultGridColumn.FieldName = "Status";
            this.resultGridColumn.Name = "resultGridColumn";
            this.resultGridColumn.Visible = true;
            this.resultGridColumn.VisibleIndex = 1;
            this.resultGridColumn.Width = 87;
            // 
            // resultStatusLookUpEdit
            // 
            this.resultStatusLookUpEdit.AutoHeight = false;
            this.resultStatusLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.resultStatusLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Text", "Статус")});
            this.resultStatusLookUpEdit.DisplayMember = "Text";
            this.resultStatusLookUpEdit.Name = "resultStatusLookUpEdit";
            this.resultStatusLookUpEdit.NullText = "";
            this.resultStatusLookUpEdit.ValueMember = "Value";
            this.resultStatusLookUpEdit.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.resultStatusLookUpEdit_CustomDisplayText);
            // 
            // controlDateGridColumn
            // 
            this.controlDateGridColumn.Caption = "Дата контроля";
            this.controlDateGridColumn.ColumnEdit = this.operationDateEdit;
            this.controlDateGridColumn.FieldName = "Date";
            this.controlDateGridColumn.Name = "controlDateGridColumn";
            this.controlDateGridColumn.Visible = true;
            this.controlDateGridColumn.VisibleIndex = 2;
            this.controlDateGridColumn.Width = 121;
            // 
            // operationDateEdit
            // 
            this.operationDateEdit.AutoHeight = false;
            this.operationDateEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.operationDateEdit.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.operationDateEdit.Name = "operationDateEdit";
            // 
            // inspectorsGridColumn
            // 
            this.inspectorsGridColumn.Caption = "Инспектора";
            this.inspectorsGridColumn.ColumnEdit = this.inspectorsPopupContainerEdit;
            this.inspectorsGridColumn.FieldName = "Inspectors";
            this.inspectorsGridColumn.Name = "inspectorsGridColumn";
            this.inspectorsGridColumn.Visible = true;
            this.inspectorsGridColumn.VisibleIndex = 3;
            this.inspectorsGridColumn.Width = 230;
            // 
            // inspectorsPopupContainerEdit
            // 
            this.inspectorsPopupContainerEdit.AutoHeight = false;
            this.inspectorsPopupContainerEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.inspectorsPopupContainerEdit.Name = "inspectorsPopupContainerEdit";
            this.inspectorsPopupContainerEdit.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.inspectorsPopupContainerEdit_CloseUp);
            this.inspectorsPopupContainerEdit.Popup += new System.EventHandler(this.inspectorsPopupContainerEdit_Popup);
            this.inspectorsPopupContainerEdit.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.inspectorsPopupContainerEdit_CustomDisplayText);
            // 
            // valueGridColumn
            // 
            this.valueGridColumn.Caption = "Значение";
            this.valueGridColumn.ColumnEdit = this.ResultValueTextEdit;
            this.valueGridColumn.FieldName = "Value";
            this.valueGridColumn.Name = "valueGridColumn";
            this.valueGridColumn.Visible = true;
            this.valueGridColumn.VisibleIndex = 4;
            this.valueGridColumn.Width = 79;
            // 
            // ResultValueTextEdit
            // 
            this.ResultValueTextEdit.AutoHeight = false;
            this.ResultValueTextEdit.Name = "ResultValueTextEdit";
            // 
            // inspectionsGridView
            // 
            this.inspectionsGridView.GridControl = this.controlOperations;
            this.inspectionsGridView.Name = "inspectionsGridView";
            // 
            // secondJointElement
            // 
            this.secondJointElement.Location = new System.Drawing.Point(292, 117);
            this.secondJointElement.Name = "secondJointElement";
            this.secondJointElement.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.secondJointElement.Properties.Appearance.Options.UseBackColor = true;
            this.secondJointElement.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.secondJointElement.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});

            this.secondJointElement.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Number", "Номер"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PartTypeDescription", "Тип"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ConnectorsCount", "Свободные коннекторы (диаметры)")});
            this.secondJointElement.Properties.NullText = "Введите номер";
            this.secondJointElement.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.secondJointElement.Size = new System.Drawing.Size(242, 20);
            this.secondJointElement.StyleController = this.newJointLayoutControl;
            this.secondJointElement.TabIndex = 3;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Не может быть пустым";
            this.dxValidationProvider.SetValidationRule(this.secondJointElement, conditionValidationRule1);
            this.secondJointElement.EditValueChanged += new System.EventHandler(this.secondJointElement_EditValueChanged);
            // 
            // firstJointElement
            // 
            this.firstJointElement.Location = new System.Drawing.Point(34, 117);
            this.firstJointElement.Name = "firstJointElement";
            this.firstJointElement.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.firstJointElement.Properties.Appearance.Options.UseBackColor = true;
            this.firstJointElement.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.firstJointElement.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});

            this.firstJointElement.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Number", "Номер"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PartTypeDescription", "Тип"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ConnectorsCount", "Свободные коннекторы (диаметры)")});
            this.firstJointElement.Properties.NullText = "Введите номер";
            this.firstJointElement.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.firstJointElement.Size = new System.Drawing.Size(239, 20);
            this.firstJointElement.StyleController = this.newJointLayoutControl;
            this.firstJointElement.TabIndex = 2;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Не может быть пустым";
            this.dxValidationProvider.SetValidationRule(this.firstJointElement, conditionValidationRule2);
            this.firstJointElement.EditValueChanged += new System.EventHandler(this.firstJointElement_EditValueChanged);
            // 
            // loweringDate
            // 
            this.loweringDate.EditValue = null;
            this.loweringDate.Location = new System.Drawing.Point(292, 69);
            this.loweringDate.Name = "loweringDate";
            this.loweringDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.loweringDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.loweringDate.Size = new System.Drawing.Size(242, 20);
            this.loweringDate.StyleController = this.newJointLayoutControl;
            this.loweringDate.TabIndex = 1;
            // 
            // newJointLayoutGroup
            // 
            this.newJointLayoutGroup.CustomizationFormText = "Root";
            this.newJointLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.newJointLayoutGroup.GroupBordersVisible = false;
            this.newJointLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.inspectionLayoutGroup,
            this.loweringLayoutGroup,
            this.jointParametersLayoutGroup,
            this.extraFilesLayout,
            this.deactivatedLayout,
            this.saveButtonLayout,
            this.saveButtonEmptySpace,
            this.saveAndCreateLayout});
            this.newJointLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.newJointLayoutGroup.Name = "Root";
            this.newJointLayoutGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.newJointLayoutGroup.Size = new System.Drawing.Size(1275, 550);
            this.newJointLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 20, 20, 20);
            this.newJointLayoutGroup.Text = "Root";
            this.newJointLayoutGroup.TextVisible = false;
            // 
            // inspectionLayoutGroup
            // 
            this.inspectionLayoutGroup.CustomizationFormText = "Данные контроля";
            this.inspectionLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.repairOperationLayout,
            this.controlOperationsLayout});
            this.inspectionLayoutGroup.Location = new System.Drawing.Point(0, 138);
            this.inspectionLayoutGroup.Name = "inspectionLayoutGroup";
            this.inspectionLayoutGroup.Size = new System.Drawing.Size(1235, 346);
            this.inspectionLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 13, 13);
            this.inspectionLayoutGroup.Text = "Операции";
            // 
            // repairOperationLayout
            // 
            this.repairOperationLayout.Control = this.repairOperations;
            this.repairOperationLayout.CustomizationFormText = "Ремонтные операции";
            this.repairOperationLayout.Location = new System.Drawing.Point(0, 0);
            this.repairOperationLayout.Name = "repairOperationLayout";
            this.repairOperationLayout.Size = new System.Drawing.Size(543, 281);
            this.repairOperationLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 7, 0, 0);
            this.repairOperationLayout.Text = "Сварка и ремонт";
            this.repairOperationLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.repairOperationLayout.TextSize = new System.Drawing.Size(120, 13);
            // 
            // controlOperationsLayout
            // 
            this.controlOperationsLayout.Control = this.controlOperations;
            this.controlOperationsLayout.CustomizationFormText = "Контрольные операции";
            this.controlOperationsLayout.Location = new System.Drawing.Point(543, 0);
            this.controlOperationsLayout.Name = "controlOperationsLayout";
            this.controlOperationsLayout.Size = new System.Drawing.Size(668, 281);
            this.controlOperationsLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(7, 0, 0, 0);
            this.controlOperationsLayout.Text = "Контрольные операции";
            this.controlOperationsLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.controlOperationsLayout.TextSize = new System.Drawing.Size(120, 13);
            // 
            // loweringLayoutGroup
            // 
            this.loweringLayoutGroup.CustomizationFormText = "Параметры укаладки";
            this.loweringLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.GPSLatLayout,
            this.GPSLongLayout,
            this.elevationLayout,
            this.PKNumberLayout,
            this.distanceFromPKLayout,
            this.loweringEmptySpace,
            this.PKLabelLayout,
            this.GPSLabelLayout});
            this.loweringLayoutGroup.Location = new System.Drawing.Point(543, 0);
            this.loweringLayoutGroup.Name = "loweringLayoutGroup";
            this.loweringLayoutGroup.Size = new System.Drawing.Size(692, 138);
            this.loweringLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 2, 2, 2);
            this.loweringLayoutGroup.Text = "Параметры укладки";
            // 
            // GPSLatLayout
            // 
            this.GPSLatLayout.Control = this.GPSLat;
            this.GPSLatLayout.CustomizationFormText = "Øèðîòà";
            this.GPSLatLayout.Location = new System.Drawing.Point(23, 0);
            this.GPSLatLayout.MinSize = new System.Drawing.Size(119, 40);
            this.GPSLatLayout.Name = "GPSLatLayout";
            this.GPSLatLayout.Size = new System.Drawing.Size(210, 48);
            this.GPSLatLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.GPSLatLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 15, 0, 7);
            this.GPSLatLayout.Text = "Широта";
            this.GPSLatLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.GPSLatLayout.TextSize = new System.Drawing.Size(120, 13);
            // 
            // GPSLongLayout
            // 
            this.GPSLongLayout.Control = this.GPSLong;
            this.GPSLongLayout.CustomizationFormText = "Äîëãîòà";
            this.GPSLongLayout.Location = new System.Drawing.Point(233, 0);
            this.GPSLongLayout.MinSize = new System.Drawing.Size(134, 40);
            this.GPSLongLayout.Name = "GPSLongLayout";
            this.GPSLongLayout.Size = new System.Drawing.Size(210, 48);
            this.GPSLongLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.GPSLongLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 15, 0, 7);
            this.GPSLongLayout.Text = "Долгота";
            this.GPSLongLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.GPSLongLayout.TextSize = new System.Drawing.Size(120, 13);
            // 
            // elevationLayout
            // 
            this.elevationLayout.Control = this.seaLevel;
            this.elevationLayout.CustomizationFormText = "Âûñîòà";
            this.elevationLayout.Location = new System.Drawing.Point(443, 0);
            this.elevationLayout.MinSize = new System.Drawing.Size(136, 40);
            this.elevationLayout.Name = "elevationLayout";
            this.elevationLayout.Size = new System.Drawing.Size(212, 48);
            this.elevationLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.elevationLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 15, 0, 7);
            this.elevationLayout.Text = "Высота";
            this.elevationLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.elevationLayout.TextSize = new System.Drawing.Size(120, 13);
            // 
            // PKNumberLayout
            // 
            this.PKNumberLayout.Control = this.PKNumber;
            this.PKNumberLayout.CustomizationFormText = "Номер пикета";
            this.PKNumberLayout.Location = new System.Drawing.Point(23, 48);
            this.PKNumberLayout.Name = "PKNumberLayout";
            this.PKNumberLayout.Size = new System.Drawing.Size(210, 47);
            this.PKNumberLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 15, 0, 7);
            this.PKNumberLayout.Text = "Номер пикета";
            this.PKNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.PKNumberLayout.TextSize = new System.Drawing.Size(120, 13);
            // 
            // distanceFromPKLayout
            // 
            this.distanceFromPKLayout.Control = this.distanceFromPK;
            this.distanceFromPKLayout.CustomizationFormText = "Расстояние от пикета";
            this.distanceFromPKLayout.Location = new System.Drawing.Point(233, 48);
            this.distanceFromPKLayout.Name = "distanceFromPKLayout";
            this.distanceFromPKLayout.Size = new System.Drawing.Size(210, 47);
            this.distanceFromPKLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 15, 0, 7);
            this.distanceFromPKLayout.Text = "Расстояние от пикета";
            this.distanceFromPKLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.distanceFromPKLayout.TextSize = new System.Drawing.Size(120, 13);
            // 
            // loweringEmptySpace
            // 
            this.loweringEmptySpace.AllowHotTrack = false;
            this.loweringEmptySpace.CustomizationFormText = "loweringEmptySpace";
            this.loweringEmptySpace.Location = new System.Drawing.Point(443, 48);
            this.loweringEmptySpace.Name = "loweringEmptySpace";
            this.loweringEmptySpace.Size = new System.Drawing.Size(212, 47);
            this.loweringEmptySpace.Text = "loweringEmptySpace";
            this.loweringEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // PKLabelLayout
            // 
            this.PKLabelLayout.Control = this.PKLabel;
            this.PKLabelLayout.CustomizationFormText = "PK";
            this.PKLabelLayout.Location = new System.Drawing.Point(0, 48);
            this.PKLabelLayout.Name = "PKLabelLayout";
            this.PKLabelLayout.Size = new System.Drawing.Size(23, 47);
            this.PKLabelLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 7, 19, 9);
            this.PKLabelLayout.Text = "PK ";
            this.PKLabelLayout.TextSize = new System.Drawing.Size(0, 0);
            this.PKLabelLayout.TextToControlDistance = 0;
            this.PKLabelLayout.TextVisible = false;
            // 
            // GPSLabelLayout
            // 
            this.GPSLabelLayout.Control = this.GPSLabel;
            this.GPSLabelLayout.CustomizationFormText = "GPSLabelLayout";
            this.GPSLabelLayout.Location = new System.Drawing.Point(0, 0);
            this.GPSLabelLayout.Name = "GPSLabelLayout";
            this.GPSLabelLayout.Size = new System.Drawing.Size(23, 48);
            this.GPSLabelLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 19, 12);
            this.GPSLabelLayout.Text = "GPSLabelLayout";
            this.GPSLabelLayout.TextSize = new System.Drawing.Size(0, 0);
            this.GPSLabelLayout.TextToControlDistance = 0;
            this.GPSLabelLayout.TextVisible = false;
            // 
            // jointParametersLayoutGroup
            // 
            this.jointParametersLayoutGroup.CustomizationFormText = "Параметры стыка";
            this.jointParametersLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.jointNumberLayout,
            this.loweringDateLayout,
            this.firstJointElementLayout,
            this.secondJointElementLayout});
            this.jointParametersLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.jointParametersLayoutGroup.Name = "jointParametersLayoutGroup";
            this.jointParametersLayoutGroup.Size = new System.Drawing.Size(543, 138);
            this.jointParametersLayoutGroup.Text = "Параметры стыка";
            // 
            // jointNumberLayout
            // 
            this.jointNumberLayout.Control = this.jointNumber;
            this.jointNumberLayout.CustomizationFormText = "Íîìåð ñòûêà";
            this.jointNumberLayout.Location = new System.Drawing.Point(0, 0);
            this.jointNumberLayout.MinSize = new System.Drawing.Size(100, 47);
            this.jointNumberLayout.Name = "jointNumberLayout";
            this.jointNumberLayout.Size = new System.Drawing.Size(258, 48);
            this.jointNumberLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.jointNumberLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 15, 0, 7);
            this.jointNumberLayout.Text = "Номер стыка";
            this.jointNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.jointNumberLayout.TextSize = new System.Drawing.Size(120, 13);
            // 
            // loweringDateLayout
            // 
            this.loweringDateLayout.Control = this.loweringDate;
            this.loweringDateLayout.CustomizationFormText = "Äàòà óêëàäêè";
            this.loweringDateLayout.Location = new System.Drawing.Point(258, 0);
            this.loweringDateLayout.MinSize = new System.Drawing.Size(134, 47);
            this.loweringDateLayout.Name = "loweringDateLayout";
            this.loweringDateLayout.Size = new System.Drawing.Size(261, 48);
            this.loweringDateLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.loweringDateLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 15, 0, 7);
            this.loweringDateLayout.Text = "Дата укладки";
            this.loweringDateLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.loweringDateLayout.TextSize = new System.Drawing.Size(120, 13);
            // 
            // firstJointElementLayout
            // 
            this.firstJointElementLayout.Control = this.firstJointElement;
            this.firstJointElementLayout.CustomizationFormText = "Ïåðâûé ñòûêóåìûé ýëåìåíò";
            this.firstJointElementLayout.Location = new System.Drawing.Point(0, 48);
            this.firstJointElementLayout.MinSize = new System.Drawing.Size(169, 47);
            this.firstJointElementLayout.Name = "firstJointElementLayout";
            this.firstJointElementLayout.Size = new System.Drawing.Size(258, 47);
            this.firstJointElementLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.firstJointElementLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 15, 0, 7);
            this.firstJointElementLayout.Text = "Первый элемент стыка";
            this.firstJointElementLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.firstJointElementLayout.TextSize = new System.Drawing.Size(120, 13);
            // 
            // secondJointElementLayout
            // 
            this.secondJointElementLayout.Control = this.secondJointElement;
            this.secondJointElementLayout.CustomizationFormText = "Âòîðîé ñòûêóåìûé ýëåìåíò";
            this.secondJointElementLayout.Location = new System.Drawing.Point(258, 48);
            this.secondJointElementLayout.MinSize = new System.Drawing.Size(169, 47);
            this.secondJointElementLayout.Name = "secondJointElementLayout";
            this.secondJointElementLayout.Size = new System.Drawing.Size(261, 47);
            this.secondJointElementLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.secondJointElementLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 15, 0, 7);
            this.secondJointElementLayout.Text = "Второй элемент стыка";
            this.secondJointElementLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.secondJointElementLayout.TextSize = new System.Drawing.Size(120, 13);
            // 
            // extraFilesLayout
            // 
            this.extraFilesLayout.Control = this.extraFiles;
            this.extraFilesLayout.CustomizationFormText = "extraFilesLayout";
            this.extraFilesLayout.Location = new System.Drawing.Point(0, 484);
            this.extraFilesLayout.MinSize = new System.Drawing.Size(104, 26);
            this.extraFilesLayout.Name = "extraFilesLayout";
            this.extraFilesLayout.Size = new System.Drawing.Size(104, 26);
            this.extraFilesLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.extraFilesLayout.Text = "extraFilesLayout";
            this.extraFilesLayout.TextSize = new System.Drawing.Size(0, 0);
            this.extraFilesLayout.TextToControlDistance = 0;
            this.extraFilesLayout.TextVisible = false;
            // 
            // deactivatedLayout
            // 
            this.deactivatedLayout.Control = this.deactivated;
            this.deactivatedLayout.CustomizationFormText = "deactivatedLayout";
            this.deactivatedLayout.Location = new System.Drawing.Point(104, 484);
            this.deactivatedLayout.MaxSize = new System.Drawing.Size(175, 23);
            this.deactivatedLayout.MinSize = new System.Drawing.Size(175, 23);
            this.deactivatedLayout.Name = "deactivatedLayout";
            this.deactivatedLayout.Size = new System.Drawing.Size(175, 26);
            this.deactivatedLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.deactivatedLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(25, 15, 0, 0);
            this.deactivatedLayout.Text = "deactivatedLayout";
            this.deactivatedLayout.TextSize = new System.Drawing.Size(0, 0);
            this.deactivatedLayout.TextToControlDistance = 0;
            this.deactivatedLayout.TextVisible = false;
            // 
            // saveButtonLayout
            // 
            this.saveButtonLayout.Control = this.saveButton;
            this.saveButtonLayout.CustomizationFormText = "saveButtonLayout";
            this.saveButtonLayout.Location = new System.Drawing.Point(973, 484);
            this.saveButtonLayout.MaxSize = new System.Drawing.Size(116, 26);
            this.saveButtonLayout.MinSize = new System.Drawing.Size(116, 26);
            this.saveButtonLayout.Name = "saveButtonLayout";
            this.saveButtonLayout.Size = new System.Drawing.Size(116, 26);
            this.saveButtonLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.saveButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 0, 0, 0);
            this.saveButtonLayout.Text = "saveButtonLayout";
            this.saveButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.saveButtonLayout.TextToControlDistance = 0;
            this.saveButtonLayout.TextVisible = false;
            // 
            // saveButtonEmptySpace
            // 
            this.saveButtonEmptySpace.AllowHotTrack = false;
            this.saveButtonEmptySpace.CustomizationFormText = "saveButtonEmptySpace";
            this.saveButtonEmptySpace.Location = new System.Drawing.Point(279, 484);
            this.saveButtonEmptySpace.Name = "saveButtonEmptySpace";
            this.saveButtonEmptySpace.Size = new System.Drawing.Size(694, 26);
            this.saveButtonEmptySpace.Text = "saveButtonEmptySpace";
            this.saveButtonEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // saveAndCreateLayout
            // 
            this.saveAndCreateLayout.Control = this.saveAndCreateButton;
            this.saveAndCreateLayout.CustomizationFormText = "saveAndCreateLayout";
            this.saveAndCreateLayout.Location = new System.Drawing.Point(1089, 484);
            this.saveAndCreateLayout.Name = "saveAndCreateLayout";
            this.saveAndCreateLayout.Size = new System.Drawing.Size(146, 26);
            this.saveAndCreateLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 0);
            this.saveAndCreateLayout.Text = "saveAndCreateLayout";
            this.saveAndCreateLayout.TextSize = new System.Drawing.Size(0, 0);
            this.saveAndCreateLayout.TextToControlDistance = 0;
            this.saveAndCreateLayout.TextVisible = false;
            // 
            // JointNewEditXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1275, 550);
            this.Controls.Add(this.newJointLayoutControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JointNewEditXtraForm";
            this.ShowIcon = false;
            this.Text = "Стык";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JointNewEditXtraForm_FormClosed);
            this.Load += new System.EventHandler(this.JointNewEditXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jointNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newJointLayoutControl)).EndInit();
            this.newJointLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repairOperations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairOperationsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairOperationsLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairDateEdit.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairDateEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompletedCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldersPopupContainerEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deactivated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceFromPK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PKNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seaLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPSLat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPSLong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlOperations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlOperationsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlOperationLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultStatusLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationDateEdit.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationDateEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsPopupContainerEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultValueTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondJointElement.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstJointElement.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loweringDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loweringDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newJointLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairOperationLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlOperationsLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loweringLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPSLatLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPSLongLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevationLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PKNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceFromPKLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loweringEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PKLabelLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPSLabelLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointParametersLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loweringDateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstJointElementLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondJointElementLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraFilesLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deactivatedLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveAndCreateLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointNewEditBindingSoure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipelinePiecesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldersDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit jointNumber;
        private DevExpress.XtraEditors.DateEdit loweringDate;
        private DevExpress.XtraLayout.LayoutControl newJointLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup newJointLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem jointNumberLayout;
        private DevExpress.XtraLayout.LayoutControlItem loweringDateLayout;
        private DevExpress.XtraEditors.LookUpEdit secondJointElement;
        private DevExpress.XtraEditors.LookUpEdit firstJointElement;
        private DevExpress.XtraLayout.LayoutControlItem firstJointElementLayout;
        private DevExpress.XtraLayout.LayoutControlItem secondJointElementLayout;
        private DevExpress.XtraEditors.LabelControl GPSLabel;
        private DevExpress.XtraEditors.TextEdit seaLevel;
        private DevExpress.XtraEditors.TextEdit GPSLat;
        private DevExpress.XtraEditors.TextEdit GPSLong;
        private DevExpress.XtraGrid.GridControl controlOperations;
        private DevExpress.XtraGrid.Views.Grid.GridView controlOperationsView;
        private DevExpress.XtraGrid.Columns.GridColumn controlTypeGridColumn;
        private DevExpress.XtraGrid.Views.Grid.GridView inspectionsGridView;
        private DevExpress.XtraLayout.LayoutControlGroup inspectionLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem controlOperationsLayout;
        private DevExpress.XtraLayout.LayoutControlGroup loweringLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem GPSLatLayout;
        private DevExpress.XtraLayout.LayoutControlItem GPSLongLayout;
        private DevExpress.XtraLayout.LayoutControlItem elevationLayout;
        private DevExpress.XtraLayout.LayoutControlItem GPSLabelLayout;
        private DevExpress.XtraEditors.SimpleButton extraFiles;
        private DevExpress.XtraEditors.CheckEdit deactivated;
        private DevExpress.XtraGrid.Columns.GridColumn resultGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn controlDateGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn inspectorsGridColumn;
        private DevExpress.XtraLayout.LayoutControlGroup jointParametersLayoutGroup;
        private DevExpress.XtraEditors.TextEdit distanceFromPK;
        private DevExpress.XtraEditors.TextEdit PKNumber;
        private DevExpress.XtraEditors.LabelControl PKLabel;
        private DevExpress.XtraLayout.LayoutControlItem PKLabelLayout;
        private DevExpress.XtraLayout.LayoutControlItem PKNumberLayout;
        private DevExpress.XtraLayout.LayoutControlItem distanceFromPKLayout;
        private DevExpress.XtraLayout.EmptySpaceItem loweringEmptySpace;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraLayout.LayoutControlItem extraFilesLayout;
        private DevExpress.XtraLayout.LayoutControlItem deactivatedLayout;
        private DevExpress.XtraLayout.LayoutControlItem saveButtonLayout;
        private DevExpress.XtraLayout.EmptySpaceItem saveButtonEmptySpace;
        private System.Windows.Forms.BindingSource jointNewEditBindingSoure;
        private System.Windows.Forms.BindingSource pipelinePiecesBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ControlOperationLookUpEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit operationDateEdit;
        private DevExpress.XtraGrid.GridControl repairOperations;
        private DevExpress.XtraGrid.Views.Grid.GridView repairOperationsView;
        private DevExpress.XtraLayout.LayoutControlItem repairOperationLayout;
        private DevExpress.XtraGrid.Columns.GridColumn repairTypeGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn repairDateGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn completedGridColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit CompletedCheckEdit;
        private DevExpress.XtraGrid.Columns.GridColumn weldersGridColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repairOperationsLookUpEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repairDateEdit;
        private System.Windows.Forms.BindingSource inspectorsDataSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit inspectorsPopupContainerEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit resultStatusLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn valueGridColumn;
        private System.Windows.Forms.BindingSource weldersDataSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit weldersPopupContainerEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ResultValueTextEdit;
        private DevExpress.XtraEditors.SimpleButton saveAndCreateButton;
        private DevExpress.XtraLayout.LayoutControlItem saveAndCreateLayout;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;

    }
}