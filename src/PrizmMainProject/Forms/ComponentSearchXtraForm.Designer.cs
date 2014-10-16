namespace PrizmMain.Forms
{
    partial class ComponentSearchXtraForm
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.searchParametersGroup = new DevExpress.XtraEditors.GroupControl();
            this.certificateLabel = new DevExpress.XtraEditors.LabelControl();
            this.TypeLabel = new DevExpress.XtraEditors.LabelControl();
            this.componentNumberLabel = new DevExpress.XtraEditors.LabelControl();
            this.searchComponentryButton = new DevExpress.XtraEditors.SimpleButton();
            this.certificate = new DevExpress.XtraEditors.TextEdit();
            this.componentType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.componentNumber = new DevExpress.XtraEditors.TextEdit();
            this.searchResultsGroup = new DevExpress.XtraEditors.GroupControl();
            this.searchResultsGrid = new DevExpress.XtraGrid.GridControl();
            this.searchResultsView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.componentNumberColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.componentTypeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.certificateColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectionResultColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectorColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectionDateColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diameterThicknessSubGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.diameterColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.thicknessColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.searchParametersGroup)).BeginInit();
            this.searchParametersGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.certificate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsGroup)).BeginInit();
            this.searchResultsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diameterThicknessSubGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // searchParametersGroup
            // 
            this.searchParametersGroup.Controls.Add(this.certificateLabel);
            this.searchParametersGroup.Controls.Add(this.TypeLabel);
            this.searchParametersGroup.Controls.Add(this.componentNumberLabel);
            this.searchParametersGroup.Controls.Add(this.searchComponentryButton);
            this.searchParametersGroup.Controls.Add(this.certificate);
            this.searchParametersGroup.Controls.Add(this.componentType);
            this.searchParametersGroup.Controls.Add(this.componentNumber);
            this.searchParametersGroup.Location = new System.Drawing.Point(13, 13);
            this.searchParametersGroup.Name = "searchParametersGroup";
            this.searchParametersGroup.Size = new System.Drawing.Size(700, 75);
            this.searchParametersGroup.TabIndex = 0;
            this.searchParametersGroup.Text = "Search parameters";
            // 
            // certificateLabel
            // 
            this.certificateLabel.Location = new System.Drawing.Point(378, 30);
            this.certificateLabel.Name = "certificateLabel";
            this.certificateLabel.Size = new System.Drawing.Size(50, 13);
            this.certificateLabel.TabIndex = 6;
            this.certificateLabel.Text = "Certificate";
            // 
            // TypeLabel
            // 
            this.TypeLabel.Location = new System.Drawing.Point(192, 30);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(24, 13);
            this.TypeLabel.TabIndex = 5;
            this.TypeLabel.Text = "Type";
            // 
            // componentNumberLabel
            // 
            this.componentNumberLabel.Location = new System.Drawing.Point(6, 30);
            this.componentNumberLabel.Name = "componentNumberLabel";
            this.componentNumberLabel.Size = new System.Drawing.Size(94, 13);
            this.componentNumberLabel.TabIndex = 4;
            this.componentNumberLabel.Text = "Component number";
            // 
            // searchComponentryButton
            // 
            this.searchComponentryButton.Location = new System.Drawing.Point(620, 47);
            this.searchComponentryButton.Name = "searchComponentryButton";
            this.searchComponentryButton.Size = new System.Drawing.Size(75, 23);
            this.searchComponentryButton.TabIndex = 3;
            this.searchComponentryButton.Text = "Search";
            // 
            // certificate
            // 
            this.certificate.Location = new System.Drawing.Point(378, 50);
            this.certificate.Name = "certificate";
            this.certificate.Size = new System.Drawing.Size(136, 20);
            this.certificate.TabIndex = 2;
            // 
            // componentType
            // 
            this.componentType.Location = new System.Drawing.Point(192, 50);
            this.componentType.Name = "componentType";
            this.componentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.componentType.Size = new System.Drawing.Size(136, 20);
            this.componentType.TabIndex = 1;
            // 
            // componentNumber
            // 
            this.componentNumber.Location = new System.Drawing.Point(6, 50);
            this.componentNumber.Name = "componentNumber";
            this.componentNumber.Size = new System.Drawing.Size(136, 20);
            this.componentNumber.TabIndex = 0;
            // 
            // searchResultsGroup
            // 
            this.searchResultsGroup.Controls.Add(this.searchResultsGrid);
            this.searchResultsGroup.Location = new System.Drawing.Point(12, 94);
            this.searchResultsGroup.Name = "searchResultsGroup";
            this.searchResultsGroup.Size = new System.Drawing.Size(701, 319);
            this.searchResultsGroup.TabIndex = 1;
            this.searchResultsGroup.Text = "Search results";
            // 
            // searchResultsGrid
            // 
            this.searchResultsGrid.Cursor = System.Windows.Forms.Cursors.Default;
            gridLevelNode1.LevelTemplate = this.diameterThicknessSubGrid;
            gridLevelNode1.RelationName = "diameterThicknessGrid";
            this.searchResultsGrid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.searchResultsGrid.Location = new System.Drawing.Point(7, 24);
            this.searchResultsGrid.MainView = this.searchResultsView;
            this.searchResultsGrid.Name = "searchResultsGrid";
            this.searchResultsGrid.Size = new System.Drawing.Size(689, 290);
            this.searchResultsGrid.TabIndex = 7;
            this.searchResultsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.searchResultsView,
            this.diameterThicknessSubGrid});
            // 
            // searchResultsView
            // 
            this.searchResultsView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.componentNumberColumn,
            this.componentTypeColumn,
            this.certificateColumn,
            this.inspectionResultColumn,
            this.inspectorColumn,
            this.inspectionDateColumn});
            this.searchResultsView.GridControl = this.searchResultsGrid;
            this.searchResultsView.Name = "searchResultsView";
            // 
            // componentNumberColumn
            // 
            this.componentNumberColumn.Caption = "Number";
            this.componentNumberColumn.Name = "componentNumberColumn";
            this.componentNumberColumn.Visible = true;
            this.componentNumberColumn.VisibleIndex = 0;
            // 
            // componentTypeColumn
            // 
            this.componentTypeColumn.Caption = "Type";
            this.componentTypeColumn.Name = "componentTypeColumn";
            this.componentTypeColumn.Visible = true;
            this.componentTypeColumn.VisibleIndex = 1;
            // 
            // certificateColumn
            // 
            this.certificateColumn.Caption = "Certificate";
            this.certificateColumn.Name = "certificateColumn";
            this.certificateColumn.Visible = true;
            this.certificateColumn.VisibleIndex = 2;
            // 
            // inspectionResultColumn
            // 
            this.inspectionResultColumn.Caption = "Inspection result";
            this.inspectionResultColumn.Name = "inspectionResultColumn";
            this.inspectionResultColumn.Visible = true;
            this.inspectionResultColumn.VisibleIndex = 3;
            // 
            // inspectorColumn
            // 
            this.inspectorColumn.Caption = "Inspector";
            this.inspectorColumn.Name = "inspectorColumn";
            this.inspectorColumn.Visible = true;
            this.inspectorColumn.VisibleIndex = 4;
            // 
            // inspectionDateColumn
            // 
            this.inspectionDateColumn.Caption = "Inspection date";
            this.inspectionDateColumn.Name = "inspectionDateColumn";
            this.inspectionDateColumn.Visible = true;
            this.inspectionDateColumn.VisibleIndex = 5;
            // 
            // diameterThicknessSubGrid
            // 
            this.diameterThicknessSubGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.diameterColumn,
            this.thicknessColumn});
            this.diameterThicknessSubGrid.GridControl = this.searchResultsGrid;
            this.diameterThicknessSubGrid.Name = "diameterThicknessSubGrid";
            // 
            // diameterColumn
            // 
            this.diameterColumn.Caption = "Bore diameter";
            this.diameterColumn.Name = "diameterColumn";
            this.diameterColumn.Visible = true;
            this.diameterColumn.VisibleIndex = 0;
            // 
            // thicknessColumn
            // 
            this.thicknessColumn.Caption = "Wall thickness";
            this.thicknessColumn.Name = "thicknessColumn";
            this.thicknessColumn.Visible = true;
            this.thicknessColumn.VisibleIndex = 1;
            // 
            // ComponentSearchXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 425);
            this.Controls.Add(this.searchResultsGroup);
            this.Controls.Add(this.searchParametersGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComponentSearchXtraForm";
            this.Text = "ComponentSearchXtraForm";
            ((System.ComponentModel.ISupportInitialize)(this.searchParametersGroup)).EndInit();
            this.searchParametersGroup.ResumeLayout(false);
            this.searchParametersGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.certificate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsGroup)).EndInit();
            this.searchResultsGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diameterThicknessSubGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl searchParametersGroup;
        private DevExpress.XtraEditors.SimpleButton searchComponentryButton;
        private DevExpress.XtraEditors.TextEdit certificate;
        private DevExpress.XtraEditors.ComboBoxEdit componentType;
        private DevExpress.XtraEditors.TextEdit componentNumber;
        private DevExpress.XtraEditors.GroupControl searchResultsGroup;
        private DevExpress.XtraEditors.LabelControl certificateLabel;
        private DevExpress.XtraEditors.LabelControl TypeLabel;
        private DevExpress.XtraEditors.LabelControl componentNumberLabel;
        private DevExpress.XtraGrid.GridControl searchResultsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView searchResultsView;
        private DevExpress.XtraGrid.Columns.GridColumn componentNumberColumn;
        private DevExpress.XtraGrid.Columns.GridColumn componentTypeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn certificateColumn;
        private DevExpress.XtraGrid.Columns.GridColumn inspectionResultColumn;
        private DevExpress.XtraGrid.Columns.GridColumn inspectorColumn;
        private DevExpress.XtraGrid.Columns.GridColumn inspectionDateColumn;
        private DevExpress.XtraGrid.Views.Grid.GridView diameterThicknessSubGrid;
        private DevExpress.XtraGrid.Columns.GridColumn diameterColumn;
        private DevExpress.XtraGrid.Columns.GridColumn thicknessColumn;
    }
}