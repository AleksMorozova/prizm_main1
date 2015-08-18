namespace Prizm.Main.Forms.Parts.Inspection
{
    partial class PartInspectionXtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartInspectionXtraForm));
            this.inspectionLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.saveAndClearButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.inspections = new DevExpress.XtraGrid.GridControl();
            this.inspectionsView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryInspectionDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.resultStatusLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colInspector = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectorsPopupContainerEdit = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.colReason = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.elementType = new DevExpress.XtraEditors.TextEdit();
            this.elementNumber = new DevExpress.XtraEditors.TextEdit();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.searchNumber = new DevExpress.XtraEditors.TextEdit();
            this.InspectionLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.searchElementGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.searchButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.searchNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.findElementEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.inspectionControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.elementTypeLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.elementNumberLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.inspectionsLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.elementEmptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.saveButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.saveAndClearLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonsEmptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inspectorsDataSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inspectionLayoutControl)).BeginInit();
            this.inspectionLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inspections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryInspectionDateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryInspectionDateEdit.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultStatusLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsPopupContainerEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InspectionLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchElementGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findElementEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementTypeLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementNumberLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementEmptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveAndClearLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsEmptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsDataSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inspectionLayoutControl
            // 
            this.inspectionLayoutControl.Controls.Add(this.saveAndClearButton);
            this.inspectionLayoutControl.Controls.Add(this.saveButton);
            this.inspectionLayoutControl.Controls.Add(this.inspections);
            this.inspectionLayoutControl.Controls.Add(this.elementType);
            this.inspectionLayoutControl.Controls.Add(this.elementNumber);
            this.inspectionLayoutControl.Controls.Add(this.searchButton);
            this.inspectionLayoutControl.Controls.Add(this.searchNumber);
            this.inspectionLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inspectionLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.inspectionLayoutControl.Name = "inspectionLayoutControl";
            this.inspectionLayoutControl.OptionsView.UseDefaultDragAndDropRendering = false;
            this.inspectionLayoutControl.Root = this.InspectionLayoutControlGroup;
            this.inspectionLayoutControl.Size = new System.Drawing.Size(901, 493);
            this.inspectionLayoutControl.TabIndex = 0;
            this.inspectionLayoutControl.Text = "layoutControl1";
            // 
            // saveAndClearButton
            // 
            this.saveAndClearButton.Image = ((System.Drawing.Image)(resources.GetObject("saveAndClearButton.Image")));
            this.saveAndClearButton.Location = new System.Drawing.Point(732, 447);
            this.saveAndClearButton.Name = "saveAndClearButton";
            this.saveAndClearButton.Size = new System.Drawing.Size(145, 22);
            this.saveAndClearButton.StyleController = this.inspectionLayoutControl;
            this.saveAndClearButton.TabIndex = 10;
            this.saveAndClearButton.Text = "Со&хранить/Очистить";
            // 
            // saveButton
            // 
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(621, 447);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(92, 22);
            this.saveButton.StyleController = this.inspectionLayoutControl;
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "&Сохранить";
            // 
            // inspections
            // 
            this.inspections.Cursor = System.Windows.Forms.Cursors.Default;
            this.inspections.Location = new System.Drawing.Point(29, 187);
            this.inspections.MainView = this.inspectionsView;
            this.inspections.Name = "inspections";
            this.inspections.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.resultStatusLookUpEdit,
            this.inspectorsPopupContainerEdit,
            this.repositoryInspectionDateEdit});
            this.inspections.Size = new System.Drawing.Size(848, 256);
            this.inspections.TabIndex = 8;
            this.inspections.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.inspectionsView});
            // 
            // inspectionsView
            // 
            this.inspectionsView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDate,
            this.colResult,
            this.colInspector,
            this.colReason,
            this.colOrder});
            this.inspectionsView.GridControl = this.inspections;
            this.inspectionsView.Name = "inspectionsView";
            this.inspectionsView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.inspectionsView.OptionsBehavior.FocusLeaveOnTab = true;
            this.inspectionsView.OptionsNavigation.UseTabKey = false;
            this.inspectionsView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.inspectionsView.OptionsView.ShowGroupPanel = false;
            this.inspectionsView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colOrder, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.inspectionsView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.inspectionsView_InitNewRow);
            this.inspectionsView.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.HandleInvalidRowException);
            this.inspectionsView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.inspectionsView_ValidateRow);
            this.inspectionsView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inspectionsView_KeyDown);
            // 
            // colDate
            // 
            this.colDate.Caption = "Дата";
            this.colDate.ColumnEdit = this.repositoryInspectionDateEdit;
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            this.colDate.Width = 107;
            // 
            // repositoryInspectionDateEdit
            // 
            this.repositoryInspectionDateEdit.AutoHeight = false;
            this.repositoryInspectionDateEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryInspectionDateEdit.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryInspectionDateEdit.Name = "repositoryInspectionDateEdit";
            // 
            // colResult
            // 
            this.colResult.Caption = "Результат";
            this.colResult.ColumnEdit = this.resultStatusLookUpEdit;
            this.colResult.FieldName = "Status";
            this.colResult.Name = "colResult";
            this.colResult.Visible = true;
            this.colResult.VisibleIndex = 1;
            this.colResult.Width = 148;
            // 
            // resultStatusLookUpEdit
            // 
            this.resultStatusLookUpEdit.AutoHeight = false;
            this.resultStatusLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});

            //this.resultStatusLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            //new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Результат")});
         //   this.resultStatusLookUpEdit.DisplayMember = "Name";
            this.resultStatusLookUpEdit.Name = "resultStatusLookUpEdit";
            this.resultStatusLookUpEdit.NullText = "";
            this.resultStatusLookUpEdit.EditValueChanged += new System.EventHandler(this.resultStatusLookUpEdit_EditValueChanged);
            this.resultStatusLookUpEdit.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.resultStatusLookUpEdit_CustomDisplayText);
            
            // 
            // colInspector
            // 
            this.colInspector.Caption = "Инспектор";
            this.colInspector.ColumnEdit = this.inspectorsPopupContainerEdit;
            this.colInspector.FieldName = "Inspectors";
            this.colInspector.Name = "colInspector";
            this.colInspector.Visible = true;
            this.colInspector.VisibleIndex = 2;
            this.colInspector.Width = 360;
            // 
            // inspectorsPopupContainerEdit
            // 
            this.inspectorsPopupContainerEdit.AutoHeight = false;
            this.inspectorsPopupContainerEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.inspectorsPopupContainerEdit.Name = "inspectorsPopupContainerEdit";
            this.inspectorsPopupContainerEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.inspectorsPopupContainerEdit_QueryPopUp);
            this.inspectorsPopupContainerEdit.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.inspectorsPopupContainerEdit_CloseUp);
            this.inspectorsPopupContainerEdit.Popup += new System.EventHandler(this.inspectorsPopupContainerEdit_Popup);
            this.inspectorsPopupContainerEdit.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.inspectorsPopupContainerEdit_CustomDisplayText);
            // 
            // colReason
            // 
            this.colReason.Caption = "Причина";
            this.colReason.FieldName = "Value";
            this.colReason.Name = "colReason";
            this.colReason.Visible = true;
            this.colReason.VisibleIndex = 3;
            this.colReason.Width = 175;
            // 
            // colOrder
            // 
            this.colOrder.Caption = "Порядок";
            this.colOrder.FieldName = "Order";
            this.colOrder.Name = "colOrder";
            this.colOrder.OptionsColumn.AllowEdit = false;
            this.colOrder.OptionsColumn.ReadOnly = true;
            this.colOrder.Visible = true;
            this.colOrder.VisibleIndex = 4;
            // 
            // elementType
            // 
            this.elementType.Location = new System.Drawing.Point(263, 148);
            this.elementType.Name = "elementType";
            this.elementType.Properties.ReadOnly = true;
            this.elementType.Size = new System.Drawing.Size(100, 20);
            this.elementType.StyleController = this.inspectionLayoutControl;
            this.elementType.TabIndex = 7;
            // 
            // elementNumber
            // 
            this.elementNumber.Location = new System.Drawing.Point(29, 148);
            this.elementNumber.Name = "elementNumber";
            this.elementNumber.Properties.ReadOnly = true;
            this.elementNumber.Size = new System.Drawing.Size(200, 20);
            this.elementNumber.StyleController = this.inspectionLayoutControl;
            this.elementNumber.TabIndex = 6;
            this.elementNumber.EditValueChanged += new System.EventHandler(this.elementNumber_EditValueChanged);
            // 
            // searchButton
            // 
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(263, 58);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(232, 22);
            this.searchButton.StyleController = this.inspectionLayoutControl;
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Найти и &редактировать для контроля";
            // 
            // searchNumber
            // 
            this.searchNumber.Location = new System.Drawing.Point(29, 59);
            this.searchNumber.Name = "searchNumber";
            this.searchNumber.Size = new System.Drawing.Size(200, 20);
            this.searchNumber.StyleController = this.inspectionLayoutControl;
            this.searchNumber.TabIndex = 4;
            this.searchNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchNumber_KeyDown);
            // 
            // InspectionLayoutControlGroup
            // 
            this.InspectionLayoutControlGroup.CustomizationFormText = "InspectionLayoutControlGroup";
            this.InspectionLayoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.InspectionLayoutControlGroup.GroupBordersVisible = false;
            this.InspectionLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.searchElementGroup,
            this.inspectionControlGroup});
            this.InspectionLayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.InspectionLayoutControlGroup.Name = "InspectionLayoutControlGroup";
            this.InspectionLayoutControlGroup.Size = new System.Drawing.Size(901, 493);
            this.InspectionLayoutControlGroup.TextVisible = false;
            // 
            // searchElementGroup
            // 
            this.searchElementGroup.CustomizationFormText = "Поиск элемента";
            this.searchElementGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.searchButtonLayout,
            this.searchNumberLayout,
            this.findElementEmptySpace});
            this.searchElementGroup.Location = new System.Drawing.Point(0, 0);
            this.searchElementGroup.Name = "searchElementGroup";
            this.searchElementGroup.Size = new System.Drawing.Size(881, 89);
            this.searchElementGroup.Text = "Поиск элемента";
            // 
            // searchButtonLayout
            // 
            this.searchButtonLayout.Control = this.searchButton;
            this.searchButtonLayout.CustomizationFormText = "searchButtonLayout";
            this.searchButtonLayout.Location = new System.Drawing.Point(224, 0);
            this.searchButtonLayout.Name = "searchButtonLayout";
            this.searchButtonLayout.Size = new System.Drawing.Size(266, 46);
            this.searchButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 15, 5);
            this.searchButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.searchButtonLayout.TextVisible = false;
            // 
            // searchNumberLayout
            // 
            this.searchNumberLayout.Control = this.searchNumber;
            this.searchNumberLayout.CustomizationFormText = "Ном&ер искомого элемента";
            this.searchNumberLayout.Location = new System.Drawing.Point(0, 0);
            this.searchNumberLayout.MinSize = new System.Drawing.Size(224, 45);
            this.searchNumberLayout.Name = "searchNumberLayout";
            this.searchNumberLayout.Size = new System.Drawing.Size(224, 46);
            this.searchNumberLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.searchNumberLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 15, 0, 5);
            this.searchNumberLayout.Text = "Ном&ер искомого элемента";
            this.searchNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.searchNumberLayout.TextSize = new System.Drawing.Size(130, 13);
            // 
            // findElementEmptySpace
            // 
            this.findElementEmptySpace.AllowHotTrack = false;
            this.findElementEmptySpace.CustomizationFormText = "findElementEmptySpace";
            this.findElementEmptySpace.Location = new System.Drawing.Point(490, 0);
            this.findElementEmptySpace.Name = "findElementEmptySpace";
            this.findElementEmptySpace.Size = new System.Drawing.Size(367, 46);
            this.findElementEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // inspectionControlGroup
            // 
            this.inspectionControlGroup.CustomizationFormText = "layoutControlGroup";
            this.inspectionControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.elementTypeLayout,
            this.elementNumberLayout,
            this.inspectionsLayout,
            this.elementEmptySpaceItem,
            this.saveButtonLayout,
            this.saveAndClearLayout,
            this.buttonsEmptySpaceItem});
            this.inspectionControlGroup.Location = new System.Drawing.Point(0, 89);
            this.inspectionControlGroup.Name = "inspectionControlGroup";
            this.inspectionControlGroup.Size = new System.Drawing.Size(881, 384);
            this.inspectionControlGroup.Text = "Входной контроль";
            // 
            // elementTypeLayout
            // 
            this.elementTypeLayout.Control = this.elementType;
            this.elementTypeLayout.CustomizationFormText = "Тип элемента";
            this.elementTypeLayout.Location = new System.Drawing.Point(224, 0);
            this.elementTypeLayout.MinSize = new System.Drawing.Size(134, 40);
            this.elementTypeLayout.Name = "elementTypeLayout";
            this.elementTypeLayout.Size = new System.Drawing.Size(134, 40);
            this.elementTypeLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.elementTypeLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(15, 15, 0, 0);
            this.elementTypeLayout.Text = "&Тип элемента";
            this.elementTypeLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.elementTypeLayout.TextSize = new System.Drawing.Size(130, 13);
            // 
            // elementNumberLayout
            // 
            this.elementNumberLayout.Control = this.elementNumber;
            this.elementNumberLayout.CustomizationFormText = "Номер &элемента";
            this.elementNumberLayout.Location = new System.Drawing.Point(0, 0);
            this.elementNumberLayout.MinSize = new System.Drawing.Size(224, 40);
            this.elementNumberLayout.Name = "elementNumberLayout";
            this.elementNumberLayout.Size = new System.Drawing.Size(224, 40);
            this.elementNumberLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.elementNumberLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 15, 0, 0);
            this.elementNumberLayout.Text = "Номер &элемента";
            this.elementNumberLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.elementNumberLayout.TextSize = new System.Drawing.Size(130, 13);
            // 
            // inspectionsLayout
            // 
            this.inspectionsLayout.Control = this.inspections;
            this.inspectionsLayout.CustomizationFormText = "inspectionsLayout";
            this.inspectionsLayout.Location = new System.Drawing.Point(0, 40);
            this.inspectionsLayout.Name = "inspectionsLayout";
            this.inspectionsLayout.Size = new System.Drawing.Size(857, 275);
            this.inspectionsLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 0, 15, 0);
            this.inspectionsLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.inspectionsLayout.TextSize = new System.Drawing.Size(0, 0);
            this.inspectionsLayout.TextVisible = false;
            // 
            // elementEmptySpaceItem
            // 
            this.elementEmptySpaceItem.AllowHotTrack = false;
            this.elementEmptySpaceItem.CustomizationFormText = "elementEmptySpaceItem";
            this.elementEmptySpaceItem.Location = new System.Drawing.Point(358, 0);
            this.elementEmptySpaceItem.Name = "elementEmptySpaceItem";
            this.elementEmptySpaceItem.Size = new System.Drawing.Size(499, 40);
            this.elementEmptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // saveButtonLayout
            // 
            this.saveButtonLayout.Control = this.saveButton;
            this.saveButtonLayout.CustomizationFormText = "saveButtonLayout";
            this.saveButtonLayout.Location = new System.Drawing.Point(597, 315);
            this.saveButtonLayout.Name = "saveButtonLayout";
            this.saveButtonLayout.Size = new System.Drawing.Size(101, 26);
            this.saveButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 5, 0, 0);
            this.saveButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.saveButtonLayout.TextVisible = false;
            // 
            // saveAndClearLayout
            // 
            this.saveAndClearLayout.Control = this.saveAndClearButton;
            this.saveAndClearLayout.CustomizationFormText = "saveAndClearLayout";
            this.saveAndClearLayout.Location = new System.Drawing.Point(698, 315);
            this.saveAndClearLayout.Name = "saveAndClearLayout";
            this.saveAndClearLayout.Size = new System.Drawing.Size(159, 26);
            this.saveAndClearLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 0);
            this.saveAndClearLayout.TextSize = new System.Drawing.Size(0, 0);
            this.saveAndClearLayout.TextVisible = false;
            // 
            // buttonsEmptySpaceItem
            // 
            this.buttonsEmptySpaceItem.AllowHotTrack = false;
            this.buttonsEmptySpaceItem.CustomizationFormText = "buttonsEmptySpaceItem";
            this.buttonsEmptySpaceItem.Location = new System.Drawing.Point(0, 315);
            this.buttonsEmptySpaceItem.Name = "buttonsEmptySpaceItem";
            this.buttonsEmptySpaceItem.Size = new System.Drawing.Size(597, 26);
            this.buttonsEmptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // PartInspectionXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 493);
            this.Controls.Add(this.inspectionLayoutControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PartInspectionXtraForm";
            this.Text = "Входной контроль";
            this.Load += new System.EventHandler(this.PartInspectionXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inspectionLayoutControl)).EndInit();
            this.inspectionLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inspections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryInspectionDateEdit.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryInspectionDateEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultStatusLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsPopupContainerEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InspectionLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchElementGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findElementEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementTypeLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementNumberLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementEmptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveAndClearLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsEmptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsDataSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl inspectionLayoutControl;
        private DevExpress.XtraGrid.GridControl inspections;
        private DevExpress.XtraGrid.Views.Grid.GridView inspectionsView;
        private DevExpress.XtraEditors.TextEdit elementType;
        private DevExpress.XtraEditors.TextEdit elementNumber;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraEditors.TextEdit searchNumber;
        private DevExpress.XtraLayout.LayoutControlGroup InspectionLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlGroup searchElementGroup;
        private DevExpress.XtraLayout.LayoutControlItem searchButtonLayout;
        private DevExpress.XtraLayout.LayoutControlItem searchNumberLayout;
        private DevExpress.XtraLayout.LayoutControlGroup inspectionControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem elementTypeLayout;
        private DevExpress.XtraLayout.LayoutControlItem elementNumberLayout;
        private DevExpress.XtraLayout.LayoutControlItem inspectionsLayout;
        private DevExpress.XtraLayout.EmptySpaceItem findElementEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem elementEmptySpaceItem;
        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colResult;
        private DevExpress.XtraGrid.Columns.GridColumn colInspector;
        private DevExpress.XtraGrid.Columns.GridColumn colReason;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit resultStatusLookUpEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit inspectorsPopupContainerEdit;
        private System.Windows.Forms.BindingSource inspectorsDataSource;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraLayout.LayoutControlItem saveButtonLayout;
        private DevExpress.XtraEditors.SimpleButton saveAndClearButton;
        private DevExpress.XtraLayout.LayoutControlItem saveAndClearLayout;
        private DevExpress.XtraLayout.EmptySpaceItem buttonsEmptySpaceItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryInspectionDateEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colOrder;
    }
}