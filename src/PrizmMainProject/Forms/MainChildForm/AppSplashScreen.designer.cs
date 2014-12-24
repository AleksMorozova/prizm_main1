namespace Prizm.Main.Forms.MainChildForm
{
    partial class AppSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppSplashScreen));
            this.marqueeProgressBarControl = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.labelCopyright = new DevExpress.XtraEditors.LabelControl();
            this.labelMessage = new DevExpress.XtraEditors.LabelControl();
            this.pictureEditTop = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEditBottom = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditTop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditBottom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // marqueeProgressBarControl
            // 
            this.marqueeProgressBarControl.EditValue = 0;
            this.marqueeProgressBarControl.Location = new System.Drawing.Point(23, 231);
            this.marqueeProgressBarControl.Name = "marqueeProgressBarControl";
            this.marqueeProgressBarControl.Size = new System.Drawing.Size(404, 12);
            this.marqueeProgressBarControl.TabIndex = 5;
            // 
            // labelCopyright
            // 
            this.labelCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelCopyright.Location = new System.Drawing.Point(23, 286);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(115, 13);
            this.labelCopyright.TabIndex = 6;
            this.labelCopyright.Text = "Copyright © 1998-2013";
            this.labelCopyright.Visible = false;
            // 
            // labelMessage
            // 
            this.labelMessage.Location = new System.Drawing.Point(23, 206);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(50, 13);
            this.labelMessage.TabIndex = 7;
            this.labelMessage.Text = "Starting...";
            // 
            // pictureEditTop
            // 
            this.pictureEditTop.EditValue = ((object)(resources.GetObject("pictureEditTop.EditValue")));
            this.pictureEditTop.Location = new System.Drawing.Point(12, 12);
            this.pictureEditTop.Name = "pictureEditTop";
            this.pictureEditTop.Properties.AllowFocused = false;
            this.pictureEditTop.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEditTop.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEditTop.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEditTop.Properties.ShowMenu = false;
            this.pictureEditTop.Size = new System.Drawing.Size(426, 180);
            this.pictureEditTop.TabIndex = 9;
            // 
            // pictureEditBottom
            // 
            this.pictureEditBottom.EditValue = ((object)(resources.GetObject("pictureEditBottom.EditValue")));
            this.pictureEditBottom.Location = new System.Drawing.Point(278, 266);
            this.pictureEditBottom.Name = "pictureEditBottom";
            this.pictureEditBottom.Properties.AllowFocused = false;
            this.pictureEditBottom.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEditBottom.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEditBottom.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEditBottom.Properties.ShowMenu = false;
            this.pictureEditBottom.Size = new System.Drawing.Size(160, 48);
            this.pictureEditBottom.TabIndex = 8;
            this.pictureEditBottom.Visible = false;
            // 
            // AppSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 320);
            this.Controls.Add(this.pictureEditTop);
            this.Controls.Add(this.pictureEditBottom);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.marqueeProgressBarControl);
            this.Name = "AppSplashScreen";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditTop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditBottom.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MarqueeProgressBarControl marqueeProgressBarControl;
        private DevExpress.XtraEditors.LabelControl labelCopyright;
        private DevExpress.XtraEditors.LabelControl labelMessage;
        private DevExpress.XtraEditors.PictureEdit pictureEditBottom;
        private DevExpress.XtraEditors.PictureEdit pictureEditTop;
    }
}
