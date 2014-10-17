namespace PrizmMain.Forms
{
    partial class SettingsEditDictionaryXtraForm
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
            this.items = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.English = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Russian = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.Tools = new DevExpress.XtraBars.Bar();
            this.addItem = new DevExpress.XtraBars.BarButtonItem();
            this.removeItem = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // items
            // 
            this.items.Cursor = System.Windows.Forms.Cursors.Default;
            this.items.Location = new System.Drawing.Point(0, 26);
            this.items.MainView = this.gridView1;
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(361, 200);
            this.items.TabIndex = 0;
            this.items.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.English,
            this.Russian});
            this.gridView1.GridControl = this.items;
            this.gridView1.Name = "gridView1";
            // 
            // English
            // 
            this.English.Caption = "language1GridColumn";
            this.English.Name = "English";
            this.English.Visible = true;
            this.English.VisibleIndex = 0;
            // 
            // Russian
            // 
            this.Russian.Caption = "language2GridColumn";
            this.Russian.Name = "Russian";
            this.Russian.Visible = true;
            this.Russian.VisibleIndex = 1;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.Tools});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.addItem,
            this.removeItem});
            this.barManager1.MaxItemId = 2;
            // 
            // Tools
            // 
            this.Tools.BarName = "Tools";
            this.Tools.DockCol = 0;
            this.Tools.DockRow = 0;
            this.Tools.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.Tools.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.addItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.removeItem)});
            this.Tools.Text = "Tools";
            // 
            // addItem
            // 
            this.addItem.Caption = "Add item";
            this.addItem.Id = 0;
            this.addItem.Name = "addItem";
            // 
            // removeItem
            // 
            this.removeItem.Caption = "Remove item";
            this.removeItem.Id = 1;
            this.removeItem.Name = "removeItem";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(391, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 261);
            this.barDockControlBottom.Size = new System.Drawing.Size(391, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 232);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(391, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 232);
            // 
            // SettingsEditDictionaryXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 261);
            this.Controls.Add(this.items);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "SettingsEditDictionaryXtraForm";
            this.Text = "Settings - Edit dictionary";
            ((System.ComponentModel.ISupportInitialize)(this.items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl items;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn English;
        private DevExpress.XtraGrid.Columns.GridColumn Russian;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar Tools;
        private DevExpress.XtraBars.BarButtonItem addItem;
        private DevExpress.XtraBars.BarButtonItem removeItem;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}