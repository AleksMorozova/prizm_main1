namespace PrizmMain.Forms
{
    partial class SpoolsXtraForm
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
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.pipeNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pipeNumberLabel = new DevExpress.XtraEditors.LabelControl();
            this.pipeLengthLabel = new DevExpress.XtraEditors.LabelControl();
            this.spoollengthLabel = new DevExpress.XtraEditors.LabelControl();
            this.spoolLength = new DevExpress.XtraEditors.TextEdit();
            this.pipeLength = new DevExpress.XtraEditors.TextEdit();
            this.spoolNumberLabel = new DevExpress.XtraEditors.LabelControl();
            this.spoolNumber = new DevExpress.XtraEditors.TextEdit();
            this.length = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.length)).BeginInit();
            this.length.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(232, 51);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 39;
            this.searchButton.Text = "Search";
            // 
            // pipeNumber
            // 
            this.pipeNumber.Location = new System.Drawing.Point(27, 54);
            this.pipeNumber.Name = "pipeNumber";
            this.pipeNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pipeNumber.Size = new System.Drawing.Size(141, 20);
            this.pipeNumber.TabIndex = 38;
            // 
            // pipeNumberLabel
            // 
            this.pipeNumberLabel.Location = new System.Drawing.Point(27, 35);
            this.pipeNumberLabel.Name = "pipeNumberLabel";
            this.pipeNumberLabel.Size = new System.Drawing.Size(59, 13);
            this.pipeNumberLabel.TabIndex = 37;
            this.pipeNumberLabel.Text = "Pipe number";
            // 
            // pipeLengthLabel
            // 
            this.pipeLengthLabel.Location = new System.Drawing.Point(18, 31);
            this.pipeLengthLabel.Name = "pipeLengthLabel";
            this.pipeLengthLabel.Size = new System.Drawing.Size(20, 13);
            this.pipeLengthLabel.TabIndex = 19;
            this.pipeLengthLabel.Text = "Pipe";
            // 
            // spoollengthLabel
            // 
            this.spoollengthLabel.Location = new System.Drawing.Point(116, 29);
            this.spoollengthLabel.Name = "spoollengthLabel";
            this.spoollengthLabel.Size = new System.Drawing.Size(26, 13);
            this.spoollengthLabel.TabIndex = 20;
            this.spoollengthLabel.Text = "Spool";
            // 
            // spoolLength
            // 
            this.spoolLength.Location = new System.Drawing.Point(116, 54);
            this.spoolLength.Name = "spoolLength";
            this.spoolLength.Size = new System.Drawing.Size(73, 20);
            this.spoolLength.TabIndex = 16;
            // 
            // pipeLength
            // 
            this.pipeLength.Location = new System.Drawing.Point(18, 54);
            this.pipeLength.Name = "pipeLength";
            this.pipeLength.Properties.ReadOnly = true;
            this.pipeLength.Size = new System.Drawing.Size(73, 20);
            this.pipeLength.TabIndex = 13;
            // 
            // spoolNumberLabel
            // 
            this.spoolNumberLabel.Location = new System.Drawing.Point(27, 100);
            this.spoolNumberLabel.Name = "spoolNumberLabel";
            this.spoolNumberLabel.Size = new System.Drawing.Size(65, 13);
            this.spoolNumberLabel.TabIndex = 40;
            this.spoolNumberLabel.Text = "Spool number";
            // 
            // spoolNumber
            // 
            this.spoolNumber.Location = new System.Drawing.Point(27, 119);
            this.spoolNumber.Name = "spoolNumber";
            this.spoolNumber.Size = new System.Drawing.Size(100, 20);
            this.spoolNumber.TabIndex = 41;
            // 
            // length
            // 
            this.length.Controls.Add(this.pipeLength);
            this.length.Controls.Add(this.spoolLength);
            this.length.Controls.Add(this.spoollengthLabel);
            this.length.Controls.Add(this.pipeLengthLabel);
            this.length.Location = new System.Drawing.Point(27, 177);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(200, 100);
            this.length.TabIndex = 42;
            this.length.Text = "Length";
            // 
            // SpoolsXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 386);
            this.Controls.Add(this.length);
            this.Controls.Add(this.spoolNumber);
            this.Controls.Add(this.spoolNumberLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.pipeNumber);
            this.Controls.Add(this.pipeNumberLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SpoolsXtraForm";
            this.Text = "Spools";
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoolNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.length)).EndInit();
            this.length.ResumeLayout(false);
            this.length.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraEditors.ComboBoxEdit pipeNumber;
        private DevExpress.XtraEditors.LabelControl pipeNumberLabel;
        private DevExpress.XtraEditors.LabelControl pipeLengthLabel;
        private DevExpress.XtraEditors.LabelControl spoollengthLabel;
        private DevExpress.XtraEditors.TextEdit spoolLength;
        private DevExpress.XtraEditors.TextEdit pipeLength;
        private DevExpress.XtraEditors.LabelControl spoolNumberLabel;
        private DevExpress.XtraEditors.TextEdit spoolNumber;
        private DevExpress.XtraEditors.GroupControl length;
    }
}