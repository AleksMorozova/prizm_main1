namespace PrizmMain.Forms
{
    partial class UserInfoXtraForm
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
            this.loginLabel = new DevExpress.XtraEditors.LabelControl();
            this.passwordLabel = new DevExpress.XtraEditors.LabelControl();
            this.confirmPasswordLabel = new DevExpress.XtraEditors.LabelControl();
            this.login = new DevExpress.XtraEditors.TextEdit();
            this.password = new DevExpress.XtraEditors.TextEdit();
            this.confirmPassword = new DevExpress.XtraEditors.TextEdit();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.closeButton = new DevExpress.XtraEditors.SimpleButton();
            this.userRoleLabel = new DevExpress.XtraEditors.LabelControl();
            this.lastNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.firstNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.middleNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.lastName = new DevExpress.XtraEditors.TextEdit();
            this.middleName = new DevExpress.XtraEditors.TextEdit();
            this.firstName = new DevExpress.XtraEditors.TextEdit();
            this.userRoleComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.login.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleComboBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.Location = new System.Drawing.Point(15, 113);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(25, 13);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Location = new System.Drawing.Point(12, 158);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(46, 13);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "Password";
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.Location = new System.Drawing.Point(174, 158);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(86, 13);
            this.confirmPasswordLabel.TabIndex = 0;
            this.confirmPasswordLabel.Text = "Confirm Password";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(14, 132);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(316, 20);
            this.login.TabIndex = 4;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(12, 177);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(156, 20);
            this.password.TabIndex = 5;
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(174, 177);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(156, 20);
            this.confirmPassword.TabIndex = 6;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(174, 294);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "&Save";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(255, 294);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "&Close";
            // 
            // userRoleLabel
            // 
            this.userRoleLabel.Location = new System.Drawing.Point(14, 199);
            this.userRoleLabel.Name = "userRoleLabel";
            this.userRoleLabel.Size = new System.Drawing.Size(46, 13);
            this.userRoleLabel.TabIndex = 8;
            this.userRoleLabel.Text = "User Role";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Location = new System.Drawing.Point(12, 12);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(50, 13);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Location = new System.Drawing.Point(14, 56);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(51, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.Location = new System.Drawing.Point(176, 57);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(60, 13);
            this.middleNameLabel.TabIndex = 0;
            this.middleNameLabel.Text = "Middle Name";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(12, 31);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(318, 20);
            this.lastName.TabIndex = 1;
            // 
            // middleName
            // 
            this.middleName.Location = new System.Drawing.Point(176, 75);
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(153, 20);
            this.middleName.TabIndex = 3;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(14, 75);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(156, 20);
            this.firstName.TabIndex = 2;
            // 
            // userRoleComboBox
            // 
            this.userRoleComboBox.Enabled = false;
            this.userRoleComboBox.Location = new System.Drawing.Point(13, 218);
            this.userRoleComboBox.Name = "userRoleComboBox";
            this.userRoleComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.userRoleComboBox.Size = new System.Drawing.Size(318, 20);
            this.userRoleComboBox.TabIndex = 10;
            // 
            // UserInfoXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 329);
            this.Controls.Add(this.userRoleComboBox);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.middleName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.userRoleLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Name = "UserInfoXtraForm";
            this.Text = "Edit User";
            ((System.ComponentModel.ISupportInitialize)(this.login.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleComboBox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl loginLabel;
        private DevExpress.XtraEditors.LabelControl passwordLabel;
        private DevExpress.XtraEditors.LabelControl confirmPasswordLabel;
        private DevExpress.XtraEditors.TextEdit login;
        private DevExpress.XtraEditors.TextEdit password;
        private DevExpress.XtraEditors.TextEdit confirmPassword;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.SimpleButton closeButton;
        private DevExpress.XtraEditors.LabelControl userRoleLabel;
        private DevExpress.XtraEditors.LabelControl lastNameLabel;
        private DevExpress.XtraEditors.LabelControl firstNameLabel;
        private DevExpress.XtraEditors.LabelControl middleNameLabel;
        private DevExpress.XtraEditors.TextEdit lastName;
        private DevExpress.XtraEditors.TextEdit middleName;
        private DevExpress.XtraEditors.TextEdit firstName;
        private DevExpress.XtraEditors.ComboBoxEdit userRoleComboBox;
    }
}