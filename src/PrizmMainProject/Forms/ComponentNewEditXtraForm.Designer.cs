namespace PrizmMain.Forms
{
    partial class ComponentNewEditXtraForm
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
            this.componentNumber = new DevExpress.XtraEditors.TextEdit();
            this.componentNumberLabel = new DevExpress.XtraEditors.LabelControl();
            this.certificateNumber = new DevExpress.XtraEditors.TextEdit();
            this.certificateNumberLabel = new DevExpress.XtraEditors.LabelControl();
            this.componentParameters = new DevExpress.XtraGrid.GridControl();
            this.componentParametersView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.diameterGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.wallThicknessGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.typeLabel = new DevExpress.XtraEditors.LabelControl();
            this.type = new DevExpress.XtraEditors.ComboBoxEdit();
            this.inspection = new DevExpress.XtraEditors.GroupControl();
            this.reasonLabel = new DevExpress.XtraEditors.LabelControl();
            this.rejectedReason = new DevExpress.XtraEditors.TextEdit();
            this.resultRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.inspectionDateLabel = new DevExpress.XtraEditors.LabelControl();
            this.inspectorLabel = new DevExpress.XtraEditors.LabelControl();
            this.resultLabel = new DevExpress.XtraEditors.LabelControl();
            this.inspectionDate = new DevExpress.XtraEditors.DateEdit();
            this.inspector = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.componentNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentParameters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentParametersView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspection)).BeginInit();
            this.inspection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rejectedReason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspector.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // componentNumber
            // 
            this.componentNumber.Location = new System.Drawing.Point(26, 34);
            this.componentNumber.Name = "componentNumber";
            this.componentNumber.Size = new System.Drawing.Size(100, 20);
            this.componentNumber.TabIndex = 0;
            // 
            // componentNumberLabel
            // 
            this.componentNumberLabel.Location = new System.Drawing.Point(26, 12);
            this.componentNumberLabel.Name = "componentNumberLabel";
            this.componentNumberLabel.Size = new System.Drawing.Size(94, 13);
            this.componentNumberLabel.TabIndex = 1;
            this.componentNumberLabel.Text = "Component number";
            // 
            // certificateNumber
            // 
            this.certificateNumber.Location = new System.Drawing.Point(26, 146);
            this.certificateNumber.Name = "certificateNumber";
            this.certificateNumber.Size = new System.Drawing.Size(100, 20);
            this.certificateNumber.TabIndex = 2;
            // 
            // certificateNumberLabel
            // 
            this.certificateNumberLabel.Location = new System.Drawing.Point(26, 127);
            this.certificateNumberLabel.Name = "certificateNumberLabel";
            this.certificateNumberLabel.Size = new System.Drawing.Size(89, 13);
            this.certificateNumberLabel.TabIndex = 3;
            this.certificateNumberLabel.Text = "Certificate number";
            // 
            // componentParameters
            // 
            this.componentParameters.Cursor = System.Windows.Forms.Cursors.Default;
            this.componentParameters.Location = new System.Drawing.Point(284, 37);
            this.componentParameters.MainView = this.componentParametersView;
            this.componentParameters.Name = "componentParameters";
            this.componentParameters.Size = new System.Drawing.Size(400, 129);
            this.componentParameters.TabIndex = 4;
            this.componentParameters.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.componentParametersView});
            // 
            // componentParametersView
            // 
            this.componentParametersView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.diameterGridColumn,
            this.wallThicknessGridColumn});
            this.componentParametersView.GridControl = this.componentParameters;
            this.componentParametersView.Name = "componentParametersView";
            this.componentParametersView.OptionsView.ShowGroupPanel = false;
            // 
            // diameterGridColumn
            // 
            this.diameterGridColumn.Caption = "Bore diameter";
            this.diameterGridColumn.Name = "diameterGridColumn";
            this.diameterGridColumn.Visible = true;
            this.diameterGridColumn.VisibleIndex = 0;
            // 
            // wallThicknessGridColumn
            // 
            this.wallThicknessGridColumn.Caption = "Wall thickness";
            this.wallThicknessGridColumn.Name = "wallThicknessGridColumn";
            this.wallThicknessGridColumn.Visible = true;
            this.wallThicknessGridColumn.VisibleIndex = 1;
            // 
            // typeLabel
            // 
            this.typeLabel.Location = new System.Drawing.Point(26, 71);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(24, 13);
            this.typeLabel.TabIndex = 5;
            this.typeLabel.Text = "Type";
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(26, 90);
            this.type.Name = "type";
            this.type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.type.Size = new System.Drawing.Size(100, 20);
            this.type.TabIndex = 6;
            // 
            // inspection
            // 
            this.inspection.Controls.Add(this.reasonLabel);
            this.inspection.Controls.Add(this.rejectedReason);
            this.inspection.Controls.Add(this.resultRadioGroup);
            this.inspection.Controls.Add(this.inspectionDateLabel);
            this.inspection.Controls.Add(this.inspectorLabel);
            this.inspection.Controls.Add(this.resultLabel);
            this.inspection.Controls.Add(this.inspectionDate);
            this.inspection.Controls.Add(this.inspector);
            this.inspection.Location = new System.Drawing.Point(26, 222);
            this.inspection.Name = "inspection";
            this.inspection.Size = new System.Drawing.Size(672, 165);
            this.inspection.TabIndex = 7;
            this.inspection.Text = "Inspection";
            // 
            // reasonLabel
            // 
            this.reasonLabel.Location = new System.Drawing.Point(493, 39);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(36, 13);
            this.reasonLabel.TabIndex = 8;
            this.reasonLabel.Text = "Reason";
            // 
            // rejectedReason
            // 
            this.rejectedReason.Location = new System.Drawing.Point(493, 58);
            this.rejectedReason.Name = "rejectedReason";
            this.rejectedReason.Size = new System.Drawing.Size(165, 20);
            this.rejectedReason.TabIndex = 7;
            // 
            // resultRadioGroup
            // 
            this.resultRadioGroup.Location = new System.Drawing.Point(393, 58);
            this.resultRadioGroup.Name = "resultRadioGroup";
            this.resultRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.resultRadioGroup.Properties.Appearance.Options.UseBackColor = true;
            this.resultRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "accepted"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "hold "),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "rejected ")});
            this.resultRadioGroup.Size = new System.Drawing.Size(85, 96);
            this.resultRadioGroup.TabIndex = 6;
            // 
            // inspectionDateLabel
            // 
            this.inspectionDateLabel.Location = new System.Drawing.Point(5, 101);
            this.inspectionDateLabel.Name = "inspectionDateLabel";
            this.inspectionDateLabel.Size = new System.Drawing.Size(75, 13);
            this.inspectionDateLabel.TabIndex = 5;
            this.inspectionDateLabel.Text = "Inspection date";
            // 
            // inspectorLabel
            // 
            this.inspectorLabel.Location = new System.Drawing.Point(5, 36);
            this.inspectorLabel.Name = "inspectorLabel";
            this.inspectorLabel.Size = new System.Drawing.Size(46, 13);
            this.inspectorLabel.TabIndex = 4;
            this.inspectorLabel.Text = "Inspector";
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(393, 39);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(30, 13);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "Result";
            // 
            // inspectionDate
            // 
            this.inspectionDate.EditValue = null;
            this.inspectionDate.Location = new System.Drawing.Point(5, 120);
            this.inspectionDate.Name = "inspectionDate";
            this.inspectionDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.inspectionDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.inspectionDate.Size = new System.Drawing.Size(209, 20);
            this.inspectionDate.TabIndex = 2;
            // 
            // inspector
            // 
            this.inspector.Location = new System.Drawing.Point(5, 55);
            this.inspector.Name = "inspector";
            this.inspector.Size = new System.Drawing.Size(209, 20);
            this.inspector.TabIndex = 1;
            // 
            // ComponentNewEditXtraForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 425);
            this.ControlBox = false;
            this.Controls.Add(this.inspection);
            this.Controls.Add(this.type);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.componentParameters);
            this.Controls.Add(this.certificateNumberLabel);
            this.Controls.Add(this.certificateNumber);
            this.Controls.Add(this.componentNumberLabel);
            this.Controls.Add(this.componentNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComponentNewEditXtraForm";
            this.Text = "ComponentryNewEditXtraForm";
            ((System.ComponentModel.ISupportInitialize)(this.componentNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificateNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentParameters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentParametersView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspection)).EndInit();
            this.inspection.ResumeLayout(false);
            this.inspection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rejectedReason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspector.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit componentNumber;
        private DevExpress.XtraEditors.LabelControl componentNumberLabel;
        private DevExpress.XtraEditors.TextEdit certificateNumber;
        private DevExpress.XtraEditors.LabelControl certificateNumberLabel;
        private DevExpress.XtraGrid.GridControl componentParameters;
        private DevExpress.XtraGrid.Views.Grid.GridView componentParametersView;
        private DevExpress.XtraGrid.Columns.GridColumn diameterGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn wallThicknessGridColumn;
        private DevExpress.XtraEditors.LabelControl typeLabel;
        private DevExpress.XtraEditors.ComboBoxEdit type;
        private DevExpress.XtraEditors.GroupControl inspection;
        private DevExpress.XtraEditors.LabelControl inspectionDateLabel;
        private DevExpress.XtraEditors.LabelControl inspectorLabel;
        private DevExpress.XtraEditors.LabelControl resultLabel;
        private DevExpress.XtraEditors.DateEdit inspectionDate;
        private DevExpress.XtraEditors.TextEdit inspector;
        private DevExpress.XtraEditors.LabelControl reasonLabel;
        private DevExpress.XtraEditors.TextEdit rejectedReason;
        private DevExpress.XtraEditors.RadioGroup resultRadioGroup;
    }
}