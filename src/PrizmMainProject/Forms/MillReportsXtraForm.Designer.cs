namespace PrizmMain.Forms
{
    partial class MillReportsXtraForm
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
            this.dateLabel = new DevExpress.XtraEditors.LabelControl();
            this.previewReportDocument = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.date = new DevExpress.XtraEditors.DateEdit();
            this.previewButton = new DevExpress.XtraEditors.SimpleButton();
            this.createReportButton = new DevExpress.XtraEditors.SimpleButton();
            this.millStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.millStatusLabel = new DevExpress.XtraEditors.LabelControl();
            this.heatNumber = new DevExpress.XtraEditors.TextEdit();
            this.externalCoatingTeam = new DevExpress.XtraEditors.ComboBoxEdit();
            this.externalCoatingTeamLable = new DevExpress.XtraEditors.LabelControl();
            this.internalCoatingTeam = new DevExpress.XtraEditors.ComboBoxEdit();
            this.internalCoatingTeamLabel = new DevExpress.XtraEditors.LabelControl();
            this.weldingTeam = new DevExpress.XtraEditors.ComboBoxEdit();
            this.weldingTeamLabel = new DevExpress.XtraEditors.LabelControl();
            this.heatNumberLabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.millStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalCoatingTeam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internalCoatingTeam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingTeam.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(408, 51);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(23, 13);
            this.dateLabel.TabIndex = 79;
            this.dateLabel.Text = "Date";
            // 
            // previewReportDocument
            // 
            this.previewReportDocument.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.previewReportDocument.IsMetric = false;
            this.previewReportDocument.Location = new System.Drawing.Point(0, 111);
            this.previewReportDocument.Name = "previewReportDocument";
            this.previewReportDocument.Size = new System.Drawing.Size(709, 275);
            this.previewReportDocument.TabIndex = 78;
            // 
            // date
            // 
            this.date.EditValue = null;
            this.date.Location = new System.Drawing.Point(408, 70);
            this.date.Name = "date";
            this.date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date.Size = new System.Drawing.Size(82, 20);
            this.date.TabIndex = 77;
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(522, 67);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(73, 23);
            this.previewButton.TabIndex = 76;
            this.previewButton.Text = "Preview";
            // 
            // createReportButton
            // 
            this.createReportButton.Location = new System.Drawing.Point(602, 67);
            this.createReportButton.Name = "createReportButton";
            this.createReportButton.Size = new System.Drawing.Size(75, 23);
            this.createReportButton.TabIndex = 75;
            this.createReportButton.Text = "Create report";
            // 
            // millStatus
            // 
            this.millStatus.Location = new System.Drawing.Point(21, 70);
            this.millStatus.Name = "millStatus";
            this.millStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.millStatus.Size = new System.Drawing.Size(149, 20);
            this.millStatus.TabIndex = 73;
            // 
            // millStatusLabel
            // 
            this.millStatusLabel.Location = new System.Drawing.Point(21, 51);
            this.millStatusLabel.Name = "millStatusLabel";
            this.millStatusLabel.Size = new System.Drawing.Size(82, 13);
            this.millStatusLabel.TabIndex = 74;
            this.millStatusLabel.Text = "Status on the mill";
            // 
            // heatNumber
            // 
            this.heatNumber.Location = new System.Drawing.Point(21, 25);
            this.heatNumber.Name = "heatNumber";
            this.heatNumber.Size = new System.Drawing.Size(149, 20);
            this.heatNumber.TabIndex = 72;
            // 
            // externalCoatingTeam
            // 
            this.externalCoatingTeam.Location = new System.Drawing.Point(194, 25);
            this.externalCoatingTeam.Name = "externalCoatingTeam";
            this.externalCoatingTeam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.externalCoatingTeam.Size = new System.Drawing.Size(187, 20);
            this.externalCoatingTeam.TabIndex = 71;
            // 
            // externalCoatingTeamLable
            // 
            this.externalCoatingTeamLable.Location = new System.Drawing.Point(196, 6);
            this.externalCoatingTeamLable.Name = "externalCoatingTeamLable";
            this.externalCoatingTeamLable.Size = new System.Drawing.Size(105, 13);
            this.externalCoatingTeamLable.TabIndex = 70;
            this.externalCoatingTeamLable.Text = "External coating team";
            // 
            // internalCoatingTeam
            // 
            this.internalCoatingTeam.Location = new System.Drawing.Point(194, 70);
            this.internalCoatingTeam.Name = "internalCoatingTeam";
            this.internalCoatingTeam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.internalCoatingTeam.Size = new System.Drawing.Size(185, 20);
            this.internalCoatingTeam.TabIndex = 69;
            // 
            // internalCoatingTeamLabel
            // 
            this.internalCoatingTeamLabel.Location = new System.Drawing.Point(196, 51);
            this.internalCoatingTeamLabel.Name = "internalCoatingTeamLabel";
            this.internalCoatingTeamLabel.Size = new System.Drawing.Size(103, 13);
            this.internalCoatingTeamLabel.TabIndex = 68;
            this.internalCoatingTeamLabel.Text = "Internal coating team";
            // 
            // weldingTeam
            // 
            this.weldingTeam.Location = new System.Drawing.Point(408, 25);
            this.weldingTeam.Name = "weldingTeam";
            this.weldingTeam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weldingTeam.Size = new System.Drawing.Size(187, 20);
            this.weldingTeam.TabIndex = 67;
            // 
            // weldingTeamLabel
            // 
            this.weldingTeamLabel.Location = new System.Drawing.Point(410, 6);
            this.weldingTeamLabel.Name = "weldingTeamLabel";
            this.weldingTeamLabel.Size = new System.Drawing.Size(65, 13);
            this.weldingTeamLabel.TabIndex = 66;
            this.weldingTeamLabel.Text = "Welding team";
            // 
            // heatNumberLabel
            // 
            this.heatNumberLabel.Location = new System.Drawing.Point(21, 6);
            this.heatNumberLabel.Name = "heatNumberLabel";
            this.heatNumberLabel.Size = new System.Drawing.Size(62, 13);
            this.heatNumberLabel.TabIndex = 65;
            this.heatNumberLabel.Text = "Heat number";
            // 
            // MillReportsXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 386);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.previewReportDocument);
            this.Controls.Add(this.date);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.createReportButton);
            this.Controls.Add(this.millStatus);
            this.Controls.Add(this.millStatusLabel);
            this.Controls.Add(this.heatNumber);
            this.Controls.Add(this.externalCoatingTeam);
            this.Controls.Add(this.externalCoatingTeamLable);
            this.Controls.Add(this.internalCoatingTeam);
            this.Controls.Add(this.internalCoatingTeamLabel);
            this.Controls.Add(this.weldingTeam);
            this.Controls.Add(this.weldingTeamLabel);
            this.Controls.Add(this.heatNumberLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MillReportsXtraForm";
            this.Text = "MillReportsXtraForm";
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.millStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalCoatingTeam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internalCoatingTeam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weldingTeam.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl dateLabel;
        private DevExpress.XtraPrinting.Preview.DocumentViewer previewReportDocument;
        private DevExpress.XtraEditors.DateEdit date;
        private DevExpress.XtraEditors.SimpleButton previewButton;
        private DevExpress.XtraEditors.SimpleButton createReportButton;
        private DevExpress.XtraEditors.ComboBoxEdit millStatus;
        private DevExpress.XtraEditors.LabelControl millStatusLabel;
        private DevExpress.XtraEditors.TextEdit heatNumber;
        private DevExpress.XtraEditors.ComboBoxEdit externalCoatingTeam;
        private DevExpress.XtraEditors.LabelControl externalCoatingTeamLable;
        private DevExpress.XtraEditors.ComboBoxEdit internalCoatingTeam;
        private DevExpress.XtraEditors.LabelControl internalCoatingTeamLabel;
        private DevExpress.XtraEditors.ComboBoxEdit weldingTeam;
        private DevExpress.XtraEditors.LabelControl weldingTeamLabel;
        private DevExpress.XtraEditors.LabelControl heatNumberLabel;
    }
}