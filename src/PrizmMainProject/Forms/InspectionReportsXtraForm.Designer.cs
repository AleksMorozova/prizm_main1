namespace PrizmMain.Forms
{
    partial class InspectionReportsXtraForm
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
            this.previewButton = new DevExpress.XtraEditors.SimpleButton();
            this.createReportButton = new DevExpress.XtraEditors.SimpleButton();
            this.toDate = new DevExpress.XtraEditors.DateEdit();
            this.fromDate = new DevExpress.XtraEditors.DateEdit();
            this.toLabel = new DevExpress.XtraEditors.LabelControl();
            this.fromLabel = new DevExpress.XtraEditors.LabelControl();
            this.previewReportDocument = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            ((System.ComponentModel.ISupportInitialize)(this.toDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(471, 17);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(73, 23);
            this.previewButton.TabIndex = 56;
            this.previewButton.Text = "Preview";
            // 
            // createReportButton
            // 
            this.createReportButton.Location = new System.Drawing.Point(566, 17);
            this.createReportButton.Name = "createReportButton";
            this.createReportButton.Size = new System.Drawing.Size(75, 23);
            this.createReportButton.TabIndex = 55;
            this.createReportButton.Text = "Create report";
            // 
            // toDate
            // 
            this.toDate.EditValue = null;
            this.toDate.Location = new System.Drawing.Point(174, 14);
            this.toDate.Name = "toDate";
            this.toDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toDate.Size = new System.Drawing.Size(90, 20);
            this.toDate.TabIndex = 54;
            // 
            // fromDate
            // 
            this.fromDate.EditValue = null;
            this.fromDate.Location = new System.Drawing.Point(40, 14);
            this.fromDate.Name = "fromDate";
            this.fromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fromDate.Size = new System.Drawing.Size(90, 20);
            this.fromDate.TabIndex = 53;
            // 
            // toLabel
            // 
            this.toLabel.Location = new System.Drawing.Point(158, 17);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(10, 13);
            this.toLabel.TabIndex = 52;
            this.toLabel.Text = "to";
            // 
            // fromLabel
            // 
            this.fromLabel.Location = new System.Drawing.Point(12, 17);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(22, 13);
            this.fromLabel.TabIndex = 51;
            this.fromLabel.Text = "from";
            // 
            // previewReportDocument
            // 
            this.previewReportDocument.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.previewReportDocument.IsMetric = false;
            this.previewReportDocument.Location = new System.Drawing.Point(0, 72);
            this.previewReportDocument.Name = "previewReportDocument";
            this.previewReportDocument.Size = new System.Drawing.Size(709, 314);
            this.previewReportDocument.TabIndex = 50;
            // 
            // InspectionReportsXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 386);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.createReportButton);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.previewReportDocument);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InspectionReportsXtraForm";
            this.Text = "InspectionsReportXtraForm";
            ((System.ComponentModel.ISupportInitialize)(this.toDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton previewButton;
        private DevExpress.XtraEditors.SimpleButton createReportButton;
        private DevExpress.XtraEditors.DateEdit toDate;
        private DevExpress.XtraEditors.DateEdit fromDate;
        private DevExpress.XtraEditors.LabelControl toLabel;
        private DevExpress.XtraEditors.LabelControl fromLabel;
        private DevExpress.XtraPrinting.Preview.DocumentViewer previewReportDocument;
    }
}