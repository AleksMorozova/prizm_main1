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
            this.searchParametersGroup = new DevExpress.XtraEditors.GroupControl();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.certificateLable = new DevExpress.XtraEditors.LabelControl();
            this.componentTypeLable = new DevExpress.XtraEditors.LabelControl();
            this.componentNumberLabel = new DevExpress.XtraEditors.LabelControl();
            this.certificateNumber = new DevExpress.XtraEditors.TextEdit();
            this.type = new DevExpress.XtraEditors.TextEdit();
            this.componentNumber = new DevExpress.XtraEditors.TextEdit();
            this.searchResultsGroup = new DevExpress.XtraEditors.GroupControl();
            this.searchResultGrid = new DevExpress.XtraGrid.GridControl();
            this.searchResultGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.componentParameters = new DevExpress.XtraGrid.GridControl();
            this.componentParametersView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.boreDiameterGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.wallThicknessGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectionDateLable = new DevExpress.XtraEditors.LabelControl();
            this.inspectorLabel = new DevExpress.XtraEditors.LabelControl();
            this.resultLabel = new DevExpress.XtraEditors.LabelControl();
            this.inspector = new DevExpress.XtraEditors.TextEdit();
            this.inspectionDate = new DevExpress.XtraEditors.TextEdit();
            this.result = new DevExpress.XtraEditors.TextEdit();
            this.componentNumberColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.typeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.certificateNumberColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectionResultColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectorColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inspectionDateColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.searchParametersGroup)).BeginInit();
            this.searchParametersGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsGroup)).BeginInit();
            this.searchResultsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentParameters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentParametersView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspector.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.result.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // searchParametersGroup
            // 
            this.searchParametersGroup.Controls.Add(this.searchButton);
            this.searchParametersGroup.Controls.Add(this.certificateLable);
            this.searchParametersGroup.Controls.Add(this.componentTypeLable);
            this.searchParametersGroup.Controls.Add(this.componentNumberLabel);
            this.searchParametersGroup.Controls.Add(this.certificateNumber);
            this.searchParametersGroup.Controls.Add(this.type);
            this.searchParametersGroup.Controls.Add(this.componentNumber);
            this.searchParametersGroup.Location = new System.Drawing.Point(13, 12);
            this.searchParametersGroup.Name = "searchParametersGroup";
            this.searchParametersGroup.Size = new System.Drawing.Size(700, 74);
            this.searchParametersGroup.TabIndex = 0;
            this.searchParametersGroup.Text = "Search parameters";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(620, 46);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            // 
            // certificateLable
            // 
            this.certificateLable.Location = new System.Drawing.Point(363, 30);
            this.certificateLable.Name = "certificateLable";
            this.certificateLable.Size = new System.Drawing.Size(89, 13);
            this.certificateLable.TabIndex = 5;
            this.certificateLable.Text = "Certificate number";
            // 
            // componentTypeLable
            // 
            this.componentTypeLable.Location = new System.Drawing.Point(184, 30);
            this.componentTypeLable.Name = "componentTypeLable";
            this.componentTypeLable.Size = new System.Drawing.Size(24, 13);
            this.componentTypeLable.TabIndex = 4;
            this.componentTypeLable.Text = "Type";
            // 
            // componentNumberLabel
            // 
            this.componentNumberLabel.Location = new System.Drawing.Point(5, 30);
            this.componentNumberLabel.Name = "componentNumberLabel";
            this.componentNumberLabel.Size = new System.Drawing.Size(94, 13);
            this.componentNumberLabel.TabIndex = 3;
            this.componentNumberLabel.Text = "Component number";
            // 
            // certificateNumber
            // 
            this.certificateNumber.Location = new System.Drawing.Point(363, 49);
            this.certificateNumber.Name = "certificateNumber";
            this.certificateNumber.Size = new System.Drawing.Size(150, 20);
            this.certificateNumber.TabIndex = 2;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(184, 49);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(150, 20);
            this.type.TabIndex = 1;
            // 
            // componentNumber
            // 
            this.componentNumber.Location = new System.Drawing.Point(5, 49);
            this.componentNumber.Name = "componentNumber";
            this.componentNumber.Size = new System.Drawing.Size(150, 20);
            this.componentNumber.TabIndex = 0;
            // 
            // searchResultsGroup
            // 
            this.searchResultsGroup.Controls.Add(this.searchResultGrid);
            this.searchResultsGroup.Controls.Add(this.componentParameters);
            this.searchResultsGroup.Controls.Add(this.inspectionDateLable);
            this.searchResultsGroup.Controls.Add(this.inspectorLabel);
            this.searchResultsGroup.Controls.Add(this.resultLabel);
            this.searchResultsGroup.Controls.Add(this.inspector);
            this.searchResultsGroup.Controls.Add(this.inspectionDate);
            this.searchResultsGroup.Controls.Add(this.result);
            this.searchResultsGroup.Location = new System.Drawing.Point(12, 92);
            this.searchResultsGroup.Name = "searchResultsGroup";
            this.searchResultsGroup.Size = new System.Drawing.Size(701, 321);
            this.searchResultsGroup.TabIndex = 1;
            this.searchResultsGroup.Text = "Search results";
            // 
            // searchResultGrid
            // 
            this.searchResultGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.searchResultGrid.Location = new System.Drawing.Point(6, 154);
            this.searchResultGrid.MainView = this.searchResultGridView;
            this.searchResultGrid.Name = "searchResultGrid";
            this.searchResultGrid.Size = new System.Drawing.Size(689, 162);
            this.searchResultGrid.TabIndex = 6;
            this.searchResultGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.searchResultGridView});
            // 
            // searchResultGridView
            // 
            this.searchResultGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.componentNumberColumn,
            this.typeColumn,
            this.certificateNumberColumn,
            this.inspectionResultColumn,
            this.inspectorColumn,
            this.inspectionDateColumn});
            this.searchResultGridView.GridControl = this.searchResultGrid;
            this.searchResultGridView.Name = "searchResultGridView";
            // 
            // componentParameters
            // 
            this.componentParameters.Cursor = System.Windows.Forms.Cursors.Default;
            this.componentParameters.Location = new System.Drawing.Point(364, 25);
            this.componentParameters.MainView = this.componentParametersView;
            this.componentParameters.Name = "componentParameters";
            this.componentParameters.Size = new System.Drawing.Size(332, 122);
            this.componentParameters.TabIndex = 4;
            this.componentParameters.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.componentParametersView});
            // 
            // componentParametersView
            // 
            this.componentParametersView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.boreDiameterGridColumn,
            this.wallThicknessGridColumn});
            this.componentParametersView.GridControl = this.componentParameters;
            this.componentParametersView.Name = "componentParametersView";
            // 
            // boreDiameterGridColumn
            // 
            this.boreDiameterGridColumn.Caption = "Bore diameter";
            this.boreDiameterGridColumn.Name = "boreDiameterGridColumn";
            this.boreDiameterGridColumn.Visible = true;
            this.boreDiameterGridColumn.VisibleIndex = 0;
            // 
            // wallThicknessGridColumn
            // 
            this.wallThicknessGridColumn.Caption = "Wall thickness";
            this.wallThicknessGridColumn.Name = "wallThicknessGridColumn";
            this.wallThicknessGridColumn.Visible = true;
            this.wallThicknessGridColumn.VisibleIndex = 1;
            // 
            // inspectionDateLable
            // 
            this.inspectionDateLable.Location = new System.Drawing.Point(6, 89);
            this.inspectionDateLable.Name = "inspectionDateLable";
            this.inspectionDateLable.Size = new System.Drawing.Size(75, 13);
            this.inspectionDateLable.TabIndex = 5;
            this.inspectionDateLable.Text = "Inspection date";
            // 
            // inspectorLabel
            // 
            this.inspectorLabel.Location = new System.Drawing.Point(185, 33);
            this.inspectorLabel.Name = "inspectorLabel";
            this.inspectorLabel.Size = new System.Drawing.Size(46, 13);
            this.inspectorLabel.TabIndex = 4;
            this.inspectorLabel.Text = "Inspector";
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(6, 34);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(80, 13);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "Inspection result";
            // 
            // inspector
            // 
            this.inspector.Location = new System.Drawing.Point(185, 53);
            this.inspector.Name = "inspector";
            this.inspector.Size = new System.Drawing.Size(150, 20);
            this.inspector.TabIndex = 1;
            // 
            // inspectionDate
            // 
            this.inspectionDate.Location = new System.Drawing.Point(6, 108);
            this.inspectionDate.Name = "inspectionDate";
            this.inspectionDate.Size = new System.Drawing.Size(150, 20);
            this.inspectionDate.TabIndex = 2;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(6, 53);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(150, 20);
            this.result.TabIndex = 0;
            // 
            // componentNumberColumn
            // 
            this.componentNumberColumn.Caption = "Component number";
            this.componentNumberColumn.Name = "componentNumberColumn";
            this.componentNumberColumn.Visible = true;
            this.componentNumberColumn.VisibleIndex = 0;
            // 
            // typeColumn
            // 
            this.typeColumn.Caption = "Type";
            this.typeColumn.Name = "typeColumn";
            this.typeColumn.Visible = true;
            this.typeColumn.VisibleIndex = 1;
            // 
            // certificateNumberColumn
            // 
            this.certificateNumberColumn.Caption = "Certificate number";
            this.certificateNumberColumn.Name = "certificateNumberColumn";
            this.certificateNumberColumn.Visible = true;
            this.certificateNumberColumn.VisibleIndex = 2;
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
            // ComponentSearchXtraForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsGroup)).EndInit();
            this.searchResultsGroup.ResumeLayout(false);
            this.searchResultsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentParameters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentParametersView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspector.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.result.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl searchParametersGroup;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraEditors.LabelControl certificateLable;
        private DevExpress.XtraEditors.LabelControl componentTypeLable;
        private DevExpress.XtraEditors.LabelControl componentNumberLabel;
        private DevExpress.XtraEditors.TextEdit certificateNumber;
        private DevExpress.XtraEditors.TextEdit type;
        private DevExpress.XtraEditors.TextEdit componentNumber;
        private DevExpress.XtraEditors.GroupControl searchResultsGroup;
        private DevExpress.XtraEditors.TextEdit inspector;
        private DevExpress.XtraEditors.TextEdit inspectionDate;
        private DevExpress.XtraEditors.TextEdit result;
        private DevExpress.XtraGrid.GridControl componentParameters;
        private DevExpress.XtraGrid.Views.Grid.GridView componentParametersView;
        private DevExpress.XtraEditors.LabelControl inspectionDateLable;
        private DevExpress.XtraEditors.LabelControl inspectorLabel;
        private DevExpress.XtraEditors.LabelControl resultLabel;
        private DevExpress.XtraGrid.GridControl searchResultGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView searchResultGridView;
        private DevExpress.XtraGrid.Columns.GridColumn boreDiameterGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn wallThicknessGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn componentNumberColumn;
        private DevExpress.XtraGrid.Columns.GridColumn typeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn certificateNumberColumn;
        private DevExpress.XtraGrid.Columns.GridColumn inspectionResultColumn;
        private DevExpress.XtraGrid.Columns.GridColumn inspectorColumn;
        private DevExpress.XtraGrid.Columns.GridColumn inspectionDateColumn;

    }
}