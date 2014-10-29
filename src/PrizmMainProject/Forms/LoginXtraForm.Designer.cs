namespace PrizmMain.Forms
{
    partial class LoginXtraForm
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
            this.login = new DevExpress.XtraEditors.TextEdit();
            this.loginLabel = new DevExpress.XtraEditors.LabelControl();
            this.password = new DevExpress.XtraEditors.TextEdit();
            this.passwordLabel = new DevExpress.XtraEditors.LabelControl();
            this.enter = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.login.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login.Location = new System.Drawing.Point(64, 20);
            this.login.Margin = new System.Windows.Forms.Padding(11);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(164, 20);
            this.login.TabIndex = 0;
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginLabel.Location = new System.Drawing.Point(20, 23);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(30, 13);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Логин";
            // 
            // password
            // 
            this.password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password.Location = new System.Drawing.Point(64, 58);
            this.password.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(164, 20);
            this.password.TabIndex = 2;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLabel.Location = new System.Drawing.Point(20, 61);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(37, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Пароль";
            // 
            // enter
            // 
            this.enter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enter.Location = new System.Drawing.Point(64, 92);
            this.enter.Margin = new System.Windows.Forms.Padding(11);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(164, 23);
            this.enter.TabIndex = 4;
            this.enter.Text = "Войти";
            // 
            // LoginXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 132);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.login);
            this.Name = "LoginXtraForm";
            this.Text = "Вход в систему";
            ((System.ComponentModel.ISupportInitialize)(this.login.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit login;
        private DevExpress.XtraEditors.LabelControl loginLabel;
        private DevExpress.XtraEditors.TextEdit password;
        private DevExpress.XtraEditors.LabelControl passwordLabel;
        private DevExpress.XtraEditors.SimpleButton enter;
    }
}