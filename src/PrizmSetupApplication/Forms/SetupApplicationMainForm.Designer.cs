namespace PrizmSetupApplication.Forms
{
    partial class SetupApplicationMainForm
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
            this.designLabel = new DevExpress.XtraEditors.LabelControl();
            this.clientLabel = new DevExpress.XtraEditors.LabelControl();
            this.design = new DevExpress.XtraEditors.TextEdit();
            this.client = new DevExpress.XtraEditors.TextEdit();
            this.splitContainer = new DevExpress.XtraEditors.SplitContainerControl();
            this.plateManufacturersList = new DevExpress.XtraGrid.GridControl();
            this.plateManufacturersListView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.plateManufacturerGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.plateManufacturersLabel = new DevExpress.XtraEditors.LabelControl();
            this.pipeManufacturersList = new DevExpress.XtraGrid.GridControl();
            this.pipeManufacturerListView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pipeManufacturerGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pipeSizeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pipeSizeItem = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.pipeManufacturersLabel = new DevExpress.XtraEditors.LabelControl();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.oKButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.design.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeManufacturersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeManufacturerListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSizeItem)).BeginInit();
            this.SuspendLayout();
            // 
            // designLabel
            // 
            this.designLabel.Location = new System.Drawing.Point(29, 63);
            this.designLabel.Name = "designLabel";
            this.designLabel.Size = new System.Drawing.Size(42, 13);
            this.designLabel.TabIndex = 7;
            this.designLabel.Text = "Designer";
            // 
            // clientLabel
            // 
            this.clientLabel.Location = new System.Drawing.Point(29, 27);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(27, 13);
            this.clientLabel.TabIndex = 6;
            this.clientLabel.Text = "Client";
            // 
            // design
            // 
            this.design.Location = new System.Drawing.Point(143, 56);
            this.design.Name = "design";
            this.design.Size = new System.Drawing.Size(251, 20);
            this.design.TabIndex = 5;
            // 
            // client
            // 
            this.client.Location = new System.Drawing.Point(143, 20);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(251, 20);
            this.client.TabIndex = 4;
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splitContainer.Location = new System.Drawing.Point(29, 98);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Panel1.Controls.Add(this.plateManufacturersList);
            this.splitContainer.Panel1.Controls.Add(this.plateManufacturersLabel);
            this.splitContainer.Panel1.Text = "PlatePanel";
            this.splitContainer.Panel2.Controls.Add(this.pipeManufacturersList);
            this.splitContainer.Panel2.Controls.Add(this.pipeManufacturersLabel);
            this.splitContainer.Panel2.Text = "PipePanel";
            this.splitContainer.Size = new System.Drawing.Size(632, 306);
            this.splitContainer.SplitterPosition = 316;
            this.splitContainer.TabIndex = 8;
            this.splitContainer.Text = "splitContainerControl1";
            // 
            // plateManufacturersList
            // 
            this.plateManufacturersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plateManufacturersList.Cursor = System.Windows.Forms.Cursors.Default;
            this.plateManufacturersList.Location = new System.Drawing.Point(3, 57);
            this.plateManufacturersList.MainView = this.plateManufacturersListView;
            this.plateManufacturersList.Name = "plateManufacturersList";
            this.plateManufacturersList.Size = new System.Drawing.Size(302, 241);
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
            // 
            // plateManufacturerGridColumn
            // 
            this.plateManufacturerGridColumn.Caption = "Manufacture";
            this.plateManufacturerGridColumn.Name = "plateManufacturerGridColumn";
            this.plateManufacturerGridColumn.Visible = true;
            this.plateManufacturerGridColumn.VisibleIndex = 0;
            // 
            // plateManufacturersLabel
            // 
            this.plateManufacturersLabel.Location = new System.Drawing.Point(3, 20);
            this.plateManufacturersLabel.Name = "plateManufacturersLabel";
            this.plateManufacturersLabel.Size = new System.Drawing.Size(97, 13);
            this.plateManufacturersLabel.TabIndex = 9;
            this.plateManufacturersLabel.Text = "Plate manufacturers";
            // 
            // pipeManufacturersList
            // 
            this.pipeManufacturersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pipeManufacturersList.Cursor = System.Windows.Forms.Cursors.Default;
            this.pipeManufacturersList.Location = new System.Drawing.Point(8, 57);
            this.pipeManufacturersList.MainView = this.pipeManufacturerListView;
            this.pipeManufacturersList.Name = "pipeManufacturersList";
            this.pipeManufacturersList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.pipeSizeItem});
            this.pipeManufacturersList.Size = new System.Drawing.Size(302, 241);
            this.pipeManufacturersList.TabIndex = 11;
            this.pipeManufacturersList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.pipeManufacturerListView});
            // 
            // pipeManufacturerListView
            // 
            this.pipeManufacturerListView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.pipeManufacturerGridColumn,
            this.pipeSizeGridColumn});
            this.pipeManufacturerListView.GridControl = this.pipeManufacturersList;
            this.pipeManufacturerListView.Name = "pipeManufacturerListView";
            // 
            // pipeManufacturerGridColumn
            // 
            this.pipeManufacturerGridColumn.Caption = "Manufacturer";
            this.pipeManufacturerGridColumn.Name = "pipeManufacturerGridColumn";
            this.pipeManufacturerGridColumn.Visible = true;
            this.pipeManufacturerGridColumn.VisibleIndex = 0;
            // 
            // pipeSizeGridColumn
            // 
            this.pipeSizeGridColumn.Caption = "Pipe size";
            this.pipeSizeGridColumn.ColumnEdit = this.pipeSizeItem;
            this.pipeSizeGridColumn.Name = "pipeSizeGridColumn";
            this.pipeSizeGridColumn.Visible = true;
            this.pipeSizeGridColumn.VisibleIndex = 1;
            // 
            // pipeSizeItem
            // 
            this.pipeSizeItem.AutoHeight = false;
            this.pipeSizeItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pipeSizeItem.Name = "pipeSizeItem";
            // 
            // pipeManufacturersLabel
            // 
            this.pipeManufacturersLabel.Location = new System.Drawing.Point(14, 20);
            this.pipeManufacturersLabel.Name = "pipeManufacturersLabel";
            this.pipeManufacturersLabel.Size = new System.Drawing.Size(93, 13);
            this.pipeManufacturersLabel.TabIndex = 10;
            this.pipeManufacturersLabel.Text = "Pipe manufacturers";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(586, 431);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            // 
            // oKButton
            // 
            this.oKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.oKButton.Location = new System.Drawing.Point(475, 431);
            this.oKButton.Name = "oKButton";
            this.oKButton.Size = new System.Drawing.Size(75, 23);
            this.oKButton.TabIndex = 10;
            this.oKButton.Text = "OK";
            // 
            // SetupApplicationMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 466);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.oKButton);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.designLabel);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.design);
            this.Controls.Add(this.client);
            this.Name = "SetupApplicationMainForm";
            this.Text = "SetupApplicationMain";
            ((System.ComponentModel.ISupportInitialize)(this.design.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plateManufacturersListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeManufacturersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeManufacturerListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeSizeItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl designLabel;
        private DevExpress.XtraEditors.LabelControl clientLabel;
        private DevExpress.XtraEditors.TextEdit design;
        private DevExpress.XtraEditors.TextEdit client;
        private DevExpress.XtraEditors.SplitContainerControl splitContainer;
        private DevExpress.XtraGrid.GridControl plateManufacturersList;
        private DevExpress.XtraGrid.Views.Grid.GridView plateManufacturersListView;
        private DevExpress.XtraEditors.LabelControl plateManufacturersLabel;
        private DevExpress.XtraEditors.LabelControl pipeManufacturersLabel;
        private DevExpress.XtraGrid.GridControl pipeManufacturersList;
        private DevExpress.XtraGrid.Views.Grid.GridView pipeManufacturerListView;
        private DevExpress.XtraGrid.Columns.GridColumn plateManufacturerGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn pipeManufacturerGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn pipeSizeGridColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit pipeSizeItem;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SimpleButton oKButton;
    }
}