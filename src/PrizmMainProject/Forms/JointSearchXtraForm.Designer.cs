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
            this.coordinateGPSLabel = new DevExpress.XtraEditors.LabelControl();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.controlDate = new DevExpress.XtraEditors.DateEdit();
            this.controlDateLabel = new DevExpress.XtraEditors.LabelControl();
            this.weldingDate = new DevExpress.XtraEditors.DateEdit();
            this.weldingDateLabel = new DevExpress.XtraEditors.LabelControl();
            this.controlStateLabel = new DevExpress.XtraEditors.LabelControl();
            this.controlState = new DevExpress.XtraEditors.ComboBoxEdit();
            this.status = new DevExpress.XtraEditors.ComboBoxEdit();
            this.statusLabel = new DevExpress.XtraEditors.LabelControl();
            this.jointNumber = new DevExpress.XtraEditors.TextEdit();
            this.jointNumberLabel = new DevExpress.XtraEditors.LabelControl();
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
            this.pegNumber = new DevExpress.XtraEditors.TextEdit();
            this.pegNumberLabel = new DevExpress.XtraEditors.LabelControl();
            this.GPSLat = new DevExpress.XtraEditors.TextEdit();
            this.GPSLong = new DevExpress.XtraEditors.TextEdit();
            this.seaLevel = new DevExpress.XtraEditors.TextEdit();
            this.GPSLatLabel = new DevExpress.XtraEditors.LabelControl();
            this.GPSLongLabel = new DevExpress.XtraEditors.LabelControl();
            this.seaLevelLabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.controlDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSerchResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraJointButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPSLat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPSLong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seaLevel.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // coordinateGPSLabel
            // 
            this.coordinateGPSLabel.Location = new System.Drawing.Point(175, 87);
            this.coordinateGPSLabel.Name = "coordinateGPSLabel";
            this.coordinateGPSLabel.Size = new System.Drawing.Size(19, 13);
            this.coordinateGPSLabel.TabIndex = 48;
            this.coordinateGPSLabel.Text = "GPS";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(842, 86);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 44;
            this.searchButton.Text = "Search";
            // 
            // controlDate
            // 
            this.controlDate.EditValue = null;
            this.controlDate.Location = new System.Drawing.Point(597, 39);
            this.controlDate.Name = "controlDate";
            this.controlDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.controlDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.controlDate.Size = new System.Drawing.Size(120, 20);
            this.controlDate.TabIndex = 43;
            // 
            // controlDateLabel
            // 
            this.controlDateLabel.Location = new System.Drawing.Point(597, 20);
            this.controlDateLabel.Name = "controlDateLabel";
            this.controlDateLabel.Size = new System.Drawing.Size(60, 13);
            this.controlDateLabel.TabIndex = 42;
            this.controlDateLabel.Text = "Control date";
            // 
            // weldingDate
            // 
            this.weldingDate.EditValue = null;
            this.weldingDate.Location = new System.Drawing.Point(19, 84);
            this.weldingDate.Name = "weldingDate";
            this.weldingDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weldingDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weldingDate.Size = new System.Drawing.Size(99, 20);
            this.weldingDate.TabIndex = 41;
            // 
            // weldingDateLabel
            // 
            this.weldingDateLabel.Location = new System.Drawing.Point(20, 65);
            this.weldingDateLabel.Name = "weldingDateLabel";
            this.weldingDateLabel.Size = new System.Drawing.Size(63, 13);
            this.weldingDateLabel.TabIndex = 40;
            this.weldingDateLabel.Text = "Welding date";
            // 
            // controlStateLabel
            // 
            this.controlStateLabel.Location = new System.Drawing.Point(390, 20);
            this.controlStateLabel.Name = "controlStateLabel";
            this.controlStateLabel.Size = new System.Drawing.Size(63, 13);
            this.controlStateLabel.TabIndex = 39;
            this.controlStateLabel.Text = "Control state";
            // 
            // controlState
            // 
            this.controlState.Location = new System.Drawing.Point(390, 39);
            this.controlState.Name = "controlState";
            this.controlState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.controlState.Size = new System.Drawing.Size(125, 20);
            this.controlState.TabIndex = 38;
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(200, 39);
            this.status.Name = "status";
            this.status.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.status.Size = new System.Drawing.Size(108, 20);
            this.status.TabIndex = 37;
            // 
            // statusLabel
            // 
            this.statusLabel.Location = new System.Drawing.Point(200, 20);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(31, 13);
            this.statusLabel.TabIndex = 36;
            this.statusLabel.Text = "Status";
            // 
            // jointNumber
            // 
            this.jointNumber.Location = new System.Drawing.Point(20, 39);
            this.jointNumber.Name = "jointNumber";
            this.jointNumber.Size = new System.Drawing.Size(98, 20);
            this.jointNumber.TabIndex = 35;
            // 
            // jointNumberLabel
            // 
            this.jointNumberLabel.Location = new System.Drawing.Point(20, 20);
            this.jointNumberLabel.Name = "jointNumberLabel";
            this.jointNumberLabel.Size = new System.Drawing.Size(62, 13);
            this.jointNumberLabel.TabIndex = 34;
            this.jointNumberLabel.Text = "Joint number";
            // 
            // gridControlSerchResult
            // 
            this.gridControlSerchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlSerchResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlSerchResult.Location = new System.Drawing.Point(20, 121);
            this.gridControlSerchResult.MainView = this.resultView;
            this.gridControlSerchResult.Name = "gridControlSerchResult";
            this.gridControlSerchResult.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.extraJointButton});
            this.gridControlSerchResult.Size = new System.Drawing.Size(897, 309);
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
            // 
            // joinStatusGridColumn
            // 
            this.joinStatusGridColumn.Caption = "Status";
            this.joinStatusGridColumn.FieldName = "Status";
            this.joinStatusGridColumn.Name = "joinStatusGridColumn";
            this.joinStatusGridColumn.Visible = true;
            this.joinStatusGridColumn.VisibleIndex = 1;
            // 
            // weldingDateGridColumn
            // 
            this.weldingDateGridColumn.Caption = "Welding Date";
            this.weldingDateGridColumn.FieldName = "WeldingDate";
            this.weldingDateGridColumn.Name = "weldingDateGridColumn";
            this.weldingDateGridColumn.Visible = true;
            this.weldingDateGridColumn.VisibleIndex = 3;
            // 
            // repairGridColumn
            // 
            this.repairGridColumn.Caption = "Repair";
            this.repairGridColumn.FieldName = "Repair";
            this.repairGridColumn.Name = "repairGridColumn";
            this.repairGridColumn.Visible = true;
            this.repairGridColumn.VisibleIndex = 4;
            // 
            // controlStateGridColumn
            // 
            this.controlStateGridColumn.Caption = "Control State";
            this.controlStateGridColumn.FieldName = "State";
            this.controlStateGridColumn.Name = "controlStateGridColumn";
            this.controlStateGridColumn.Visible = true;
            this.controlStateGridColumn.VisibleIndex = 2;
            // 
            // controlDateGridColumn
            // 
            this.controlDateGridColumn.Caption = "Control Date";
            this.controlDateGridColumn.FieldName = "ControlDate";
            this.controlDateGridColumn.Name = "controlDateGridColumn";
            this.controlDateGridColumn.Visible = true;
            this.controlDateGridColumn.VisibleIndex = 5;
            // 
            // extraGridColumn
            // 
            this.extraGridColumn.Caption = "Extra";
            this.extraGridColumn.ColumnEdit = this.extraJointButton;
            this.extraGridColumn.FieldName = "extraGridColumn";
            this.extraGridColumn.Name = "extraGridColumn";
            this.extraGridColumn.Visible = true;
            this.extraGridColumn.VisibleIndex = 6;
            // 
            // extraJointButton
            // 
            this.extraJointButton.AutoHeight = false;
            this.extraJointButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.extraJointButton.Name = "extraJointButton";
            this.extraJointButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // pegNumber
            // 
            this.pegNumber.Location = new System.Drawing.Point(799, 39);
            this.pegNumber.Name = "pegNumber";
            this.pegNumber.Size = new System.Drawing.Size(115, 20);
            this.pegNumber.TabIndex = 52;
            // 
            // pegNumberLabel
            // 
            this.pegNumberLabel.Location = new System.Drawing.Point(802, 20);
            this.pegNumberLabel.Name = "pegNumberLabel";
            this.pegNumberLabel.Size = new System.Drawing.Size(57, 13);
            this.pegNumberLabel.TabIndex = 51;
            this.pegNumberLabel.Text = "Peg number";
            // 
            // GPSLat
            // 
            this.GPSLat.Location = new System.Drawing.Point(200, 84);
            this.GPSLat.Name = "GPSLat";
            this.GPSLat.Size = new System.Drawing.Size(71, 20);
            this.GPSLat.TabIndex = 53;
            // 
            // GPSLong
            // 
            this.GPSLong.Location = new System.Drawing.Point(295, 84);
            this.GPSLong.Name = "GPSLong";
            this.GPSLong.Size = new System.Drawing.Size(71, 20);
            this.GPSLong.TabIndex = 54;
            // 
            // seaLevel
            // 
            this.seaLevel.Location = new System.Drawing.Point(390, 84);
            this.seaLevel.Name = "seaLevel";
            this.seaLevel.Size = new System.Drawing.Size(71, 20);
            this.seaLevel.TabIndex = 55;
            // 
            // GPSLatLabel
            // 
            this.GPSLatLabel.Location = new System.Drawing.Point(200, 65);
            this.GPSLatLabel.Name = "GPSLatLabel";
            this.GPSLatLabel.Size = new System.Drawing.Size(15, 13);
            this.GPSLatLabel.TabIndex = 56;
            this.GPSLatLabel.Text = "Lat";
            // 
            // GPSLongLabel
            // 
            this.GPSLongLabel.Location = new System.Drawing.Point(295, 65);
            this.GPSLongLabel.Name = "GPSLongLabel";
            this.GPSLongLabel.Size = new System.Drawing.Size(23, 13);
            this.GPSLongLabel.TabIndex = 57;
            this.GPSLongLabel.Text = "Long";
            // 
            // seaLevelLabel
            // 
            this.seaLevelLabel.Location = new System.Drawing.Point(390, 65);
            this.seaLevelLabel.Name = "seaLevelLabel";
            this.seaLevelLabel.Size = new System.Drawing.Size(43, 13);
            this.seaLevelLabel.TabIndex = 58;
            this.seaLevelLabel.Text = "Sea level";
            // 
            // JointSearchXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.ControlBox = false;
            this.Controls.Add(this.seaLevelLabel);
            this.Controls.Add(this.GPSLongLabel);
            this.Controls.Add(this.GPSLatLabel);
            this.Controls.Add(this.seaLevel);
            this.Controls.Add(this.GPSLong);
            this.Controls.Add(this.GPSLat);
            this.Controls.Add(this.pegNumber);
            this.Controls.Add(this.pegNumberLabel);
            this.Controls.Add(this.coordinateGPSLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.controlDate);
            this.Controls.Add(this.controlDateLabel);
            this.Controls.Add(this.weldingDate);
            this.Controls.Add(this.weldingDateLabel);
            this.Controls.Add(this.controlStateLabel);
            this.Controls.Add(this.controlState);
            this.Controls.Add(this.status);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.jointNumber);
            this.Controls.Add(this.jointNumberLabel);
            this.Controls.Add(this.gridControlSerchResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JointSearchXtraForm";
            this.Text = "JointSearchXtraForm";
            ((System.ComponentModel.ISupportInitialize)(this.controlDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSerchResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraJointButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPSLat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPSLong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seaLevel.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl coordinateGPSLabel;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraEditors.DateEdit controlDate;
        private DevExpress.XtraEditors.LabelControl controlDateLabel;
        private DevExpress.XtraEditors.DateEdit weldingDate;
        private DevExpress.XtraEditors.LabelControl weldingDateLabel;
        private DevExpress.XtraEditors.LabelControl controlStateLabel;
        private DevExpress.XtraEditors.ComboBoxEdit controlState;
        private DevExpress.XtraEditors.ComboBoxEdit status;
        private DevExpress.XtraEditors.LabelControl statusLabel;
        private DevExpress.XtraEditors.TextEdit jointNumber;
        private DevExpress.XtraEditors.LabelControl jointNumberLabel;
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
        private DevExpress.XtraEditors.LabelControl pegNumberLabel;
        private DevExpress.XtraEditors.TextEdit GPSLat;
        private DevExpress.XtraEditors.TextEdit GPSLong;
        private DevExpress.XtraEditors.TextEdit seaLevel;
        private DevExpress.XtraEditors.LabelControl GPSLatLabel;
        private DevExpress.XtraEditors.LabelControl GPSLongLabel;
        private DevExpress.XtraEditors.LabelControl seaLevelLabel;

    }
}