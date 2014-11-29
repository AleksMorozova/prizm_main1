namespace PrizmMain.Forms.Settings
{
    partial class SettingsXtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsXtraForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.pipesSizeList = new DevExpress.XtraGrid.GridControl();
            this.pipesSizeListGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pipeSizeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.typeRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.isActiveGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.settings = new DevExpress.XtraTab.XtraTabControl();
            this.pipePage = new DevExpress.XtraTab.XtraTabPage();
            this.generalPipeLayout = new DevExpress.XtraLayout.LayoutControl();
            this.inspectionOperation = new DevExpress.XtraGrid.GridControl();
            this.inspectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inspectionView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.inspectionCodeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.codeRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.inspectionNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.controlNameRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.testSubjectGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.subjectRepositoryItemEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.controlTypeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.controlTypeItems = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.resultTypeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.resultTypeItems = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.boolExpectedGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.minExpectedGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.maxExpectedGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isRequiredGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isRequired = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.testIsActiveGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pipeParametersLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.inspectionOperationLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.pipesSizeListLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.projectPage = new DevExpress.XtraTab.XtraTabPage();
            this.generalProjectLayout = new DevExpress.XtraLayout.LayoutControl();
            this.projectTitle = new DevExpress.XtraEditors.TextEdit();
            this.design = new DevExpress.XtraEditors.TextEdit();
            this.externalDocumentSize = new DevExpress.XtraEditors.TextEdit();
            this.client = new DevExpress.XtraEditors.TextEdit();
            this.plateManufacturersList = new DevExpress.XtraGrid.GridControl();
            this.plateManufacturersListView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.plateManufacturerGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.manufacturerRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.projectLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.generalProjectParametersLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.clientLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.designLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.clientEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.plateManufacturersLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.projectTitleLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.projectTitleEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.technicalProjectParametersLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.externalDocumentSizeLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.externalDocumentSizeEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.pipelinePage = new DevExpress.XtraTab.XtraTabPage();
            this.usersPage = new DevExpress.XtraTab.XtraTabPage();
            this.usersLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.userEditButton = new DevExpress.XtraEditors.SimpleButton();
            this.userAddButton = new DevExpress.XtraEditors.SimpleButton();
            this.users = new DevExpress.XtraGrid.GridControl();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.usersRootGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.usersAddButtonLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.editUserLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.usersLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.rightUsersButtonEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.divideButtonUsersEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.rolesPage = new DevExpress.XtraTab.XtraTabPage();
            this.usersButtonLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.roles = new DevExpress.XtraGrid.GridControl();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.roleEditButton = new DevExpress.XtraEditors.SimpleButton();
            this.roleAddButton = new DevExpress.XtraEditors.SimpleButton();
            this.rolesRootGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.roleButtonRightEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.roleAddButtonLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.roleEditLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.roleButtonDivideEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.roleEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.roleLayoutControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.dictionariesPage = new DevExpress.XtraTab.XtraTabPage();
            this.dictionaryLayout = new DevExpress.XtraLayout.LayoutControl();
            this.dictionaries = new DevExpress.XtraGrid.GridControl();
            this.dictionaryView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dictionaryNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.editDictionary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.editItem = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.dictonaryLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.dictionaryGridLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.weldersPage = new DevExpress.XtraTab.XtraTabPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControlWelders = new DevExpress.XtraGrid.GridControl();
            this.gridViewWelders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWelderFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.welderFNRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colWelderLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.welderLNRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colWelderMiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.welderMNRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colWelderCert = new DevExpress.XtraGrid.Columns.GridColumn();
            this.welderCertificateTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colWelderCertExp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWelderStamp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stampRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colWelderGrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWelderActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroupWerlders = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemWelders = new DevExpress.XtraLayout.LayoutControlItem();
            this.inspectorsPage = new DevExpress.XtraTab.XtraTabPage();
            this.layoutControlInspectors = new DevExpress.XtraLayout.LayoutControl();
            this.gridControlInspectors = new DevExpress.XtraGrid.GridControl();
            this.gridViewInspectors = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colInspectorFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectorFNRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colInspectorLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectorLNRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colInspectorMiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectorMNRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colInspectorCertificate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectorCertificateTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colInspectorCertExp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInspectorActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemInspectors = new DevExpress.XtraLayout.LayoutControlItem();
            this.settingsTabPanel = new DevExpress.XtraEditors.PanelControl();
            this.generalSettingsLayout = new DevExpress.XtraLayout.LayoutControl();
            this.closeButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.generalSettingsLayoutGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.settingsLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.closeButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonEmptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.saveButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.pipeMillSizeTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pipesSizeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipesSizeListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
            this.settings.SuspendLayout();
            this.pipePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalPipeLayout)).BeginInit();
            this.generalPipeLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlNameRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectRepositoryItemEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlTypeItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultTypeItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isRequired)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeParametersLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionOperationLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipesSizeListLayout)).BeginInit();
            this.projectPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalProjectLayout)).BeginInit();
            this.generalProjectLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.design.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalDocumentSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalProjectParametersLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTitleLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTitleEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicalProjectParametersLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalDocumentSizeLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalDocumentSizeEmptySpace)).BeginInit();
            this.usersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersLayoutControl)).BeginInit();
            this.usersLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersRootGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersAddButtonLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editUserLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightUsersButtonEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divideButtonUsersEmptySpace)).BeginInit();
            this.rolesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersButtonLayoutControl)).BeginInit();
            this.usersButtonLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesRootGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleButtonRightEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleAddButtonLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleEditLayoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleButtonDivideEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleLayoutControl)).BeginInit();
            this.dictionariesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryLayout)).BeginInit();
            this.dictionaryLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictonaryLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryGridLayout)).BeginInit();
            this.weldersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWelders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWelders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.welderFNRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.welderLNRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.welderMNRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.welderCertificateTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stampRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupWerlders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemWelders)).BeginInit();
            this.inspectorsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlInspectors)).BeginInit();
            this.layoutControlInspectors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInspectors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInspectors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorFNRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorLNRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorMNRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorCertificateTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemInspectors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsTabPanel)).BeginInit();
            this.settingsTabPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalSettingsLayout)).BeginInit();
            this.generalSettingsLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalSettingsLayoutGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEmptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeMillSizeTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pipesSizeList
            // 
            this.pipesSizeList.Cursor = System.Windows.Forms.Cursors.Default;
            this.pipesSizeList.Location = new System.Drawing.Point(14, 27);
            this.pipesSizeList.MainView = this.pipesSizeListGridView;
            this.pipesSizeList.Name = "pipesSizeList";
            this.pipesSizeList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.typeRepositoryTextEdit});
            this.pipesSizeList.Size = new System.Drawing.Size(273, 422);
            this.pipesSizeList.TabIndex = 11;
            this.pipesSizeList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.pipesSizeListGridView});
            // 
            // pipesSizeListGridView
            // 
            this.pipesSizeListGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.pipeSizeGridColumn,
            this.isActiveGridColumn});
            this.pipesSizeListGridView.GridControl = this.pipesSizeList;
            this.pipesSizeListGridView.Name = "pipesSizeListGridView";
            this.pipesSizeListGridView.OptionsView.ShowGroupPanel = false;
            this.pipesSizeListGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.pipesSizeListGridView_InitNewRow);
            this.pipesSizeListGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.pipesSizeListGridView_FocusedRowChanged);
            // 
            // pipeSizeGridColumn
            // 
            this.pipeSizeGridColumn.Caption = "Типоразмер";
            this.pipeSizeGridColumn.ColumnEdit = this.typeRepositoryTextEdit;
            this.pipeSizeGridColumn.FieldName = "Type";
            this.pipeSizeGridColumn.Name = "pipeSizeGridColumn";
            this.pipeSizeGridColumn.Visible = true;
            this.pipeSizeGridColumn.VisibleIndex = 0;
            this.pipeSizeGridColumn.Width = 213;
            // 
            // typeRepositoryTextEdit
            // 
            this.typeRepositoryTextEdit.AutoHeight = false;
            this.typeRepositoryTextEdit.Name = "typeRepositoryTextEdit";
            // 
            // isActiveGridColumn
            // 
            this.isActiveGridColumn.Caption = "Активный";
            this.isActiveGridColumn.FieldName = "IsActive";
            this.isActiveGridColumn.Name = "isActiveGridColumn";
            this.isActiveGridColumn.Visible = true;
            this.isActiveGridColumn.VisibleIndex = 1;
            this.isActiveGridColumn.Width = 42;
            // 
            // settings
            // 
            this.settings.Location = new System.Drawing.Point(14, 4);
            this.settings.Name = "settings";
            this.settings.Padding = new System.Windows.Forms.Padding(5);
            this.settings.SelectedTabPage = this.pipePage;
            this.settings.Size = new System.Drawing.Size(1247, 491);
            this.settings.TabIndex = 0;
            this.settings.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.projectPage,
            this.pipePage,
            this.pipelinePage,
            this.usersPage,
            this.rolesPage,
            this.dictionariesPage,
            this.weldersPage,
            this.inspectorsPage});
            // 
            // pipePage
            // 
            this.pipePage.Controls.Add(this.generalPipeLayout);
            this.pipePage.Name = "pipePage";
            this.pipePage.Size = new System.Drawing.Size(1241, 463);
            this.pipePage.Text = "&Труба";
            // 
            // generalPipeLayout
            // 
            this.generalPipeLayout.Controls.Add(this.pipesSizeList);
            this.generalPipeLayout.Controls.Add(this.inspectionOperation);
            this.generalPipeLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalPipeLayout.Location = new System.Drawing.Point(0, 0);
            this.generalPipeLayout.Name = "generalPipeLayout";
            this.generalPipeLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(346, 216, 250, 350);
            this.generalPipeLayout.Root = this.pipeParametersLayoutGroup;
            this.generalPipeLayout.Size = new System.Drawing.Size(1241, 463);
            this.generalPipeLayout.TabIndex = 10;
            this.generalPipeLayout.Text = "layoutControl2";
            // 
            // inspectionOperation
            // 
            this.inspectionOperation.Cursor = System.Windows.Forms.Cursors.Default;
            this.inspectionOperation.DataSource = this.inspectionBindingSource;
            this.inspectionOperation.Location = new System.Drawing.Point(301, 27);
            this.inspectionOperation.MainView = this.inspectionView;
            this.inspectionOperation.Name = "inspectionOperation";
            this.inspectionOperation.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.isRequired,
            this.controlTypeItems,
            this.resultTypeItems,
            this.codeRepositoryTextEdit,
            this.controlNameRepositoryTextEdit,
            this.subjectRepositoryItemEdit});
            this.inspectionOperation.Size = new System.Drawing.Size(926, 422);
            this.inspectionOperation.TabIndex = 9;
            this.inspectionOperation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.inspectionView});
            // 
            // inspectionBindingSource
            // 
            this.inspectionBindingSource.DataSource = typeof(PrizmMain.DummyData.InspectionDummy);
            // 
            // inspectionView
            // 
            this.inspectionView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.inspectionCodeGridColumn,
            this.inspectionNameGridColumn,
            this.testSubjectGridColumn,
            this.controlTypeGridColumn,
            this.resultTypeGridColumn,
            this.boolExpectedGridColumn,
            this.minExpectedGridColumn,
            this.maxExpectedGridColumn,
            this.isRequiredGridColumn,
            this.testIsActiveGridColumn});
            this.inspectionView.GridControl = this.inspectionOperation;
            this.inspectionView.Name = "inspectionView";
            this.inspectionView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.inspectionView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.inspectionView.OptionsView.ShowGroupPanel = false;
            this.inspectionView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.inspectionView_InitNewRow);
            // 
            // inspectionCodeGridColumn
            // 
            this.inspectionCodeGridColumn.Caption = "Код";
            this.inspectionCodeGridColumn.ColumnEdit = this.codeRepositoryTextEdit;
            this.inspectionCodeGridColumn.FieldName = "Code";
            this.inspectionCodeGridColumn.Name = "inspectionCodeGridColumn";
            this.inspectionCodeGridColumn.Visible = true;
            this.inspectionCodeGridColumn.VisibleIndex = 0;
            this.inspectionCodeGridColumn.Width = 50;
            // 
            // codeRepositoryTextEdit
            // 
            this.codeRepositoryTextEdit.AutoHeight = false;
            this.codeRepositoryTextEdit.Name = "codeRepositoryTextEdit";
            // 
            // inspectionNameGridColumn
            // 
            this.inspectionNameGridColumn.Caption = "Название операции";
            this.inspectionNameGridColumn.ColumnEdit = this.controlNameRepositoryTextEdit;
            this.inspectionNameGridColumn.FieldName = "Name";
            this.inspectionNameGridColumn.Name = "inspectionNameGridColumn";
            this.inspectionNameGridColumn.Visible = true;
            this.inspectionNameGridColumn.VisibleIndex = 1;
            this.inspectionNameGridColumn.Width = 180;
            // 
            // controlNameRepositoryTextEdit
            // 
            this.controlNameRepositoryTextEdit.AutoHeight = false;
            this.controlNameRepositoryTextEdit.Name = "controlNameRepositoryTextEdit";
            // 
            // testSubjectGridColumn
            // 
            this.testSubjectGridColumn.Caption = "Объект инспекции";
            this.testSubjectGridColumn.ColumnEdit = this.subjectRepositoryItemEdit;
            this.testSubjectGridColumn.FieldName = "TestSubject";
            this.testSubjectGridColumn.Name = "testSubjectGridColumn";
            this.testSubjectGridColumn.Visible = true;
            this.testSubjectGridColumn.VisibleIndex = 2;
            this.testSubjectGridColumn.Width = 180;
            // 
            // subjectRepositoryItemEdit
            // 
            this.subjectRepositoryItemEdit.AutoHeight = false;
            this.subjectRepositoryItemEdit.Name = "subjectRepositoryItemEdit";
            // 
            // controlTypeGridColumn
            // 
            this.controlTypeGridColumn.Caption = "Вид контроля";
            this.controlTypeGridColumn.ColumnEdit = this.controlTypeItems;
            this.controlTypeGridColumn.FieldName = "ControlType";
            this.controlTypeGridColumn.Name = "controlTypeGridColumn";
            this.controlTypeGridColumn.Visible = true;
            this.controlTypeGridColumn.VisibleIndex = 3;
            this.controlTypeGridColumn.Width = 100;
            // 
            // controlTypeItems
            // 
            this.controlTypeItems.AutoHeight = false;
            this.controlTypeItems.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.controlTypeItems.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Text", "Вид контроля")});
            this.controlTypeItems.DisplayMember = "Text";
            this.controlTypeItems.DropDownRows = 4;
            this.controlTypeItems.Name = "controlTypeItems";
            this.controlTypeItems.NullText = "";
            this.controlTypeItems.ValueMember = "Value";
            // 
            // resultTypeGridColumn
            // 
            this.resultTypeGridColumn.Caption = "Тип результата";
            this.resultTypeGridColumn.ColumnEdit = this.resultTypeItems;
            this.resultTypeGridColumn.FieldName = "ResultType";
            this.resultTypeGridColumn.Name = "resultTypeGridColumn";
            this.resultTypeGridColumn.Visible = true;
            this.resultTypeGridColumn.VisibleIndex = 4;
            this.resultTypeGridColumn.Width = 80;
            // 
            // resultTypeItems
            // 
            this.resultTypeItems.AutoHeight = false;
            this.resultTypeItems.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.resultTypeItems.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Text", "Тип результата")});
            this.resultTypeItems.DisplayMember = "Text";
            this.resultTypeItems.DropDownRows = 3;
            this.resultTypeItems.Name = "resultTypeItems";
            this.resultTypeItems.NullText = "";
            this.resultTypeItems.ValueMember = "Value";
            // 
            // boolExpectedGridColumn
            // 
            this.boolExpectedGridColumn.Caption = "Контрольное значение";
            this.boolExpectedGridColumn.FieldName = "BoolExpected";
            this.boolExpectedGridColumn.Name = "boolExpectedGridColumn";
            this.boolExpectedGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.boolExpectedGridColumn.Visible = true;
            this.boolExpectedGridColumn.VisibleIndex = 5;
            this.boolExpectedGridColumn.Width = 40;
            // 
            // minExpectedGridColumn
            // 
            this.minExpectedGridColumn.Caption = "min";
            this.minExpectedGridColumn.FieldName = "MinExpected";
            this.minExpectedGridColumn.Name = "minExpectedGridColumn";
            this.minExpectedGridColumn.Visible = true;
            this.minExpectedGridColumn.VisibleIndex = 6;
            this.minExpectedGridColumn.Width = 96;
            // 
            // maxExpectedGridColumn
            // 
            this.maxExpectedGridColumn.Caption = "max";
            this.maxExpectedGridColumn.FieldName = "MaxExpected";
            this.maxExpectedGridColumn.Name = "maxExpectedGridColumn";
            this.maxExpectedGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.maxExpectedGridColumn.Visible = true;
            this.maxExpectedGridColumn.VisibleIndex = 7;
            this.maxExpectedGridColumn.Width = 96;
            // 
            // isRequiredGridColumn
            // 
            this.isRequiredGridColumn.Caption = "Обязательна для отгрузки";
            this.isRequiredGridColumn.ColumnEdit = this.isRequired;
            this.isRequiredGridColumn.FieldName = "IsRequired";
            this.isRequiredGridColumn.Name = "isRequiredGridColumn";
            this.isRequiredGridColumn.Visible = true;
            this.isRequiredGridColumn.VisibleIndex = 8;
            this.isRequiredGridColumn.Width = 43;
            // 
            // isRequired
            // 
            this.isRequired.AutoHeight = false;
            this.isRequired.Name = "isRequired";
            // 
            // testIsActiveGridColumn
            // 
            this.testIsActiveGridColumn.Caption = "Активная";
            this.testIsActiveGridColumn.FieldName = "IsActive";
            this.testIsActiveGridColumn.Name = "testIsActiveGridColumn";
            this.testIsActiveGridColumn.Visible = true;
            this.testIsActiveGridColumn.VisibleIndex = 9;
            this.testIsActiveGridColumn.Width = 43;
            // 
            // pipeParametersLayoutGroup
            // 
            this.pipeParametersLayoutGroup.CustomizationFormText = "pipeParametersLayoutGroup";
            this.pipeParametersLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.pipeParametersLayoutGroup.GroupBordersVisible = false;
            this.pipeParametersLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.inspectionOperationLayout,
            this.pipesSizeListLayout});
            this.pipeParametersLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.pipeParametersLayoutGroup.Name = "pipeParametersLayoutGroup";
            this.pipeParametersLayoutGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.pipeParametersLayoutGroup.Size = new System.Drawing.Size(1241, 463);
            this.pipeParametersLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 5);
            this.pipeParametersLayoutGroup.Text = "pipeParametersLayoutGroup";
            this.pipeParametersLayoutGroup.TextVisible = false;
            // 
            // inspectionOperationLayout
            // 
            this.inspectionOperationLayout.Control = this.inspectionOperation;
            this.inspectionOperationLayout.CustomizationFormText = "Список контрольных операций";
            this.inspectionOperationLayout.Location = new System.Drawing.Point(287, 0);
            this.inspectionOperationLayout.Name = "inspectionOperationLayout";
            this.inspectionOperationLayout.Size = new System.Drawing.Size(940, 452);
            this.inspectionOperationLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.inspectionOperationLayout.Text = "Список контрольных операций для выбранного типоразмера";
            this.inspectionOperationLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.inspectionOperationLayout.TextSize = new System.Drawing.Size(312, 13);
            // 
            // pipesSizeListLayout
            // 
            this.pipesSizeListLayout.Control = this.pipesSizeList;
            this.pipesSizeListLayout.CustomizationFormText = "Список типоразмеров";
            this.pipesSizeListLayout.Location = new System.Drawing.Point(0, 0);
            this.pipesSizeListLayout.MinSize = new System.Drawing.Size(214, 50);
            this.pipesSizeListLayout.Name = "pipesSizeListLayout";
            this.pipesSizeListLayout.Size = new System.Drawing.Size(287, 452);
            this.pipesSizeListLayout.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.pipesSizeListLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.pipesSizeListLayout.Text = "Список типоразмеров";
            this.pipesSizeListLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.pipesSizeListLayout.TextSize = new System.Drawing.Size(312, 13);
            // 
            // projectPage
            // 
            this.projectPage.Controls.Add(this.generalProjectLayout);
            this.projectPage.Name = "projectPage";
            this.projectPage.Size = new System.Drawing.Size(1241, 463);
            this.projectPage.Text = "&Проект";
            // 
            // generalProjectLayout
            // 
            this.generalProjectLayout.Controls.Add(this.projectTitle);
            this.generalProjectLayout.Controls.Add(this.design);
            this.generalProjectLayout.Controls.Add(this.externalDocumentSize);
            this.generalProjectLayout.Controls.Add(this.client);
            this.generalProjectLayout.Controls.Add(this.plateManufacturersList);
            this.generalProjectLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.generalProjectLayout.Location = new System.Drawing.Point(0, 0);
            this.generalProjectLayout.Name = "generalProjectLayout";
            this.generalProjectLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(502, 203, 250, 350);
            this.generalProjectLayout.Root = this.projectLayoutGroup;
            this.generalProjectLayout.Size = new System.Drawing.Size(903, 463);
            this.generalProjectLayout.TabIndex = 16;
            this.generalProjectLayout.Text = "layoutControl1";
            // 
            // projectTitle
            // 
            this.projectTitle.EditValue = "Мой новый трубопровод";
            this.projectTitle.Location = new System.Drawing.Point(32, 62);
            this.projectTitle.Name = "projectTitle";
            this.projectTitle.Properties.ReadOnly = true;
            this.projectTitle.Size = new System.Drawing.Size(403, 20);
            this.projectTitle.StyleController = this.generalProjectLayout;
            this.projectTitle.TabIndex = 14;
            // 
            // design
            // 
            this.design.Location = new System.Drawing.Point(451, 112);
            this.design.Name = "design";
            this.design.Size = new System.Drawing.Size(405, 20);
            this.design.StyleController = this.generalProjectLayout;
            this.design.TabIndex = 13;
            // 
            // externalDocumentSize
            // 
            this.externalDocumentSize.EditValue = "";
            this.externalDocumentSize.Location = new System.Drawing.Point(34, 411);
            this.externalDocumentSize.Name = "externalDocumentSize";
            this.externalDocumentSize.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.externalDocumentSize.Properties.Mask.EditMask = "d";
            this.externalDocumentSize.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.externalDocumentSize.Properties.Mask.SaveLiteral = false;
            this.externalDocumentSize.Properties.Mask.ShowPlaceHolders = false;
            this.externalDocumentSize.Size = new System.Drawing.Size(260, 20);
            this.externalDocumentSize.StyleController = this.generalProjectLayout;
            this.externalDocumentSize.TabIndex = 3;
            // 
            // client
            // 
            this.client.Location = new System.Drawing.Point(32, 112);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(403, 20);
            this.client.StyleController = this.generalProjectLayout;
            this.client.TabIndex = 12;
            // 
            // plateManufacturersList
            // 
            this.plateManufacturersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plateManufacturersList.Cursor = System.Windows.Forms.Cursors.Default;
            this.plateManufacturersList.Location = new System.Drawing.Point(34, 162);
            this.plateManufacturersList.MainView = this.plateManufacturersListView;
            this.plateManufacturersList.Name = "plateManufacturersList";
            this.plateManufacturersList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.manufacturerRepositoryTextEdit});
            this.plateManufacturersList.Size = new System.Drawing.Size(838, 171);
            this.plateManufacturersList.TabIndex = 10;
            this.plateManufacturersList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.plateManufacturersListView});
            // 
            // plateManufacturersListView
            // 
            this.plateManufacturersListView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.plateManufacturerGridColumn});
            this.plateManufacturersListView.GridControl = this.plateManufacturersList;
            this.plateManufacturersListView.Name = "plateManufacturersListView";
            this.plateManufacturersListView.OptionsView.ShowGroupPanel = false;
            // 
            // plateManufacturerGridColumn
            // 
            this.plateManufacturerGridColumn.Caption = "Название";
            this.plateManufacturerGridColumn.ColumnEdit = this.manufacturerRepositoryTextEdit;
            this.plateManufacturerGridColumn.FieldName = "Name";
            this.plateManufacturerGridColumn.Name = "plateManufacturerGridColumn";
            this.plateManufacturerGridColumn.Visible = true;
            this.plateManufacturerGridColumn.VisibleIndex = 0;
            // 
            // manufacturerRepositoryTextEdit
            // 
            this.manufacturerRepositoryTextEdit.AutoHeight = false;
            this.manufacturerRepositoryTextEdit.Name = "manufacturerRepositoryTextEdit";
            // 
            // projectLayoutGroup
            // 
            this.projectLayoutGroup.CustomizationFormText = "projectLayoutGroup";
            this.projectLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.projectLayoutGroup.GroupBordersVisible = false;
            this.projectLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.generalProjectParametersLayoutGroup,
            this.technicalProjectParametersLayoutGroup});
            this.projectLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.projectLayoutGroup.Name = "projectLayoutGroup";
            this.projectLayoutGroup.Size = new System.Drawing.Size(903, 463);
            this.projectLayoutGroup.Text = "projectLayoutGroup";
            this.projectLayoutGroup.TextVisible = false;
            // 
            // generalProjectParametersLayoutGroup
            // 
            this.generalProjectParametersLayoutGroup.CustomizationFormText = "Общие параметры проекта : Мой новый трубопровод";
            this.generalProjectParametersLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.clientLayout,
            this.designLayout,
            this.clientEmptySpace,
            this.plateManufacturersLayout,
            this.projectTitleLayout,
            this.projectTitleEmptySpace});
            this.generalProjectParametersLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.generalProjectParametersLayoutGroup.Name = "generalProjectParametersLayoutGroup";
            this.generalProjectParametersLayoutGroup.Size = new System.Drawing.Size(883, 347);
            this.generalProjectParametersLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 2, 5, 7);
            this.generalProjectParametersLayoutGroup.Text = "Общие параметры";
            // 
            // clientLayout
            // 
            this.clientLayout.Control = this.client;
            this.clientLayout.CustomizationFormText = "Заказчик";
            this.clientLayout.Location = new System.Drawing.Point(0, 50);
            this.clientLayout.Name = "clientLayout";
            this.clientLayout.Size = new System.Drawing.Size(419, 40);
            this.clientLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 7, 0, 0);
            this.clientLayout.Text = "Заказчик";
            this.clientLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.clientLayout.TextSize = new System.Drawing.Size(251, 13);
            // 
            // designLayout
            // 
            this.designLayout.Control = this.design;
            this.designLayout.CustomizationFormText = "Производитель";
            this.designLayout.Location = new System.Drawing.Point(419, 50);
            this.designLayout.Name = "designLayout";
            this.designLayout.Size = new System.Drawing.Size(421, 40);
            this.designLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 7, 0, 0);
            this.designLayout.Text = "Производитель";
            this.designLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.designLayout.TextSize = new System.Drawing.Size(251, 13);
            // 
            // clientEmptySpace
            // 
            this.clientEmptySpace.AllowHotTrack = false;
            this.clientEmptySpace.CustomizationFormText = "clientEmptySpace";
            this.clientEmptySpace.Location = new System.Drawing.Point(840, 50);
            this.clientEmptySpace.Name = "clientEmptySpace";
            this.clientEmptySpace.Size = new System.Drawing.Size(16, 40);
            this.clientEmptySpace.Text = "clientEmptySpace";
            this.clientEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // plateManufacturersLayout
            // 
            this.plateManufacturersLayout.Control = this.plateManufacturersList;
            this.plateManufacturersLayout.CustomizationFormText = "производители листов";
            this.plateManufacturersLayout.Location = new System.Drawing.Point(0, 90);
            this.plateManufacturersLayout.Name = "plateManufacturersLayout";
            this.plateManufacturersLayout.Size = new System.Drawing.Size(856, 206);
            this.plateManufacturersLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(7, 7, 10, 5);
            this.plateManufacturersLayout.Text = "Производители листов";
            this.plateManufacturersLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.plateManufacturersLayout.TextSize = new System.Drawing.Size(251, 13);
            // 
            // projectTitleLayout
            // 
            this.projectTitleLayout.Control = this.projectTitle;
            this.projectTitleLayout.CustomizationFormText = "Название проекта";
            this.projectTitleLayout.Location = new System.Drawing.Point(0, 0);
            this.projectTitleLayout.Name = "projectTitleLayout";
            this.projectTitleLayout.Size = new System.Drawing.Size(419, 50);
            this.projectTitleLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 7, 0, 10);
            this.projectTitleLayout.Text = "Название";
            this.projectTitleLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.projectTitleLayout.TextSize = new System.Drawing.Size(251, 13);
            // 
            // projectTitleEmptySpace
            // 
            this.projectTitleEmptySpace.AllowHotTrack = false;
            this.projectTitleEmptySpace.CustomizationFormText = "projectTitleEmptySpace";
            this.projectTitleEmptySpace.Location = new System.Drawing.Point(419, 0);
            this.projectTitleEmptySpace.Name = "projectTitleEmptySpace";
            this.projectTitleEmptySpace.Size = new System.Drawing.Size(437, 50);
            this.projectTitleEmptySpace.Text = "projectTitleEmptySpace";
            this.projectTitleEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // technicalProjectParametersLayoutGroup
            // 
            this.technicalProjectParametersLayoutGroup.CustomizationFormText = "Технические параметры проекта";
            this.technicalProjectParametersLayoutGroup.ExpandButtonVisible = true;
            this.technicalProjectParametersLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.externalDocumentSizeLayout,
            this.externalDocumentSizeEmptySpace});
            this.technicalProjectParametersLayoutGroup.Location = new System.Drawing.Point(0, 347);
            this.technicalProjectParametersLayoutGroup.Name = "technicalProjectParametersLayoutGroup";
            this.technicalProjectParametersLayoutGroup.Size = new System.Drawing.Size(883, 96);
            this.technicalProjectParametersLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 2, 7, 5);
            this.technicalProjectParametersLayoutGroup.Text = "Технические параметры";
            // 
            // externalDocumentSizeLayout
            // 
            this.externalDocumentSizeLayout.Control = this.externalDocumentSize;
            this.externalDocumentSizeLayout.CustomizationFormText = "External document size limit, Kbytes";
            this.externalDocumentSizeLayout.Location = new System.Drawing.Point(0, 0);
            this.externalDocumentSizeLayout.Name = "externalDocumentSizeLayout";
            this.externalDocumentSizeLayout.Size = new System.Drawing.Size(271, 45);
            this.externalDocumentSizeLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(7, 0, 0, 5);
            this.externalDocumentSizeLayout.Text = "Допустимый размер внешнего документа, Kbytes";
            this.externalDocumentSizeLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.externalDocumentSizeLayout.TextSize = new System.Drawing.Size(251, 13);
            // 
            // externalDocumentSizeEmptySpace
            // 
            this.externalDocumentSizeEmptySpace.AllowHotTrack = false;
            this.externalDocumentSizeEmptySpace.CustomizationFormText = "externalDocumentSizeEmptySpace";
            this.externalDocumentSizeEmptySpace.Location = new System.Drawing.Point(271, 0);
            this.externalDocumentSizeEmptySpace.Name = "externalDocumentSizeEmptySpace";
            this.externalDocumentSizeEmptySpace.Size = new System.Drawing.Size(585, 45);
            this.externalDocumentSizeEmptySpace.Text = "externalDocumentSizeEmptySpace";
            this.externalDocumentSizeEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // pipelinePage
            // 
            this.pipelinePage.Name = "pipelinePage";
            this.pipelinePage.Size = new System.Drawing.Size(1241, 463);
            this.pipelinePage.Text = "Тру&бопровод";
            // 
            // usersPage
            // 
            this.usersPage.Controls.Add(this.usersLayoutControl);
            this.usersPage.Name = "usersPage";
            this.usersPage.Size = new System.Drawing.Size(1241, 463);
            this.usersPage.Text = "По&льзователи";
            // 
            // usersLayoutControl
            // 
            this.usersLayoutControl.Controls.Add(this.userEditButton);
            this.usersLayoutControl.Controls.Add(this.userAddButton);
            this.usersLayoutControl.Controls.Add(this.users);
            this.usersLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.usersLayoutControl.Name = "usersLayoutControl";
            this.usersLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(346, 216, 250, 350);
            this.usersLayoutControl.Root = this.usersRootGroup;
            this.usersLayoutControl.Size = new System.Drawing.Size(1241, 463);
            this.usersLayoutControl.TabIndex = 0;
            this.usersLayoutControl.Text = "UsersLayoutControl";
            // 
            // userEditButton
            // 
            this.userEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userEditButton.Image = ((System.Drawing.Image)(resources.GetObject("userEditButton.Image")));
            this.userEditButton.Location = new System.Drawing.Point(193, 17);
            this.userEditButton.MinimumSize = new System.Drawing.Size(100, 0);
            this.userEditButton.Name = "userEditButton";
            this.userEditButton.Size = new System.Drawing.Size(100, 22);
            this.userEditButton.StyleController = this.usersLayoutControl;
            this.userEditButton.TabIndex = 5;
            this.userEditButton.Text = "Привилегии";
            this.userEditButton.Click += new System.EventHandler(this.userEditButton_Click);
            // 
            // userAddButton
            // 
            this.userAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userAddButton.Image = ((System.Drawing.Image)(resources.GetObject("userAddButton.Image")));
            this.userAddButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.userAddButton.Location = new System.Drawing.Point(17, 17);
            this.userAddButton.Name = "userAddButton";
            this.userAddButton.Size = new System.Drawing.Size(140, 22);
            this.userAddButton.StyleController = this.usersLayoutControl;
            this.userAddButton.TabIndex = 6;
            this.userAddButton.Text = "Пользователь";
            // 
            // users
            // 
            this.users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.users.Cursor = System.Windows.Forms.Cursors.Default;
            this.users.DataSource = this.userBindingSource;
            this.users.Location = new System.Drawing.Point(17, 69);
            this.users.MainView = this.usersGridView;
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(1207, 377);
            this.users.TabIndex = 7;
            this.users.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.usersGridView});
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(PrizmMain.DummyData.User);
            // 
            // usersGridView
            // 
            this.usersGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLastName,
            this.colFirstName,
            this.colMiddleName,
            this.colLogin,
            this.colPassword,
            this.colRole});
            this.usersGridView.GridControl = this.users;
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.OptionsBehavior.Editable = false;
            this.usersGridView.OptionsCustomization.AllowGroup = false;
            this.usersGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Фамилия";
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 0;
            this.colLastName.Width = 180;
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "Имя";
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            this.colFirstName.Width = 180;
            // 
            // colMiddleName
            // 
            this.colMiddleName.Caption = "Отчество";
            this.colMiddleName.FieldName = "MiddleName";
            this.colMiddleName.Name = "colMiddleName";
            this.colMiddleName.Visible = true;
            this.colMiddleName.VisibleIndex = 2;
            this.colMiddleName.Width = 180;
            // 
            // colLogin
            // 
            this.colLogin.Caption = "Логин";
            this.colLogin.FieldName = "Login";
            this.colLogin.Name = "colLogin";
            this.colLogin.Visible = true;
            this.colLogin.VisibleIndex = 3;
            this.colLogin.Width = 150;
            // 
            // colPassword
            // 
            this.colPassword.Caption = "Пароль";
            this.colPassword.FieldName = "Password";
            this.colPassword.MaxWidth = 50;
            this.colPassword.Name = "colPassword";
            this.colPassword.Width = 50;
            // 
            // colRole
            // 
            this.colRole.Caption = "Роль";
            this.colRole.FieldName = "Role.Name";
            this.colRole.Name = "colRole";
            this.colRole.Visible = true;
            this.colRole.VisibleIndex = 4;
            this.colRole.Width = 164;
            // 
            // usersRootGroup
            // 
            this.usersRootGroup.CustomizationFormText = "Root";
            this.usersRootGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.usersRootGroup.GroupBordersVisible = false;
            this.usersRootGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.usersAddButtonLayoutControl,
            this.editUserLayoutControl,
            this.usersLabel,
            this.rightUsersButtonEmptySpace,
            this.divideButtonUsersEmptySpace});
            this.usersRootGroup.Location = new System.Drawing.Point(0, 0);
            this.usersRootGroup.Name = "usersRootGroup";
            this.usersRootGroup.Size = new System.Drawing.Size(1241, 463);
            this.usersRootGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.usersRootGroup.Text = "usersRootGroup";
            this.usersRootGroup.TextVisible = false;
            // 
            // usersAddButtonLayoutControl
            // 
            this.usersAddButtonLayoutControl.Control = this.userAddButton;
            this.usersAddButtonLayoutControl.CustomizationFormText = "usersAddButtonLayoutControl";
            this.usersAddButtonLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.usersAddButtonLayoutControl.MaxSize = new System.Drawing.Size(154, 26);
            this.usersAddButtonLayoutControl.MinSize = new System.Drawing.Size(100, 26);
            this.usersAddButtonLayoutControl.Name = "usersAddButtonLayoutControl";
            this.usersAddButtonLayoutControl.Size = new System.Drawing.Size(144, 26);
            this.usersAddButtonLayoutControl.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.usersAddButtonLayoutControl.Text = "usersAddButtonLayoutControl";
            this.usersAddButtonLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.usersAddButtonLayoutControl.TextToControlDistance = 0;
            this.usersAddButtonLayoutControl.TextVisible = false;
            // 
            // editUserLayoutControl
            // 
            this.editUserLayoutControl.Control = this.userEditButton;
            this.editUserLayoutControl.CustomizationFormText = "editUserLayoutControl";
            this.editUserLayoutControl.Location = new System.Drawing.Point(176, 0);
            this.editUserLayoutControl.MaxSize = new System.Drawing.Size(100, 26);
            this.editUserLayoutControl.MinSize = new System.Drawing.Size(100, 26);
            this.editUserLayoutControl.Name = "editUserLayoutControl";
            this.editUserLayoutControl.Size = new System.Drawing.Size(100, 26);
            this.editUserLayoutControl.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.editUserLayoutControl.Text = "editUserLayoutControl";
            this.editUserLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.editUserLayoutControl.TextToControlDistance = 0;
            this.editUserLayoutControl.TextVisible = false;
            // 
            // usersLabel
            // 
            this.usersLabel.Control = this.users;
            this.usersLabel.CustomizationFormText = "Пользователи";
            this.usersLabel.Location = new System.Drawing.Point(0, 26);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(1211, 407);
            this.usersLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 0);
            this.usersLabel.Text = "Пользователи";
            this.usersLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.usersLabel.TextSize = new System.Drawing.Size(72, 13);
            // 
            // rightUsersButtonEmptySpace
            // 
            this.rightUsersButtonEmptySpace.AllowHotTrack = false;
            this.rightUsersButtonEmptySpace.CustomizationFormText = "rightUsersButtonEmptySpace";
            this.rightUsersButtonEmptySpace.Location = new System.Drawing.Point(276, 0);
            this.rightUsersButtonEmptySpace.MinSize = new System.Drawing.Size(104, 24);
            this.rightUsersButtonEmptySpace.Name = "rightUsersButtonEmptySpace";
            this.rightUsersButtonEmptySpace.Size = new System.Drawing.Size(935, 26);
            this.rightUsersButtonEmptySpace.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.rightUsersButtonEmptySpace.Text = "rightUsersButtonEmptySpace";
            this.rightUsersButtonEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // divideButtonUsersEmptySpace
            // 
            this.divideButtonUsersEmptySpace.AllowHotTrack = false;
            this.divideButtonUsersEmptySpace.CustomizationFormText = "divideButtonUsersEmptySpace";
            this.divideButtonUsersEmptySpace.Location = new System.Drawing.Point(144, 0);
            this.divideButtonUsersEmptySpace.Name = "divideButtonUsersEmptySpace";
            this.divideButtonUsersEmptySpace.Size = new System.Drawing.Size(32, 26);
            this.divideButtonUsersEmptySpace.Text = "divideButtonUsersEmptySpace";
            this.divideButtonUsersEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // rolesPage
            // 
            this.rolesPage.Controls.Add(this.usersButtonLayoutControl);
            this.rolesPage.Name = "rolesPage";
            this.rolesPage.Size = new System.Drawing.Size(1241, 463);
            this.rolesPage.Text = "&Роли";
            // 
            // usersButtonLayoutControl
            // 
            this.usersButtonLayoutControl.Controls.Add(this.roles);
            this.usersButtonLayoutControl.Controls.Add(this.roleEditButton);
            this.usersButtonLayoutControl.Controls.Add(this.roleAddButton);
            this.usersButtonLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersButtonLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.usersButtonLayoutControl.Name = "usersButtonLayoutControl";
            this.usersButtonLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(346, 216, 250, 350);
            this.usersButtonLayoutControl.Root = this.rolesRootGroup;
            this.usersButtonLayoutControl.Size = new System.Drawing.Size(1241, 463);
            this.usersButtonLayoutControl.TabIndex = 6;
            this.usersButtonLayoutControl.Text = "layoutControl2";
            // 
            // roles
            // 
            this.roles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roles.Cursor = System.Windows.Forms.Cursors.Default;
            this.roles.DataSource = this.roleBindingSource;
            this.roles.Location = new System.Drawing.Point(17, 76);
            this.roles.MainView = this.rolesGridView;
            this.roles.Name = "roles";
            this.roles.Size = new System.Drawing.Size(697, 370);
            this.roles.TabIndex = 5;
            this.roles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.rolesGridView});
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(PrizmMain.DummyData.Role);
            // 
            // rolesGridView
            // 
            this.rolesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colDescription});
            this.rolesGridView.GridControl = this.roles;
            this.rolesGridView.Name = "rolesGridView";
            this.rolesGridView.OptionsBehavior.Editable = false;
            this.rolesGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colName
            // 
            this.colName.Caption = "Роль";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 150;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Описание";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 356;
            // 
            // roleEditButton
            // 
            this.roleEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roleEditButton.Image = ((System.Drawing.Image)(resources.GetObject("roleEditButton.Image")));
            this.roleEditButton.Location = new System.Drawing.Point(186, 17);
            this.roleEditButton.Name = "roleEditButton";
            this.roleEditButton.Size = new System.Drawing.Size(150, 24);
            this.roleEditButton.StyleController = this.usersButtonLayoutControl;
            this.roleEditButton.TabIndex = 3;
            this.roleEditButton.Text = "Привилегии";
            this.roleEditButton.Click += new System.EventHandler(this.editRoleButton_Click);
            // 
            // roleAddButton
            // 
            this.roleAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.roleAddButton.Image = ((System.Drawing.Image)(resources.GetObject("roleAddButton.Image")));
            this.roleAddButton.Location = new System.Drawing.Point(17, 17);
            this.roleAddButton.Name = "roleAddButton";
            this.roleAddButton.Size = new System.Drawing.Size(150, 24);
            this.roleAddButton.StyleController = this.usersButtonLayoutControl;
            this.roleAddButton.TabIndex = 4;
            this.roleAddButton.Text = "Пользователь";
            this.roleAddButton.Click += new System.EventHandler(this.roleAddButton_Click);
            // 
            // rolesRootGroup
            // 
            this.rolesRootGroup.CustomizationFormText = "Root";
            this.rolesRootGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.rolesRootGroup.GroupBordersVisible = false;
            this.rolesRootGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.roleButtonRightEmptySpace,
            this.roleAddButtonLayoutControl,
            this.roleEditLayoutControl,
            this.roleButtonDivideEmptySpace,
            this.roleEmptySpace,
            this.roleLayoutControl});
            this.rolesRootGroup.Location = new System.Drawing.Point(0, 0);
            this.rolesRootGroup.Name = "rolesRootGroup";
            this.rolesRootGroup.Size = new System.Drawing.Size(1241, 463);
            this.rolesRootGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.rolesRootGroup.Text = "rolesRootGroup";
            this.rolesRootGroup.TextVisible = false;
            // 
            // roleButtonRightEmptySpace
            // 
            this.roleButtonRightEmptySpace.AllowHotTrack = false;
            this.roleButtonRightEmptySpace.CustomizationFormText = "roleButtonRightEmptySpace";
            this.roleButtonRightEmptySpace.Location = new System.Drawing.Point(323, 0);
            this.roleButtonRightEmptySpace.MinSize = new System.Drawing.Size(104, 24);
            this.roleButtonRightEmptySpace.Name = "roleButtonRightEmptySpace";
            this.roleButtonRightEmptySpace.Size = new System.Drawing.Size(888, 28);
            this.roleButtonRightEmptySpace.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.roleButtonRightEmptySpace.Text = "roleButtonRightEmptySpace";
            this.roleButtonRightEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // roleAddButtonLayoutControl
            // 
            this.roleAddButtonLayoutControl.Control = this.roleAddButton;
            this.roleAddButtonLayoutControl.CustomizationFormText = "roleAddButtonLayoutControl";
            this.roleAddButtonLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.roleAddButtonLayoutControl.MaxSize = new System.Drawing.Size(154, 28);
            this.roleAddButtonLayoutControl.MinSize = new System.Drawing.Size(154, 28);
            this.roleAddButtonLayoutControl.Name = "roleAddButtonLayoutControl";
            this.roleAddButtonLayoutControl.Size = new System.Drawing.Size(154, 28);
            this.roleAddButtonLayoutControl.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.roleAddButtonLayoutControl.Text = "roleAddButtonLayoutControl";
            this.roleAddButtonLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.roleAddButtonLayoutControl.TextToControlDistance = 0;
            this.roleAddButtonLayoutControl.TextVisible = false;
            // 
            // roleEditLayoutControl
            // 
            this.roleEditLayoutControl.Control = this.roleEditButton;
            this.roleEditLayoutControl.CustomizationFormText = "roleEditLayoutControl";
            this.roleEditLayoutControl.Location = new System.Drawing.Point(169, 0);
            this.roleEditLayoutControl.MaxSize = new System.Drawing.Size(154, 28);
            this.roleEditLayoutControl.MinSize = new System.Drawing.Size(154, 28);
            this.roleEditLayoutControl.Name = "roleEditLayoutControl";
            this.roleEditLayoutControl.Size = new System.Drawing.Size(154, 28);
            this.roleEditLayoutControl.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.roleEditLayoutControl.Text = "roleEditLayoutControl";
            this.roleEditLayoutControl.TextSize = new System.Drawing.Size(0, 0);
            this.roleEditLayoutControl.TextToControlDistance = 0;
            this.roleEditLayoutControl.TextVisible = false;
            // 
            // roleButtonDivideEmptySpace
            // 
            this.roleButtonDivideEmptySpace.AllowHotTrack = false;
            this.roleButtonDivideEmptySpace.CustomizationFormText = "roleButtonDivideEmptySpace";
            this.roleButtonDivideEmptySpace.Location = new System.Drawing.Point(154, 0);
            this.roleButtonDivideEmptySpace.Name = "roleButtonDivideEmptySpace";
            this.roleButtonDivideEmptySpace.Size = new System.Drawing.Size(15, 28);
            this.roleButtonDivideEmptySpace.Text = "roleButtonDivideEmptySpace";
            this.roleButtonDivideEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // roleEmptySpace
            // 
            this.roleEmptySpace.AllowHotTrack = false;
            this.roleEmptySpace.CustomizationFormText = "roleEmptySpace";
            this.roleEmptySpace.Location = new System.Drawing.Point(701, 28);
            this.roleEmptySpace.Name = "roleEmptySpace";
            this.roleEmptySpace.Size = new System.Drawing.Size(510, 405);
            this.roleEmptySpace.Text = "roleEmptySpace";
            this.roleEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // roleLayoutControl
            // 
            this.roleLayoutControl.Control = this.roles;
            this.roleLayoutControl.CustomizationFormText = "Ðîëè";
            this.roleLayoutControl.Location = new System.Drawing.Point(0, 28);
            this.roleLayoutControl.MinSize = new System.Drawing.Size(104, 40);
            this.roleLayoutControl.Name = "roleLayoutControl";
            this.roleLayoutControl.Size = new System.Drawing.Size(701, 405);
            this.roleLayoutControl.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.roleLayoutControl.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 15, 0);
            this.roleLayoutControl.Text = "Роли";
            this.roleLayoutControl.TextLocation = DevExpress.Utils.Locations.Top;
            this.roleLayoutControl.TextSize = new System.Drawing.Size(24, 13);
            // 
            // dictionariesPage
            // 
            this.dictionariesPage.Controls.Add(this.dictionaryLayout);
            this.dictionariesPage.Name = "dictionariesPage";
            this.dictionariesPage.Size = new System.Drawing.Size(1241, 463);
            this.dictionariesPage.Text = "Словар&и";
            // 
            // dictionaryLayout
            // 
            this.dictionaryLayout.Controls.Add(this.dictionaries);
            this.dictionaryLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dictionaryLayout.Location = new System.Drawing.Point(0, 0);
            this.dictionaryLayout.Name = "dictionaryLayout";
            this.dictionaryLayout.Root = this.dictonaryLayoutGroup;
            this.dictionaryLayout.Size = new System.Drawing.Size(1241, 463);
            this.dictionaryLayout.TabIndex = 1;
            this.dictionaryLayout.Text = "layoutControl1";
            // 
            // dictionaries
            // 
            this.dictionaries.Cursor = System.Windows.Forms.Cursors.Default;
            this.dictionaries.Location = new System.Drawing.Point(12, 12);
            this.dictionaries.MainView = this.dictionaryView;
            this.dictionaries.Name = "dictionaries";
            this.dictionaries.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.editItem});
            this.dictionaries.Size = new System.Drawing.Size(1217, 439);
            this.dictionaries.TabIndex = 0;
            this.dictionaries.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dictionaryView});
            // 
            // dictionaryView
            // 
            this.dictionaryView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.dictionaryNameGridColumn,
            this.editDictionary});
            this.dictionaryView.GridControl = this.dictionaries;
            this.dictionaryView.Name = "dictionaryView";
            this.dictionaryView.OptionsView.ShowGroupPanel = false;
            // 
            // dictionaryNameGridColumn
            // 
            this.dictionaryNameGridColumn.Caption = "Словари";
            this.dictionaryNameGridColumn.FieldName = "DictionaryName";
            this.dictionaryNameGridColumn.Name = "dictionaryNameGridColumn";
            this.dictionaryNameGridColumn.Visible = true;
            this.dictionaryNameGridColumn.VisibleIndex = 0;
            this.dictionaryNameGridColumn.Width = 864;
            // 
            // editDictionary
            // 
            this.editDictionary.ColumnEdit = this.editItem;
            this.editDictionary.Name = "editDictionary";
            this.editDictionary.Visible = true;
            this.editDictionary.VisibleIndex = 1;
            this.editDictionary.Width = 52;
            // 
            // editItem
            // 
            this.editItem.AutoHeight = false;
            this.editItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("editItem.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.editItem.Name = "editItem";
            this.editItem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.editItem.Click += new System.EventHandler(this.editItem_Click);
            // 
            // dictonaryLayoutGroup
            // 
            this.dictonaryLayoutGroup.CustomizationFormText = "dictonaryLayoutGroup";
            this.dictonaryLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.dictonaryLayoutGroup.GroupBordersVisible = false;
            this.dictonaryLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.dictionaryGridLayout});
            this.dictonaryLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.dictonaryLayoutGroup.Name = "dictonaryLayoutGroup";
            this.dictonaryLayoutGroup.Size = new System.Drawing.Size(1241, 463);
            this.dictonaryLayoutGroup.Text = "dictonaryLayoutGroup";
            this.dictonaryLayoutGroup.TextVisible = false;
            // 
            // dictionaryGridLayout
            // 
            this.dictionaryGridLayout.Control = this.dictionaries;
            this.dictionaryGridLayout.CustomizationFormText = "dictionaryGridLayout";
            this.dictionaryGridLayout.Location = new System.Drawing.Point(0, 0);
            this.dictionaryGridLayout.Name = "dictionaryGridLayout";
            this.dictionaryGridLayout.Size = new System.Drawing.Size(1221, 443);
            this.dictionaryGridLayout.Text = "dictionaryGridLayout";
            this.dictionaryGridLayout.TextSize = new System.Drawing.Size(0, 0);
            this.dictionaryGridLayout.TextToControlDistance = 0;
            this.dictionaryGridLayout.TextVisible = false;
            // 
            // weldersPage
            // 
            this.weldersPage.Controls.Add(this.layoutControl1);
            this.weldersPage.Name = "weldersPage";
            this.weldersPage.Size = new System.Drawing.Size(1241, 463);
            this.weldersPage.Text = "Сварщики";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControlWelders);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1014, 176, 250, 350);
            this.layoutControl1.OptionsView.UseDefaultDragAndDropRendering = false;
            this.layoutControl1.Root = this.layoutControlGroupWerlders;
            this.layoutControl1.Size = new System.Drawing.Size(1241, 463);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControlWelders
            // 
            this.gridControlWelders.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlWelders.Location = new System.Drawing.Point(12, 12);
            this.gridControlWelders.MainView = this.gridViewWelders;
            this.gridControlWelders.Name = "gridControlWelders";
            this.gridControlWelders.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.welderLNRepositoryTextEdit,
            this.welderFNRepositoryTextEdit,
            this.welderMNRepositoryTextEdit,
            this.welderCertificateTextEdit,
            this.stampRepositoryTextEdit});
            this.gridControlWelders.Size = new System.Drawing.Size(1217, 439);
            this.gridControlWelders.TabIndex = 0;
            this.gridControlWelders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewWelders});
            // 
            // gridViewWelders
            // 
            this.gridViewWelders.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWelderFirstName,
            this.colWelderLastName,
            this.colWelderMiddleName,
            this.colWelderCert,
            this.colWelderCertExp,
            this.colWelderStamp,
            this.colWelderGrade,
            this.colWelderActive});
            this.gridViewWelders.GridControl = this.gridControlWelders;
            this.gridViewWelders.Name = "gridViewWelders";
            this.gridViewWelders.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewWelders.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewWelders.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewWelders.OptionsView.ShowGroupPanel = false;
            this.gridViewWelders.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.HandleInvalidRowException);
            this.gridViewWelders.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewWelders_ValidateRow);
            this.gridViewWelders.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewWelders_KeyDown);
            // 
            // colWelderFirstName
            // 
            this.colWelderFirstName.Caption = "Имя";
            this.colWelderFirstName.ColumnEdit = this.welderFNRepositoryTextEdit;
            this.colWelderFirstName.FieldName = "FirstName";
            this.colWelderFirstName.Name = "colWelderFirstName";
            this.colWelderFirstName.Visible = true;
            this.colWelderFirstName.VisibleIndex = 0;
            this.colWelderFirstName.Width = 149;
            // 
            // welderFNRepositoryTextEdit
            // 
            this.welderFNRepositoryTextEdit.AutoHeight = false;
            this.welderFNRepositoryTextEdit.Name = "welderFNRepositoryTextEdit";
            // 
            // colWelderLastName
            // 
            this.colWelderLastName.Caption = "Фамилия";
            this.colWelderLastName.ColumnEdit = this.welderLNRepositoryTextEdit;
            this.colWelderLastName.FieldName = "LastName";
            this.colWelderLastName.Name = "colWelderLastName";
            this.colWelderLastName.Visible = true;
            this.colWelderLastName.VisibleIndex = 1;
            this.colWelderLastName.Width = 149;
            // 
            // welderLNRepositoryTextEdit
            // 
            this.welderLNRepositoryTextEdit.AutoHeight = false;
            this.welderLNRepositoryTextEdit.Name = "welderLNRepositoryTextEdit";
            // 
            // colWelderMiddleName
            // 
            this.colWelderMiddleName.Caption = "Отчество";
            this.colWelderMiddleName.ColumnEdit = this.welderMNRepositoryTextEdit;
            this.colWelderMiddleName.FieldName = "MiddleName";
            this.colWelderMiddleName.Name = "colWelderMiddleName";
            this.colWelderMiddleName.Visible = true;
            this.colWelderMiddleName.VisibleIndex = 2;
            this.colWelderMiddleName.Width = 149;
            // 
            // welderMNRepositoryTextEdit
            // 
            this.welderMNRepositoryTextEdit.AutoHeight = false;
            this.welderMNRepositoryTextEdit.Name = "welderMNRepositoryTextEdit";
            // 
            // colWelderCert
            // 
            this.colWelderCert.Caption = "Сертификат";
            this.colWelderCert.ColumnEdit = this.welderCertificateTextEdit;
            this.colWelderCert.FieldName = "Certificate";
            this.colWelderCert.Name = "colWelderCert";
            this.colWelderCert.Visible = true;
            this.colWelderCert.VisibleIndex = 3;
            this.colWelderCert.Width = 204;
            // 
            // welderCertificateTextEdit
            // 
            this.welderCertificateTextEdit.AutoHeight = false;
            this.welderCertificateTextEdit.Name = "welderCertificateTextEdit";
            // 
            // colWelderCertExp
            // 
            this.colWelderCertExp.Caption = "Дата аттестации";
            this.colWelderCertExp.FieldName = "CertificateExpiration";
            this.colWelderCertExp.Name = "colWelderCertExp";
            this.colWelderCertExp.Visible = true;
            this.colWelderCertExp.VisibleIndex = 4;
            // 
            // colWelderStamp
            // 
            this.colWelderStamp.Caption = "Клеймо";
            this.colWelderStamp.ColumnEdit = this.stampRepositoryTextEdit;
            this.colWelderStamp.FieldName = "Stamp";
            this.colWelderStamp.Name = "colWelderStamp";
            this.colWelderStamp.Visible = true;
            this.colWelderStamp.VisibleIndex = 5;
            this.colWelderStamp.Width = 213;
            // 
            // stampRepositoryTextEdit
            // 
            this.stampRepositoryTextEdit.AutoHeight = false;
            this.stampRepositoryTextEdit.Name = "stampRepositoryTextEdit";
            // 
            // colWelderGrade
            // 
            this.colWelderGrade.Caption = "Разряд";
            this.colWelderGrade.FieldName = "Grade";
            this.colWelderGrade.Name = "colWelderGrade";
            this.colWelderGrade.Visible = true;
            this.colWelderGrade.VisibleIndex = 6;
            // 
            // colWelderActive
            // 
            this.colWelderActive.Caption = "Активен";
            this.colWelderActive.FieldName = "Active";
            this.colWelderActive.Name = "colWelderActive";
            this.colWelderActive.Visible = true;
            this.colWelderActive.VisibleIndex = 7;
            // 
            // layoutControlGroupWerlders
            // 
            this.layoutControlGroupWerlders.CustomizationFormText = "layoutControlGroupWerlders";
            this.layoutControlGroupWerlders.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupWerlders.GroupBordersVisible = false;
            this.layoutControlGroupWerlders.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemWelders});
            this.layoutControlGroupWerlders.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupWerlders.Name = "layoutControlGroupWerlders";
            this.layoutControlGroupWerlders.Size = new System.Drawing.Size(1241, 463);
            this.layoutControlGroupWerlders.Text = "layoutControlGroupWerlders";
            this.layoutControlGroupWerlders.TextVisible = false;
            // 
            // layoutControlItemWelders
            // 
            this.layoutControlItemWelders.Control = this.gridControlWelders;
            this.layoutControlItemWelders.CustomizationFormText = "layoutControlItemWelders";
            this.layoutControlItemWelders.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemWelders.Name = "layoutControlItemWelders";
            this.layoutControlItemWelders.Size = new System.Drawing.Size(1221, 443);
            this.layoutControlItemWelders.Text = "layoutControlItemWelders";
            this.layoutControlItemWelders.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemWelders.TextToControlDistance = 0;
            this.layoutControlItemWelders.TextVisible = false;
            // 
            // inspectorsPage
            // 
            this.inspectorsPage.Controls.Add(this.layoutControlInspectors);
            this.inspectorsPage.Name = "inspectorsPage";
            this.inspectorsPage.Size = new System.Drawing.Size(1241, 463);
            this.inspectorsPage.Text = "Инспекторы";
            // 
            // layoutControlInspectors
            // 
            this.layoutControlInspectors.Controls.Add(this.gridControlInspectors);
            this.layoutControlInspectors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlInspectors.Location = new System.Drawing.Point(0, 0);
            this.layoutControlInspectors.Name = "layoutControlInspectors";
            this.layoutControlInspectors.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1014, 176, 250, 350);
            this.layoutControlInspectors.OptionsView.UseDefaultDragAndDropRendering = false;
            this.layoutControlInspectors.Root = this.layoutControlGroup1;
            this.layoutControlInspectors.Size = new System.Drawing.Size(1241, 463);
            this.layoutControlInspectors.TabIndex = 1;
            this.layoutControlInspectors.Text = "layoutControl2";
            // 
            // gridControlInspectors
            // 
            this.gridControlInspectors.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlInspectors.Location = new System.Drawing.Point(12, 12);
            this.gridControlInspectors.MainView = this.gridViewInspectors;
            this.gridControlInspectors.Name = "gridControlInspectors";
            this.gridControlInspectors.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.inspectorLNRepositoryTextEdit,
            this.inspectorFNRepositoryTextEdit,
            this.inspectorMNRepositoryTextEdit,
            this.inspectorCertificateTextEdit});
            this.gridControlInspectors.Size = new System.Drawing.Size(1217, 439);
            this.gridControlInspectors.TabIndex = 0;
            this.gridControlInspectors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewInspectors});
            this.gridControlInspectors.Click += new System.EventHandler(this.gridControlInspectors_Click);
            // 
            // gridViewInspectors
            // 
            this.gridViewInspectors.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInspectorFirstName,
            this.colInspectorLastName,
            this.colInspectorMiddleName,
            this.colInspectorCertificate,
            this.colInspectorCertExp,
            this.colInspectorActive});
            this.gridViewInspectors.GridControl = this.gridControlInspectors;
            this.gridViewInspectors.Name = "gridViewInspectors";
            this.gridViewInspectors.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewInspectors.OptionsView.ShowGroupPanel = false;
            this.gridViewInspectors.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.HandleInvalidRowException);
            this.gridViewInspectors.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewInspectors_ValidateRow);
            this.gridViewInspectors.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewInspectors_KeyDown);
            // 
            // colInspectorFirstName
            // 
            this.colInspectorFirstName.Caption = "Имя";
            this.colInspectorFirstName.ColumnEdit = this.inspectorFNRepositoryTextEdit;
            this.colInspectorFirstName.FieldName = "FirstName";
            this.colInspectorFirstName.Name = "colInspectorFirstName";
            this.colInspectorFirstName.Visible = true;
            this.colInspectorFirstName.VisibleIndex = 0;
            this.colInspectorFirstName.Width = 199;
            // 
            // inspectorFNRepositoryTextEdit
            // 
            this.inspectorFNRepositoryTextEdit.AutoHeight = false;
            this.inspectorFNRepositoryTextEdit.Name = "inspectorFNRepositoryTextEdit";
            // 
            // colInspectorLastName
            // 
            this.colInspectorLastName.Caption = "Фамилия";
            this.colInspectorLastName.ColumnEdit = this.inspectorLNRepositoryTextEdit;
            this.colInspectorLastName.FieldName = "LastName";
            this.colInspectorLastName.Name = "colInspectorLastName";
            this.colInspectorLastName.Visible = true;
            this.colInspectorLastName.VisibleIndex = 1;
            this.colInspectorLastName.Width = 199;
            // 
            // inspectorLNRepositoryTextEdit
            // 
            this.inspectorLNRepositoryTextEdit.AutoHeight = false;
            this.inspectorLNRepositoryTextEdit.Name = "inspectorLNRepositoryTextEdit";
            // 
            // colInspectorMiddleName
            // 
            this.colInspectorMiddleName.Caption = "Отчество";
            this.colInspectorMiddleName.ColumnEdit = this.inspectorMNRepositoryTextEdit;
            this.colInspectorMiddleName.FieldName = "MiddleName";
            this.colInspectorMiddleName.Name = "colInspectorMiddleName";
            this.colInspectorMiddleName.Visible = true;
            this.colInspectorMiddleName.VisibleIndex = 2;
            this.colInspectorMiddleName.Width = 199;
            // 
            // inspectorMNRepositoryTextEdit
            // 
            this.inspectorMNRepositoryTextEdit.AutoHeight = false;
            this.inspectorMNRepositoryTextEdit.Name = "inspectorMNRepositoryTextEdit";
            // 
            // colInspectorCertificate
            // 
            this.colInspectorCertificate.Caption = "Сертификат";
            this.colInspectorCertificate.ColumnEdit = this.inspectorCertificateTextEdit;
            this.colInspectorCertificate.FieldName = "Certificate";
            this.colInspectorCertificate.Name = "colInspectorCertificate";
            this.colInspectorCertificate.Visible = true;
            this.colInspectorCertificate.VisibleIndex = 3;
            this.colInspectorCertificate.Width = 332;
            // 
            // inspectorCertificateTextEdit
            // 
            this.inspectorCertificateTextEdit.AutoHeight = false;
            this.inspectorCertificateTextEdit.Name = "inspectorCertificateTextEdit";
            // 
            // colInspectorCertExp
            // 
            this.colInspectorCertExp.Caption = "Дата аттестации";
            this.colInspectorCertExp.FieldName = "CertificateExpiration";
            this.colInspectorCertExp.Name = "colInspectorCertExp";
            this.colInspectorCertExp.Visible = true;
            this.colInspectorCertExp.VisibleIndex = 4;
            // 
            // colInspectorActive
            // 
            this.colInspectorActive.Caption = "Активен";
            this.colInspectorActive.FieldName = "Active";
            this.colInspectorActive.Name = "colInspectorActive";
            this.colInspectorActive.Visible = true;
            this.colInspectorActive.VisibleIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemInspectors});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1241, 463);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItemInspectors
            // 
            this.layoutControlItemInspectors.Control = this.gridControlInspectors;
            this.layoutControlItemInspectors.CustomizationFormText = "layoutControlItemInspectors";
            this.layoutControlItemInspectors.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemInspectors.Name = "layoutControlItemInspectors";
            this.layoutControlItemInspectors.Size = new System.Drawing.Size(1221, 443);
            this.layoutControlItemInspectors.Text = "layoutControlItemInspectors";
            this.layoutControlItemInspectors.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemInspectors.TextToControlDistance = 0;
            this.layoutControlItemInspectors.TextVisible = false;
            // 
            // settingsTabPanel
            // 
            this.settingsTabPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.settingsTabPanel.Controls.Add(this.generalSettingsLayout);
            this.settingsTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsTabPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsTabPanel.Name = "settingsTabPanel";
            this.settingsTabPanel.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.settingsTabPanel.Size = new System.Drawing.Size(1275, 550);
            this.settingsTabPanel.TabIndex = 1;
            // 
            // generalSettingsLayout
            // 
            this.generalSettingsLayout.Controls.Add(this.closeButton);
            this.generalSettingsLayout.Controls.Add(this.saveButton);
            this.generalSettingsLayout.Controls.Add(this.settings);
            this.generalSettingsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalSettingsLayout.Location = new System.Drawing.Point(0, 15);
            this.generalSettingsLayout.Name = "generalSettingsLayout";
            this.generalSettingsLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(340, 221, 250, 350);
            this.generalSettingsLayout.Root = this.generalSettingsLayoutGroup;
            this.generalSettingsLayout.Size = new System.Drawing.Size(1275, 535);
            this.generalSettingsLayout.TabIndex = 1;
            this.generalSettingsLayout.Text = "layoutControl1";
            // 
            // closeButton
            // 
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(1140, 504);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(116, 22);
            this.closeButton.StyleController = this.generalSettingsLayout;
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "За&крыть";
            // 
            // saveButton
            // 
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(995, 504);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(131, 22);
            this.saveButton.StyleController = this.generalSettingsLayout;
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Со&хранить";
            // 
            // generalSettingsLayoutGroup
            // 
            this.generalSettingsLayoutGroup.CustomizationFormText = "generalSettingsLayoutGroup";
            this.generalSettingsLayoutGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.generalSettingsLayoutGroup.GroupBordersVisible = false;
            this.generalSettingsLayoutGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.settingsLayout,
            this.closeButtonLayout,
            this.buttonEmptySpaceItem,
            this.saveButtonLayout});
            this.generalSettingsLayoutGroup.Location = new System.Drawing.Point(0, 0);
            this.generalSettingsLayoutGroup.Name = "generalSettingsLayoutGroup";
            this.generalSettingsLayoutGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.generalSettingsLayoutGroup.Size = new System.Drawing.Size(1275, 535);
            this.generalSettingsLayoutGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 0, 5);
            this.generalSettingsLayoutGroup.Text = "generalSettingsLayoutGroup";
            this.generalSettingsLayoutGroup.TextVisible = false;
            // 
            // settingsLayout
            // 
            this.settingsLayout.Control = this.settings;
            this.settingsLayout.CustomizationFormText = "settingsLayout";
            this.settingsLayout.Location = new System.Drawing.Point(0, 0);
            this.settingsLayout.Name = "settingsLayout";
            this.settingsLayout.Size = new System.Drawing.Size(1251, 495);
            this.settingsLayout.Text = "settingsLayout";
            this.settingsLayout.TextSize = new System.Drawing.Size(0, 0);
            this.settingsLayout.TextToControlDistance = 0;
            this.settingsLayout.TextVisible = false;
            // 
            // closeButtonLayout
            // 
            this.closeButtonLayout.Control = this.closeButton;
            this.closeButtonLayout.CustomizationFormText = "closeButtonLayout";
            this.closeButtonLayout.Location = new System.Drawing.Point(1121, 495);
            this.closeButtonLayout.Name = "closeButtonLayout";
            this.closeButtonLayout.Size = new System.Drawing.Size(130, 31);
            this.closeButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 0);
            this.closeButtonLayout.Text = "closeButtonLayout";
            this.closeButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.closeButtonLayout.TextToControlDistance = 0;
            this.closeButtonLayout.TextVisible = false;
            // 
            // buttonEmptySpaceItem
            // 
            this.buttonEmptySpaceItem.AllowHotTrack = false;
            this.buttonEmptySpaceItem.CustomizationFormText = "buttonEmptySpaceItem";
            this.buttonEmptySpaceItem.Location = new System.Drawing.Point(0, 495);
            this.buttonEmptySpaceItem.Name = "buttonEmptySpaceItem";
            this.buttonEmptySpaceItem.Size = new System.Drawing.Size(976, 31);
            this.buttonEmptySpaceItem.Text = "buttonEmptySpaceItem";
            this.buttonEmptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // saveButtonLayout
            // 
            this.saveButtonLayout.Control = this.saveButton;
            this.saveButtonLayout.CustomizationFormText = "saveButtonLayout";
            this.saveButtonLayout.Location = new System.Drawing.Point(976, 495);
            this.saveButtonLayout.Name = "saveButtonLayout";
            this.saveButtonLayout.Size = new System.Drawing.Size(145, 31);
            this.saveButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 0);
            this.saveButtonLayout.Text = "saveButtonLayout";
            this.saveButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.saveButtonLayout.TextToControlDistance = 0;
            this.saveButtonLayout.TextVisible = false;
            // 
            // SettingsXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 550);
            this.Controls.Add(this.settingsTabPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsXtraForm";
            this.Text = "Настройки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsXtraForm_FormClosed);
            this.Load += new System.EventHandler(this.SettingsXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pipesSizeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipesSizeListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).EndInit();
            this.settings.ResumeLayout(false);
            this.pipePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.generalPipeLayout)).EndInit();
            this.generalPipeLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inspectionOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlNameRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectRepositoryItemEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlTypeItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultTypeItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isRequired)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeParametersLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionOperationLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipesSizeListLayout)).EndInit();
            this.projectPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.generalProjectLayout)).EndInit();
            this.generalProjectLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.design.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalDocumentSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalProjectParametersLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTitleLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTitleEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicalProjectParametersLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalDocumentSizeLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalDocumentSizeEmptySpace)).EndInit();
            this.usersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersLayoutControl)).EndInit();
            this.usersLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersRootGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersAddButtonLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editUserLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightUsersButtonEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divideButtonUsersEmptySpace)).EndInit();
            this.rolesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersButtonLayoutControl)).EndInit();
            this.usersButtonLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesRootGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleButtonRightEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleAddButtonLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleEditLayoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleButtonDivideEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleLayoutControl)).EndInit();
            this.dictionariesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryLayout)).EndInit();
            this.dictionaryLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dictionaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictonaryLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryGridLayout)).EndInit();
            this.weldersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWelders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWelders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.welderFNRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.welderLNRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.welderMNRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.welderCertificateTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stampRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupWerlders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemWelders)).EndInit();
            this.inspectorsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlInspectors)).EndInit();
            this.layoutControlInspectors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInspectors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInspectors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorFNRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorLNRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorMNRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorCertificateTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemInspectors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsTabPanel)).EndInit();
            this.settingsTabPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.generalSettingsLayout)).EndInit();
            this.generalSettingsLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.generalSettingsLayoutGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEmptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeMillSizeTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabPage pipePage;
        private DevExpress.XtraTab.XtraTabPage pipelinePage;
        private DevExpress.XtraTab.XtraTabPage usersPage;
        private DevExpress.XtraTab.XtraTabPage dictionariesPage;
        private DevExpress.XtraGrid.GridControl dictionaries;
        private DevExpress.XtraGrid.Views.Grid.GridView dictionaryView;
        private DevExpress.XtraGrid.Columns.GridColumn dictionaryNameGridColumn;
        public DevExpress.XtraTab.XtraTabControl settings;
        private DevExpress.XtraTab.XtraTabPage projectPage;
        private DevExpress.XtraGrid.GridControl plateManufacturersList;
        private DevExpress.XtraGrid.Views.Grid.GridView plateManufacturersListView;
        private DevExpress.XtraGrid.Columns.GridColumn plateManufacturerGridColumn;
        private DevExpress.XtraEditors.TextEdit design;
        private DevExpress.XtraEditors.TextEdit client;
        private DevExpress.XtraEditors.TextEdit externalDocumentSize;
        private DevExpress.XtraTab.XtraTabPage rolesPage;
        private DevExpress.XtraEditors.SimpleButton roleEditButton;
        private DevExpress.XtraEditors.SimpleButton roleAddButton;
        private DevExpress.XtraGrid.Columns.GridColumn editDictionary;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit editItem;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DevExpress.XtraGrid.GridControl roles;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView rolesGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraLayout.LayoutControl usersLayoutControl;
        private DevExpress.XtraEditors.SimpleButton userEditButton;
        private DevExpress.XtraEditors.SimpleButton userAddButton;
        private DevExpress.XtraGrid.GridControl users;
        private DevExpress.XtraGrid.Views.Grid.GridView usersGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colMiddleName;
        private DevExpress.XtraGrid.Columns.GridColumn colLogin;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colRole;
        private DevExpress.XtraLayout.LayoutControlGroup usersRootGroup;
        private DevExpress.XtraLayout.LayoutControlItem usersAddButtonLayoutControl;
        private DevExpress.XtraLayout.LayoutControlItem editUserLayoutControl;
        private DevExpress.XtraLayout.LayoutControlItem usersLabel;
        private DevExpress.XtraLayout.EmptySpaceItem rightUsersButtonEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem divideButtonUsersEmptySpace;
        private DevExpress.XtraLayout.LayoutControl usersButtonLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup rolesRootGroup;
        private DevExpress.XtraLayout.LayoutControlItem roleEditLayoutControl;
        private DevExpress.XtraLayout.LayoutControlItem roleLayoutControl;
        private DevExpress.XtraLayout.LayoutControlItem roleAddButtonLayoutControl;
        private DevExpress.XtraLayout.EmptySpaceItem roleButtonRightEmptySpace;
        private DevExpress.XtraLayout.EmptySpaceItem roleButtonDivideEmptySpace;
        private DevExpress.XtraEditors.PanelControl settingsTabPanel;
        private DevExpress.XtraGrid.GridControl inspectionOperation;
        private DevExpress.XtraGrid.Views.Grid.GridView inspectionView;
        private DevExpress.XtraGrid.Columns.GridColumn inspectionCodeGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn inspectionNameGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn testSubjectGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn controlTypeGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn resultTypeGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn minExpectedGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn maxExpectedGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn boolExpectedGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn isRequiredGridColumn;
        private DevExpress.XtraLayout.LayoutControl generalProjectLayout;
        private DevExpress.XtraLayout.LayoutControlGroup projectLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem plateManufacturersLayout;
        private DevExpress.XtraLayout.LayoutControlItem externalDocumentSizeLayout;
        private DevExpress.XtraLayout.LayoutControlItem clientLayout;
        private DevExpress.XtraLayout.LayoutControlItem designLayout;
        private DevExpress.XtraLayout.LayoutControlGroup technicalProjectParametersLayoutGroup;
        private DevExpress.XtraLayout.EmptySpaceItem externalDocumentSizeEmptySpace;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit isRequired;
        private DevExpress.XtraLayout.LayoutControlGroup generalProjectParametersLayoutGroup;
        private DevExpress.XtraLayout.EmptySpaceItem clientEmptySpace;
        private DevExpress.XtraLayout.LayoutControl generalPipeLayout;
        private DevExpress.XtraLayout.LayoutControlGroup pipeParametersLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem inspectionOperationLayout;
        private System.Windows.Forms.BindingSource inspectionBindingSource;
        private DevExpress.XtraGrid.GridControl pipesSizeList;
        private DevExpress.XtraGrid.Views.Grid.GridView pipesSizeListGridView;
        private DevExpress.XtraGrid.Columns.GridColumn pipeSizeGridColumn;
        private DevExpress.XtraLayout.LayoutControlItem pipesSizeListLayout;
        private DevExpress.XtraLayout.LayoutControl generalSettingsLayout;
        private DevExpress.XtraEditors.SimpleButton closeButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraLayout.LayoutControlGroup generalSettingsLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem settingsLayout;
        private DevExpress.XtraLayout.LayoutControlItem closeButtonLayout;
        private DevExpress.XtraLayout.LayoutControlItem saveButtonLayout;
        private DevExpress.XtraLayout.EmptySpaceItem buttonEmptySpaceItem;
        private DevExpress.XtraGrid.Columns.GridColumn isActiveGridColumn;
        private System.Windows.Forms.BindingSource pipeMillSizeTypeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn testIsActiveGridColumn;
        private DevExpress.XtraTab.XtraTabPage weldersPage;
        private DevExpress.XtraGrid.GridControl gridControlWelders;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewWelders;
        private DevExpress.XtraGrid.Columns.GridColumn colWelderFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colWelderLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colWelderMiddleName;
        private DevExpress.XtraGrid.Columns.GridColumn colWelderCert;
        private DevExpress.XtraGrid.Columns.GridColumn colWelderCertExp;
        private DevExpress.XtraGrid.Columns.GridColumn colWelderStamp;
        private DevExpress.XtraGrid.Columns.GridColumn colWelderGrade;
        private DevExpress.XtraGrid.Columns.GridColumn colWelderActive;
        private DevExpress.XtraTab.XtraTabPage inspectorsPage;
        private DevExpress.XtraGrid.GridControl gridControlInspectors;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInspectors;
        private DevExpress.XtraGrid.Columns.GridColumn colInspectorFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colInspectorLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colInspectorMiddleName;
        private DevExpress.XtraGrid.Columns.GridColumn colInspectorCertificate;
        private DevExpress.XtraGrid.Columns.GridColumn colInspectorCertExp;
        private DevExpress.XtraGrid.Columns.GridColumn colInspectorActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit controlTypeItems;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit resultTypeItems;
        private DevExpress.XtraLayout.LayoutControl dictionaryLayout;
        private DevExpress.XtraLayout.LayoutControlGroup dictonaryLayoutGroup;
        private DevExpress.XtraLayout.LayoutControlItem dictionaryGridLayout;
        private DevExpress.XtraLayout.EmptySpaceItem roleEmptySpace;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupWerlders;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemWelders;
        private DevExpress.XtraLayout.LayoutControl layoutControlInspectors;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemInspectors;
        private DevExpress.XtraEditors.TextEdit projectTitle;
        private DevExpress.XtraLayout.LayoutControlItem projectTitleLayout;
        private DevExpress.XtraLayout.EmptySpaceItem projectTitleEmptySpace;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit manufacturerRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit typeRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit codeRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit controlNameRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit subjectRepositoryItemEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit welderFNRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit welderLNRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit welderMNRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit welderCertificateTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit stampRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit inspectorFNRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit inspectorLNRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit inspectorMNRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit inspectorCertificateTextEdit;
    }
}