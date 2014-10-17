namespace PrizmMain.Forms
{
    partial class RolesPrivilegeEditXtraForm
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
            this.roleLabel = new DevExpress.XtraEditors.LabelControl();
            this.privilegesCheckedList = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.roleEdit = new DevExpress.XtraEditors.TextEdit();
            this.privilegesLabel = new DevExpress.XtraEditors.LabelControl();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.privilegesCheckedList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // roleLabel
            // 
            this.roleLabel.Location = new System.Drawing.Point(12, 12);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(21, 13);
            this.roleLabel.TabIndex = 9;
            this.roleLabel.Text = "Role";
            // 
            // privilegesCheckedList
            // 
            this.privilegesCheckedList.Location = new System.Drawing.Point(12, 76);
            this.privilegesCheckedList.Name = "privilegesCheckedList";
            this.privilegesCheckedList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.privilegesCheckedList.Size = new System.Drawing.Size(318, 212);
            this.privilegesCheckedList.TabIndex = 10;
            // 
            // roleEdit
            // 
            this.roleEdit.Location = new System.Drawing.Point(12, 31);
            this.roleEdit.Name = "roleEdit";
            this.roleEdit.Size = new System.Drawing.Size(318, 20);
            this.roleEdit.TabIndex = 11;
            // 
            // privilegesLabel
            // 
            this.privilegesLabel.Location = new System.Drawing.Point(12, 57);
            this.privilegesLabel.Name = "privilegesLabel";
            this.privilegesLabel.Size = new System.Drawing.Size(45, 13);
            this.privilegesLabel.TabIndex = 13;
            this.privilegesLabel.Text = "Privileges";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(174, 294);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(255, 294);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // RolesPrivilegeEditXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 329);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.privilegesLabel);
            this.Controls.Add(this.roleEdit);
            this.Controls.Add(this.privilegesCheckedList);
            this.Controls.Add(this.roleLabel);
            this.Name = "RolesPrivilegeEditXtraForm";
            this.Text = "Edit roles";
            ((System.ComponentModel.ISupportInitialize)(this.privilegesCheckedList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl roleLabel;
        private DevExpress.XtraEditors.CheckedListBoxControl privilegesCheckedList;
        private DevExpress.XtraEditors.TextEdit roleEdit;
        private DevExpress.XtraEditors.LabelControl privilegesLabel;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
    }
}