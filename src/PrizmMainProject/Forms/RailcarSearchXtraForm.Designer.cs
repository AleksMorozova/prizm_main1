namespace PrizmMain.Forms
{
    partial class RailcarSearchXtraForm
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
            this.railcarNumberLabel = new DevExpress.XtraEditors.LabelControl();
            this.railcarList = new DevExpress.XtraGrid.GridControl();
            this.railcarListView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.railcarNumberGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deliveryDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.shippingDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.editGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.shipButton = new DevExpress.XtraEditors.SimpleButton();
            this.certificateNumber = new DevExpress.XtraEditors.TextEdit();
            this.certificateNumberLabel = new DevExpress.XtraEditors.LabelControl();
            this.shippedDate = new DevExpress.XtraEditors.DateEdit();
            this.deliveryDate = new DevExpress.XtraEditors.DateEdit();
            this.shippedDateLabel = new DevExpress.XtraEditors.LabelControl();
            this.deliveryDateLabel = new DevExpress.XtraEditors.LabelControl();
            this.purchaseOrder = new DevExpress.XtraEditors.TextEdit();
            this.purchaseOrderLabel = new DevExpress.XtraEditors.LabelControl();
            this.client = new DevExpress.XtraEditors.ComboBoxEdit();
            this.designer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.clientLabel = new DevExpress.XtraEditors.LabelControl();
            this.designerLabel = new DevExpress.XtraEditors.LabelControl();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.railcarList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designer.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // railcarNumberLabel
            // 
            this.railcarNumberLabel.Location = new System.Drawing.Point(12, 12);
            this.railcarNumberLabel.Name = "railcarNumberLabel";
            this.railcarNumberLabel.Size = new System.Drawing.Size(71, 13);
            this.railcarNumberLabel.TabIndex = 0;
            this.railcarNumberLabel.Text = "Railcar number";
            // 
            // railcarList
            // 
            this.railcarList.Cursor = System.Windows.Forms.Cursors.Default;
            this.railcarList.Location = new System.Drawing.Point(12, 148);
            this.railcarList.MainView = this.railcarListView;
            this.railcarList.Name = "railcarList";
            this.railcarList.Size = new System.Drawing.Size(685, 197);
            this.railcarList.TabIndex = 1;
            this.railcarList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.railcarListView});
            // 
            // railcarListView
            // 
            this.railcarListView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.railcarNumberGridColumn,
            this.statusGridColumn,
            this.deliveryDateGridColumn,
            this.shippingDateGridColumn,
            this.editGridColumn});
            this.railcarListView.GridControl = this.railcarList;
            this.railcarListView.Name = "railcarListView";
            // 
            // railcarNumberGridColumn
            // 
            this.railcarNumberGridColumn.Caption = "Railcar number";
            this.railcarNumberGridColumn.Name = "railcarNumberGridColumn";
            this.railcarNumberGridColumn.Visible = true;
            this.railcarNumberGridColumn.VisibleIndex = 0;
            // 
            // statusGridColumn
            // 
            this.statusGridColumn.Caption = "Status";
            this.statusGridColumn.Name = "statusGridColumn";
            this.statusGridColumn.Visible = true;
            this.statusGridColumn.VisibleIndex = 1;
            // 
            // deliveryDateGridColumn
            // 
            this.deliveryDateGridColumn.Caption = "Delivery date";
            this.deliveryDateGridColumn.Name = "deliveryDateGridColumn";
            this.deliveryDateGridColumn.Visible = true;
            this.deliveryDateGridColumn.VisibleIndex = 2;
            // 
            // shippingDateGridColumn
            // 
            this.shippingDateGridColumn.Caption = "Shiping date";
            this.shippingDateGridColumn.Name = "shippingDateGridColumn";
            this.shippingDateGridColumn.Visible = true;
            this.shippingDateGridColumn.VisibleIndex = 3;
            // 
            // editGridColumn
            // 
            this.editGridColumn.Caption = "Edit";
            this.editGridColumn.Name = "editGridColumn";
            this.editGridColumn.Visible = true;
            this.editGridColumn.VisibleIndex = 4;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(12, 31);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(122, 20);
            this.comboBoxEdit1.TabIndex = 2;
            // 
            // shipButton
            // 
            this.shipButton.Location = new System.Drawing.Point(622, 351);
            this.shipButton.Name = "shipButton";
            this.shipButton.Size = new System.Drawing.Size(75, 23);
            this.shipButton.TabIndex = 3;
            this.shipButton.Text = "Ship";
            // 
            // certificateNumber
            // 
            this.certificateNumber.Location = new System.Drawing.Point(173, 31);
            this.certificateNumber.Name = "certificateNumber";
            this.certificateNumber.Size = new System.Drawing.Size(289, 20);
            this.certificateNumber.TabIndex = 16;
            // 
            // certificateNumberLabel
            // 
            this.certificateNumberLabel.Location = new System.Drawing.Point(173, 12);
            this.certificateNumberLabel.Name = "certificateNumberLabel";
            this.certificateNumberLabel.Size = new System.Drawing.Size(89, 13);
            this.certificateNumberLabel.TabIndex = 15;
            this.certificateNumberLabel.Text = "Certificate number";
            // 
            // shippedDate
            // 
            this.shippedDate.EditValue = null;
            this.shippedDate.Location = new System.Drawing.Point(534, 76);
            this.shippedDate.Name = "shippedDate";
            this.shippedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.shippedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.shippedDate.Size = new System.Drawing.Size(138, 20);
            this.shippedDate.TabIndex = 22;
            // 
            // deliveryDate
            // 
            this.deliveryDate.EditValue = null;
            this.deliveryDate.Location = new System.Drawing.Point(359, 76);
            this.deliveryDate.Name = "deliveryDate";
            this.deliveryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deliveryDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deliveryDate.Size = new System.Drawing.Size(138, 20);
            this.deliveryDate.TabIndex = 21;
            // 
            // shippedDateLabel
            // 
            this.shippedDateLabel.Location = new System.Drawing.Point(534, 57);
            this.shippedDateLabel.Name = "shippedDateLabel";
            this.shippedDateLabel.Size = new System.Drawing.Size(65, 13);
            this.shippedDateLabel.TabIndex = 20;
            this.shippedDateLabel.Text = "Shipping date";
            // 
            // deliveryDateLabel
            // 
            this.deliveryDateLabel.Location = new System.Drawing.Point(359, 57);
            this.deliveryDateLabel.Name = "deliveryDateLabel";
            this.deliveryDateLabel.Size = new System.Drawing.Size(64, 13);
            this.deliveryDateLabel.TabIndex = 19;
            this.deliveryDateLabel.Text = "Delivery date";
            // 
            // purchaseOrder
            // 
            this.purchaseOrder.Location = new System.Drawing.Point(494, 31);
            this.purchaseOrder.Name = "purchaseOrder";
            this.purchaseOrder.Size = new System.Drawing.Size(132, 20);
            this.purchaseOrder.TabIndex = 28;
            // 
            // purchaseOrderLabel
            // 
            this.purchaseOrderLabel.Location = new System.Drawing.Point(494, 12);
            this.purchaseOrderLabel.Name = "purchaseOrderLabel";
            this.purchaseOrderLabel.Size = new System.Drawing.Size(73, 13);
            this.purchaseOrderLabel.TabIndex = 27;
            this.purchaseOrderLabel.Text = "Purchase order";
            // 
            // client
            // 
            this.client.Location = new System.Drawing.Point(187, 76);
            this.client.Name = "client";
            this.client.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.client.Size = new System.Drawing.Size(138, 20);
            this.client.TabIndex = 26;
            // 
            // designer
            // 
            this.designer.Location = new System.Drawing.Point(12, 76);
            this.designer.Name = "designer";
            this.designer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.designer.Size = new System.Drawing.Size(138, 20);
            this.designer.TabIndex = 25;
            // 
            // clientLabel
            // 
            this.clientLabel.Location = new System.Drawing.Point(187, 57);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(27, 13);
            this.clientLabel.TabIndex = 24;
            this.clientLabel.Text = "Client";
            // 
            // designerLabel
            // 
            this.designerLabel.Location = new System.Drawing.Point(12, 57);
            this.designerLabel.Name = "designerLabel";
            this.designerLabel.Size = new System.Drawing.Size(42, 13);
            this.designerLabel.TabIndex = 23;
            this.designerLabel.Text = "Designer";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(597, 113);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 29;
            this.searchButton.Text = "Search";
            // 
            // RailcarSearchXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 386);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.purchaseOrder);
            this.Controls.Add(this.purchaseOrderLabel);
            this.Controls.Add(this.client);
            this.Controls.Add(this.designer);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.designerLabel);
            this.Controls.Add(this.shippedDate);
            this.Controls.Add(this.deliveryDate);
            this.Controls.Add(this.shippedDateLabel);
            this.Controls.Add(this.deliveryDateLabel);
            this.Controls.Add(this.certificateNumber);
            this.Controls.Add(this.certificateNumberLabel);
            this.Controls.Add(this.shipButton);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.railcarList);
            this.Controls.Add(this.railcarNumberLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RailcarSearchXtraForm";
            this.Text = "RailcarSearchXtraForm";
            ((System.ComponentModel.ISupportInitialize)(this.railcarList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.railcarListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designer.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl railcarNumberLabel;
        private DevExpress.XtraGrid.GridControl railcarList;
        private DevExpress.XtraGrid.Views.Grid.GridView railcarListView;
        private DevExpress.XtraGrid.Columns.GridColumn railcarNumberGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn statusGridColumn;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.SimpleButton shipButton;
        private DevExpress.XtraGrid.Columns.GridColumn deliveryDateGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn shippingDateGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn editGridColumn;
        private DevExpress.XtraEditors.TextEdit certificateNumber;
        private DevExpress.XtraEditors.LabelControl certificateNumberLabel;
        private DevExpress.XtraEditors.DateEdit shippedDate;
        private DevExpress.XtraEditors.DateEdit deliveryDate;
        private DevExpress.XtraEditors.LabelControl shippedDateLabel;
        private DevExpress.XtraEditors.LabelControl deliveryDateLabel;
        private DevExpress.XtraEditors.TextEdit purchaseOrder;
        private DevExpress.XtraEditors.LabelControl purchaseOrderLabel;
        private DevExpress.XtraEditors.ComboBoxEdit client;
        private DevExpress.XtraEditors.ComboBoxEdit designer;
        private DevExpress.XtraEditors.LabelControl clientLabel;
        private DevExpress.XtraEditors.LabelControl designerLabel;
        private DevExpress.XtraEditors.SimpleButton searchButton;
    }
}