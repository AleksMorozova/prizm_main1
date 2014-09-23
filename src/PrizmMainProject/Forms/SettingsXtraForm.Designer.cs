namespace PrizmMain.Forms
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
            this.TabControlSettings = new DevExpress.XtraTab.XtraTabControl();
            this.TabPagePipe = new DevExpress.XtraTab.XtraTabPage();
            this.lblSizeGrade = new DevExpress.XtraEditors.LabelControl();
            this.lblPipeManufacturer = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxSizeGrade = new DevExpress.XtraEditors.ComboBoxEdit();
            this.PipeManufacturersComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.PipeSetupTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.TabPageGeneralPipeSetup = new DevExpress.XtraTab.XtraTabPage();
            this.groupControlInsideCoating = new DevExpress.XtraEditors.GroupControl();
            this.lblInsideMaterial = new DevExpress.XtraEditors.LabelControl();
            this.lblInsideAdhesion = new DevExpress.XtraEditors.LabelControl();
            this.lblInsideThickness = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtInsideMaterial = new DevExpress.XtraEditors.TextEdit();
            this.CheckEditInsideCoating = new DevExpress.XtraEditors.CheckEdit();
            this.txtEdtInsideAdhesion = new DevExpress.XtraEditors.TextEdit();
            this.txtEdtInsideThickness = new DevExpress.XtraEditors.TextEdit();
            this.groupControlOuterCoating = new DevExpress.XtraEditors.GroupControl();
            this.lblOuterMaterial = new DevExpress.XtraEditors.LabelControl();
            this.lblOuterAdhesion = new DevExpress.XtraEditors.LabelControl();
            this.lblOuterThickness = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtOuterMaterial = new DevExpress.XtraEditors.TextEdit();
            this.txtEdtOuterAdhesion = new DevExpress.XtraEditors.TextEdit();
            this.txtEdtOuterThickness = new DevExpress.XtraEditors.TextEdit();
            this.CheckEditOuterCoating = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditSpiral = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditWelded = new DevExpress.XtraEditors.CheckEdit();
            this.lblWeldType = new DevExpress.XtraEditors.LabelControl();
            this.TabPageInspection = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlInspection = new DevExpress.XtraGrid.GridControl();
            this.GridViewInspection = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.bandGridInspectionId = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.ColumnNumber = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandGridInspectionStage = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.ColumnStageOrInspection = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandGridInspectionObject = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.ColumnResearchObject = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandGridInspectionFrequency = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.ColumnFrequency = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandGridInspectionDocument = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.ColumnDocumentAndCriteria = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandGridInspectionSertification = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.ColumnDocumentCertification = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandGridInspection = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandGridInspectionPlant = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.ColumnPlant = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandGridInspectionCustomer = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.ColumnClient = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandGridInspectionOther = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.ColumnThirdPart = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.lblPipeSetup = new DevExpress.XtraEditors.LabelControl();
            this.TabPagePipeline = new DevExpress.XtraTab.XtraTabPage();
            this.TabPageUsers = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlUsers = new DevExpress.XtraGrid.GridControl();
            this.gridViewUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnUsersNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUsersName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUsersRole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblUsers = new DevExpress.XtraEditors.LabelControl();
            this.TabPageDictionaries = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlDictionaries = new DevExpress.XtraGrid.GridControl();
            this.gridViewDictionary = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnDictionary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TabControlSettings)).BeginInit();
            this.TabControlSettings.SuspendLayout();
            this.TabPagePipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxSizeGrade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeManufacturersComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeSetupTabControl)).BeginInit();
            this.PipeSetupTabControl.SuspendLayout();
            this.TabPageGeneralPipeSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInsideCoating)).BeginInit();
            this.groupControlInsideCoating.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtInsideMaterial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEditInsideCoating.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtInsideAdhesion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtInsideThickness.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlOuterCoating)).BeginInit();
            this.groupControlOuterCoating.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtOuterMaterial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtOuterAdhesion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtOuterThickness.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEditOuterCoating.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditSpiral.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditWelded.Properties)).BeginInit();
            this.TabPageInspection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInspection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewInspection)).BeginInit();
            this.TabPageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsers)).BeginInit();
            this.TabPageDictionaries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDictionaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDictionary)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlSettings
            // 
            this.TabControlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControlSettings.Location = new System.Drawing.Point(0, 1);
            this.TabControlSettings.Name = "TabControlSettings";
            this.TabControlSettings.SelectedTabPage = this.TabPagePipe;
            this.TabControlSettings.Size = new System.Drawing.Size(845, 515);
            this.TabControlSettings.TabIndex = 0;
            this.TabControlSettings.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabPagePipe,
            this.TabPagePipeline,
            this.TabPageUsers,
            this.TabPageDictionaries});
            // 
            // TabPagePipe
            // 
            this.TabPagePipe.Controls.Add(this.lblSizeGrade);
            this.TabPagePipe.Controls.Add(this.lblPipeManufacturer);
            this.TabPagePipe.Controls.Add(this.ComboBoxSizeGrade);
            this.TabPagePipe.Controls.Add(this.PipeManufacturersComboBox);
            this.TabPagePipe.Controls.Add(this.PipeSetupTabControl);
            this.TabPagePipe.Controls.Add(this.lblPipeSetup);
            this.TabPagePipe.Name = "TabPagePipe";
            this.TabPagePipe.Size = new System.Drawing.Size(839, 487);
            this.TabPagePipe.Text = "Pip&e";
            // 
            // lblSizeGrade
            // 
            this.lblSizeGrade.Location = new System.Drawing.Point(473, 25);
            this.lblSizeGrade.Name = "lblSizeGrade";
            this.lblSizeGrade.Size = new System.Drawing.Size(54, 13);
            this.lblSizeGrade.TabIndex = 8;
            this.lblSizeGrade.Text = "Size grade:";
            // 
            // lblPipeManufacturer
            // 
            this.lblPipeManufacturer.Location = new System.Drawing.Point(161, 25);
            this.lblPipeManufacturer.Name = "lblPipeManufacturer";
            this.lblPipeManufacturer.Size = new System.Drawing.Size(97, 13);
            this.lblPipeManufacturer.TabIndex = 7;
            this.lblPipeManufacturer.Text = "Pipe manufacturers:";
            // 
            // ComboBoxSizeGrade
            // 
            this.ComboBoxSizeGrade.Location = new System.Drawing.Point(541, 22);
            this.ComboBoxSizeGrade.Name = "ComboBoxSizeGrade";
            this.ComboBoxSizeGrade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxSizeGrade.Size = new System.Drawing.Size(165, 20);
            this.ComboBoxSizeGrade.TabIndex = 6;
            // 
            // PipeManufacturersComboBox
            // 
            this.PipeManufacturersComboBox.Location = new System.Drawing.Point(270, 22);
            this.PipeManufacturersComboBox.Name = "PipeManufacturersComboBox";
            this.PipeManufacturersComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PipeManufacturersComboBox.Size = new System.Drawing.Size(165, 20);
            this.PipeManufacturersComboBox.TabIndex = 5;
            // 
            // PipeSetupTabControl
            // 
            this.PipeSetupTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PipeSetupTabControl.Location = new System.Drawing.Point(11, 57);
            this.PipeSetupTabControl.Name = "PipeSetupTabControl";
            this.PipeSetupTabControl.SelectedTabPage = this.TabPageGeneralPipeSetup;
            this.PipeSetupTabControl.Size = new System.Drawing.Size(820, 427);
            this.PipeSetupTabControl.TabIndex = 0;
            this.PipeSetupTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabPageGeneralPipeSetup,
            this.TabPageInspection});
            // 
            // TabPageGeneralPipeSetup
            // 
            this.TabPageGeneralPipeSetup.Controls.Add(this.groupControlInsideCoating);
            this.TabPageGeneralPipeSetup.Controls.Add(this.groupControlOuterCoating);
            this.TabPageGeneralPipeSetup.Controls.Add(this.checkEditSpiral);
            this.TabPageGeneralPipeSetup.Controls.Add(this.checkEditWelded);
            this.TabPageGeneralPipeSetup.Controls.Add(this.lblWeldType);
            this.TabPageGeneralPipeSetup.Name = "TabPageGeneralPipeSetup";
            this.TabPageGeneralPipeSetup.Size = new System.Drawing.Size(814, 399);
            this.TabPageGeneralPipeSetup.Text = "&General set up";
            // 
            // groupControlInsideCoating
            // 
            this.groupControlInsideCoating.Controls.Add(this.lblInsideMaterial);
            this.groupControlInsideCoating.Controls.Add(this.lblInsideAdhesion);
            this.groupControlInsideCoating.Controls.Add(this.lblInsideThickness);
            this.groupControlInsideCoating.Controls.Add(this.txtEdtInsideMaterial);
            this.groupControlInsideCoating.Controls.Add(this.CheckEditInsideCoating);
            this.groupControlInsideCoating.Controls.Add(this.txtEdtInsideAdhesion);
            this.groupControlInsideCoating.Controls.Add(this.txtEdtInsideThickness);
            this.groupControlInsideCoating.Location = new System.Drawing.Point(11, 154);
            this.groupControlInsideCoating.Name = "groupControlInsideCoating";
            this.groupControlInsideCoating.Size = new System.Drawing.Size(412, 115);
            this.groupControlInsideCoating.TabIndex = 8;
            // 
            // lblInsideMaterial
            // 
            this.lblInsideMaterial.Location = new System.Drawing.Point(19, 87);
            this.lblInsideMaterial.Name = "lblInsideMaterial";
            this.lblInsideMaterial.Size = new System.Drawing.Size(38, 13);
            this.lblInsideMaterial.TabIndex = 6;
            this.lblInsideMaterial.Text = "Material";
            // 
            // lblInsideAdhesion
            // 
            this.lblInsideAdhesion.Location = new System.Drawing.Point(19, 58);
            this.lblInsideAdhesion.Name = "lblInsideAdhesion";
            this.lblInsideAdhesion.Size = new System.Drawing.Size(89, 13);
            this.lblInsideAdhesion.TabIndex = 5;
            this.lblInsideAdhesion.Text = "Adhesion, kgf/cm2";
            // 
            // lblInsideThickness
            // 
            this.lblInsideThickness.Location = new System.Drawing.Point(18, 29);
            this.lblInsideThickness.Name = "lblInsideThickness";
            this.lblInsideThickness.Size = new System.Drawing.Size(69, 13);
            this.lblInsideThickness.TabIndex = 4;
            this.lblInsideThickness.Text = "Thickness, mm";
            // 
            // txtEdtInsideMaterial
            // 
            this.txtEdtInsideMaterial.Location = new System.Drawing.Point(129, 84);
            this.txtEdtInsideMaterial.Name = "txtEdtInsideMaterial";
            this.txtEdtInsideMaterial.Size = new System.Drawing.Size(273, 20);
            this.txtEdtInsideMaterial.TabIndex = 2;
            // 
            // CheckEditInsideCoating
            // 
            this.CheckEditInsideCoating.Location = new System.Drawing.Point(5, 1);
            this.CheckEditInsideCoating.Name = "CheckEditInsideCoating";
            this.CheckEditInsideCoating.Properties.Caption = "Inside coating";
            this.CheckEditInsideCoating.Size = new System.Drawing.Size(103, 19);
            this.CheckEditInsideCoating.TabIndex = 1;
            // 
            // txtEdtInsideAdhesion
            // 
            this.txtEdtInsideAdhesion.Location = new System.Drawing.Point(129, 55);
            this.txtEdtInsideAdhesion.Name = "txtEdtInsideAdhesion";
            this.txtEdtInsideAdhesion.Size = new System.Drawing.Size(100, 20);
            this.txtEdtInsideAdhesion.TabIndex = 1;
            // 
            // txtEdtInsideThickness
            // 
            this.txtEdtInsideThickness.Location = new System.Drawing.Point(129, 26);
            this.txtEdtInsideThickness.Name = "txtEdtInsideThickness";
            this.txtEdtInsideThickness.Size = new System.Drawing.Size(100, 20);
            this.txtEdtInsideThickness.TabIndex = 0;
            // 
            // groupControlOuterCoating
            // 
            this.groupControlOuterCoating.Controls.Add(this.lblOuterMaterial);
            this.groupControlOuterCoating.Controls.Add(this.lblOuterAdhesion);
            this.groupControlOuterCoating.Controls.Add(this.lblOuterThickness);
            this.groupControlOuterCoating.Controls.Add(this.txtEdtOuterMaterial);
            this.groupControlOuterCoating.Controls.Add(this.txtEdtOuterAdhesion);
            this.groupControlOuterCoating.Controls.Add(this.txtEdtOuterThickness);
            this.groupControlOuterCoating.Controls.Add(this.CheckEditOuterCoating);
            this.groupControlOuterCoating.Location = new System.Drawing.Point(11, 35);
            this.groupControlOuterCoating.Name = "groupControlOuterCoating";
            this.groupControlOuterCoating.Size = new System.Drawing.Size(412, 113);
            this.groupControlOuterCoating.TabIndex = 7;
            // 
            // lblOuterMaterial
            // 
            this.lblOuterMaterial.Location = new System.Drawing.Point(20, 92);
            this.lblOuterMaterial.Name = "lblOuterMaterial";
            this.lblOuterMaterial.Size = new System.Drawing.Size(38, 13);
            this.lblOuterMaterial.TabIndex = 11;
            this.lblOuterMaterial.Text = "Material";
            // 
            // lblOuterAdhesion
            // 
            this.lblOuterAdhesion.Location = new System.Drawing.Point(20, 63);
            this.lblOuterAdhesion.Name = "lblOuterAdhesion";
            this.lblOuterAdhesion.Size = new System.Drawing.Size(89, 13);
            this.lblOuterAdhesion.TabIndex = 10;
            this.lblOuterAdhesion.Text = "Adhesion, kgf/cm2";
            // 
            // lblOuterThickness
            // 
            this.lblOuterThickness.Location = new System.Drawing.Point(19, 34);
            this.lblOuterThickness.Name = "lblOuterThickness";
            this.lblOuterThickness.Size = new System.Drawing.Size(69, 13);
            this.lblOuterThickness.TabIndex = 9;
            this.lblOuterThickness.Text = "Thickness, mm";
            // 
            // txtEdtOuterMaterial
            // 
            this.txtEdtOuterMaterial.Location = new System.Drawing.Point(129, 86);
            this.txtEdtOuterMaterial.Name = "txtEdtOuterMaterial";
            this.txtEdtOuterMaterial.Size = new System.Drawing.Size(273, 20);
            this.txtEdtOuterMaterial.TabIndex = 8;
            // 
            // txtEdtOuterAdhesion
            // 
            this.txtEdtOuterAdhesion.Location = new System.Drawing.Point(129, 60);
            this.txtEdtOuterAdhesion.Name = "txtEdtOuterAdhesion";
            this.txtEdtOuterAdhesion.Size = new System.Drawing.Size(100, 20);
            this.txtEdtOuterAdhesion.TabIndex = 7;
            // 
            // txtEdtOuterThickness
            // 
            this.txtEdtOuterThickness.Location = new System.Drawing.Point(129, 31);
            this.txtEdtOuterThickness.Name = "txtEdtOuterThickness";
            this.txtEdtOuterThickness.Size = new System.Drawing.Size(100, 20);
            this.txtEdtOuterThickness.TabIndex = 6;
            // 
            // CheckEditOuterCoating
            // 
            this.CheckEditOuterCoating.Location = new System.Drawing.Point(5, 1);
            this.CheckEditOuterCoating.Name = "CheckEditOuterCoating";
            this.CheckEditOuterCoating.Properties.Caption = "Outer coating";
            this.CheckEditOuterCoating.Size = new System.Drawing.Size(103, 19);
            this.CheckEditOuterCoating.TabIndex = 1;
            // 
            // checkEditSpiral
            // 
            this.checkEditSpiral.Location = new System.Drawing.Point(277, 13);
            this.checkEditSpiral.Name = "checkEditSpiral";
            this.checkEditSpiral.Properties.Caption = "Spiral";
            this.checkEditSpiral.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEditSpiral.Size = new System.Drawing.Size(75, 19);
            this.checkEditSpiral.TabIndex = 6;
            // 
            // checkEditWelded
            // 
            this.checkEditWelded.Location = new System.Drawing.Point(138, 13);
            this.checkEditWelded.Name = "checkEditWelded";
            this.checkEditWelded.Properties.Caption = "Welded";
            this.checkEditWelded.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEditWelded.Size = new System.Drawing.Size(75, 19);
            this.checkEditWelded.TabIndex = 4;
            // 
            // lblWeldType
            // 
            this.lblWeldType.Location = new System.Drawing.Point(18, 16);
            this.lblWeldType.Name = "lblWeldType";
            this.lblWeldType.Size = new System.Drawing.Size(49, 13);
            this.lblWeldType.TabIndex = 3;
            this.lblWeldType.Text = "Weld type";
            // 
            // TabPageInspection
            // 
            this.TabPageInspection.Controls.Add(this.gridControlInspection);
            this.TabPageInspection.Name = "TabPageInspection";
            this.TabPageInspection.Size = new System.Drawing.Size(780, 399);
            this.TabPageInspection.Text = "&Inspection";
            // 
            // gridControlInspection
            // 
            this.gridControlInspection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlInspection.Location = new System.Drawing.Point(3, 3);
            this.gridControlInspection.MainView = this.GridViewInspection;
            this.gridControlInspection.Name = "gridControlInspection";
            this.gridControlInspection.Size = new System.Drawing.Size(774, 275);
            this.gridControlInspection.TabIndex = 0;
            this.gridControlInspection.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewInspection});
            // 
            // GridViewInspection
            // 
            this.GridViewInspection.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 6.25F, System.Drawing.FontStyle.Bold);
            this.GridViewInspection.Appearance.HeaderPanel.Options.UseFont = true;
            this.GridViewInspection.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.GridViewInspection.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridViewInspection.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.GridViewInspection.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.GridViewInspection.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.bandGridInspectionId,
            this.bandGridInspectionStage,
            this.bandGridInspectionObject,
            this.bandGridInspectionFrequency,
            this.bandGridInspectionDocument,
            this.bandGridInspectionSertification,
            this.bandGridInspection});
            this.GridViewInspection.ColumnPanelRowHeight = 1;
            this.GridViewInspection.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.ColumnNumber,
            this.ColumnStageOrInspection,
            this.ColumnResearchObject,
            this.ColumnFrequency,
            this.ColumnDocumentAndCriteria,
            this.ColumnDocumentCertification,
            this.ColumnPlant,
            this.ColumnClient,
            this.ColumnThirdPart});
            this.GridViewInspection.FixedLineWidth = 3;
            this.GridViewInspection.GridControl = this.gridControlInspection;
            this.GridViewInspection.Name = "GridViewInspection";
            // 
            // bandGridInspectionId
            // 
            this.bandGridInspectionId.Caption = "Id";
            this.bandGridInspectionId.Columns.Add(this.ColumnNumber);
            this.bandGridInspectionId.MinWidth = 54;
            this.bandGridInspectionId.Name = "bandGridInspectionId";
            this.bandGridInspectionId.OptionsBand.FixedWidth = true;
            this.bandGridInspectionId.VisibleIndex = 0;
            this.bandGridInspectionId.Width = 54;
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.Caption = "(1)";
            this.ColumnNumber.FieldName = "Id";
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.Visible = true;
            this.ColumnNumber.Width = 54;
            // 
            // bandGridInspectionStage
            // 
            this.bandGridInspectionStage.Caption = "Stage";
            this.bandGridInspectionStage.Columns.Add(this.ColumnStageOrInspection);
            this.bandGridInspectionStage.Name = "bandGridInspectionStage";
            this.bandGridInspectionStage.VisibleIndex = 1;
            this.bandGridInspectionStage.Width = 192;
            // 
            // ColumnStageOrInspection
            // 
            this.ColumnStageOrInspection.AppearanceCell.Options.UseTextOptions = true;
            this.ColumnStageOrInspection.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ColumnStageOrInspection.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnStageOrInspection.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnStageOrInspection.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ColumnStageOrInspection.AutoFillDown = true;
            this.ColumnStageOrInspection.Caption = "(2)";
            this.ColumnStageOrInspection.FieldName = "Stage";
            this.ColumnStageOrInspection.Name = "ColumnStageOrInspection";
            this.ColumnStageOrInspection.RowCount = 2;
            this.ColumnStageOrInspection.Visible = true;
            this.ColumnStageOrInspection.Width = 192;
            // 
            // bandGridInspectionObject
            // 
            this.bandGridInspectionObject.Caption = "Object";
            this.bandGridInspectionObject.Columns.Add(this.ColumnResearchObject);
            this.bandGridInspectionObject.Name = "bandGridInspectionObject";
            this.bandGridInspectionObject.VisibleIndex = 2;
            this.bandGridInspectionObject.Width = 192;
            // 
            // ColumnResearchObject
            // 
            this.ColumnResearchObject.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnResearchObject.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnResearchObject.AutoFillDown = true;
            this.ColumnResearchObject.Caption = "(3)";
            this.ColumnResearchObject.FieldName = "Object";
            this.ColumnResearchObject.Name = "ColumnResearchObject";
            this.ColumnResearchObject.RowCount = 2;
            this.ColumnResearchObject.Visible = true;
            this.ColumnResearchObject.Width = 192;
            // 
            // bandGridInspectionFrequency
            // 
            this.bandGridInspectionFrequency.Caption = "Frequency";
            this.bandGridInspectionFrequency.Columns.Add(this.ColumnFrequency);
            this.bandGridInspectionFrequency.Name = "bandGridInspectionFrequency";
            this.bandGridInspectionFrequency.VisibleIndex = 3;
            this.bandGridInspectionFrequency.Width = 192;
            // 
            // ColumnFrequency
            // 
            this.ColumnFrequency.AutoFillDown = true;
            this.ColumnFrequency.Caption = "(4)";
            this.ColumnFrequency.FieldName = "Frequency";
            this.ColumnFrequency.Name = "ColumnFrequency";
            this.ColumnFrequency.RowCount = 2;
            this.ColumnFrequency.Visible = true;
            this.ColumnFrequency.Width = 192;
            // 
            // bandGridInspectionDocument
            // 
            this.bandGridInspectionDocument.Caption = "Document";
            this.bandGridInspectionDocument.Columns.Add(this.ColumnDocumentAndCriteria);
            this.bandGridInspectionDocument.Name = "bandGridInspectionDocument";
            this.bandGridInspectionDocument.VisibleIndex = 4;
            this.bandGridInspectionDocument.Width = 192;
            // 
            // ColumnDocumentAndCriteria
            // 
            this.ColumnDocumentAndCriteria.AutoFillDown = true;
            this.ColumnDocumentAndCriteria.Caption = "(5)";
            this.ColumnDocumentAndCriteria.FieldName = "Document";
            this.ColumnDocumentAndCriteria.Name = "ColumnDocumentAndCriteria";
            this.ColumnDocumentAndCriteria.Visible = true;
            this.ColumnDocumentAndCriteria.Width = 192;
            // 
            // bandGridInspectionSertification
            // 
            this.bandGridInspectionSertification.Caption = "Serification";
            this.bandGridInspectionSertification.Columns.Add(this.ColumnDocumentCertification);
            this.bandGridInspectionSertification.Name = "bandGridInspectionSertification";
            this.bandGridInspectionSertification.VisibleIndex = 5;
            this.bandGridInspectionSertification.Width = 198;
            // 
            // ColumnDocumentCertification
            // 
            this.ColumnDocumentCertification.AutoFillDown = true;
            this.ColumnDocumentCertification.Caption = "(6)";
            this.ColumnDocumentCertification.FieldName = "Sertification";
            this.ColumnDocumentCertification.Name = "ColumnDocumentCertification";
            this.ColumnDocumentCertification.Visible = true;
            this.ColumnDocumentCertification.Width = 198;
            // 
            // bandGridInspection
            // 
            this.bandGridInspection.AppearanceHeader.Options.UseTextOptions = true;
            this.bandGridInspection.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandGridInspection.Caption = "Inspection";
            this.bandGridInspection.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.bandGridInspectionPlant,
            this.bandGridInspectionCustomer,
            this.bandGridInspectionOther});
            this.bandGridInspection.Name = "bandGridInspection";
            this.bandGridInspection.VisibleIndex = 6;
            this.bandGridInspection.Width = 564;
            // 
            // bandGridInspectionPlant
            // 
            this.bandGridInspectionPlant.Caption = "Plant";
            this.bandGridInspectionPlant.Columns.Add(this.ColumnPlant);
            this.bandGridInspectionPlant.Name = "bandGridInspectionPlant";
            this.bandGridInspectionPlant.VisibleIndex = 0;
            this.bandGridInspectionPlant.Width = 185;
            // 
            // ColumnPlant
            // 
            this.ColumnPlant.AutoFillDown = true;
            this.ColumnPlant.Caption = "(7)";
            this.ColumnPlant.FieldName = "InspectionPlant";
            this.ColumnPlant.Name = "ColumnPlant";
            this.ColumnPlant.Visible = true;
            this.ColumnPlant.Width = 185;
            // 
            // bandGridInspectionCustomer
            // 
            this.bandGridInspectionCustomer.Caption = "Customer";
            this.bandGridInspectionCustomer.Columns.Add(this.ColumnClient);
            this.bandGridInspectionCustomer.Name = "bandGridInspectionCustomer";
            this.bandGridInspectionCustomer.VisibleIndex = 1;
            this.bandGridInspectionCustomer.Width = 185;
            // 
            // ColumnClient
            // 
            this.ColumnClient.AutoFillDown = true;
            this.ColumnClient.Caption = "(8)";
            this.ColumnClient.FieldName = "InspectionCustomer";
            this.ColumnClient.Name = "ColumnClient";
            this.ColumnClient.Visible = true;
            this.ColumnClient.Width = 185;
            // 
            // bandGridInspectionOther
            // 
            this.bandGridInspectionOther.Caption = "Other";
            this.bandGridInspectionOther.Columns.Add(this.ColumnThirdPart);
            this.bandGridInspectionOther.Name = "bandGridInspectionOther";
            this.bandGridInspectionOther.VisibleIndex = 2;
            this.bandGridInspectionOther.Width = 194;
            // 
            // ColumnThirdPart
            // 
            this.ColumnThirdPart.AutoFillDown = true;
            this.ColumnThirdPart.Caption = "(9)";
            this.ColumnThirdPart.FieldName = "InspectionOther";
            this.ColumnThirdPart.Name = "ColumnThirdPart";
            this.ColumnThirdPart.Visible = true;
            this.ColumnThirdPart.Width = 194;
            // 
            // lblPipeSetup
            // 
            this.lblPipeSetup.Location = new System.Drawing.Point(15, 25);
            this.lblPipeSetup.Name = "lblPipeSetup";
            this.lblPipeSetup.Size = new System.Drawing.Size(101, 13);
            this.lblPipeSetup.TabIndex = 4;
            this.lblPipeSetup.Text = "Set pipe parameters:";
            // 
            // TabPagePipeline
            // 
            this.TabPagePipeline.Name = "TabPagePipeline";
            this.TabPagePipeline.Size = new System.Drawing.Size(839, 487);
            this.TabPagePipeline.Text = "Pipe&line";
            // 
            // TabPageUsers
            // 
            this.TabPageUsers.Controls.Add(this.gridControlUsers);
            this.TabPageUsers.Controls.Add(this.lblUsers);
            this.TabPageUsers.Name = "TabPageUsers";
            this.TabPageUsers.Size = new System.Drawing.Size(839, 487);
            this.TabPageUsers.Text = "&Users";
            // 
            // gridControlUsers
            // 
            this.gridControlUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlUsers.Location = new System.Drawing.Point(31, 56);
            this.gridControlUsers.MainView = this.gridViewUsers;
            this.gridControlUsers.Name = "gridControlUsers";
            this.gridControlUsers.Size = new System.Drawing.Size(620, 256);
            this.gridControlUsers.TabIndex = 1;
            this.gridControlUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUsers});
            // 
            // gridViewUsers
            // 
            this.gridViewUsers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnUsersNo,
            this.gridColumnUsersName,
            this.gridColumnUsersRole});
            this.gridViewUsers.GridControl = this.gridControlUsers;
            this.gridViewUsers.Name = "gridViewUsers";
            // 
            // gridColumnUsersNo
            // 
            this.gridColumnUsersNo.Caption = "№";
            this.gridColumnUsersNo.Name = "gridColumnUsersNo";
            this.gridColumnUsersNo.Visible = true;
            this.gridColumnUsersNo.VisibleIndex = 0;
            // 
            // gridColumnUsersName
            // 
            this.gridColumnUsersName.Caption = "User full name";
            this.gridColumnUsersName.Name = "gridColumnUsersName";
            this.gridColumnUsersName.Visible = true;
            this.gridColumnUsersName.VisibleIndex = 1;
            // 
            // gridColumnUsersRole
            // 
            this.gridColumnUsersRole.Caption = "Role";
            this.gridColumnUsersRole.Name = "gridColumnUsersRole";
            this.gridColumnUsersRole.Visible = true;
            this.gridColumnUsersRole.VisibleIndex = 2;
            // 
            // lblUsers
            // 
            this.lblUsers.Location = new System.Drawing.Point(31, 27);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(27, 13);
            this.lblUsers.TabIndex = 0;
            this.lblUsers.Text = "Users";
            // 
            // TabPageDictionaries
            // 
            this.TabPageDictionaries.Controls.Add(this.gridControlDictionaries);
            this.TabPageDictionaries.Name = "TabPageDictionaries";
            this.TabPageDictionaries.Size = new System.Drawing.Size(839, 487);
            this.TabPageDictionaries.Text = "&Dictionaries";
            // 
            // gridControlDictionaries
            // 
            this.gridControlDictionaries.Location = new System.Drawing.Point(32, 30);
            this.gridControlDictionaries.MainView = this.gridViewDictionary;
            this.gridControlDictionaries.Name = "gridControlDictionaries";
            this.gridControlDictionaries.Size = new System.Drawing.Size(367, 440);
            this.gridControlDictionaries.TabIndex = 0;
            this.gridControlDictionaries.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDictionary});
            // 
            // gridViewDictionary
            // 
            this.gridViewDictionary.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnDictionary});
            this.gridViewDictionary.GridControl = this.gridControlDictionaries;
            this.gridViewDictionary.Name = "gridViewDictionary";
            // 
            // gridColumnDictionary
            // 
            this.gridColumnDictionary.Caption = "Dictionary";
            this.gridColumnDictionary.Name = "gridColumnDictionary";
            this.gridColumnDictionary.Visible = true;
            this.gridColumnDictionary.VisibleIndex = 0;
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            // 
            // SettingsXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 528);
            this.ControlBox = false;
            this.Controls.Add(this.TabControlSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsXtraForm";
            this.Text = "SettingsXtraForm";
            ((System.ComponentModel.ISupportInitialize)(this.TabControlSettings)).EndInit();
            this.TabControlSettings.ResumeLayout(false);
            this.TabPagePipe.ResumeLayout(false);
            this.TabPagePipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxSizeGrade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeManufacturersComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeSetupTabControl)).EndInit();
            this.PipeSetupTabControl.ResumeLayout(false);
            this.TabPageGeneralPipeSetup.ResumeLayout(false);
            this.TabPageGeneralPipeSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInsideCoating)).EndInit();
            this.groupControlInsideCoating.ResumeLayout(false);
            this.groupControlInsideCoating.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtInsideMaterial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEditInsideCoating.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtInsideAdhesion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtInsideThickness.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlOuterCoating)).EndInit();
            this.groupControlOuterCoating.ResumeLayout(false);
            this.groupControlOuterCoating.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtOuterMaterial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtOuterAdhesion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtOuterThickness.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEditOuterCoating.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditSpiral.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditWelded.Properties)).EndInit();
            this.TabPageInspection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInspection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewInspection)).EndInit();
            this.TabPageUsers.ResumeLayout(false);
            this.TabPageUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsers)).EndInit();
            this.TabPageDictionaries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDictionaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDictionary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl TabControlSettings;
        private DevExpress.XtraTab.XtraTabPage TabPagePipe;
        private DevExpress.XtraTab.XtraTabPage TabPagePipeline;
        private DevExpress.XtraTab.XtraTabControl PipeSetupTabControl;
        private DevExpress.XtraTab.XtraTabPage TabPageGeneralPipeSetup;
        private DevExpress.XtraTab.XtraTabPage TabPageInspection;
        private DevExpress.XtraEditors.CheckEdit checkEditWelded;
        private DevExpress.XtraEditors.LabelControl lblWeldType;
        private DevExpress.XtraEditors.LabelControl lblPipeSetup;
        private DevExpress.XtraEditors.ComboBoxEdit ComboBoxSizeGrade;
        private DevExpress.XtraEditors.ComboBoxEdit PipeManufacturersComboBox;
        private DevExpress.XtraEditors.CheckEdit checkEditSpiral;
        private DevExpress.XtraEditors.LabelControl lblSizeGrade;
        private DevExpress.XtraEditors.LabelControl lblPipeManufacturer;
        private DevExpress.XtraEditors.GroupControl groupControlInsideCoating;
        private DevExpress.XtraEditors.LabelControl lblInsideMaterial;
        private DevExpress.XtraEditors.LabelControl lblInsideAdhesion;
        private DevExpress.XtraEditors.LabelControl lblInsideThickness;
        private DevExpress.XtraEditors.TextEdit txtEdtInsideMaterial;
        private DevExpress.XtraEditors.CheckEdit CheckEditInsideCoating;
        private DevExpress.XtraEditors.TextEdit txtEdtInsideAdhesion;
        private DevExpress.XtraEditors.TextEdit txtEdtInsideThickness;
        private DevExpress.XtraEditors.GroupControl groupControlOuterCoating;
        private DevExpress.XtraEditors.LabelControl lblOuterMaterial;
        private DevExpress.XtraEditors.LabelControl lblOuterAdhesion;
        private DevExpress.XtraEditors.LabelControl lblOuterThickness;
        private DevExpress.XtraEditors.TextEdit txtEdtOuterMaterial;
        private DevExpress.XtraEditors.TextEdit txtEdtOuterAdhesion;
        private DevExpress.XtraEditors.TextEdit txtEdtOuterThickness;
        private DevExpress.XtraEditors.CheckEdit CheckEditOuterCoating;

        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;

        private DevExpress.XtraGrid.GridControl gridControlInspection;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView GridViewInspection;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnStageOrInspection;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnResearchObject;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnFrequency;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnDocumentAndCriteria;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnNumber;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnDocumentCertification;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnPlant;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnClient;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnThirdPart;
        private DevExpress.XtraTab.XtraTabPage TabPageUsers;
        private DevExpress.XtraTab.XtraTabPage TabPageDictionaries;
        private DevExpress.XtraGrid.GridControl gridControlUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUsers;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUsersNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUsersName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUsersRole;
        private DevExpress.XtraEditors.LabelControl lblUsers;
        private DevExpress.XtraGrid.GridControl gridControlDictionaries;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDictionary;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDictionary;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandGridInspectionId;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandGridInspectionStage;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandGridInspectionObject;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandGridInspectionFrequency;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandGridInspectionDocument;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandGridInspectionSertification;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandGridInspection;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandGridInspectionPlant;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandGridInspectionCustomer;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandGridInspectionOther;
    }
}