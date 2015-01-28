namespace Prizm.Main.Forms.Synch
{
   partial class ExportForm
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
            this.exportTabs = new DevExpress.XtraTab.XtraTabControl();
            this.logTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.progressPanel = new DevExpress.XtraWaitForm.ProgressPanel();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.log = new System.Windows.Forms.RichTextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.historyTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.btnReexport = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlHistory = new DevExpress.XtraGrid.GridControl();
            this.gridViewHistory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.portionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumnExportDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.exportTabs)).BeginInit();
            this.exportTabs.SuspendLayout();
            this.logTabPage.SuspendLayout();
            this.historyTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // exportTabs
            // 
            this.exportTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exportTabs.Location = new System.Drawing.Point(0, 0);
            this.exportTabs.Name = "exportTabs";
            this.exportTabs.SelectedTabPage = this.logTabPage;
            this.exportTabs.Size = new System.Drawing.Size(727, 528);
            this.exportTabs.TabIndex = 0;
            this.exportTabs.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.logTabPage,
            this.historyTabPage});
            // 
            // logTabPage
            // 
            this.logTabPage.Controls.Add(this.progressPanel);
            this.logTabPage.Controls.Add(this.btnExport);
            this.logTabPage.Controls.Add(this.log);
            this.logTabPage.Controls.Add(this.lblLog);
            this.logTabPage.Name = "logTabPage";
            this.logTabPage.Size = new System.Drawing.Size(721, 500);
            this.logTabPage.Text = "Экспорт";
            // 
            // progressPanel
            // 
            this.progressPanel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel.Appearance.Options.UseBackColor = true;
            this.progressPanel.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressPanel.AppearanceCaption.Options.UseFont = true;
            this.progressPanel.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressPanel.AppearanceDescription.Options.UseFont = true;
            this.progressPanel.Caption = "Пожалуйста подождите";
            this.progressPanel.Description = "Экспорт данных...";
            this.progressPanel.Location = new System.Drawing.Point(11, 457);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(246, 40);
            this.progressPanel.TabIndex = 3;
            this.progressPanel.Text = "progressPanel";
            this.progressPanel.Visible = false;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Image = global::Prizm.Main.Properties.Resources.export_icon;
            this.btnExport.Location = new System.Drawing.Point(586, 444);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(127, 48);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "&Экспортировать";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // log
            // 
            this.log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.Location = new System.Drawing.Point(12, 26);
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.Size = new System.Drawing.Size(702, 413);
            this.log.TabIndex = 1;
            this.log.Text = "";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(11, 9);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(47, 13);
            this.lblLog.TabIndex = 0;
            this.lblLog.Text = "Журнал";
            // 
            // historyTabPage
            // 
            this.historyTabPage.Controls.Add(this.btnReexport);
            this.historyTabPage.Controls.Add(this.gridControlHistory);
            this.historyTabPage.Name = "historyTabPage";
            this.historyTabPage.Size = new System.Drawing.Size(721, 500);
            this.historyTabPage.Text = "История";
            // 
            // btnReexport
            // 
            this.btnReexport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReexport.Image = global::Prizm.Main.Properties.Resources.export_icon;
            this.btnReexport.Location = new System.Drawing.Point(542, 445);
            this.btnReexport.Name = "btnReexport";
            this.btnReexport.Size = new System.Drawing.Size(172, 48);
            this.btnReexport.TabIndex = 1;
            this.btnReexport.Text = "&Переэкспортировать";
            this.btnReexport.Click += new System.EventHandler(this.btnReexport_Click);
            // 
            // gridControlHistory
            // 
            this.gridControlHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlHistory.Location = new System.Drawing.Point(10, 10);
            this.gridControlHistory.MainView = this.gridViewHistory;
            this.gridControlHistory.Name = "gridControlHistory";
            this.gridControlHistory.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit,
            this.repositoryItemDateEdit});
            this.gridControlHistory.Size = new System.Drawing.Size(704, 429);
            this.gridControlHistory.TabIndex = 0;
            this.gridControlHistory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHistory});
            // 
            // gridViewHistory
            // 
            this.gridViewHistory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.portionId,
            this.gridColumnExportDate});
            this.gridViewHistory.GridControl = this.gridControlHistory;
            this.gridViewHistory.Name = "gridViewHistory";
            this.gridViewHistory.OptionsBehavior.Editable = false;
            this.gridViewHistory.OptionsBehavior.ReadOnly = true;
            this.gridViewHistory.OptionsView.ShowGroupPanel = false;
            // 
            // portionId
            // 
            this.portionId.Caption = "ID порции";
            this.portionId.ColumnEdit = this.repositoryItemTextEdit;
            this.portionId.FieldName = "Id";
            this.portionId.Name = "portionId";
            this.portionId.OptionsColumn.ReadOnly = true;
            this.portionId.Visible = true;
            this.portionId.VisibleIndex = 0;
            // 
            // repositoryItemTextEdit
            // 
            this.repositoryItemTextEdit.AutoHeight = false;
            this.repositoryItemTextEdit.Name = "repositoryItemTextEdit";
            this.repositoryItemTextEdit.ReadOnly = true;
            // 
            // gridColumnExportDate
            // 
            this.gridColumnExportDate.Caption = "Дата экспорта";
            this.gridColumnExportDate.ColumnEdit = this.repositoryItemDateEdit;
            this.gridColumnExportDate.FieldName = "ExportDateTime";
            this.gridColumnExportDate.Name = "gridColumnExportDate";
            this.gridColumnExportDate.OptionsColumn.ReadOnly = true;
            this.gridColumnExportDate.Visible = true;
            this.gridColumnExportDate.VisibleIndex = 1;
            // 
            // repositoryItemDateEdit
            // 
            this.repositoryItemDateEdit.AutoHeight = false;
            this.repositoryItemDateEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit.DisplayFormat.FormatString = "g";
            this.repositoryItemDateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit.Name = "repositoryItemDateEdit";
            this.repositoryItemDateEdit.ReadOnly = true;
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 528);
            this.Controls.Add(this.exportTabs);
            this.Name = "ExportForm";
            this.ShowIcon = false;
            this.Text = "Экспорт";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExportForm_FormClosing);
            this.Load += new System.EventHandler(this.ExportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exportTabs)).EndInit();
            this.exportTabs.ResumeLayout(false);
            this.logTabPage.ResumeLayout(false);
            this.logTabPage.PerformLayout();
            this.historyTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit)).EndInit();
            this.ResumeLayout(false);

      }

      #endregion

      private DevExpress.XtraTab.XtraTabControl exportTabs;
      private DevExpress.XtraTab.XtraTabPage logTabPage;
      private DevExpress.XtraTab.XtraTabPage historyTabPage;
      private DevExpress.XtraEditors.SimpleButton btnExport;
      private System.Windows.Forms.RichTextBox log;
      private System.Windows.Forms.Label lblLog;
      private DevExpress.XtraGrid.GridControl gridControlHistory;
      private DevExpress.XtraGrid.Views.Grid.GridView gridViewHistory;
      private DevExpress.XtraGrid.Columns.GridColumn portionId;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnExportDate;
      private DevExpress.XtraEditors.SimpleButton btnReexport;
      private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit;
      private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit;
      private DevExpress.XtraWaitForm.ProgressPanel progressPanel;

   }
}