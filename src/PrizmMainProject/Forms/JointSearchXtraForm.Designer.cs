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
            this.coordinateGPSMinutes = new DevExpress.XtraEditors.TextEdit();
            this.coordinateGPSdegrees = new DevExpress.XtraEditors.TextEdit();
            this.coordinateGPSSseconds = new DevExpress.XtraEditors.TextEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.coordinateGPSMinutes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordinateGPSdegrees.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordinateGPSSseconds.Properties)).BeginInit();
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
            this.SuspendLayout();
            // 
            // coordinateGPSLabel
            // 
            this.coordinateGPSLabel.Location = new System.Drawing.Point(240, 57);
            this.coordinateGPSLabel.Name = "coordinateGPSLabel";
            this.coordinateGPSLabel.Size = new System.Drawing.Size(19, 13);
            this.coordinateGPSLabel.TabIndex = 48;
            this.coordinateGPSLabel.Text = "GPS";
            // 
            // coordinateGPSMinutes
            // 
            this.coordinateGPSMinutes.Location = new System.Drawing.Point(293, 78);
            this.coordinateGPSMinutes.Name = "coordinateGPSMinutes";
            this.coordinateGPSMinutes.Size = new System.Drawing.Size(47, 20);
            this.coordinateGPSMinutes.TabIndex = 47;
            // 
            // coordinateGPSdegrees
            // 
            this.coordinateGPSdegrees.Location = new System.Drawing.Point(240, 78);
            this.coordinateGPSdegrees.Name = "coordinateGPSdegrees";
            this.coordinateGPSdegrees.Size = new System.Drawing.Size(47, 20);
            this.coordinateGPSdegrees.TabIndex = 46;
            // 
            // coordinateGPSSseconds
            // 
            this.coordinateGPSSseconds.Location = new System.Drawing.Point(346, 78);
            this.coordinateGPSSseconds.Name = "coordinateGPSSseconds";
            this.coordinateGPSSseconds.Size = new System.Drawing.Size(47, 20);
            this.coordinateGPSSseconds.TabIndex = 45;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(636, 79);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 44;
            this.searchButton.Text = "Search";
            // 
            // controlDate
            // 
            this.controlDate.EditValue = null;
            this.controlDate.Location = new System.Drawing.Point(456, 28);
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
            this.controlDateLabel.Location = new System.Drawing.Point(456, 9);
            this.controlDateLabel.Name = "controlDateLabel";
            this.controlDateLabel.Size = new System.Drawing.Size(60, 13);
            this.controlDateLabel.TabIndex = 42;
            this.controlDateLabel.Text = "Control date";
            // 
            // weldingDate
            // 
            this.weldingDate.EditValue = null;
            this.weldingDate.Location = new System.Drawing.Point(10, 78);
            this.weldingDate.Name = "weldingDate";
            this.weldingDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weldingDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weldingDate.Size = new System.Drawing.Size(120, 20);
            this.weldingDate.TabIndex = 41;
            // 
            // weldingDateLabel
            // 
            this.weldingDateLabel.Location = new System.Drawing.Point(10, 57);
            this.weldingDateLabel.Name = "weldingDateLabel";
            this.weldingDateLabel.Size = new System.Drawing.Size(63, 13);
            this.weldingDateLabel.TabIndex = 40;
            this.weldingDateLabel.Text = "Welding date";
            // 
            // controlStateLabel
            // 
            this.controlStateLabel.Location = new System.Drawing.Point(299, 9);
            this.controlStateLabel.Name = "controlStateLabel";
            this.controlStateLabel.Size = new System.Drawing.Size(63, 13);
            this.controlStateLabel.TabIndex = 39;
            this.controlStateLabel.Text = "Control state";
            // 
            // controlState
            // 
            this.controlState.Location = new System.Drawing.Point(299, 28);
            this.controlState.Name = "controlState";
            this.controlState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.controlState.Size = new System.Drawing.Size(125, 20);
            this.controlState.TabIndex = 38;
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(159, 28);
            this.status.Name = "status";
            this.status.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.status.Size = new System.Drawing.Size(108, 20);
            this.status.TabIndex = 37;
            // 
            // statusLabel
            // 
            this.statusLabel.Location = new System.Drawing.Point(159, 9);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(31, 13);
            this.statusLabel.TabIndex = 36;
            this.statusLabel.Text = "Status";
            // 
            // jointNumber
            // 
            this.jointNumber.Location = new System.Drawing.Point(10, 28);
            this.jointNumber.Name = "jointNumber";
            this.jointNumber.Size = new System.Drawing.Size(119, 20);
            this.jointNumber.TabIndex = 35;
            // 
            // jointNumberLabel
            // 
            this.jointNumberLabel.Location = new System.Drawing.Point(10, 9);
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
            this.gridControlSerchResult.Location = new System.Drawing.Point(10, 108);
            this.gridControlSerchResult.MainView = this.resultView;
            this.gridControlSerchResult.Name = "gridControlSerchResult";
            this.gridControlSerchResult.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.extraJointButton});
            this.gridControlSerchResult.Size = new System.Drawing.Size(703, 305);
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
            this.jointNumberGridColumn.Name = "jointNumberGridColumn";
            this.jointNumberGridColumn.Visible = true;
            this.jointNumberGridColumn.VisibleIndex = 0;
            // 
            // joinStatusGridColumn
            // 
            this.joinStatusGridColumn.Caption = "Status";
            this.joinStatusGridColumn.Name = "joinStatusGridColumn";
            this.joinStatusGridColumn.Visible = true;
            this.joinStatusGridColumn.VisibleIndex = 1;
            // 
            // weldingDateGridColumn
            // 
            this.weldingDateGridColumn.Caption = "Welding Date";
            this.weldingDateGridColumn.Name = "weldingDateGridColumn";
            this.weldingDateGridColumn.Visible = true;
            this.weldingDateGridColumn.VisibleIndex = 3;
            // 
            // repairGridColumn
            // 
            this.repairGridColumn.Caption = "Repair";
            this.repairGridColumn.Name = "repairGridColumn";
            this.repairGridColumn.Visible = true;
            this.repairGridColumn.VisibleIndex = 4;
            // 
            // controlStateGridColumn
            // 
            this.controlStateGridColumn.Caption = "Control State";
            this.controlStateGridColumn.Name = "controlStateGridColumn";
            this.controlStateGridColumn.Visible = true;
            this.controlStateGridColumn.VisibleIndex = 2;
            // 
            // controlDateGridColumn
            // 
            this.controlDateGridColumn.Caption = "Control Date";
            this.controlDateGridColumn.Name = "controlDateGridColumn";
            this.controlDateGridColumn.Visible = true;
            this.controlDateGridColumn.VisibleIndex = 5;
            // 
            // extraGridColumn
            // 
            this.extraGridColumn.Caption = "Extra";
            this.extraGridColumn.ColumnEdit = this.extraJointButton;
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
            this.pegNumber.Location = new System.Drawing.Point(598, 28);
            this.pegNumber.Name = "pegNumber";
            this.pegNumber.Size = new System.Drawing.Size(115, 20);
            this.pegNumber.TabIndex = 52;
            // 
            // pegNumberLabel
            // 
            this.pegNumberLabel.Location = new System.Drawing.Point(598, 9);
            this.pegNumberLabel.Name = "pegNumberLabel";
            this.pegNumberLabel.Size = new System.Drawing.Size(57, 13);
            this.pegNumberLabel.TabIndex = 51;
            this.pegNumberLabel.Text = "Peg number";
            // 
            // JointSearchXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 425);
            this.ControlBox = false;
            this.Controls.Add(this.pegNumber);
            this.Controls.Add(this.pegNumberLabel);
            this.Controls.Add(this.coordinateGPSLabel);
            this.Controls.Add(this.coordinateGPSMinutes);
            this.Controls.Add(this.coordinateGPSdegrees);
            this.Controls.Add(this.coordinateGPSSseconds);
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
            this.Text = "Find joint";
            ((System.ComponentModel.ISupportInitialize)(this.coordinateGPSMinutes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordinateGPSdegrees.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordinateGPSSseconds.Properties)).EndInit();
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl coordinateGPSLabel;
        private DevExpress.XtraEditors.TextEdit coordinateGPSMinutes;
        private DevExpress.XtraEditors.TextEdit coordinateGPSdegrees;
        private DevExpress.XtraEditors.TextEdit coordinateGPSSseconds;
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

    }
}