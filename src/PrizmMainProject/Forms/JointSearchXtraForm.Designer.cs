namespace PrizmMain.Forms
{
    partial class JointSearchXtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JointSearchXtraForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.controlState = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.pegNumber = new DevExpress.XtraEditors.TextEdit();
            this.seaLevel = new DevExpress.XtraEditors.TextEdit();
            this.weldingDate = new DevExpress.XtraEditors.DateEdit();
            this.GPSLong = new DevExpress.XtraEditors.TextEdit();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.jointNumber = new DevExpress.XtraEditors.TextEdit();
            this.GPSLat = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.statusLabel = new DevExpress.XtraEditors.LabelControl();
            this.gridControlSerchResult = new DevExpress.XtraGrid.GridControl();
            this.resultView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.jointNumberGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.joinStatusGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.weldingDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repairGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.controlStateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.controlDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.extraGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.extraJointButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.controlState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pegNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seaLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPSLong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPSLat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSerchResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraJointButton)).BeginInit();
            this.SuspendLayout();
            // 
            // controlState
            // 
            this.controlState.Location = new System.Drawing.Point(236, 18);
            this.controlState.Name = "controlState";
            this.controlState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.controlState.Size = new System.Drawing.Size(457, 20);
            this.controlState.StyleController = this.layoutControl1;
            this.controlState.TabIndex = 38;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl1.Controls.Add(this.pegNumber);
            this.layoutControl1.Controls.Add(this.seaLevel);
            this.layoutControl1.Controls.Add(this.weldingDate);
            this.layoutControl1.Controls.Add(this.GPSLong);
            this.layoutControl1.Controls.Add(this.searchButton);
            this.layoutControl1.Controls.Add(this.jointNumber);
            this.layoutControl1.Controls.Add(this.GPSLat);
            this.layoutControl1.Controls.Add(this.controlState);
            this.layoutControl1.Location = new System.Drawing.Point(20, 20);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(11);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(86, 161, 250, 350);
            this.layoutControl1.OptionsView.UseDefaultDragAndDropRendering = false;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(888, 98);
            this.layoutControl1.TabIndex = 59;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // pegNumber
            // 
            this.pegNumber.Location = new System.Drawing.Point(725, 18);
            this.pegNumber.Name = "pegNumber";
            this.pegNumber.Size = new System.Drawing.Size(161, 20);
            this.pegNumber.StyleController = this.layoutControl1;
            this.pegNumber.TabIndex = 52;
            // 
            // seaLevel
            // 
            this.seaLevel.Location = new System.Drawing.Point(562, 71);
            this.seaLevel.Name = "seaLevel";
            this.seaLevel.Size = new System.Drawing.Size(131, 20);
            this.seaLevel.StyleController = this.layoutControl1;
            this.seaLevel.TabIndex = 55;
            // 
            // weldingDate
            // 
            this.weldingDate.EditValue = null;
            this.weldingDate.Location = new System.Drawing.Point(0, 71);
            this.weldingDate.Name = "weldingDate";
            this.weldingDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weldingDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weldingDate.Size = new System.Drawing.Size(206, 20);
            this.weldingDate.StyleController = this.layoutControl1;
            this.weldingDate.TabIndex = 63;
            // 
            // GPSLong
            // 
            this.GPSLong.Location = new System.Drawing.Point(399, 71);
            this.GPSLong.Name = "GPSLong";
            this.GPSLong.Size = new System.Drawing.Size(131, 20);
            this.GPSLong.StyleController = this.layoutControl1;
            this.GPSLong.TabIndex = 54;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(725, 68);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(161, 22);
            this.searchButton.StyleController = this.layoutControl1;
            this.searchButton.TabIndex = 60;
            this.searchButton.Text = "Search";
            // 
            // jointNumber
            // 
            this.jointNumber.EditValue = "";
            this.jointNumber.Location = new System.Drawing.Point(2, 18);
            this.jointNumber.Margin = new System.Windows.Forms.Padding(15);
            this.jointNumber.Name = "jointNumber";
            this.jointNumber.Size = new System.Drawing.Size(202, 20);
            this.jointNumber.StyleController = this.layoutControl1;
            this.jointNumber.TabIndex = 61;
            // 
            // GPSLat
            // 
            this.GPSLat.Location = new System.Drawing.Point(236, 71);
            this.GPSLat.Name = "GPSLat";
            this.GPSLat.Size = new System.Drawing.Size(131, 20);
            this.GPSLat.StyleController = this.layoutControl1;
            this.GPSLat.TabIndex = 53;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(888, 98);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.jointNumber;
            this.layoutControlItem2.CustomizationFormText = "Номер";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(206, 40);
            this.layoutControlItem2.Text = "Номер";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(131, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.weldingDate;
            this.layoutControlItem1.CustomizationFormText = "Дата сварки";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 15, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(206, 58);
            this.layoutControlItem1.Text = "Дата сварки";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(131, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.controlState;
            this.layoutControlItem3.CustomizationFormText = "Статус";
            this.layoutControlItem3.Location = new System.Drawing.Point(206, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(30, 2, 2, 2);
            this.layoutControlItem3.Size = new System.Drawing.Size(489, 40);
            this.layoutControlItem3.Text = "Статус";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(131, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.GPSLat;
            this.layoutControlItem4.CustomizationFormText = "Широта";
            this.layoutControlItem4.Location = new System.Drawing.Point(206, 40);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(30, 2, 15, 2);
            this.layoutControlItem4.Size = new System.Drawing.Size(163, 58);
            this.layoutControlItem4.Text = "Широта";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(131, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.GPSLong;
            this.layoutControlItem5.CustomizationFormText = "Долгота";
            this.layoutControlItem5.Location = new System.Drawing.Point(369, 40);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(30, 2, 15, 2);
            this.layoutControlItem5.Size = new System.Drawing.Size(163, 58);
            this.layoutControlItem5.Text = "Долгота";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(131, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.seaLevel;
            this.layoutControlItem6.CustomizationFormText = "Высота над уровнем моря";
            this.layoutControlItem6.Location = new System.Drawing.Point(532, 40);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(30, 2, 15, 2);
            this.layoutControlItem6.Size = new System.Drawing.Size(163, 58);
            this.layoutControlItem6.Text = "Высота над уровнем моря";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(131, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.pegNumber;
            this.layoutControlItem7.CustomizationFormText = "Номер пикета";
            this.layoutControlItem7.Location = new System.Drawing.Point(695, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(30, 2, 2, 2);
            this.layoutControlItem7.Size = new System.Drawing.Size(193, 40);
            this.layoutControlItem7.Text = "Номер пикета";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(131, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.searchButton;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
            this.layoutControlItem8.Location = new System.Drawing.Point(695, 40);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Padding = new DevExpress.XtraLayout.Utils.Padding(30, 2, 28, 2);
            this.layoutControlItem8.Size = new System.Drawing.Size(193, 58);
            this.layoutControlItem8.Text = "layoutControlItem8";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextToControlDistance = 0;
            this.layoutControlItem8.TextVisible = false;
            // 
            // statusLabel
            // 
            this.statusLabel.Location = new System.Drawing.Point(79, 12);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(31, 13);
            this.statusLabel.TabIndex = 36;
            this.statusLabel.Text = "Status";
            // 
            // gridControlSerchResult
            // 
            this.gridControlSerchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlSerchResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlSerchResult.Location = new System.Drawing.Point(20, 140);
            this.gridControlSerchResult.MainView = this.resultView;
            this.gridControlSerchResult.Margin = new System.Windows.Forms.Padding(11);
            this.gridControlSerchResult.Name = "gridControlSerchResult";
            this.gridControlSerchResult.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.extraJointButton});
            this.gridControlSerchResult.Size = new System.Drawing.Size(888, 290);
            this.gridControlSerchResult.TabIndex = 33;
            this.gridControlSerchResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.resultView});
            // 
            // resultView
            // 
            this.resultView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.jointNumberGridColumn,
            this.joinStatusGridColumn,
            this.weldingDateGridColumn,
            this.repairGridColumn,
            this.controlStateGridColumn,
            this.controlDateGridColumn,
            this.extraGridColumn});
            this.resultView.GridControl = this.gridControlSerchResult;
            this.resultView.Name = "resultView";
            this.resultView.OptionsView.ShowGroupPanel = false;
            // 
            // jointNumberGridColumn
            // 
            this.jointNumberGridColumn.Caption = "№";
            this.jointNumberGridColumn.FieldName = "Id";
            this.jointNumberGridColumn.Name = "jointNumberGridColumn";
            this.jointNumberGridColumn.Visible = true;
            this.jointNumberGridColumn.VisibleIndex = 0;
            this.jointNumberGridColumn.Width = 125;
            // 
            // joinStatusGridColumn
            // 
            this.joinStatusGridColumn.Caption = "Status";
            this.joinStatusGridColumn.FieldName = "Status";
            this.joinStatusGridColumn.Name = "joinStatusGridColumn";
            this.joinStatusGridColumn.Visible = true;
            this.joinStatusGridColumn.VisibleIndex = 1;
            this.joinStatusGridColumn.Width = 125;
            // 
            // weldingDateGridColumn
            // 
            this.weldingDateGridColumn.Caption = "Welding Date";
            this.weldingDateGridColumn.FieldName = "WeldingDate";
            this.weldingDateGridColumn.Name = "weldingDateGridColumn";
            this.weldingDateGridColumn.Visible = true;
            this.weldingDateGridColumn.VisibleIndex = 3;
            this.weldingDateGridColumn.Width = 125;
            // 
            // repairGridColumn
            // 
            this.repairGridColumn.Caption = "Repair";
            this.repairGridColumn.FieldName = "Repair";
            this.repairGridColumn.Name = "repairGridColumn";
            this.repairGridColumn.Visible = true;
            this.repairGridColumn.VisibleIndex = 4;
            this.repairGridColumn.Width = 125;
            // 
            // controlStateGridColumn
            // 
            this.controlStateGridColumn.Caption = "Control State";
            this.controlStateGridColumn.FieldName = "State";
            this.controlStateGridColumn.Name = "controlStateGridColumn";
            this.controlStateGridColumn.Visible = true;
            this.controlStateGridColumn.VisibleIndex = 2;
            this.controlStateGridColumn.Width = 125;
            // 
            // controlDateGridColumn
            // 
            this.controlDateGridColumn.Caption = "Control Date";
            this.controlDateGridColumn.FieldName = "ControlDate";
            this.controlDateGridColumn.Name = "controlDateGridColumn";
            this.controlDateGridColumn.Visible = true;
            this.controlDateGridColumn.VisibleIndex = 5;
            this.controlDateGridColumn.Width = 194;
            // 
            // extraGridColumn
            // 
            this.extraGridColumn.ColumnEdit = this.extraJointButton;
            this.extraGridColumn.FieldName = "extraGridColumn";
            this.extraGridColumn.Name = "extraGridColumn";
            this.extraGridColumn.Visible = true;
            this.extraGridColumn.VisibleIndex = 6;
            this.extraGridColumn.Width = 60;
            // 
            // extraJointButton
            // 
            this.extraJointButton.AutoHeight = false;
            this.extraJointButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("extraJointButton.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.extraJointButton.Name = "extraJointButton";
            this.extraJointButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // JointSearchXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.gridControlSerchResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JointSearchXtraForm";
            this.Text = "Find joint";
            ((System.ComponentModel.ISupportInitialize)(this.controlState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pegNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seaLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPSLong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPSLat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSerchResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraJointButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit controlState;
        private DevExpress.XtraEditors.LabelControl statusLabel;
        private DevExpress.XtraGrid.GridControl gridControlSerchResult;
        private DevExpress.XtraGrid.Views.Grid.GridView resultView;
        private DevExpress.XtraGrid.Columns.GridColumn jointNumberGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn joinStatusGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn weldingDateGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn repairGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn controlStateGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn controlDateGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn extraGridColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit extraJointButton;
        private DevExpress.XtraEditors.TextEdit pegNumber;
        private DevExpress.XtraEditors.TextEdit GPSLat;
        private DevExpress.XtraEditors.TextEdit GPSLong;
        private DevExpress.XtraEditors.TextEdit seaLevel;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit jointNumber;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.DateEdit weldingDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;

    }
}