namespace PrizmMain.Forms
{
    partial class ExternalFilesXtraForm
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
            this.files = new DevExpress.XtraGrid.GridControl();
            this.fileBindingSource = new System.Windows.Forms.BindingSource();
            this.filesView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUploadDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.addFile = new DevExpress.XtraEditors.SimpleButton();
            this.viewFile = new DevExpress.XtraEditors.SimpleButton();
            this.downloadFile = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.files)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesView)).BeginInit();
            this.SuspendLayout();
            // 
            // files
            // 
            this.files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.files.Cursor = System.Windows.Forms.Cursors.Default;
            this.files.DataSource = this.fileBindingSource;
            this.files.Location = new System.Drawing.Point(20, 20);
            this.files.MainView = this.filesView;
            this.files.Margin = new System.Windows.Forms.Padding(11);
            this.files.Name = "files";
            this.files.Size = new System.Drawing.Size(475, 251);
            this.files.TabIndex = 0;
            this.files.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.filesView});
            // 
            // filesView
            // 
            this.filesView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFileName,
            this.colDescription,
            this.colUploadDate});
            this.filesView.GridControl = this.files;
            this.filesView.Name = "filesView";
            // 
            // colFileName
            // 
            this.colFileName.FieldName = "Имя файла";
            this.colFileName.Name = "colFileName";
            this.colFileName.Visible = true;
            this.colFileName.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Описание";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            // 
            // colUploadDate
            // 
            this.colUploadDate.FieldName = "Дата добавления";
            this.colUploadDate.Name = "colUploadDate";
            this.colUploadDate.Visible = true;
            this.colUploadDate.VisibleIndex = 2;
            // 
            // addFile
            // 
            this.addFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addFile.Location = new System.Drawing.Point(20, 293);
            this.addFile.Margin = new System.Windows.Forms.Padding(11);
            this.addFile.Name = "addFile";
            this.addFile.Size = new System.Drawing.Size(113, 23);
            this.addFile.TabIndex = 1;
            this.addFile.Text = "Добавить файл";
            // 
            // viewFile
            // 
            this.viewFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.viewFile.Location = new System.Drawing.Point(208, 293);
            this.viewFile.Margin = new System.Windows.Forms.Padding(11);
            this.viewFile.Name = "viewFile";
            this.viewFile.Size = new System.Drawing.Size(113, 23);
            this.viewFile.TabIndex = 2;
            this.viewFile.Text = "Просмотреть файл";
            // 
            // downloadFile
            // 
            this.downloadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadFile.Location = new System.Drawing.Point(382, 293);
            this.downloadFile.Margin = new System.Windows.Forms.Padding(11);
            this.downloadFile.Name = "downloadFile";
            this.downloadFile.Size = new System.Drawing.Size(113, 23);
            this.downloadFile.TabIndex = 3;
            this.downloadFile.Text = "Извлечь файл";
            // 
            // ExternalFilesXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 336);
            this.Controls.Add(this.downloadFile);
            this.Controls.Add(this.viewFile);
            this.Controls.Add(this.addFile);
            this.Controls.Add(this.files);
            this.Name = "ExternalFilesXtraForm";
            this.Text = "ExternalFilesXtraForm";
            ((System.ComponentModel.ISupportInitialize)(this.files)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl files;
        private DevExpress.XtraGrid.Views.Grid.GridView filesView;
        private System.Windows.Forms.BindingSource fileBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFileName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colUploadDate;
        private DevExpress.XtraEditors.SimpleButton addFile;
        private DevExpress.XtraEditors.SimpleButton viewFile;
        private DevExpress.XtraEditors.SimpleButton downloadFile;
    }
}