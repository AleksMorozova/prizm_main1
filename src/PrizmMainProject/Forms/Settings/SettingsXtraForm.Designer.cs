using Prizm.Main.Properties;
namespace Prizm.Main.Forms.Settings
{
    partial class SettingsXtraForm
    {
        /// <summary>
        /// Required  variable.
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsXtraForm));
            this.pipesSizeList = new DevExpress.XtraGrid.GridControl();
            this.pipesSizeListGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pipeSizeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.typeRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.isActiveGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlPermission = new DevExpress.XtraGrid.GridControl();
            this.permissionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewPermissions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPermissionDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewRole = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRoleSetupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.roleNameRepositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.roleDescriptionRepositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridControlRoles = new DevExpress.XtraGrid.GridControl();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewRoles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRoleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoleDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlUsers = new DevExpress.XtraGrid.GridControl();
            this.gridViewUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userLoginRepositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lastNameRepositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userFirstNameRepositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colMiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userMiddleNameRepositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colPasswordExpires = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserPass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonUserPass = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.certificateTypes = new DevExpress.XtraGrid.GridControl();
            this.certificateTypesView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.certificateNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.certificateTypeRepositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.certificateIsActiveColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryCertificateIsActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridControlInspectorsCertificates = new DevExpress.XtraGrid.GridControl();
            this.inspectorCertificateGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.inspectorCertificateNumberCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectorSertificateNumberRepositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.certificateTypeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryLookUpCertificateType = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryLookUpCertificateTypeView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.inspectorCertificateTypeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectorCertificateExpirationCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlInspectors = new DevExpress.XtraGrid.GridControl();
            this.gridViewInspectors = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colInspectorLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectorLNRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colInspectorFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectorFNRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colInspectorMiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectorMNRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colInspectorGrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInspectorActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInspectorCertExp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInspectorCertificate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectorCertificateTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridControlWelders = new DevExpress.XtraGrid.GridControl();
            this.gridViewWelders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWelderLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.welderLNRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colWelderFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.welderFNRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colWelderMiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.welderMNRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colWelderCert = new DevExpress.XtraGrid.Columns.GridColumn();
            this.welderCertificateTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colWelderCertExp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWelderStamp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stampRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colWelderGrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWelderActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.componentryTypeGridControl = new DevExpress.XtraGrid.GridControl();
            this.componentryTypeGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.typeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.componentTypeNameRepositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.connectorsNumbersColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryConnectorsNumbers = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.isActiveComponentColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryComponentryTypeCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.jointOperations = new DevExpress.XtraGrid.GridControl();
            this.jointsOperationsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pipelineOperationNameRepositoryItem = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.isRequiredForJointGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TestTypeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.jointOperationTypeLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.testHasAcceptedGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.testHasToRepairGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.testHasToWithdrawGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.testResultRequiredGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isActiveJointOperationGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.externalDocumentSize = new DevExpress.XtraEditors.TextEdit();
            this.rootLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.editTestButton = new DevExpress.XtraEditors.SimpleButton();
            this.addTestButton = new DevExpress.XtraEditors.SimpleButton();
            this.closeButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.seamTypes = new DevExpress.XtraGrid.GridControl();
            this.seemTypeGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.seemTypeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.seamTypeRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.seemTypeIsActiveColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cloneTypeSizeButton = new DevExpress.XtraEditors.SimpleButton();
            this.categoriesGrid = new DevExpress.XtraGrid.GridControl();
            this.categoriesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.categoryNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.categoryRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.isActiveColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryIsActiveCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.pipeNumberMaskRulesLabel = new DevExpress.XtraEditors.LabelControl();
            this.pipeLength = new DevExpress.XtraEditors.TextEdit();
            this.pipeNumberMask = new DevExpress.XtraEditors.TextEdit();
            this.millName = new DevExpress.XtraEditors.TextEdit();
            this.projectTitle = new DevExpress.XtraEditors.TextEdit();
            this.inspectionOperation = new DevExpress.XtraGrid.GridControl();
            this.inspectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inspectionView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.inspectionCodeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectionNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.categoryColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemsСategory = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemsСategoryView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.plateManufacturersList = new DevExpress.XtraGrid.GridControl();
            this.plateManufacturersListView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.plateManufacturerGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.manufacturerRepositoryTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.client = new DevExpress.XtraEditors.TextEdit();
            this.wallThickness = new DevExpress.XtraEditors.TextEdit();
            this.pipeDiameter = new DevExpress.XtraEditors.TextEdit();
            this.seamType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.RootGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tabbedControlGroup = new DevExpress.XtraLayout.TabbedControlGroup();
            this.pipeLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.sizesLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.inspectionsLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.sizeParamsLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.diameterLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.wallThicknessLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.pipeLengthLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.seamTypeLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.cloneButtonLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.pipeSplitterItem = new DevExpress.XtraLayout.SplitterItem();
            this.addTestButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.testButtonsEmptySpace = new DevExpress.XtraLayout.EmptySpaceItem();
            this.editTestButtonLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.projectLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.commonParamsLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.projectTitleLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.clientLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.plateManLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.techParamsLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.extDocumentSizeLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.millLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.millNameLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.maskLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.operationsLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.maskLabelLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.seamsLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.lineLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.jointOperationLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.partsLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.partsTypeLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.partsSplitterItem = new DevExpress.XtraLayout.SplitterItem();
            this.weldersLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.weldersLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.inspectorsLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.inspectorLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.certificateLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.inspectorsLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.certificateTypeLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.certTypeListLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.inspectorSplitterItem = new DevExpress.XtraLayout.SplitterItem();
            this.usersLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.userLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.roleLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.userSplitterItem = new DevExpress.XtraLayout.SplitterItem();
            this.rolesLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.rolesTabLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.permissionLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.roleSplitterItem = new DevExpress.XtraLayout.SplitterItem();
            this.saveButtonLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.closeButtonLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonEmptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.editDictionary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.editItem = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pipeMillSizeTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inspectorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inspectorCertificateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jointOperationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.CurrentPipeMillSizeTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pipesSizeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipesSizeListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPermissions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleNameRepositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleDescriptionRepositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginRepositoryItemTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameRepositoryItemTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userFirstNameRepositoryItemTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userMiddleNameRepositoryItemTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonUserPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateTypesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateTypeRepositoryItemTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryCertificateIsActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInspectorsCertificates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorCertificateGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorSertificateNumberRepositoryItemTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryLookUpCertificateType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryLookUpCertificateTypeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInspectors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInspectors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorLNRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorFNRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorMNRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorCertificateTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWelders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWelders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.welderLNRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.welderFNRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.welderMNRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.welderCertificateTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stampRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentryTypeGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentryTypeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentTypeNameRepositoryItemTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryConnectorsNumbers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryComponentryTypeCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointOperations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointsOperationsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipelineOperationNameRepositoryItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointOperationTypeLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalDocumentSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootLayoutControl)).BeginInit();
            this.rootLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seamTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seemTypeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seamTypeRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryIsActiveCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumberMask.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.millName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlTypeItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultTypeItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isRequired)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemsСategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemsСategoryView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerRepositoryTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallThickness.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDiameter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seamType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RootGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizesLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeParamsLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diameterLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallThicknessLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeLengthLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seamTypeLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloneButtonLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSplitterItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addTestButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testButtonsEmptySpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTestButtonLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commonParamsLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTitleLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techParamsLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extDocumentSizeLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.millLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.millNameLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskLabelLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seamsLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointOperationLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsTypeLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsSplitterItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldersLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldersLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateTypeLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certTypeListLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorSplitterItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSplitterItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesTabLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleSplitterItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEmptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeMillSizeTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorCertificateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointOperationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPipeMillSizeTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pipesSizeList
            // 
            this.pipesSizeList.Cursor = System.Windows.Forms.Cursors.Default;
            this.pipesSizeList.Location = new System.Drawing.Point(29, 67);
            this.pipesSizeList.MainView = this.pipesSizeListGridView;
            this.pipesSizeList.Name = "pipesSizeList";
            this.pipesSizeList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.typeRepositoryTextEdit});
            this.pipesSizeList.Size = new System.Drawing.Size(418, 402);
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
            this.pipesSizeListGridView.OptionsBehavior.FocusLeaveOnTab = true;
            this.pipesSizeListGridView.OptionsNavigation.UseTabKey = false;
            this.pipesSizeListGridView.OptionsView.ShowGroupPanel = false;
            this.pipesSizeListGridView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.pipesSizeListGridView_RowCellStyle);
            this.pipesSizeListGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.pipesSizeListGridView_InitNewRow);
            this.pipesSizeListGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.pipesSizeListGridView_FocusedRowChanged);
            this.pipesSizeListGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pipesSizeListGridView_KeyDown);
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
            // gridControlPermission
            // 
            this.gridControlPermission.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlPermission.DataSource = this.permissionsBindingSource;
            this.gridControlPermission.Location = new System.Drawing.Point(934, 67);
            this.gridControlPermission.MainView = this.gridViewPermissions;
            this.gridControlPermission.Name = "gridControlPermission";
            this.gridControlPermission.Size = new System.Drawing.Size(312, 428);
            this.gridControlPermission.TabIndex = 5;
            this.gridControlPermission.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPermissions});
            // 
            // gridViewPermissions
            // 
            this.gridViewPermissions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPermissionDesc});
            this.gridViewPermissions.GridControl = this.gridControlPermission;
            this.gridViewPermissions.Name = "gridViewPermissions";
            this.gridViewPermissions.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewPermissions.OptionsBehavior.FocusLeaveOnTab = true;
            this.gridViewPermissions.OptionsNavigation.UseTabKey = false;
            this.gridViewPermissions.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewPermissions.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridViewPermissions.OptionsSelection.MultiSelect = true;
            this.gridViewPermissions.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewPermissions.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewPermissions.OptionsView.ShowColumnHeaders = false;
            this.gridViewPermissions.OptionsView.ShowGroupPanel = false;
            this.gridViewPermissions.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewPermissions_SelectionChanged);
            // 
            // colPermissionDesc
            // 
            this.colPermissionDesc.Caption = "Описание";
            this.colPermissionDesc.FieldName = "NameTranslation";
            this.colPermissionDesc.Name = "colPermissionDesc";
            this.colPermissionDesc.OptionsColumn.ReadOnly = true;
            this.colPermissionDesc.Visible = true;
            this.colPermissionDesc.VisibleIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.rolesBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(29, 67);
            this.gridControl1.MainView = this.gridViewRole;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.roleNameRepositoryItemTextEdit1,
            this.roleDescriptionRepositoryItemTextEdit1});
            this.gridControl1.Size = new System.Drawing.Size(886, 428);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRole});
            // 
            // gridViewRole
            // 
            this.gridViewRole.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRoleSetupName,
            this.colDesc});
            this.gridViewRole.GridControl = this.gridControl1;
            this.gridViewRole.Name = "gridViewRole";
            this.gridViewRole.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewRole.OptionsBehavior.FocusLeaveOnTab = true;
            this.gridViewRole.OptionsNavigation.UseTabKey = false;
            this.gridViewRole.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewRole.OptionsView.ShowGroupPanel = false;
            this.gridViewRole.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewRole_FocusedRowChanged);
            this.gridViewRole.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.CellModifiedGridView_CellValueChanged);
            this.gridViewRole.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridViewRole_InvalidRowException);
            this.gridViewRole.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewRole_ValidateRow);
            // 
            // colRoleSetupName
            // 
            this.colRoleSetupName.Caption = "Название";
            this.colRoleSetupName.ColumnEdit = this.roleNameRepositoryItemTextEdit1;
            this.colRoleSetupName.FieldName = "Name";
            this.colRoleSetupName.Name = "colRoleSetupName";
            this.colRoleSetupName.Visible = true;
            this.colRoleSetupName.VisibleIndex = 0;
            // 
            // roleNameRepositoryItemTextEdit1
            // 
            this.roleNameRepositoryItemTextEdit1.AutoHeight = false;
            this.roleNameRepositoryItemTextEdit1.Name = "roleNameRepositoryItemTextEdit1";
            // 
            // colDesc
            // 
            this.colDesc.Caption = "Описание";
            this.colDesc.ColumnEdit = this.roleDescriptionRepositoryItemTextEdit1;
            this.colDesc.FieldName = "Description";
            this.colDesc.Name = "colDesc";
            this.colDesc.Visible = true;
            this.colDesc.VisibleIndex = 1;
            // 
            // roleDescriptionRepositoryItemTextEdit1
            // 
            this.roleDescriptionRepositoryItemTextEdit1.AutoHeight = false;
            this.roleDescriptionRepositoryItemTextEdit1.Name = "roleDescriptionRepositoryItemTextEdit1";
            // 
            // gridControlRoles
            // 
            this.gridControlRoles.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlRoles.DataSource = this.usersBindingSource;
            this.gridControlRoles.Location = new System.Drawing.Point(934, 67);
            this.gridControlRoles.MainView = this.gridViewRoles;
            this.gridControlRoles.Name = "gridControlRoles";
            this.gridControlRoles.Size = new System.Drawing.Size(312, 428);
            this.gridControlRoles.TabIndex = 5;
            this.gridControlRoles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRoles});
            // 
            // gridViewRoles
            // 
            this.gridViewRoles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRoleName,
            this.colRoleDesc});
            this.gridViewRoles.GridControl = this.gridControlRoles;
            this.gridViewRoles.Name = "gridViewRoles";
            this.gridViewRoles.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewRoles.OptionsBehavior.FocusLeaveOnTab = true;
            this.gridViewRoles.OptionsNavigation.UseTabKey = false;
            this.gridViewRoles.OptionsSelection.MultiSelect = true;
            this.gridViewRoles.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewRoles.OptionsView.ShowColumnHeaders = false;
            this.gridViewRoles.OptionsView.ShowGroupPanel = false;
            this.gridViewRoles.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewRoles_SelectionChanged);
            // 
            // colRoleName
            // 
            this.colRoleName.Caption = "Название";
            this.colRoleName.FieldName = "Name";
            this.colRoleName.Name = "colRoleName";
            this.colRoleName.OptionsColumn.ReadOnly = true;
            this.colRoleName.Visible = true;
            this.colRoleName.VisibleIndex = 1;
            // 
            // colRoleDesc
            // 
            this.colRoleDesc.Caption = "Описание";
            this.colRoleDesc.FieldName = "Description";
            this.colRoleDesc.Name = "colRoleDesc";
            this.colRoleDesc.OptionsColumn.ReadOnly = true;
            this.colRoleDesc.Visible = true;
            this.colRoleDesc.VisibleIndex = 2;
            // 
            // gridControlUsers
            // 
            this.gridControlUsers.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlUsers.DataSource = this.usersBindingSource;
            this.gridControlUsers.Location = new System.Drawing.Point(29, 67);
            this.gridControlUsers.MainView = this.gridViewUsers;
            this.gridControlUsers.Name = "gridControlUsers";
            this.gridControlUsers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonUserPass,
            this.userLoginRepositoryItemTextEdit,
            this.lastNameRepositoryItemTextEdit,
            this.userFirstNameRepositoryItemTextEdit,
            this.userMiddleNameRepositoryItemTextEdit});
            this.gridControlUsers.Size = new System.Drawing.Size(886, 428);
            this.gridControlUsers.TabIndex = 4;
            this.gridControlUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUsers});
            // 
            // gridViewUsers
            // 
            this.gridViewUsers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLogin,
            this.colLastName,
            this.colFirstName,
            this.colMiddleName,
            this.colPasswordExpires,
            this.colActive,
            this.colUserPass});
            this.gridViewUsers.GridControl = this.gridControlUsers;
            this.gridViewUsers.Name = "gridViewUsers";
            this.gridViewUsers.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewUsers.OptionsBehavior.FocusLeaveOnTab = true;
            this.gridViewUsers.OptionsNavigation.UseTabKey = false;
            this.gridViewUsers.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewUsers.OptionsView.ShowGroupPanel = false;
            this.gridViewUsers.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridViewUsers_ShowingEditor);
            this.gridViewUsers.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridViewUsers_InitNewRow);
            this.gridViewUsers.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewUsers_FocusedRowChanged);
            this.gridViewUsers.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.CellModifiedGridView_CellValueChanged);
            this.gridViewUsers.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridViewUsers_InvalidRowException);
            this.gridViewUsers.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewUsers_ValidateRow);
            this.gridViewUsers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewUsers_KeyDown);
            // 
            // colLogin
            // 
            this.colLogin.Caption = "Логин";
            this.colLogin.ColumnEdit = this.userLoginRepositoryItemTextEdit;
            this.colLogin.FieldName = "Login";
            this.colLogin.Name = "colLogin";
            this.colLogin.Visible = true;
            this.colLogin.VisibleIndex = 0;
            this.colLogin.Width = 145;
            // 
            // userLoginRepositoryItemTextEdit
            // 
            this.userLoginRepositoryItemTextEdit.AutoHeight = false;
            this.userLoginRepositoryItemTextEdit.Name = "userLoginRepositoryItemTextEdit";
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Фамилия";
            this.colLastName.ColumnEdit = this.lastNameRepositoryItemTextEdit;
            this.colLastName.FieldName = "Name.LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 1;
            this.colLastName.Width = 145;
            // 
            // lastNameRepositoryItemTextEdit
            // 
            this.lastNameRepositoryItemTextEdit.AutoHeight = false;
            this.lastNameRepositoryItemTextEdit.Name = "lastNameRepositoryItemTextEdit";
            // 
            // colFirstName
            // 
            this.colFirstName.Caption = "Имя";
            this.colFirstName.ColumnEdit = this.userFirstNameRepositoryItemTextEdit;
            this.colFirstName.FieldName = "Name.FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 2;
            this.colFirstName.Width = 145;
            // 
            // userFirstNameRepositoryItemTextEdit
            // 
            this.userFirstNameRepositoryItemTextEdit.AutoHeight = false;
            this.userFirstNameRepositoryItemTextEdit.Name = "userFirstNameRepositoryItemTextEdit";
            // 
            // colMiddleName
            // 
            this.colMiddleName.Caption = "Отчество";
            this.colMiddleName.ColumnEdit = this.userMiddleNameRepositoryItemTextEdit;
            this.colMiddleName.FieldName = "Name.MiddleName";
            this.colMiddleName.Name = "colMiddleName";
            this.colMiddleName.Visible = true;
            this.colMiddleName.VisibleIndex = 3;
            this.colMiddleName.Width = 145;
            // 
            // userMiddleNameRepositoryItemTextEdit
            // 
            this.userMiddleNameRepositoryItemTextEdit.AutoHeight = false;
            this.userMiddleNameRepositoryItemTextEdit.Name = "userMiddleNameRepositoryItemTextEdit";
            // 
            // colPasswordExpires
            // 
            this.colPasswordExpires.Caption = "Пароль истекает";
            this.colPasswordExpires.FieldName = "PasswordExpires";
            this.colPasswordExpires.Name = "colPasswordExpires";
            this.colPasswordExpires.Visible = true;
            this.colPasswordExpires.VisibleIndex = 4;
            this.colPasswordExpires.Width = 145;
            // 
            // colActive
            // 
            this.colActive.Caption = "Активен";
            this.colActive.FieldName = "IsActive";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 5;
            this.colActive.Width = 145;
            // 
            // colUserPass
            // 
            this.colUserPass.Caption = "Пароль";
            this.colUserPass.ColumnEdit = this.repositoryItemButtonUserPass;
            this.colUserPass.Name = "colUserPass";
            this.colUserPass.Visible = true;
            this.colUserPass.VisibleIndex = 6;
            this.colUserPass.Width = 60;
            // 
            // repositoryItemButtonUserPass
            // 
            this.repositoryItemButtonUserPass.AutoHeight = false;
            this.repositoryItemButtonUserPass.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::Prizm.Main.Properties.Resources.password, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonUserPass.Name = "repositoryItemButtonUserPass";
            this.repositoryItemButtonUserPass.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonUserPass.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonUserPass_ButtonClick);
            // 
            // certificateTypes
            // 
            this.certificateTypes.Cursor = System.Windows.Forms.Cursors.Default;
            this.certificateTypes.Location = new System.Drawing.Point(919, 101);
            this.certificateTypes.MainView = this.certificateTypesView;
            this.certificateTypes.Name = "certificateTypes";
            this.certificateTypes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryCertificateIsActive,
            this.certificateTypeRepositoryItemTextEdit});
            this.certificateTypes.Size = new System.Drawing.Size(312, 379);
            this.certificateTypes.TabIndex = 5;
            this.certificateTypes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.certificateTypesView});
            // 
            // certificateTypesView
            // 
            this.certificateTypesView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.certificateNameColumn,
            this.certificateIsActiveColumn});
            this.certificateTypesView.GridControl = this.certificateTypes;
            this.certificateTypesView.Name = "certificateTypesView";
            this.certificateTypesView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.certificateTypesView.OptionsBehavior.FocusLeaveOnTab = true;
            this.certificateTypesView.OptionsNavigation.UseTabKey = false;
            this.certificateTypesView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.certificateTypesView.OptionsView.ShowGroupPanel = false;
            this.certificateTypesView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.certificateTypesView_InitNewRow);
            this.certificateTypesView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.CellModifiedGridView_CellValueChanged);
            this.certificateTypesView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.certificateTypesView_KeyDown);
            // 
            // certificateNameColumn
            // 
            this.certificateNameColumn.Caption = "Название";
            this.certificateNameColumn.ColumnEdit = this.certificateTypeRepositoryItemTextEdit;
            this.certificateNameColumn.FieldName = "Name";
            this.certificateNameColumn.Name = "certificateNameColumn";
            this.certificateNameColumn.Visible = true;
            this.certificateNameColumn.VisibleIndex = 0;
            this.certificateNameColumn.Width = 243;
            // 
            // certificateTypeRepositoryItemTextEdit
            // 
            this.certificateTypeRepositoryItemTextEdit.AutoHeight = false;
            this.certificateTypeRepositoryItemTextEdit.Name = "certificateTypeRepositoryItemTextEdit";
            // 
            // certificateIsActiveColumn
            // 
            this.certificateIsActiveColumn.Caption = "Активен";
            this.certificateIsActiveColumn.ColumnEdit = this.repositoryCertificateIsActive;
            this.certificateIsActiveColumn.FieldName = "IsActive";
            this.certificateIsActiveColumn.Name = "certificateIsActiveColumn";
            this.certificateIsActiveColumn.Visible = true;
            this.certificateIsActiveColumn.VisibleIndex = 1;
            this.certificateIsActiveColumn.Width = 51;
            // 
            // repositoryCertificateIsActive
            // 
            this.repositoryCertificateIsActive.AutoHeight = false;
            this.repositoryCertificateIsActive.Name = "repositoryCertificateIsActive";
            // 
            // gridControlInspectorsCertificates
            // 
            this.gridControlInspectorsCertificates.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlInspectorsCertificates.Location = new System.Drawing.Point(428, 101);
            this.gridControlInspectorsCertificates.MainView = this.inspectorCertificateGridView;
            this.gridControlInspectorsCertificates.Name = "gridControlInspectorsCertificates";
            this.gridControlInspectorsCertificates.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryLookUpCertificateType,
            this.inspectorSertificateNumberRepositoryItemTextEdit});
            this.gridControlInspectorsCertificates.Size = new System.Drawing.Size(442, 379);
            this.gridControlInspectorsCertificates.TabIndex = 4;
            this.gridControlInspectorsCertificates.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.inspectorCertificateGridView});
            // 
            // inspectorCertificateGridView
            // 
            this.inspectorCertificateGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.inspectorCertificateNumberCol,
            this.certificateTypeColumn,
            this.inspectorCertificateExpirationCol});
            this.inspectorCertificateGridView.GridControl = this.gridControlInspectorsCertificates;
            this.inspectorCertificateGridView.Name = "inspectorCertificateGridView";
            this.inspectorCertificateGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.inspectorCertificateGridView.OptionsBehavior.FocusLeaveOnTab = true;
            this.inspectorCertificateGridView.OptionsCustomization.AllowGroup = false;
            this.inspectorCertificateGridView.OptionsNavigation.UseTabKey = false;
            this.inspectorCertificateGridView.OptionsView.ShowGroupPanel = false;
            this.inspectorCertificateGridView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.inspectorCertificateGridView_RowCellStyle);
            this.inspectorCertificateGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.inspectorCertificateGridView_InitNewRow);
            this.inspectorCertificateGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.CellModifiedGridView_CellValueChanged);
            this.inspectorCertificateGridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.inspectorCertificateGridView_ValidateRow);
            this.inspectorCertificateGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inspectorCertificateGridView_KeyDown);
            // 
            // inspectorCertificateNumberCol
            // 
            this.inspectorCertificateNumberCol.Caption = "Номер";
            this.inspectorCertificateNumberCol.ColumnEdit = this.inspectorSertificateNumberRepositoryItemTextEdit;
            this.inspectorCertificateNumberCol.FieldName = "Certificate.Number";
            this.inspectorCertificateNumberCol.Name = "inspectorCertificateNumberCol";
            this.inspectorCertificateNumberCol.Visible = true;
            this.inspectorCertificateNumberCol.VisibleIndex = 0;
            this.inspectorCertificateNumberCol.Width = 50;
            // 
            // inspectorSertificateNumberRepositoryItemTextEdit
            // 
            this.inspectorSertificateNumberRepositoryItemTextEdit.AutoHeight = false;
            this.inspectorSertificateNumberRepositoryItemTextEdit.Name = "inspectorSertificateNumberRepositoryItemTextEdit";
            // 
            // certificateTypeColumn
            // 
            this.certificateTypeColumn.Caption = "Вид контроля";
            this.certificateTypeColumn.ColumnEdit = this.repositoryLookUpCertificateType;
            this.certificateTypeColumn.FieldName = "Type";
            this.certificateTypeColumn.Name = "certificateTypeColumn";
            this.certificateTypeColumn.Visible = true;
            this.certificateTypeColumn.VisibleIndex = 1;
            // 
            // repositoryLookUpCertificateType
            // 
            this.repositoryLookUpCertificateType.AutoHeight = false;
            this.repositoryLookUpCertificateType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryLookUpCertificateType.Name = "repositoryLookUpCertificateType";
            this.repositoryLookUpCertificateType.NullText = "";
            this.repositoryLookUpCertificateType.View = this.repositoryLookUpCertificateTypeView;
            // 
            // repositoryLookUpCertificateTypeView
            // 
            this.repositoryLookUpCertificateTypeView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.inspectorCertificateTypeColumn});
            this.repositoryLookUpCertificateTypeView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryLookUpCertificateTypeView.Name = "repositoryLookUpCertificateTypeView";
            this.repositoryLookUpCertificateTypeView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryLookUpCertificateTypeView.OptionsView.ShowGroupPanel = false;
            this.repositoryLookUpCertificateTypeView.CustomRowFilter += new DevExpress.XtraGrid.Views.Base.RowFilterEventHandler(this.repositoryLookUpCertificateTypeView_CustomRowFilter);
            // 
            // inspectorCertificateTypeColumn
            // 
            this.inspectorCertificateTypeColumn.FieldName = "Name";
            this.inspectorCertificateTypeColumn.Name = "inspectorCertificateTypeColumn";
            this.inspectorCertificateTypeColumn.OptionsColumn.ShowCaption = false;
            this.inspectorCertificateTypeColumn.Visible = true;
            this.inspectorCertificateTypeColumn.VisibleIndex = 0;
            // 
            // inspectorCertificateExpirationCol
            // 
            this.inspectorCertificateExpirationCol.Caption = "Действителен до";
            this.inspectorCertificateExpirationCol.FieldName = "Certificate.ExpirationDate";
            this.inspectorCertificateExpirationCol.MaxWidth = 120;
            this.inspectorCertificateExpirationCol.Name = "inspectorCertificateExpirationCol";
            this.inspectorCertificateExpirationCol.Visible = true;
            this.inspectorCertificateExpirationCol.VisibleIndex = 2;
            this.inspectorCertificateExpirationCol.Width = 90;
            // 
            // gridControlInspectors
            // 
            this.gridControlInspectors.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlInspectors.Location = new System.Drawing.Point(44, 101);
            this.gridControlInspectors.MainView = this.gridViewInspectors;
            this.gridControlInspectors.Name = "gridControlInspectors";
            this.gridControlInspectors.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.inspectorLNRepositoryTextEdit,
            this.inspectorFNRepositoryTextEdit,
            this.inspectorMNRepositoryTextEdit,
            this.inspectorCertificateTextEdit});
            this.gridControlInspectors.Size = new System.Drawing.Size(370, 379);
            this.gridControlInspectors.TabIndex = 0;
            this.gridControlInspectors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewInspectors});
            this.gridControlInspectors.Click += new System.EventHandler(this.gridControlInspectors_Click);
            // 
            // gridViewInspectors
            // 
            this.gridViewInspectors.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInspectorLastName,
            this.colInspectorFirstName,
            this.colInspectorMiddleName,
            this.colInspectorGrade,
            this.colInspectorActive,
            this.colInspectorCertExp,
            this.colInspectorCertificate});
            this.gridViewInspectors.GridControl = this.gridControlInspectors;
            this.gridViewInspectors.Name = "gridViewInspectors";
            this.gridViewInspectors.OptionsBehavior.FocusLeaveOnTab = true;
            this.gridViewInspectors.OptionsNavigation.UseTabKey = false;
            this.gridViewInspectors.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewInspectors.OptionsView.ShowGroupPanel = false;
            this.gridViewInspectors.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewInspectors_RowCellStyle);
            this.gridViewInspectors.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewInspectors_FocusedRowChanged);
            this.gridViewInspectors.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.HandleInvalidRowException);
            this.gridViewInspectors.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewInspectors_ValidateRow);
            this.gridViewInspectors.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewInspectors_KeyDown);
            // 
            // colInspectorLastName
            // 
            this.colInspectorLastName.Caption = "Фамилия";
            this.colInspectorLastName.ColumnEdit = this.inspectorLNRepositoryTextEdit;
            this.colInspectorLastName.FieldName = "LastName";
            this.colInspectorLastName.Name = "colInspectorLastName";
            this.colInspectorLastName.Visible = true;
            this.colInspectorLastName.VisibleIndex = 0;
            this.colInspectorLastName.Width = 162;
            // 
            // inspectorLNRepositoryTextEdit
            // 
            this.inspectorLNRepositoryTextEdit.AutoHeight = false;
            this.inspectorLNRepositoryTextEdit.Name = "inspectorLNRepositoryTextEdit";
            // 
            // colInspectorFirstName
            // 
            this.colInspectorFirstName.Caption = "Имя";
            this.colInspectorFirstName.ColumnEdit = this.inspectorFNRepositoryTextEdit;
            this.colInspectorFirstName.FieldName = "FirstName";
            this.colInspectorFirstName.Name = "colInspectorFirstName";
            this.colInspectorFirstName.Visible = true;
            this.colInspectorFirstName.VisibleIndex = 1;
            this.colInspectorFirstName.Width = 136;
            // 
            // inspectorFNRepositoryTextEdit
            // 
            this.inspectorFNRepositoryTextEdit.AutoHeight = false;
            this.inspectorFNRepositoryTextEdit.Name = "inspectorFNRepositoryTextEdit";
            // 
            // colInspectorMiddleName
            // 
            this.colInspectorMiddleName.Caption = "Отчество";
            this.colInspectorMiddleName.ColumnEdit = this.inspectorMNRepositoryTextEdit;
            this.colInspectorMiddleName.FieldName = "MiddleName";
            this.colInspectorMiddleName.Name = "colInspectorMiddleName";
            this.colInspectorMiddleName.Visible = true;
            this.colInspectorMiddleName.VisibleIndex = 2;
            this.colInspectorMiddleName.Width = 169;
            // 
            // inspectorMNRepositoryTextEdit
            // 
            this.inspectorMNRepositoryTextEdit.AutoHeight = false;
            this.inspectorMNRepositoryTextEdit.Name = "inspectorMNRepositoryTextEdit";
            // 
            // colInspectorGrade
            // 
            this.colInspectorGrade.Caption = "Уровень";
            this.colInspectorGrade.FieldName = "Grade";
            this.colInspectorGrade.Name = "colInspectorGrade";
            this.colInspectorGrade.Visible = true;
            this.colInspectorGrade.VisibleIndex = 3;
            // 
            // colInspectorActive
            // 
            this.colInspectorActive.Caption = "Активен";
            this.colInspectorActive.FieldName = "Active";
            this.colInspectorActive.MaxWidth = 115;
            this.colInspectorActive.Name = "colInspectorActive";
            this.colInspectorActive.Visible = true;
            this.colInspectorActive.VisibleIndex = 4;
            this.colInspectorActive.Width = 55;
            // 
            // colInspectorCertExp
            // 
            this.colInspectorCertExp.Caption = "Дата аттестации";
            this.colInspectorCertExp.FieldName = "CertificateExpiration";
            this.colInspectorCertExp.Name = "colInspectorCertExp";
            this.colInspectorCertExp.Width = 100;
            // 
            // colInspectorCertificate
            // 
            this.colInspectorCertificate.Caption = "Сертификат";
            this.colInspectorCertificate.ColumnEdit = this.inspectorCertificateTextEdit;
            this.colInspectorCertificate.FieldName = "Certificate";
            this.colInspectorCertificate.Name = "colInspectorCertificate";
            this.colInspectorCertificate.Width = 200;
            // 
            // inspectorCertificateTextEdit
            // 
            this.inspectorCertificateTextEdit.AutoHeight = false;
            this.inspectorCertificateTextEdit.Name = "inspectorCertificateTextEdit";
            // 
            // gridControlWelders
            // 
            this.gridControlWelders.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlWelders.Location = new System.Drawing.Point(24, 46);
            this.gridControlWelders.MainView = this.gridViewWelders;
            this.gridControlWelders.Name = "gridControlWelders";
            this.gridControlWelders.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.welderLNRepositoryTextEdit,
            this.welderFNRepositoryTextEdit,
            this.welderMNRepositoryTextEdit,
            this.welderCertificateTextEdit,
            this.stampRepositoryTextEdit});
            this.gridControlWelders.Size = new System.Drawing.Size(1227, 454);
            this.gridControlWelders.TabIndex = 0;
            this.gridControlWelders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewWelders});
            // 
            // gridViewWelders
            // 
            this.gridViewWelders.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWelderLastName,
            this.colWelderFirstName,
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
            this.gridViewWelders.OptionsBehavior.FocusLeaveOnTab = true;
            this.gridViewWelders.OptionsNavigation.UseTabKey = false;
            this.gridViewWelders.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewWelders.OptionsView.ShowGroupPanel = false;
            this.gridViewWelders.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewWelders_RowCellStyle);
            this.gridViewWelders.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.CellModifiedGridView_CellValueChanged);
            this.gridViewWelders.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.HandleInvalidRowException);
            this.gridViewWelders.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewWelders_ValidateRow);
            this.gridViewWelders.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewWelders_KeyDown);
            // 
            // colWelderLastName
            // 
            this.colWelderLastName.Caption = "Фамилия";
            this.colWelderLastName.ColumnEdit = this.welderLNRepositoryTextEdit;
            this.colWelderLastName.FieldName = "LastName";
            this.colWelderLastName.Name = "colWelderLastName";
            this.colWelderLastName.Visible = true;
            this.colWelderLastName.VisibleIndex = 0;
            this.colWelderLastName.Width = 164;
            // 
            // welderLNRepositoryTextEdit
            // 
            this.welderLNRepositoryTextEdit.AutoHeight = false;
            this.welderLNRepositoryTextEdit.Name = "welderLNRepositoryTextEdit";
            // 
            // colWelderFirstName
            // 
            this.colWelderFirstName.Caption = "Имя";
            this.colWelderFirstName.ColumnEdit = this.welderFNRepositoryTextEdit;
            this.colWelderFirstName.FieldName = "FirstName";
            this.colWelderFirstName.Name = "colWelderFirstName";
            this.colWelderFirstName.Visible = true;
            this.colWelderFirstName.VisibleIndex = 1;
            this.colWelderFirstName.Width = 164;
            // 
            // welderFNRepositoryTextEdit
            // 
            this.welderFNRepositoryTextEdit.AutoHeight = false;
            this.welderFNRepositoryTextEdit.Name = "welderFNRepositoryTextEdit";
            // 
            // colWelderMiddleName
            // 
            this.colWelderMiddleName.Caption = "Отчество";
            this.colWelderMiddleName.ColumnEdit = this.welderMNRepositoryTextEdit;
            this.colWelderMiddleName.FieldName = "MiddleName";
            this.colWelderMiddleName.Name = "colWelderMiddleName";
            this.colWelderMiddleName.Visible = true;
            this.colWelderMiddleName.VisibleIndex = 2;
            this.colWelderMiddleName.Width = 164;
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
            this.colWelderCert.FieldName = "Certificate.Number";
            this.colWelderCert.Name = "colWelderCert";
            this.colWelderCert.Visible = true;
            this.colWelderCert.VisibleIndex = 3;
            this.colWelderCert.Width = 224;
            // 
            // welderCertificateTextEdit
            // 
            this.welderCertificateTextEdit.AutoHeight = false;
            this.welderCertificateTextEdit.Name = "welderCertificateTextEdit";
            // 
            // colWelderCertExp
            // 
            this.colWelderCertExp.Caption = "Действительно до";
            this.colWelderCertExp.FieldName = "CertificateExpiration";
            this.colWelderCertExp.Name = "colWelderCertExp";
            this.colWelderCertExp.Visible = true;
            this.colWelderCertExp.VisibleIndex = 4;
            this.colWelderCertExp.Width = 82;
            // 
            // colWelderStamp
            // 
            this.colWelderStamp.Caption = "Клеймо";
            this.colWelderStamp.ColumnEdit = this.stampRepositoryTextEdit;
            this.colWelderStamp.FieldName = "Stamp";
            this.colWelderStamp.Name = "colWelderStamp";
            this.colWelderStamp.Visible = true;
            this.colWelderStamp.VisibleIndex = 5;
            this.colWelderStamp.Width = 234;
            // 
            // stampRepositoryTextEdit
            // 
            this.stampRepositoryTextEdit.AutoHeight = false;
            this.stampRepositoryTextEdit.Name = "stampRepositoryTextEdit";
            // 
            // colWelderGrade
            // 
            this.colWelderGrade.Caption = "Уровень";
            this.colWelderGrade.FieldName = "Grade";
            this.colWelderGrade.Name = "colWelderGrade";
            this.colWelderGrade.Visible = true;
            this.colWelderGrade.VisibleIndex = 6;
            this.colWelderGrade.Width = 105;
            // 
            // colWelderActive
            // 
            this.colWelderActive.Caption = "Активен";
            this.colWelderActive.FieldName = "Active";
            this.colWelderActive.Name = "colWelderActive";
            this.colWelderActive.Visible = true;
            this.colWelderActive.VisibleIndex = 7;
            this.colWelderActive.Width = 62;
            // 
            // componentryTypeGridControl
            // 
            this.componentryTypeGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.componentryTypeGridControl.Location = new System.Drawing.Point(24, 62);
            this.componentryTypeGridControl.MainView = this.componentryTypeGridView;
            this.componentryTypeGridControl.Name = "componentryTypeGridControl";
            this.componentryTypeGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryComponentryTypeCheck,
            this.repositoryConnectorsNumbers,
            this.componentTypeNameRepositoryItemTextEdit});
            this.componentryTypeGridControl.Size = new System.Drawing.Size(610, 438);
            this.componentryTypeGridControl.TabIndex = 4;
            this.componentryTypeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.componentryTypeGridView});
            // 
            // componentryTypeGridView
            // 
            this.componentryTypeGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.typeColumn,
            this.connectorsNumbersColumn,
            this.isActiveComponentColumn});
            this.componentryTypeGridView.GridControl = this.componentryTypeGridControl;
            this.componentryTypeGridView.Name = "componentryTypeGridView";
            this.componentryTypeGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.componentryTypeGridView.OptionsBehavior.FocusLeaveOnTab = true;
            this.componentryTypeGridView.OptionsNavigation.UseTabKey = false;
            this.componentryTypeGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.componentryTypeGridView.OptionsView.ShowGroupPanel = false;
            this.componentryTypeGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.componentryTypeGridView_InitNewRow);
            this.componentryTypeGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.CellModifiedGridView_CellValueChanged);
            this.componentryTypeGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.componentryTypeGridView_KeyDown);
            // 
            // typeColumn
            // 
            this.typeColumn.Caption = "Тип комплектующего";
            this.typeColumn.ColumnEdit = this.componentTypeNameRepositoryItemTextEdit;
            this.typeColumn.FieldName = "Name";
            this.typeColumn.Name = "typeColumn";
            this.typeColumn.Visible = true;
            this.typeColumn.VisibleIndex = 0;
            this.typeColumn.Width = 169;
            // 
            // componentTypeNameRepositoryItemTextEdit
            // 
            this.componentTypeNameRepositoryItemTextEdit.AutoHeight = false;
            this.componentTypeNameRepositoryItemTextEdit.Name = "componentTypeNameRepositoryItemTextEdit";
            // 
            // connectorsNumbersColumn
            // 
            this.connectorsNumbersColumn.Caption = "Количество коннекторов";
            this.connectorsNumbersColumn.ColumnEdit = this.repositoryConnectorsNumbers;
            this.connectorsNumbersColumn.FieldName = "ConnectorsCount";
            this.connectorsNumbersColumn.Name = "connectorsNumbersColumn";
            this.connectorsNumbersColumn.Visible = true;
            this.connectorsNumbersColumn.VisibleIndex = 1;
            this.connectorsNumbersColumn.Width = 280;
            // 
            // repositoryConnectorsNumbers
            // 
            this.repositoryConnectorsNumbers.AutoHeight = false;
            this.repositoryConnectorsNumbers.Mask.EditMask = "[1-9]";
            this.repositoryConnectorsNumbers.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.repositoryConnectorsNumbers.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryConnectorsNumbers.Name = "repositoryConnectorsNumbers";
            // 
            // isActiveComponentColumn
            // 
            this.isActiveComponentColumn.Caption = "Активно";
            this.isActiveComponentColumn.ColumnEdit = this.repositoryComponentryTypeCheck;
            this.isActiveComponentColumn.FieldName = "IsActive";
            this.isActiveComponentColumn.Name = "isActiveComponentColumn";
            this.isActiveComponentColumn.Visible = true;
            this.isActiveComponentColumn.VisibleIndex = 2;
            this.isActiveComponentColumn.Width = 59;
            // 
            // repositoryComponentryTypeCheck
            // 
            this.repositoryComponentryTypeCheck.AutoHeight = false;
            this.repositoryComponentryTypeCheck.Name = "repositoryComponentryTypeCheck";
            // 
            // jointOperations
            // 
            this.jointOperations.Cursor = System.Windows.Forms.Cursors.Default;
            this.jointOperations.Location = new System.Drawing.Point(24, 62);
            this.jointOperations.MainView = this.jointsOperationsGridView;
            this.jointOperations.Name = "jointOperations";
            this.jointOperations.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.jointOperationTypeLookUpEdit,
            this.pipelineOperationNameRepositoryItem});
            this.jointOperations.Size = new System.Drawing.Size(1227, 438);
            this.jointOperations.TabIndex = 0;
            this.jointOperations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.jointsOperationsGridView});
            // 
            // jointsOperationsGridView
            // 
            this.jointsOperationsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nameGridColumn,
            this.isRequiredForJointGridColumn,
            this.TestTypeColumn,
            this.testHasAcceptedGridColumn,
            this.testHasToRepairGridColumn,
            this.testHasToWithdrawGridColumn,
            this.testResultRequiredGridColumn,
            this.isActiveJointOperationGridColumn});
            this.jointsOperationsGridView.GridControl = this.jointOperations;
            this.jointsOperationsGridView.Name = "jointsOperationsGridView";
            this.jointsOperationsGridView.OptionsBehavior.FocusLeaveOnTab = true;
            this.jointsOperationsGridView.OptionsNavigation.UseTabKey = false;
            this.jointsOperationsGridView.OptionsView.ShowGroupPanel = false;
            this.jointsOperationsGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.jointsOperationsGridView_InitNewRow);
            this.jointsOperationsGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.CellModifiedGridView_CellValueChanged);
            // 
            // nameGridColumn
            // 
            this.nameGridColumn.Caption = "Название операции";
            this.nameGridColumn.ColumnEdit = this.pipelineOperationNameRepositoryItem;
            this.nameGridColumn.FieldName = "Name";
            this.nameGridColumn.Name = "nameGridColumn";
            this.nameGridColumn.Visible = true;
            this.nameGridColumn.VisibleIndex = 0;
            this.nameGridColumn.Width = 300;
            // 
            // pipelineOperationNameRepositoryItem
            // 
            this.pipelineOperationNameRepositoryItem.AutoHeight = false;
            this.pipelineOperationNameRepositoryItem.Name = "pipelineOperationNameRepositoryItem";
            // 
            // isRequiredForJointGridColumn
            // 
            this.isRequiredForJointGridColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.isRequiredForJointGridColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.isRequiredForJointGridColumn.Caption = "Обязательна";
            this.isRequiredForJointGridColumn.FieldName = "IsRequired";
            this.isRequiredForJointGridColumn.Name = "isRequiredForJointGridColumn";
            this.isRequiredForJointGridColumn.Visible = true;
            this.isRequiredForJointGridColumn.VisibleIndex = 1;
            this.isRequiredForJointGridColumn.Width = 115;
            // 
            // TestTypeColumn
            // 
            this.TestTypeColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.TestTypeColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TestTypeColumn.Caption = "Тип операции";
            this.TestTypeColumn.ColumnEdit = this.jointOperationTypeLookUpEdit;
            this.TestTypeColumn.FieldName = "Type";
            this.TestTypeColumn.Name = "TestTypeColumn";
            this.TestTypeColumn.Visible = true;
            this.TestTypeColumn.VisibleIndex = 2;
            this.TestTypeColumn.Width = 209;
            // 
            // jointOperationTypeLookUpEdit
            // 
            this.jointOperationTypeLookUpEdit.AutoHeight = false;
            this.jointOperationTypeLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.jointOperationTypeLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Text", "Тип операции")});
            this.jointOperationTypeLookUpEdit.DisplayMember = "Text";
            this.jointOperationTypeLookUpEdit.Name = "jointOperationTypeLookUpEdit";
            this.jointOperationTypeLookUpEdit.NullText = "";
            this.jointOperationTypeLookUpEdit.ValueMember = "Value";
            // 
            // testHasAcceptedGridColumn
            // 
            this.testHasAcceptedGridColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.testHasAcceptedGridColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.testHasAcceptedGridColumn.Caption = "Принято";
            this.testHasAcceptedGridColumn.FieldName = "TestHasAccepted";
            this.testHasAcceptedGridColumn.Name = "testHasAcceptedGridColumn";
            this.testHasAcceptedGridColumn.Visible = true;
            this.testHasAcceptedGridColumn.VisibleIndex = 3;
            this.testHasAcceptedGridColumn.Width = 115;
            // 
            // testHasToRepairGridColumn
            // 
            this.testHasToRepairGridColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.testHasToRepairGridColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.testHasToRepairGridColumn.Caption = "Ремонт";
            this.testHasToRepairGridColumn.FieldName = "TestHasToRepair";
            this.testHasToRepairGridColumn.Name = "testHasToRepairGridColumn";
            this.testHasToRepairGridColumn.Visible = true;
            this.testHasToRepairGridColumn.VisibleIndex = 4;
            this.testHasToRepairGridColumn.Width = 115;
            // 
            // testHasToWithdrawGridColumn
            // 
            this.testHasToWithdrawGridColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.testHasToWithdrawGridColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.testHasToWithdrawGridColumn.Caption = "Вырезка";
            this.testHasToWithdrawGridColumn.FieldName = "TestHasToWithdraw";
            this.testHasToWithdrawGridColumn.Name = "testHasToWithdrawGridColumn";
            this.testHasToWithdrawGridColumn.Visible = true;
            this.testHasToWithdrawGridColumn.VisibleIndex = 5;
            this.testHasToWithdrawGridColumn.Width = 115;
            // 
            // testResultRequiredGridColumn
            // 
            this.testResultRequiredGridColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.testResultRequiredGridColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.testResultRequiredGridColumn.Caption = "Обязательный результат";
            this.testResultRequiredGridColumn.FieldName = "TestResultRequired";
            this.testResultRequiredGridColumn.Name = "testResultRequiredGridColumn";
            this.testResultRequiredGridColumn.Visible = true;
            this.testResultRequiredGridColumn.VisibleIndex = 6;
            this.testResultRequiredGridColumn.Width = 115;
            // 
            // isActiveJointOperationGridColumn
            // 
            this.isActiveJointOperationGridColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.isActiveJointOperationGridColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.isActiveJointOperationGridColumn.Caption = "Активна";
            this.isActiveJointOperationGridColumn.FieldName = "IsActive";
            this.isActiveJointOperationGridColumn.Name = "isActiveJointOperationGridColumn";
            this.isActiveJointOperationGridColumn.Visible = true;
            this.isActiveJointOperationGridColumn.VisibleIndex = 7;
            this.isActiveJointOperationGridColumn.Width = 115;
            // 
            // externalDocumentSize
            // 
            this.externalDocumentSize.EditValue = "";
            this.externalDocumentSize.Location = new System.Drawing.Point(59, 445);
            this.externalDocumentSize.Name = "externalDocumentSize";
            this.externalDocumentSize.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.externalDocumentSize.Properties.Mask.EditMask = "d";
            this.externalDocumentSize.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.externalDocumentSize.Properties.Mask.SaveLiteral = false;
            this.externalDocumentSize.Properties.Mask.ShowPlaceHolders = false;
            this.externalDocumentSize.Size = new System.Drawing.Size(368, 20);
            this.externalDocumentSize.StyleController = this.rootLayoutControl;
            this.externalDocumentSize.TabIndex = 4;
            // 
            // rootLayoutControl
            // 
            this.rootLayoutControl.Controls.Add(this.editTestButton);
            this.rootLayoutControl.Controls.Add(this.addTestButton);
            this.rootLayoutControl.Controls.Add(this.closeButton);
            this.rootLayoutControl.Controls.Add(this.gridControlPermission);
            this.rootLayoutControl.Controls.Add(this.saveButton);
            this.rootLayoutControl.Controls.Add(this.gridControlRoles);
            this.rootLayoutControl.Controls.Add(this.gridControl1);
            this.rootLayoutControl.Controls.Add(this.certificateTypes);
            this.rootLayoutControl.Controls.Add(this.gridControlUsers);
            this.rootLayoutControl.Controls.Add(this.gridControlWelders);
            this.rootLayoutControl.Controls.Add(this.gridControlInspectorsCertificates);
            this.rootLayoutControl.Controls.Add(this.componentryTypeGridControl);
            this.rootLayoutControl.Controls.Add(this.gridControlInspectors);
            this.rootLayoutControl.Controls.Add(this.jointOperations);
            this.rootLayoutControl.Controls.Add(this.externalDocumentSize);
            this.rootLayoutControl.Controls.Add(this.seamTypes);
            this.rootLayoutControl.Controls.Add(this.cloneTypeSizeButton);
            this.rootLayoutControl.Controls.Add(this.categoriesGrid);
            this.rootLayoutControl.Controls.Add(this.pipeNumberMaskRulesLabel);
            this.rootLayoutControl.Controls.Add(this.pipeLength);
            this.rootLayoutControl.Controls.Add(this.pipeNumberMask);
            this.rootLayoutControl.Controls.Add(this.pipesSizeList);
            this.rootLayoutControl.Controls.Add(this.millName);
            this.rootLayoutControl.Controls.Add(this.projectTitle);
            this.rootLayoutControl.Controls.Add(this.inspectionOperation);
            this.rootLayoutControl.Controls.Add(this.plateManufacturersList);
            this.rootLayoutControl.Controls.Add(this.client);
            this.rootLayoutControl.Controls.Add(this.wallThickness);
            this.rootLayoutControl.Controls.Add(this.pipeDiameter);
            this.rootLayoutControl.Controls.Add(this.seamType);
            this.rootLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.rootLayoutControl.Name = "rootLayoutControl";
            this.rootLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(337, 159, 542, 721);
            this.rootLayoutControl.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.rootLayoutControl.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.rootLayoutControl.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.rootLayoutControl.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.rootLayoutControl.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.rootLayoutControl.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rootLayoutControl.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.rootLayoutControl.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.rootLayoutControl.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.rootLayoutControl.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.rootLayoutControl.Root = this.RootGroup;
            this.rootLayoutControl.Size = new System.Drawing.Size(1275, 550);
            this.rootLayoutControl.TabIndex = 2;
            this.rootLayoutControl.Text = "layoutControl3";
            // 
            // editTestButton
            // 
            this.editTestButton.Image = ((System.Drawing.Image)(resources.GetObject("editTestButton.Image")));
            this.editTestButton.Location = new System.Drawing.Point(560, 51);
            this.editTestButton.Name = "editTestButton";
            this.editTestButton.Size = new System.Drawing.Size(109, 22);
            this.editTestButton.StyleController = this.rootLayoutControl;
            this.editTestButton.TabIndex = 19;
            this.editTestButton.Text = "Редактировать";
            this.editTestButton.Click += new System.EventHandler(this.editTestButton_Click);
            // 
            // addTestButton
            // 
            this.addTestButton.Image = ((System.Drawing.Image)(resources.GetObject("addTestButton.Image")));
            this.addTestButton.Location = new System.Drawing.Point(466, 51);
            this.addTestButton.Name = "addTestButton";
            this.addTestButton.Size = new System.Drawing.Size(80, 22);
            this.addTestButton.StyleController = this.rootLayoutControl;
            this.addTestButton.TabIndex = 18;
            this.addTestButton.Text = "Добавить";
            this.addTestButton.Click += new System.EventHandler(this.addTestButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(1119, 516);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(144, 22);
            this.closeButton.StyleController = this.rootLayoutControl;
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Закр&ыть";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.Location = new System.Drawing.Point(973, 516);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(142, 22);
            this.saveButton.StyleController = this.rootLayoutControl;
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "&Сохранить";
            // 
            // seamTypes
            // 
            this.seamTypes.Cursor = System.Windows.Forms.Cursors.Default;
            this.seamTypes.Location = new System.Drawing.Point(832, 201);
            this.seamTypes.MainView = this.seemTypeGridView;
            this.seamTypes.Name = "seamTypes";
            this.seamTypes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.seamTypeRepositoryTextEdit});
            this.seamTypes.Size = new System.Drawing.Size(399, 279);
            this.seamTypes.TabIndex = 17;
            this.seamTypes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.seemTypeGridView});
            // 
            // seemTypeGridView
            // 
            this.seemTypeGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.seemTypeColumn,
            this.seemTypeIsActiveColumn});
            this.seemTypeGridView.GridControl = this.seamTypes;
            this.seemTypeGridView.Name = "seemTypeGridView";
            this.seemTypeGridView.OptionsBehavior.FocusLeaveOnTab = true;
            this.seemTypeGridView.OptionsNavigation.UseTabKey = false;
            this.seemTypeGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.seemTypeGridView.OptionsView.ShowGroupPanel = false;
            this.seemTypeGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.seemTypeGridView_InitNewRow);
            this.seemTypeGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.CellModifiedGridView_CellValueChanged);
            this.seemTypeGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.seemTypeGridView_KeyDown);
            // 
            // seemTypeColumn
            // 
            this.seemTypeColumn.Caption = "Тип шва";
            this.seemTypeColumn.ColumnEdit = this.seamTypeRepositoryTextEdit;
            this.seemTypeColumn.FieldName = "Name";
            this.seemTypeColumn.Name = "seemTypeColumn";
            this.seemTypeColumn.Visible = true;
            this.seemTypeColumn.VisibleIndex = 0;
            // 
            // seamTypeRepositoryTextEdit
            // 
            this.seamTypeRepositoryTextEdit.AutoHeight = false;
            this.seamTypeRepositoryTextEdit.Name = "seamTypeRepositoryTextEdit";
            // 
            // seemTypeIsActiveColumn
            // 
            this.seemTypeIsActiveColumn.Caption = "Активен";
            this.seemTypeIsActiveColumn.FieldName = "IsActive";
            this.seemTypeIsActiveColumn.Name = "seemTypeIsActiveColumn";
            this.seemTypeIsActiveColumn.Visible = true;
            this.seemTypeIsActiveColumn.VisibleIndex = 1;
            // 
            // cloneTypeSizeButton
            // 
            this.cloneTypeSizeButton.Image = ((System.Drawing.Image)(resources.GetObject("cloneTypeSizeButton.Image")));
            this.cloneTypeSizeButton.Location = new System.Drawing.Point(52, 478);
            this.cloneTypeSizeButton.Name = "cloneTypeSizeButton";
            this.cloneTypeSizeButton.Size = new System.Drawing.Size(377, 22);
            this.cloneTypeSizeButton.StyleController = this.rootLayoutControl;
            this.cloneTypeSizeButton.TabIndex = 6;
            this.cloneTypeSizeButton.Text = "Копироват&ь типоразмер";
            this.cloneTypeSizeButton.Click += new System.EventHandler(this.cloneTypeSizeButton_Click);
            // 
            // categoriesGrid
            // 
            this.categoriesGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.categoriesGrid.Location = new System.Drawing.Point(486, 201);
            this.categoriesGrid.MainView = this.categoriesGridView;
            this.categoriesGrid.Name = "categoriesGrid";
            this.categoriesGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryIsActiveCheckEdit});
            this.categoriesGrid.Size = new System.Drawing.Size(332, 279);
            this.categoriesGrid.TabIndex = 7;
            this.categoriesGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.categoriesGridView});
            // 
            // categoriesGridView
            // 
            this.categoriesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.categoryNameColumn,
            this.isActiveColumn});
            this.categoriesGridView.GridControl = this.categoriesGrid;
            this.categoriesGridView.Name = "categoriesGridView";
            this.categoriesGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.categoriesGridView.OptionsBehavior.FocusLeaveOnTab = true;
            this.categoriesGridView.OptionsNavigation.UseTabKey = false;
            this.categoriesGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.categoriesGridView.OptionsView.ShowGroupPanel = false;
            this.categoriesGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.categoryGridView_InitNewRow);
            this.categoriesGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.CellModifiedGridView_CellValueChanged);
            this.categoriesGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.categoryGridView_KeyDown);
            // 
            // categoryNameColumn
            // 
            this.categoryNameColumn.Caption = "Название";
            this.categoryNameColumn.ColumnEdit = this.categoryRepositoryTextEdit;
            this.categoryNameColumn.FieldName = "Name";
            this.categoryNameColumn.Name = "categoryNameColumn";
            this.categoryNameColumn.Visible = true;
            this.categoryNameColumn.VisibleIndex = 0;
            this.categoryNameColumn.Width = 411;
            // 
            // categoryRepositoryTextEdit
            // 
            this.categoryRepositoryTextEdit.AutoHeight = false;
            this.categoryRepositoryTextEdit.Name = "categoryRepositoryTextEdit";
            // 
            // isActiveColumn
            // 
            this.isActiveColumn.Caption = "Активна";
            this.isActiveColumn.ColumnEdit = this.repositoryIsActiveCheckEdit;
            this.isActiveColumn.FieldName = "IsActive";
            this.isActiveColumn.Name = "isActiveColumn";
            this.isActiveColumn.Visible = true;
            this.isActiveColumn.VisibleIndex = 1;
            this.isActiveColumn.Width = 189;
            // 
            // repositoryIsActiveCheckEdit
            // 
            this.repositoryIsActiveCheckEdit.AutoHeight = false;
            this.repositoryIsActiveCheckEdit.Name = "repositoryIsActiveCheckEdit";
            // 
            // pipeNumberMaskRulesLabel
            // 
            this.pipeNumberMaskRulesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pipeNumberMaskRulesLabel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.pipeNumberMaskRulesLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.pipeNumberMaskRulesLabel.Location = new System.Drawing.Point(830, 130);
            this.pipeNumberMaskRulesLabel.Name = "pipeNumberMaskRulesLabel";
            this.pipeNumberMaskRulesLabel.Size = new System.Drawing.Size(403, 1);
            this.pipeNumberMaskRulesLabel.StyleController = this.rootLayoutControl;
            this.pipeNumberMaskRulesLabel.TabIndex = 16;
            // 
            // pipeLength
            // 
            this.pipeLength.Location = new System.Drawing.Point(864, 455);
            this.pipeLength.Name = "pipeLength";
            this.pipeLength.Properties.Mask.EditMask = "d";
            this.pipeLength.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.pipeLength.Size = new System.Drawing.Size(164, 20);
            this.pipeLength.StyleController = this.rootLayoutControl;
            this.pipeLength.TabIndex = 15;
            // 
            // pipeNumberMask
            // 
            this.pipeNumberMask.Location = new System.Drawing.Point(486, 151);
            this.pipeNumberMask.Name = "pipeNumberMask";
            this.pipeNumberMask.Size = new System.Drawing.Size(332, 20);
            this.pipeNumberMask.StyleController = this.rootLayoutControl;
            this.pipeNumberMask.TabIndex = 6;
            // 
            // millName
            // 
            this.millName.Location = new System.Drawing.Point(486, 101);
            this.millName.Name = "millName";
            this.millName.Size = new System.Drawing.Size(745, 20);
            this.millName.StyleController = this.rootLayoutControl;
            this.millName.TabIndex = 5;
            // 
            // projectTitle
            // 
            this.projectTitle.EditValue = "";
            this.projectTitle.Location = new System.Drawing.Point(44, 101);
            this.projectTitle.Name = "projectTitle";
            this.projectTitle.Size = new System.Drawing.Size(398, 20);
            this.projectTitle.StyleController = this.rootLayoutControl;
            this.projectTitle.TabIndex = 1;
            // 
            // inspectionOperation
            // 
            this.inspectionOperation.Cursor = System.Windows.Forms.Cursors.Default;
            this.inspectionOperation.DataSource = this.inspectionBindingSource;
            this.inspectionOperation.Location = new System.Drawing.Point(466, 103);
            this.inspectionOperation.MainView = this.inspectionView;
            this.inspectionOperation.Name = "inspectionOperation";
            this.inspectionOperation.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.isRequired,
            this.controlTypeItems,
            this.resultTypeItems,
            this.repositoryItemsСategory});
            this.inspectionOperation.Size = new System.Drawing.Size(780, 288);
            this.inspectionOperation.TabIndex = 9;
            this.inspectionOperation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.inspectionView});
            this.inspectionOperation.DoubleClick += new System.EventHandler(this.inspectionOperation_DoubleClick);
            // 
            // inspectionBindingSource
            // 
            this.inspectionBindingSource.DataSource = typeof(Prizm.Main.DummyData.InspectionDummy);
            // 
            // inspectionView
            // 
            this.inspectionView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.inspectionCodeGridColumn,
            this.inspectionNameGridColumn,
            this.controlTypeGridColumn,
            this.resultTypeGridColumn,
            this.boolExpectedGridColumn,
            this.minExpectedGridColumn,
            this.maxExpectedGridColumn,
            this.isRequiredGridColumn,
            this.testIsActiveGridColumn,
            this.categoryColumn});
            this.inspectionView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.inspectionView.GridControl = this.inspectionOperation;
            this.inspectionView.Name = "inspectionView";
            this.inspectionView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.inspectionView.OptionsBehavior.Editable = false;
            this.inspectionView.OptionsBehavior.FocusLeaveOnTab = true;
            this.inspectionView.OptionsNavigation.UseTabKey = false;
            this.inspectionView.OptionsView.ShowGroupPanel = false;
            this.inspectionView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.inspectionView_InitNewRow);
            this.inspectionView.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.HandleInvalidRowException);
            this.inspectionView.BeforeLeaveRow += new DevExpress.XtraGrid.Views.Base.RowAllowEventHandler(this.inspectionView_BeforeLeaveRow);
            this.inspectionView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.inspectionView_ValidateRow);
            this.inspectionView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inspectionView_KeyDown);
            // 
            // inspectionCodeGridColumn
            // 
            this.inspectionCodeGridColumn.Caption = "Код";
            this.inspectionCodeGridColumn.FieldName = "Code";
            this.inspectionCodeGridColumn.Name = "inspectionCodeGridColumn";
            this.inspectionCodeGridColumn.OptionsColumn.AllowEdit = false;
            this.inspectionCodeGridColumn.Visible = true;
            this.inspectionCodeGridColumn.VisibleIndex = 0;
            this.inspectionCodeGridColumn.Width = 60;
            // 
            // inspectionNameGridColumn
            // 
            this.inspectionNameGridColumn.Caption = "Название операции";
            this.inspectionNameGridColumn.FieldName = "Name";
            this.inspectionNameGridColumn.Name = "inspectionNameGridColumn";
            this.inspectionNameGridColumn.OptionsColumn.AllowEdit = false;
            this.inspectionNameGridColumn.Visible = true;
            this.inspectionNameGridColumn.VisibleIndex = 1;
            this.inspectionNameGridColumn.Width = 240;
            // 
            // controlTypeGridColumn
            // 
            this.controlTypeGridColumn.Caption = "Вид контроля";
            this.controlTypeGridColumn.ColumnEdit = this.controlTypeItems;
            this.controlTypeGridColumn.FieldName = "ControlType";
            this.controlTypeGridColumn.Name = "controlTypeGridColumn";
            this.controlTypeGridColumn.OptionsColumn.AllowEdit = false;
            this.controlTypeGridColumn.Visible = true;
            this.controlTypeGridColumn.VisibleIndex = 3;
            this.controlTypeGridColumn.Width = 120;
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
            this.resultTypeGridColumn.OptionsColumn.AllowEdit = false;
            this.resultTypeGridColumn.Visible = true;
            this.resultTypeGridColumn.VisibleIndex = 4;
            this.resultTypeGridColumn.Width = 120;
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
            this.boolExpectedGridColumn.MaxWidth = 50;
            this.boolExpectedGridColumn.Name = "boolExpectedGridColumn";
            this.boolExpectedGridColumn.OptionsColumn.AllowEdit = false;
            this.boolExpectedGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.boolExpectedGridColumn.Visible = true;
            this.boolExpectedGridColumn.VisibleIndex = 5;
            this.boolExpectedGridColumn.Width = 50;
            // 
            // minExpectedGridColumn
            // 
            this.minExpectedGridColumn.Caption = "min";
            this.minExpectedGridColumn.FieldName = "MinExpected";
            this.minExpectedGridColumn.Name = "minExpectedGridColumn";
            this.minExpectedGridColumn.OptionsColumn.AllowEdit = false;
            this.minExpectedGridColumn.Visible = true;
            this.minExpectedGridColumn.VisibleIndex = 6;
            this.minExpectedGridColumn.Width = 50;
            // 
            // maxExpectedGridColumn
            // 
            this.maxExpectedGridColumn.Caption = "max";
            this.maxExpectedGridColumn.FieldName = "MaxExpected";
            this.maxExpectedGridColumn.Name = "maxExpectedGridColumn";
            this.maxExpectedGridColumn.OptionsColumn.AllowEdit = false;
            this.maxExpectedGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.maxExpectedGridColumn.Visible = true;
            this.maxExpectedGridColumn.VisibleIndex = 7;
            this.maxExpectedGridColumn.Width = 50;
            // 
            // isRequiredGridColumn
            // 
            this.isRequiredGridColumn.Caption = "Обязательное";
            this.isRequiredGridColumn.ColumnEdit = this.isRequired;
            this.isRequiredGridColumn.FieldName = "IsRequired";
            this.isRequiredGridColumn.MaxWidth = 50;
            this.isRequiredGridColumn.Name = "isRequiredGridColumn";
            this.isRequiredGridColumn.OptionsColumn.AllowEdit = false;
            this.isRequiredGridColumn.Visible = true;
            this.isRequiredGridColumn.VisibleIndex = 8;
            this.isRequiredGridColumn.Width = 40;
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
            this.testIsActiveGridColumn.MaxWidth = 50;
            this.testIsActiveGridColumn.Name = "testIsActiveGridColumn";
            this.testIsActiveGridColumn.OptionsColumn.AllowEdit = false;
            this.testIsActiveGridColumn.Visible = true;
            this.testIsActiveGridColumn.VisibleIndex = 9;
            this.testIsActiveGridColumn.Width = 43;
            // 
            // categoryColumn
            // 
            this.categoryColumn.Caption = "Группа";
            this.categoryColumn.ColumnEdit = this.repositoryItemsСategory;
            this.categoryColumn.FieldName = "Category";
            this.categoryColumn.Name = "categoryColumn";
            this.categoryColumn.OptionsColumn.AllowEdit = false;
            this.categoryColumn.Visible = true;
            this.categoryColumn.VisibleIndex = 2;
            this.categoryColumn.Width = 135;
            // 
            // repositoryItemsСategory
            // 
            this.repositoryItemsСategory.AutoHeight = false;
            this.repositoryItemsСategory.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemsСategory.LookAndFeel.SkinName = "VS2010";
            this.repositoryItemsСategory.Name = "repositoryItemsСategory";
            this.repositoryItemsСategory.NullText = "";
            this.repositoryItemsСategory.View = this.repositoryItemsСategoryView;
            // 
            // repositoryItemsСategoryView
            // 
            this.repositoryItemsСategoryView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CategoryName});
            this.repositoryItemsСategoryView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemsСategoryView.Name = "repositoryItemsСategoryView";
            this.repositoryItemsСategoryView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemsСategoryView.OptionsView.ShowGroupPanel = false;
            this.repositoryItemsСategoryView.CustomRowFilter += new DevExpress.XtraGrid.Views.Base.RowFilterEventHandler(this.repositoryItemsСategoryView_CustomRowFilter);
            // 
            // CategoryName
            // 
            this.CategoryName.FieldName = "Name";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.OptionsColumn.AllowEdit = false;
            this.CategoryName.OptionsColumn.ShowCaption = false;
            this.CategoryName.Visible = true;
            this.CategoryName.VisibleIndex = 0;
            // 
            // plateManufacturersList
            // 
            this.plateManufacturersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plateManufacturersList.Cursor = System.Windows.Forms.Cursors.Default;
            this.plateManufacturersList.Location = new System.Drawing.Point(44, 201);
            this.plateManufacturersList.MainView = this.plateManufacturersListView;
            this.plateManufacturersList.Name = "plateManufacturersList";
            this.plateManufacturersList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.manufacturerRepositoryTextEdit});
            this.plateManufacturersList.Size = new System.Drawing.Size(398, 180);
            this.plateManufacturersList.TabIndex = 3;
            this.plateManufacturersList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.plateManufacturersListView});
            // 
            // plateManufacturersListView
            // 
            this.plateManufacturersListView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.plateManufacturerGridColumn});
            this.plateManufacturersListView.GridControl = this.plateManufacturersList;
            this.plateManufacturersListView.Name = "plateManufacturersListView";
            this.plateManufacturersListView.OptionsBehavior.FocusLeaveOnTab = true;
            this.plateManufacturersListView.OptionsNavigation.UseTabKey = false;
            this.plateManufacturersListView.OptionsView.ShowGroupPanel = false;
            this.plateManufacturersListView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.CellModifiedGridView_CellValueChanged);
            this.plateManufacturersListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.plateManufacturersList_KeyDown);
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
            // client
            // 
            this.client.Location = new System.Drawing.Point(44, 151);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(398, 20);
            this.client.StyleController = this.rootLayoutControl;
            this.client.TabIndex = 2;
            // 
            // wallThickness
            // 
            this.wallThickness.Location = new System.Drawing.Point(672, 455);
            this.wallThickness.Name = "wallThickness";
            this.wallThickness.Properties.Mask.EditMask = "d";
            this.wallThickness.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.wallThickness.Size = new System.Drawing.Size(178, 20);
            this.wallThickness.StyleController = this.rootLayoutControl;
            this.wallThickness.TabIndex = 12;
            // 
            // pipeDiameter
            // 
            this.pipeDiameter.Location = new System.Drawing.Point(481, 455);
            this.pipeDiameter.Name = "pipeDiameter";
            this.pipeDiameter.Properties.Mask.EditMask = "d";
            this.pipeDiameter.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.pipeDiameter.Size = new System.Drawing.Size(177, 20);
            this.pipeDiameter.StyleController = this.rootLayoutControl;
            this.pipeDiameter.TabIndex = 13;
            // 
            // seamType
            // 
            this.seamType.Location = new System.Drawing.Point(1042, 455);
            this.seamType.Name = "seamType";
            this.seamType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seamType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.seamType.Size = new System.Drawing.Size(189, 20);
            this.seamType.StyleController = this.rootLayoutControl;
            this.seamType.TabIndex = 14;
            // 
            // RootGroup
            // 
            this.RootGroup.CustomizationFormText = "RootGroup";
            this.RootGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.RootGroup.GroupBordersVisible = false;
            this.RootGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tabbedControlGroup,
            this.saveButtonLayoutControlItem,
            this.closeButtonLayoutControlItem,
            this.buttonEmptySpaceItem});
            this.RootGroup.Location = new System.Drawing.Point(0, 0);
            this.RootGroup.Name = "Root";
            this.RootGroup.Size = new System.Drawing.Size(1275, 550);
            this.RootGroup.Text = "Root";
            this.RootGroup.TextVisible = false;
            // 
            // tabbedControlGroup
            // 
            this.tabbedControlGroup.CustomizationFormText = "Группа вкладок";
            this.tabbedControlGroup.Location = new System.Drawing.Point(0, 0);
            this.tabbedControlGroup.Name = "tabbedControlGroup";
            this.tabbedControlGroup.SelectedTabPage = this.pipeLayoutControlGroup;
            this.tabbedControlGroup.SelectedTabPageIndex = 1;
            this.tabbedControlGroup.Size = new System.Drawing.Size(1255, 504);
            this.tabbedControlGroup.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.projectLayoutControlGroup,
            this.pipeLayoutControlGroup,
            this.lineLayoutControlGroup,
            this.partsLayoutControlGroup,
            this.weldersLayoutControlGroup,
            this.inspectorsLayoutControlGroup,
            this.usersLayoutControlGroup,
            this.rolesLayoutControlGroup});
            this.tabbedControlGroup.Text = "Группа вкладок";
            // 
            // pipeLayoutControlGroup
            // 
            this.pipeLayoutControlGroup.CustomizationFormText = "&Труба";
            this.pipeLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.sizesLayoutControlItem,
            this.inspectionsLayoutControlItem,
            this.sizeParamsLayoutControlGroup,
            this.cloneButtonLayoutControlItem,
            this.pipeSplitterItem,
            this.addTestButtonLayout,
            this.testButtonsEmptySpace,
            this.editTestButtonLayout});
            this.pipeLayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.pipeLayoutControlGroup.Name = "pipeLayoutControlGroup";
            this.pipeLayoutControlGroup.Size = new System.Drawing.Size(1231, 458);
            this.pipeLayoutControlGroup.Text = "&Труба";
            this.pipeLayoutControlGroup.Shown += new System.EventHandler(this.pipeLayoutControlGroup_Shown);
            // 
            // sizesLayoutControlItem
            // 
            this.sizesLayoutControlItem.Control = this.pipesSizeList;
            this.sizesLayoutControlItem.CustomizationFormText = "Список типораз&меров";
            this.sizesLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.sizesLayoutControlItem.Name = "sizesLayoutControlItem";
            this.sizesLayoutControlItem.Size = new System.Drawing.Size(432, 432);
            this.sizesLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.sizesLayoutControlItem.Text = "Список типораз&меров";
            this.sizesLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.sizesLayoutControlItem.TextSize = new System.Drawing.Size(312, 13);
            // 
            // inspectionsLayoutControlItem
            // 
            this.inspectionsLayoutControlItem.Control = this.inspectionOperation;
            this.inspectionsLayoutControlItem.CustomizationFormText = "Список контрольных операций для выбранного типоразмера";
            this.inspectionsLayoutControlItem.Location = new System.Drawing.Point(437, 36);
            this.inspectionsLayoutControlItem.Name = "inspectionsLayoutControlItem";
            this.inspectionsLayoutControlItem.Size = new System.Drawing.Size(794, 318);
            this.inspectionsLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.inspectionsLayoutControlItem.Text = "Список контрольных опера&ций для выбранного типоразмера";
            this.inspectionsLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.inspectionsLayoutControlItem.TextSize = new System.Drawing.Size(312, 13);
            // 
            // sizeParamsLayoutControlGroup
            // 
            this.sizeParamsLayoutControlGroup.CustomizationFormText = "Параметры типоразмера";
            this.sizeParamsLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.diameterLayoutControlItem,
            this.wallThicknessLayoutControlItem,
            this.pipeLengthLayoutControlItem,
            this.seamTypeLayoutControlItem});
            this.sizeParamsLayoutControlGroup.Location = new System.Drawing.Point(437, 354);
            this.sizeParamsLayoutControlGroup.Name = "sizeParamsLayoutControlGroup";
            this.sizeParamsLayoutControlGroup.Size = new System.Drawing.Size(794, 104);
            this.sizeParamsLayoutControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.sizeParamsLayoutControlGroup.Text = "Параметры типоразмера";
            // 
            // diameterLayoutControlItem
            // 
            this.diameterLayoutControlItem.Control = this.pipeDiameter;
            this.diameterLayoutControlItem.CustomizationFormText = "Диаметр трубы";
            this.diameterLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.diameterLayoutControlItem.MinSize = new System.Drawing.Size(116, 40);
            this.diameterLayoutControlItem.Name = "diameterLayoutControlItem";
            this.diameterLayoutControlItem.Size = new System.Drawing.Size(191, 55);
            this.diameterLayoutControlItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.diameterLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.diameterLayoutControlItem.Text = "Диаметр трубы";
            this.diameterLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.diameterLayoutControlItem.TextSize = new System.Drawing.Size(312, 13);
            // 
            // wallThicknessLayoutControlItem
            // 
            this.wallThicknessLayoutControlItem.Control = this.wallThickness;
            this.wallThicknessLayoutControlItem.CustomizationFormText = "Толщина стенки";
            this.wallThicknessLayoutControlItem.Location = new System.Drawing.Point(191, 0);
            this.wallThicknessLayoutControlItem.MinSize = new System.Drawing.Size(116, 40);
            this.wallThicknessLayoutControlItem.Name = "wallThicknessLayoutControlItem";
            this.wallThicknessLayoutControlItem.Size = new System.Drawing.Size(192, 55);
            this.wallThicknessLayoutControlItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.wallThicknessLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.wallThicknessLayoutControlItem.Text = "Толщина ст&енки";
            this.wallThicknessLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.wallThicknessLayoutControlItem.TextSize = new System.Drawing.Size(312, 13);
            // 
            // pipeLengthLayoutControlItem
            // 
            this.pipeLengthLayoutControlItem.Control = this.pipeLength;
            this.pipeLengthLayoutControlItem.CustomizationFormText = "Номинальная длина трубы";
            this.pipeLengthLayoutControlItem.Location = new System.Drawing.Point(383, 0);
            this.pipeLengthLayoutControlItem.MinSize = new System.Drawing.Size(116, 40);
            this.pipeLengthLayoutControlItem.Name = "pipeLengthLayoutControlItem";
            this.pipeLengthLayoutControlItem.Size = new System.Drawing.Size(178, 55);
            this.pipeLengthLayoutControlItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.pipeLengthLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.pipeLengthLayoutControlItem.Text = "Номинал&ьная длина трубы";
            this.pipeLengthLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.pipeLengthLayoutControlItem.TextSize = new System.Drawing.Size(312, 13);
            // 
            // seamTypeLayoutControlItem
            // 
            this.seamTypeLayoutControlItem.Control = this.seamType;
            this.seamTypeLayoutControlItem.CustomizationFormText = "Тип шва";
            this.seamTypeLayoutControlItem.Location = new System.Drawing.Point(561, 0);
            this.seamTypeLayoutControlItem.MinSize = new System.Drawing.Size(50, 25);
            this.seamTypeLayoutControlItem.Name = "seamTypeLayoutControlItem";
            this.seamTypeLayoutControlItem.Size = new System.Drawing.Size(203, 55);
            this.seamTypeLayoutControlItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.seamTypeLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.seamTypeLayoutControlItem.Text = "Тип &шва";
            this.seamTypeLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.seamTypeLayoutControlItem.TextSize = new System.Drawing.Size(312, 13);
            // 
            // cloneButtonLayoutControlItem
            // 
            this.cloneButtonLayoutControlItem.Control = this.cloneTypeSizeButton;
            this.cloneButtonLayoutControlItem.CustomizationFormText = "Копировать типоразмер";
            this.cloneButtonLayoutControlItem.Location = new System.Drawing.Point(0, 432);
            this.cloneButtonLayoutControlItem.Name = "cloneButtonLayoutControlItem";
            this.cloneButtonLayoutControlItem.Padding = new DevExpress.XtraLayout.Utils.Padding(30, 30, 2, 2);
            this.cloneButtonLayoutControlItem.Size = new System.Drawing.Size(437, 26);
            this.cloneButtonLayoutControlItem.Text = "cloneButtonLayoutControlItem";
            this.cloneButtonLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.cloneButtonLayoutControlItem.TextVisible = false;
            // 
            // pipeSplitterItem
            // 
            this.pipeSplitterItem.AllowHotTrack = true;
            this.pipeSplitterItem.CustomizationFormText = "Разделитель";
            this.pipeSplitterItem.Location = new System.Drawing.Point(432, 0);
            this.pipeSplitterItem.Name = "pipeSplitterItem";
            this.pipeSplitterItem.Size = new System.Drawing.Size(5, 432);
            // 
            // addTestButtonLayout
            // 
            this.addTestButtonLayout.Control = this.addTestButton;
            this.addTestButtonLayout.CustomizationFormText = "addTestButtonLayout";
            this.addTestButtonLayout.Location = new System.Drawing.Point(437, 0);
            this.addTestButtonLayout.Name = "addTestButtonLayout";
            this.addTestButtonLayout.Size = new System.Drawing.Size(94, 36);
            this.addTestButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.addTestButtonLayout.Text = "addTestButtonLayout";
            this.addTestButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.addTestButtonLayout.TextVisible = false;
            // 
            // testButtonsEmptySpace
            // 
            this.testButtonsEmptySpace.AllowHotTrack = false;
            this.testButtonsEmptySpace.CustomizationFormText = "testButtonsEmptySpace";
            this.testButtonsEmptySpace.Location = new System.Drawing.Point(654, 0);
            this.testButtonsEmptySpace.Name = "testButtonsEmptySpace";
            this.testButtonsEmptySpace.Size = new System.Drawing.Size(577, 36);
            this.testButtonsEmptySpace.Text = "testButtonsEmptySpace";
            this.testButtonsEmptySpace.TextSize = new System.Drawing.Size(0, 0);
            // 
            // editTestButtonLayout
            // 
            this.editTestButtonLayout.Control = this.editTestButton;
            this.editTestButtonLayout.CustomizationFormText = "editTestButtonLayout";
            this.editTestButtonLayout.Location = new System.Drawing.Point(531, 0);
            this.editTestButtonLayout.Name = "editTestButtonLayout";
            this.editTestButtonLayout.Size = new System.Drawing.Size(123, 36);
            this.editTestButtonLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.editTestButtonLayout.Text = "editTestButtonLayout";
            this.editTestButtonLayout.TextSize = new System.Drawing.Size(0, 0);
            this.editTestButtonLayout.TextVisible = false;
            // 
            // projectLayoutControlGroup
            // 
            this.projectLayoutControlGroup.CustomizationFormText = "&Проект";
            this.projectLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.commonParamsLayoutControlGroup,
            this.millLayoutControlGroup});
            this.projectLayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.projectLayoutControlGroup.Name = "projectLayoutControlGroup";
            this.projectLayoutControlGroup.Size = new System.Drawing.Size(1231, 458);
            this.projectLayoutControlGroup.Text = "&Проект";
            this.projectLayoutControlGroup.Shown += new System.EventHandler(this.projectLayoutControlGroup_Shown);
            // 
            // commonParamsLayoutControlGroup
            // 
            this.commonParamsLayoutControlGroup.CustomizationFormText = "Общие параметры";
            this.commonParamsLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.projectTitleLayoutControlItem,
            this.clientLayoutControlItem,
            this.plateManLayoutControlItem,
            this.techParamsLayoutControlGroup});
            this.commonParamsLayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.commonParamsLayoutControlGroup.Name = "commonParamsLayoutControlGroup";
            this.commonParamsLayoutControlGroup.Size = new System.Drawing.Size(442, 458);
            this.commonParamsLayoutControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.commonParamsLayoutControlGroup.Text = "Общие параметры";
            // 
            // projectTitleLayoutControlItem
            // 
            this.projectTitleLayoutControlItem.Control = this.projectTitle;
            this.projectTitleLayoutControlItem.CustomizationFormText = "Названи&е";
            this.projectTitleLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.projectTitleLayoutControlItem.Name = "projectTitleLayoutControlItem";
            this.projectTitleLayoutControlItem.Size = new System.Drawing.Size(412, 50);
            this.projectTitleLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.projectTitleLayoutControlItem.Text = "Названи&е";
            this.projectTitleLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.projectTitleLayoutControlItem.TextSize = new System.Drawing.Size(312, 13);
            // 
            // clientLayoutControlItem
            // 
            this.clientLayoutControlItem.Control = this.client;
            this.clientLayoutControlItem.CustomizationFormText = "Заказ&чик";
            this.clientLayoutControlItem.Location = new System.Drawing.Point(0, 50);
            this.clientLayoutControlItem.Name = "clientLayoutControlItem";
            this.clientLayoutControlItem.Size = new System.Drawing.Size(412, 50);
            this.clientLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.clientLayoutControlItem.Text = "Заказ&чик";
            this.clientLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.clientLayoutControlItem.TextSize = new System.Drawing.Size(312, 13);
            // 
            // plateManLayoutControlItem
            // 
            this.plateManLayoutControlItem.Control = this.plateManufacturersList;
            this.plateManLayoutControlItem.CustomizationFormText = "Производ&ители листов";
            this.plateManLayoutControlItem.Location = new System.Drawing.Point(0, 100);
            this.plateManLayoutControlItem.Name = "plateManLayoutControlItem";
            this.plateManLayoutControlItem.Size = new System.Drawing.Size(412, 210);
            this.plateManLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.plateManLayoutControlItem.Text = "Произво&дители листов";
            this.plateManLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.plateManLayoutControlItem.TextSize = new System.Drawing.Size(312, 13);
            // 
            // techParamsLayoutControlGroup
            // 
            this.techParamsLayoutControlGroup.CustomizationFormText = "Те&хнические параметры";
            this.techParamsLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.extDocumentSizeLayoutControlItem});
            this.techParamsLayoutControlGroup.Location = new System.Drawing.Point(0, 310);
            this.techParamsLayoutControlGroup.Name = "techParamsLayoutControlGroup";
            this.techParamsLayoutControlGroup.Size = new System.Drawing.Size(412, 99);
            this.techParamsLayoutControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.techParamsLayoutControlGroup.Text = "Те&хнические параметры";
            // 
            // extDocumentSizeLayoutControlItem
            // 
            this.extDocumentSizeLayoutControlItem.Control = this.externalDocumentSize;
            this.extDocumentSizeLayoutControlItem.CustomizationFormText = "Допустимый размер внешнего документа, Kbytes";
            this.extDocumentSizeLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.extDocumentSizeLayoutControlItem.Name = "extDocumentSizeLayoutControlItem";
            this.extDocumentSizeLayoutControlItem.Size = new System.Drawing.Size(382, 50);
            this.extDocumentSizeLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.extDocumentSizeLayoutControlItem.Text = "Допустимый размер внешнего документа, Kbytes";
            this.extDocumentSizeLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.extDocumentSizeLayoutControlItem.TextSize = new System.Drawing.Size(312, 13);
            // 
            // millLayoutControlGroup
            // 
            this.millLayoutControlGroup.CustomizationFormText = "Завод";
            this.millLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.millNameLayoutControlItem,
            this.maskLayoutControlItem,
            this.operationsLayoutControlItem,
            this.maskLabelLayoutControlItem,
            this.seamsLayoutControlItem});
            this.millLayoutControlGroup.Location = new System.Drawing.Point(442, 0);
            this.millLayoutControlGroup.Name = "millLayoutControlGroup";
            this.millLayoutControlGroup.Size = new System.Drawing.Size(789, 458);
            this.millLayoutControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.millLayoutControlGroup.Text = "Завод";
            // 
            // millNameLayoutControlItem
            // 
            this.millNameLayoutControlItem.Control = this.millName;
            this.millNameLayoutControlItem.CustomizationFormText = "Производител&ь";
            this.millNameLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.millNameLayoutControlItem.Name = "millNameLayoutControlItem";
            this.millNameLayoutControlItem.Size = new System.Drawing.Size(759, 50);
            this.millNameLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.millNameLayoutControlItem.Text = "Производител&ь";
            this.millNameLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.millNameLayoutControlItem.TextSize = new System.Drawing.Size(312, 13);
            // 
            // maskLayoutControlItem
            // 
            this.maskLayoutControlItem.Control = this.pipeNumberMask;
            this.maskLayoutControlItem.CustomizationFormText = "&Формат номера трубы";
            this.maskLayoutControlItem.Location = new System.Drawing.Point(0, 50);
            this.maskLayoutControlItem.Name = "maskLayoutControlItem";
            this.maskLayoutControlItem.Size = new System.Drawing.Size(346, 50);
            this.maskLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.maskLayoutControlItem.Text = "Формат но&мера трубы";
            this.maskLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.maskLayoutControlItem.TextSize = new System.Drawing.Size(312, 13);
            // 
            // operationsLayoutControlItem
            // 
            this.operationsLayoutControlItem.Control = this.categoriesGrid;
            this.operationsLayoutControlItem.CustomizationFormText = "Группы контрольных операций";
            this.operationsLayoutControlItem.Location = new System.Drawing.Point(0, 100);
            this.operationsLayoutControlItem.Name = "operationsLayoutControlItem";
            this.operationsLayoutControlItem.Size = new System.Drawing.Size(346, 309);
            this.operationsLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.operationsLayoutControlItem.Text = "Группы контрольных операций";
            this.operationsLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.operationsLayoutControlItem.TextSize = new System.Drawing.Size(312, 13);
            // 
            // maskLabelLayoutControlItem
            // 
            this.maskLabelLayoutControlItem.Control = this.pipeNumberMaskRulesLabel;
            this.maskLabelLayoutControlItem.CustomizationFormText = "Подсказка формата номера трубы";
            this.maskLabelLayoutControlItem.Location = new System.Drawing.Point(346, 50);
            this.maskLabelLayoutControlItem.Name = "maskLabelLayoutControlItem";
            this.maskLabelLayoutControlItem.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2);
            this.maskLabelLayoutControlItem.Size = new System.Drawing.Size(413, 50);
            this.maskLabelLayoutControlItem.Text = "maskLabelLayoutControlItem";
            this.maskLabelLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.maskLabelLayoutControlItem.TextVisible = false;
            // 
            // seamsLayoutControlItem
            // 
            this.seamsLayoutControlItem.Control = this.seamTypes;
            this.seamsLayoutControlItem.CustomizationFormText = "Типы сварочных швов";
            this.seamsLayoutControlItem.Location = new System.Drawing.Point(346, 100);
            this.seamsLayoutControlItem.Name = "seamsLayoutControlItem";
            this.seamsLayoutControlItem.Size = new System.Drawing.Size(413, 309);
            this.seamsLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.seamsLayoutControlItem.Text = "Типы сварочных швов";
            this.seamsLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.seamsLayoutControlItem.TextSize = new System.Drawing.Size(312, 13);
            // 
            // lineLayoutControlGroup
            // 
            this.lineLayoutControlGroup.CustomizationFormText = "Тру&бопровод";
            this.lineLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.jointOperationLayoutControlItem});
            this.lineLayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.lineLayoutControlGroup.Name = "lineLayoutControlGroup";
            this.lineLayoutControlGroup.Size = new System.Drawing.Size(1231, 458);
            this.lineLayoutControlGroup.Text = "Тру&бопровод";
            // 
            // jointOperationLayoutControlItem
            // 
            this.jointOperationLayoutControlItem.Control = this.jointOperations;
            this.jointOperationLayoutControlItem.CustomizationFormText = "Набор операций - условия приемки стыка для спуска";
            this.jointOperationLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.jointOperationLayoutControlItem.Name = "jointOperationLayoutControlItem";
            this.jointOperationLayoutControlItem.Size = new System.Drawing.Size(1231, 458);
            this.jointOperationLayoutControlItem.Text = "Набор операций - условия приемки стыка для спуска";
            this.jointOperationLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.jointOperationLayoutControlItem.TextSize = new System.Drawing.Size(312, 13);
            // 
            // partsLayoutControlGroup
            // 
            this.partsLayoutControlGroup.CustomizationFormText = "Комплектую&щие";
            this.partsLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.partsTypeLayoutControlItem,
            this.emptySpaceItem,
            this.partsSplitterItem});
            this.partsLayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.partsLayoutControlGroup.Name = "partsLayoutControlGroup";
            this.partsLayoutControlGroup.Size = new System.Drawing.Size(1231, 458);
            this.partsLayoutControlGroup.Text = "Комплектую&щие";
            // 
            // partsTypeLayoutControlItem
            // 
            this.partsTypeLayoutControlItem.Control = this.componentryTypeGridControl;
            this.partsTypeLayoutControlItem.CustomizationFormText = "Типы комплектующих изделий";
            this.partsTypeLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.partsTypeLayoutControlItem.Name = "partsTypeLayoutControlItem";
            this.partsTypeLayoutControlItem.Size = new System.Drawing.Size(614, 458);
            this.partsTypeLayoutControlItem.Text = "Типы комплектующих изделий";
            this.partsTypeLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.partsTypeLayoutControlItem.TextSize = new System.Drawing.Size(312, 13);
            // 
            // emptySpaceItem
            // 
            this.emptySpaceItem.AllowHotTrack = false;
            this.emptySpaceItem.CustomizationFormText = "emptySpaceItem";
            this.emptySpaceItem.Location = new System.Drawing.Point(619, 0);
            this.emptySpaceItem.Name = "emptySpaceItem";
            this.emptySpaceItem.Size = new System.Drawing.Size(612, 458);
            this.emptySpaceItem.Text = "emptySpaceItem";
            this.emptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // partsSplitterItem
            // 
            this.partsSplitterItem.AllowHotTrack = true;
            this.partsSplitterItem.CustomizationFormText = "Разделитель";
            this.partsSplitterItem.Location = new System.Drawing.Point(614, 0);
            this.partsSplitterItem.Name = "partsSplitterItem";
            this.partsSplitterItem.Size = new System.Drawing.Size(5, 458);
            // 
            // weldersLayoutControlGroup
            // 
            this.weldersLayoutControlGroup.CustomizationFormText = "С&варщики";
            this.weldersLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.weldersLayoutControlItem});
            this.weldersLayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.weldersLayoutControlGroup.Name = "weldersLayoutControlGroup";
            this.weldersLayoutControlGroup.Size = new System.Drawing.Size(1231, 458);
            this.weldersLayoutControlGroup.Text = "С&варщики";
            // 
            // weldersLayoutControlItem
            // 
            this.weldersLayoutControlItem.Control = this.gridControlWelders;
            this.weldersLayoutControlItem.CustomizationFormText = "Сварщики";
            this.weldersLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.weldersLayoutControlItem.Name = "weldersLayoutControlItem";
            this.weldersLayoutControlItem.Size = new System.Drawing.Size(1231, 458);
            this.weldersLayoutControlItem.Text = "Сварщики";
            this.weldersLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.weldersLayoutControlItem.TextVisible = false;
            // 
            // inspectorsLayoutControlGroup
            // 
            this.inspectorsLayoutControlGroup.CustomizationFormText = "&Инспекторы";
            this.inspectorsLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.inspectorLayoutControlGroup,
            this.certificateTypeLayoutControlGroup,
            this.inspectorSplitterItem});
            this.inspectorsLayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.inspectorsLayoutControlGroup.Name = "inspectorsLayoutControlGroup";
            this.inspectorsLayoutControlGroup.Size = new System.Drawing.Size(1231, 458);
            this.inspectorsLayoutControlGroup.Text = "&Инспекторы";
            // 
            // inspectorLayoutControlGroup
            // 
            this.inspectorLayoutControlGroup.CustomizationFormText = "Инспекторы";
            this.inspectorLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.certificateLayoutControlItem,
            this.inspectorsLayoutControlItem});
            this.inspectorLayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.inspectorLayoutControlGroup.Name = "inspectorLayoutControlGroup";
            this.inspectorLayoutControlGroup.Size = new System.Drawing.Size(870, 458);
            this.inspectorLayoutControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.inspectorLayoutControlGroup.Text = "Инспекторы";
            // 
            // certificateLayoutControlItem
            // 
            this.certificateLayoutControlItem.Control = this.gridControlInspectorsCertificates;
            this.certificateLayoutControlItem.CustomizationFormText = "Сертификаты";
            this.certificateLayoutControlItem.Location = new System.Drawing.Point(384, 0);
            this.certificateLayoutControlItem.Name = "certificateLayoutControlItem";
            this.certificateLayoutControlItem.Size = new System.Drawing.Size(456, 409);
            this.certificateLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.certificateLayoutControlItem.Text = "Сертификаты";
            this.certificateLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.certificateLayoutControlItem.TextSize = new System.Drawing.Size(312, 13);
            // 
            // inspectorsLayoutControlItem
            // 
            this.inspectorsLayoutControlItem.Control = this.gridControlInspectors;
            this.inspectorsLayoutControlItem.CustomizationFormText = "Инспекторы";
            this.inspectorsLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.inspectorsLayoutControlItem.Name = "inspectorsLayoutControlItem";
            this.inspectorsLayoutControlItem.Size = new System.Drawing.Size(384, 409);
            this.inspectorsLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.inspectorsLayoutControlItem.Text = "Инспекторы";
            this.inspectorsLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.inspectorsLayoutControlItem.TextSize = new System.Drawing.Size(312, 13);
            // 
            // certificateTypeLayoutControlGroup
            // 
            this.certificateTypeLayoutControlGroup.CustomizationFormText = "Типы сертификатов";
            this.certificateTypeLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.certTypeListLayoutControlItem});
            this.certificateTypeLayoutControlGroup.Location = new System.Drawing.Point(875, 0);
            this.certificateTypeLayoutControlGroup.Name = "certificateTypeLayoutControlGroup";
            this.certificateTypeLayoutControlGroup.Size = new System.Drawing.Size(356, 458);
            this.certificateTypeLayoutControlGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.certificateTypeLayoutControlGroup.Text = "Типы сертификатов";
            // 
            // certTypeListLayoutControlItem
            // 
            this.certTypeListLayoutControlItem.Control = this.certificateTypes;
            this.certTypeListLayoutControlItem.CustomizationFormText = "Список типов";
            this.certTypeListLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.certTypeListLayoutControlItem.Name = "certTypeListLayoutControlItem";
            this.certTypeListLayoutControlItem.Size = new System.Drawing.Size(326, 409);
            this.certTypeListLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.certTypeListLayoutControlItem.Text = "Список типов";
            this.certTypeListLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.certTypeListLayoutControlItem.TextSize = new System.Drawing.Size(312, 13);
            // 
            // inspectorSplitterItem
            // 
            this.inspectorSplitterItem.AllowHotTrack = true;
            this.inspectorSplitterItem.CustomizationFormText = "Разделитель";
            this.inspectorSplitterItem.Location = new System.Drawing.Point(870, 0);
            this.inspectorSplitterItem.Name = "inspectorSplitterItem";
            this.inspectorSplitterItem.Size = new System.Drawing.Size(5, 458);
            // 
            // usersLayoutControlGroup
            // 
            this.usersLayoutControlGroup.CustomizationFormText = "Пользователи";
            this.usersLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.userLayoutControlItem,
            this.roleLayoutControlItem,
            this.userSplitterItem});
            this.usersLayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.usersLayoutControlGroup.Name = "usersLayoutControlGroup";
            this.usersLayoutControlGroup.Size = new System.Drawing.Size(1231, 458);
            this.usersLayoutControlGroup.Text = "По&льзователи";
            // 
            // userLayoutControlItem
            // 
            this.userLayoutControlItem.Control = this.gridControlUsers;
            this.userLayoutControlItem.CustomizationFormText = "Пользователи";
            this.userLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.userLayoutControlItem.Name = "userLayoutControlItem";
            this.userLayoutControlItem.Size = new System.Drawing.Size(900, 458);
            this.userLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.userLayoutControlItem.Text = "Пользователи";
            this.userLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.userLayoutControlItem.TextSize = new System.Drawing.Size(312, 13);
            // 
            // roleLayoutControlItem
            // 
            this.roleLayoutControlItem.Control = this.gridControlRoles;
            this.roleLayoutControlItem.CustomizationFormText = "Роли";
            this.roleLayoutControlItem.Location = new System.Drawing.Point(905, 0);
            this.roleLayoutControlItem.Name = "roleLayoutControlItem";
            this.roleLayoutControlItem.Size = new System.Drawing.Size(326, 458);
            this.roleLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.roleLayoutControlItem.Text = "Роли";
            this.roleLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.roleLayoutControlItem.TextSize = new System.Drawing.Size(312, 13);
            // 
            // userSplitterItem
            // 
            this.userSplitterItem.AllowHotTrack = true;
            this.userSplitterItem.CustomizationFormText = "Разделитель";
            this.userSplitterItem.Location = new System.Drawing.Point(900, 0);
            this.userSplitterItem.Name = "userSplitterItem";
            this.userSplitterItem.Size = new System.Drawing.Size(5, 458);
            // 
            // rolesLayoutControlGroup
            // 
            this.rolesLayoutControlGroup.CustomizationFormText = "Роли";
            this.rolesLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.rolesTabLayoutControlItem,
            this.permissionLayoutControlItem,
            this.roleSplitterItem});
            this.rolesLayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.rolesLayoutControlGroup.Name = "rolesLayoutControlGroup";
            this.rolesLayoutControlGroup.Size = new System.Drawing.Size(1231, 458);
            this.rolesLayoutControlGroup.Text = "&Роли";
            // 
            // rolesTabLayoutControlItem
            // 
            this.rolesTabLayoutControlItem.Control = this.gridControl1;
            this.rolesTabLayoutControlItem.CustomizationFormText = "Роли";
            this.rolesTabLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.rolesTabLayoutControlItem.Name = "rolesTabLayoutControlItem";
            this.rolesTabLayoutControlItem.Size = new System.Drawing.Size(900, 458);
            this.rolesTabLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.rolesTabLayoutControlItem.Text = "Роли";
            this.rolesTabLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.rolesTabLayoutControlItem.TextSize = new System.Drawing.Size(312, 13);
            // 
            // permissionLayoutControlItem
            // 
            this.permissionLayoutControlItem.Control = this.gridControlPermission;
            this.permissionLayoutControlItem.CustomizationFormText = "Права";
            this.permissionLayoutControlItem.Location = new System.Drawing.Point(905, 0);
            this.permissionLayoutControlItem.Name = "permissionLayoutControlItem";
            this.permissionLayoutControlItem.Size = new System.Drawing.Size(326, 458);
            this.permissionLayoutControlItem.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.permissionLayoutControlItem.Text = "Права";
            this.permissionLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.permissionLayoutControlItem.TextSize = new System.Drawing.Size(312, 13);
            // 
            // roleSplitterItem
            // 
            this.roleSplitterItem.AllowHotTrack = true;
            this.roleSplitterItem.CustomizationFormText = "Разделитель";
            this.roleSplitterItem.Location = new System.Drawing.Point(900, 0);
            this.roleSplitterItem.Name = "roleSplitterItem";
            this.roleSplitterItem.Size = new System.Drawing.Size(5, 458);
            // 
            // saveButtonLayoutControlItem
            // 
            this.saveButtonLayoutControlItem.Control = this.saveButton;
            this.saveButtonLayoutControlItem.CustomizationFormText = "Сохранить";
            this.saveButtonLayoutControlItem.Location = new System.Drawing.Point(961, 504);
            this.saveButtonLayoutControlItem.Name = "saveButtonLayoutControlItem";
            this.saveButtonLayoutControlItem.Size = new System.Drawing.Size(146, 26);
            this.saveButtonLayoutControlItem.Text = "Сохранить";
            this.saveButtonLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.saveButtonLayoutControlItem.TextVisible = false;
            // 
            // closeButtonLayoutControlItem
            // 
            this.closeButtonLayoutControlItem.Control = this.closeButton;
            this.closeButtonLayoutControlItem.CustomizationFormText = "Закрыть";
            this.closeButtonLayoutControlItem.Location = new System.Drawing.Point(1107, 504);
            this.closeButtonLayoutControlItem.Name = "closeButtonLayoutControlItem";
            this.closeButtonLayoutControlItem.Size = new System.Drawing.Size(148, 26);
            this.closeButtonLayoutControlItem.Text = "closeButtonLayoutControlItem";
            this.closeButtonLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.closeButtonLayoutControlItem.TextVisible = false;
            // 
            // buttonEmptySpaceItem
            // 
            this.buttonEmptySpaceItem.AllowHotTrack = false;
            this.buttonEmptySpaceItem.CustomizationFormText = "emptySpaceItem";
            this.buttonEmptySpaceItem.Location = new System.Drawing.Point(0, 504);
            this.buttonEmptySpaceItem.Name = "buttonEmptySpaceItem";
            this.buttonEmptySpaceItem.Size = new System.Drawing.Size(961, 26);
            this.buttonEmptySpaceItem.Text = "buttonEmptySpaceItem";
            this.buttonEmptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // editDictionary
            // 
            this.editDictionary.Name = "editDictionary";
            // 
            // editItem
            // 
            this.editItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.editItem.Name = "editItem";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Prizm.Main.DummyData.User);
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(Prizm.Main.DummyData.Role);
            // 
            // jointOperationsBindingSource
            // 
            this.jointOperationsBindingSource.DataSource = typeof(Prizm.Main.DummyData.User);
            // 
            // SettingsXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 550);
            this.Controls.Add(this.rootLayoutControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsXtraForm";
            this.Text = "Настройки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsXtraForm_FormClosed);
            this.Load += new System.EventHandler(this.SettingsXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pipesSizeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipesSizeListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPermissions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleNameRepositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleDescriptionRepositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginRepositoryItemTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameRepositoryItemTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userFirstNameRepositoryItemTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userMiddleNameRepositoryItemTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonUserPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateTypesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateTypeRepositoryItemTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryCertificateIsActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInspectorsCertificates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorCertificateGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorSertificateNumberRepositoryItemTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryLookUpCertificateType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryLookUpCertificateTypeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInspectors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInspectors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorLNRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorFNRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorMNRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorCertificateTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWelders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWelders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.welderLNRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.welderFNRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.welderMNRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.welderCertificateTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stampRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentryTypeGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentryTypeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentTypeNameRepositoryItemTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryConnectorsNumbers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryComponentryTypeCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointOperations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointsOperationsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipelineOperationNameRepositoryItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointOperationTypeLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalDocumentSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootLayoutControl)).EndInit();
            this.rootLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seamTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seemTypeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seamTypeRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryIsActiveCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumberMask.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.millName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlTypeItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultTypeItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isRequired)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemsСategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemsСategoryView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerRepositoryTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallThickness.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDiameter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seamType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RootGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizesLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeParamsLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diameterLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallThicknessLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeLengthLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seamTypeLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloneButtonLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSplitterItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addTestButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testButtonsEmptySpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTestButtonLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commonParamsLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTitleLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techParamsLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extDocumentSizeLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.millLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.millNameLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskLabelLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seamsLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointOperationLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsTypeLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsSplitterItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldersLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldersLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateTypeLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certTypeListLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorSplitterItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSplitterItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesTabLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissionLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleSplitterItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveButtonLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEmptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeMillSizeTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorCertificateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointOperationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPipeMillSizeTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private DevExpress.XtraGrid.GridControl plateManufacturersList;
        private DevExpress.XtraGrid.Views.Grid.GridView plateManufacturersListView;
        private DevExpress.XtraGrid.Columns.GridColumn plateManufacturerGridColumn;
        private DevExpress.XtraEditors.TextEdit millName;
        private DevExpress.XtraEditors.TextEdit client;
        private DevExpress.XtraEditors.TextEdit externalDocumentSize;
        private DevExpress.XtraGrid.Columns.GridColumn editDictionary;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit editItem;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private DevExpress.XtraGrid.GridControl inspectionOperation;
        private DevExpress.XtraGrid.Views.Grid.GridView inspectionView;
        private DevExpress.XtraGrid.Columns.GridColumn inspectionCodeGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn inspectionNameGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn controlTypeGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn resultTypeGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn minExpectedGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn maxExpectedGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn boolExpectedGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn isRequiredGridColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit isRequired;
        private System.Windows.Forms.BindingSource inspectionBindingSource;
        private DevExpress.XtraGrid.GridControl pipesSizeList;
        private DevExpress.XtraGrid.Views.Grid.GridView pipesSizeListGridView;
        private DevExpress.XtraGrid.Columns.GridColumn pipeSizeGridColumn;
        private DevExpress.XtraEditors.SimpleButton closeButton;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraGrid.Columns.GridColumn isActiveGridColumn;
        private System.Windows.Forms.BindingSource pipeMillSizeTypeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn testIsActiveGridColumn;
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
        private DevExpress.XtraEditors.TextEdit projectTitle;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit manufacturerRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit typeRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit welderFNRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit welderLNRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit welderMNRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit welderCertificateTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit stampRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit inspectorFNRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit inspectorLNRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit inspectorMNRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit inspectorCertificateTextEdit;
        private DevExpress.XtraEditors.TextEdit pipeNumberMask;
        private DevExpress.XtraGrid.GridControl gridControlInspectorsCertificates;
        private DevExpress.XtraGrid.Views.Grid.GridView inspectorCertificateGridView;
        private DevExpress.XtraGrid.Columns.GridColumn inspectorCertificateNumberCol;
        private DevExpress.XtraGrid.Columns.GridColumn inspectorCertificateExpirationCol;
        private System.Windows.Forms.BindingSource inspectorBindingSource;
        private System.Windows.Forms.BindingSource inspectorCertificateBindingSource;
        private DevExpress.XtraGrid.GridControl categoriesGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView categoriesGridView;
        private DevExpress.XtraGrid.Columns.GridColumn categoryNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn isActiveColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryIsActiveCheckEdit;
        private DevExpress.XtraGrid.GridControl gridControlRoles;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRoles;
        private DevExpress.XtraGrid.GridControl gridControlUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUsers;
        private DevExpress.XtraGrid.Columns.GridColumn colLogin;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colMiddleName;
        private DevExpress.XtraGrid.Columns.GridColumn colPasswordExpires;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleName;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleDesc;
        private DevExpress.XtraGrid.GridControl gridControlPermission;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPermissions;
        private DevExpress.XtraGrid.Columns.GridColumn colPermissionDesc;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRole;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleSetupName;
        private DevExpress.XtraGrid.Columns.GridColumn colDesc;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private System.Windows.Forms.BindingSource permissionsBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colUserPass;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonUserPass;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit categoryRepositoryTextEdit;
        private DevExpress.XtraGrid.GridControl jointOperations;
        private DevExpress.XtraGrid.Views.Grid.GridView jointsOperationsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn nameGridColumn;
        private System.Windows.Forms.BindingSource jointOperationsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn isRequiredForJointGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn TestTypeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn testHasAcceptedGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn testHasToRepairGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn testHasToWithdrawGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn testResultRequiredGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn isActiveJointOperationGridColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit jointOperationTypeLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn categoryColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemsСategory;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemsСategoryView;
        private DevExpress.XtraGrid.Columns.GridColumn CategoryName;
        private DevExpress.XtraEditors.SimpleButton cloneTypeSizeButton;
        private DevExpress.XtraEditors.LabelControl pipeNumberMaskRulesLabel;
        private DevExpress.XtraGrid.GridControl componentryTypeGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView componentryTypeGridView;
        private DevExpress.XtraGrid.Columns.GridColumn typeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn connectorsNumbersColumn;
        private DevExpress.XtraGrid.Columns.GridColumn isActiveComponentColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryComponentryTypeCheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryConnectorsNumbers;
        private DevExpress.XtraGrid.GridControl certificateTypes;
        private DevExpress.XtraGrid.Views.Grid.GridView certificateTypesView;
        private DevExpress.XtraGrid.Columns.GridColumn certificateNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn certificateIsActiveColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryCertificateIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn certificateTypeColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryLookUpCertificateType;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryLookUpCertificateTypeView;
        private DevExpress.XtraGrid.Columns.GridColumn inspectorCertificateTypeColumn;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
        private DevExpress.XtraEditors.TextEdit pipeLength;
        private DevExpress.XtraEditors.TextEdit pipeDiameter;
        private DevExpress.XtraEditors.TextEdit wallThickness;
        private DevExpress.XtraGrid.GridControl seamTypes;
        private DevExpress.XtraGrid.Views.Grid.GridView seemTypeGridView;
        private DevExpress.XtraGrid.Columns.GridColumn seemTypeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn seemTypeIsActiveColumn;
        private System.Windows.Forms.BindingSource CurrentPipeMillSizeTypeBindingSource;
        private DevExpress.XtraLayout.LayoutControl rootLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup RootGroup;
        private DevExpress.XtraLayout.LayoutControlGroup pipeLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem sizesLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem inspectionsLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlGroup sizeParamsLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem diameterLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem wallThicknessLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem pipeLengthLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem seamTypeLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem cloneButtonLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlGroup projectLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlGroup commonParamsLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem projectTitleLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem clientLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem plateManLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlGroup millLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem millNameLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem maskLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem operationsLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem maskLabelLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem seamsLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlGroup techParamsLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem extDocumentSizeLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlGroup lineLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem jointOperationLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlGroup partsLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem partsTypeLayoutControlItem;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem;
        private DevExpress.XtraLayout.LayoutControlGroup weldersLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem weldersLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlGroup inspectorsLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlGroup inspectorLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem certificateLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem inspectorsLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlGroup certificateTypeLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem certTypeListLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlGroup usersLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem userLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem roleLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlGroup rolesLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem rolesTabLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem permissionLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem saveButtonLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem closeButtonLayoutControlItem;
        private DevExpress.XtraLayout.EmptySpaceItem buttonEmptySpaceItem;
        public DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup;
        private DevExpress.XtraLayout.SplitterItem roleSplitterItem;
        private DevExpress.XtraLayout.SplitterItem pipeSplitterItem;
        private DevExpress.XtraLayout.SplitterItem partsSplitterItem;
        private DevExpress.XtraLayout.SplitterItem inspectorSplitterItem;
        private DevExpress.XtraLayout.SplitterItem userSplitterItem;
        private DevExpress.XtraEditors.ComboBoxEdit seamType;
        private DevExpress.XtraGrid.Columns.GridColumn colInspectorGrade;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit seamTypeRepositoryTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit pipelineOperationNameRepositoryItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit componentTypeNameRepositoryItemTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit certificateTypeRepositoryItemTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit inspectorSertificateNumberRepositoryItemTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit userLoginRepositoryItemTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit lastNameRepositoryItemTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit userFirstNameRepositoryItemTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit userMiddleNameRepositoryItemTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit roleNameRepositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit roleDescriptionRepositoryItemTextEdit1;
        private DevExpress.XtraEditors.SimpleButton editTestButton;
        private DevExpress.XtraEditors.SimpleButton addTestButton;
        private DevExpress.XtraLayout.LayoutControlItem addTestButtonLayout;
        private DevExpress.XtraLayout.EmptySpaceItem testButtonsEmptySpace;
        private DevExpress.XtraLayout.LayoutControlItem editTestButtonLayout;
    }
}