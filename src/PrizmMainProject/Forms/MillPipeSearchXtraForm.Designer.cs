namespace PrizmMain.Forms
{
    partial class MillPipeSearchXtraForm
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.internalCoatingDate = new DevExpress.XtraEditors.DateEdit();
            this.sizeGrade = new DevExpress.XtraEditors.ComboBoxEdit();
            this.welding = new DevExpress.XtraEditors.DateEdit();
            this.weldingDateLabel = new DevExpress.XtraEditors.LabelControl();
            this.internalCoatingLabel = new DevExpress.XtraEditors.LabelControl();
            this.externalCoatingDate = new DevExpress.XtraEditors.DateEdit();
            this.externalCoatingLabel = new DevExpress.XtraEditors.LabelControl();
            this.sizeLabel = new DevExpress.XtraEditors.LabelControl();
            this.pipeLocation = new DevExpress.XtraEditors.TextEdit();
            this.locationLabel = new DevExpress.XtraEditors.LabelControl();
            this.pipeStatus = new DevExpress.XtraEditors.TextEdit();
            this.pipeStatusLabel = new DevExpress.XtraEditors.LabelControl();
            this.pipeNumber = new DevExpress.XtraEditors.TextEdit();
            this.pipeNumberLabel = new DevExpress.XtraEditors.LabelControl();
            this.pipesSearchReselt = new DevExpress.XtraGrid.GridControl();
            this.pipesSearchResultview = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pipeNumberGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.certificateNumberGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.heatNumberGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusSearchGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.locationGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.weldingDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.internalCoatingDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.externalCoatingDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.extraGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.extraButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.pegNumberLabel = new DevExpress.XtraEditors.LabelControl();
            this.pegNumber = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.internalCoatingDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internalCoatingDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeGrade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.welding.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.welding.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalCoatingDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalCoatingDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipesSearchReselt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipesSearchResultview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegNumber.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(566, 82);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 48;
            this.searchButton.Text = "Search";
            // 
            // internalCoatingDate
            // 
            this.internalCoatingDate.EditValue = null;
            this.internalCoatingDate.Location = new System.Drawing.Point(346, 85);
            this.internalCoatingDate.Name = "internalCoatingDate";
            this.internalCoatingDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.internalCoatingDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.internalCoatingDate.Size = new System.Drawing.Size(126, 20);
            this.internalCoatingDate.TabIndex = 47;
            // 
            // sizeGrade
            // 
            this.sizeGrade.Location = new System.Drawing.Point(406, 29);
            this.sizeGrade.Name = "sizeGrade";
            this.sizeGrade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sizeGrade.Size = new System.Drawing.Size(119, 20);
            this.sizeGrade.TabIndex = 46;
            // 
            // welding
            // 
            this.welding.EditValue = null;
            this.welding.Location = new System.Drawing.Point(13, 85);
            this.welding.Name = "welding";
            this.welding.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.welding.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.welding.Size = new System.Drawing.Size(100, 20);
            this.welding.TabIndex = 45;
            // 
            // weldingDateLabel
            // 
            this.weldingDateLabel.Location = new System.Drawing.Point(12, 66);
            this.weldingDateLabel.Name = "weldingDateLabel";
            this.weldingDateLabel.Size = new System.Drawing.Size(49, 13);
            this.weldingDateLabel.TabIndex = 44;
            this.weldingDateLabel.Text = "Weld date";
            // 
            // internalCoatingLabel
            // 
            this.internalCoatingLabel.Location = new System.Drawing.Point(346, 66);
            this.internalCoatingLabel.Name = "internalCoatingLabel";
            this.internalCoatingLabel.Size = new System.Drawing.Size(101, 13);
            this.internalCoatingLabel.TabIndex = 43;
            this.internalCoatingLabel.Text = "Internal coating date";
            // 
            // externalCoatingDate
            // 
            this.externalCoatingDate.EditValue = null;
            this.externalCoatingDate.Location = new System.Drawing.Point(172, 85);
            this.externalCoatingDate.Name = "externalCoatingDate";
            this.externalCoatingDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.externalCoatingDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.externalCoatingDate.Size = new System.Drawing.Size(126, 20);
            this.externalCoatingDate.TabIndex = 42;
            // 
            // externalCoatingLabel
            // 
            this.externalCoatingLabel.Location = new System.Drawing.Point(172, 66);
            this.externalCoatingLabel.Name = "externalCoatingLabel";
            this.externalCoatingLabel.Size = new System.Drawing.Size(103, 13);
            this.externalCoatingLabel.TabIndex = 41;
            this.externalCoatingLabel.Text = "External coating date";
            // 
            // sizeLabel
            // 
            this.sizeLabel.Location = new System.Drawing.Point(406, 10);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(41, 13);
            this.sizeLabel.TabIndex = 40;
            this.sizeLabel.Text = "Pipe size";
            // 
            // pipeLocation
            // 
            this.pipeLocation.Location = new System.Drawing.Point(265, 29);
            this.pipeLocation.Name = "pipeLocation";
            this.pipeLocation.Size = new System.Drawing.Size(110, 20);
            this.pipeLocation.TabIndex = 39;
            // 
            // locationLabel
            // 
            this.locationLabel.Location = new System.Drawing.Point(265, 10);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(40, 13);
            this.locationLabel.TabIndex = 38;
            this.locationLabel.Text = "Location";
            // 
            // pipeStatus
            // 
            this.pipeStatus.Location = new System.Drawing.Point(133, 29);
            this.pipeStatus.Name = "pipeStatus";
            this.pipeStatus.Size = new System.Drawing.Size(102, 20);
            this.pipeStatus.TabIndex = 37;
            // 
            // pipeStatusLabel
            // 
            this.pipeStatusLabel.Location = new System.Drawing.Point(133, 10);
            this.pipeStatusLabel.Name = "pipeStatusLabel";
            this.pipeStatusLabel.Size = new System.Drawing.Size(31, 13);
            this.pipeStatusLabel.TabIndex = 36;
            this.pipeStatusLabel.Text = "Status";
            // 
            // pipeNumber
            // 
            this.pipeNumber.Location = new System.Drawing.Point(11, 29);
            this.pipeNumber.Name = "pipeNumber";
            this.pipeNumber.Size = new System.Drawing.Size(99, 20);
            this.pipeNumber.TabIndex = 35;
            // 
            // pipeNumberLabel
            // 
            this.pipeNumberLabel.Location = new System.Drawing.Point(11, 10);
            this.pipeNumberLabel.Name = "pipeNumberLabel";
            this.pipeNumberLabel.Size = new System.Drawing.Size(59, 13);
            this.pipeNumberLabel.TabIndex = 34;
            this.pipeNumberLabel.Text = "Pipe number";
            // 
            // pipesSearchReselt
            // 
            this.pipesSearchReselt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pipesSearchReselt.Cursor = System.Windows.Forms.Cursors.Default;
            this.pipesSearchReselt.Location = new System.Drawing.Point(11, 121);
            this.pipesSearchReselt.MainView = this.pipesSearchResultview;
            this.pipesSearchReselt.Name = "pipesSearchReselt";
            this.pipesSearchReselt.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.extraButton});
            this.pipesSearchReselt.Size = new System.Drawing.Size(702, 293);
            this.pipesSearchReselt.TabIndex = 33;
            this.pipesSearchReselt.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.pipesSearchResultview});
            // 
            // pipesSearchResultview
            // 
            this.pipesSearchResultview.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.pipeNumberGridColumn,
            this.certificateNumberGridColumn,
            this.heatNumberGridColumn,
            this.statusSearchGridColumn,
            this.locationGridColumn,
            this.weldingDateGridColumn,
            this.internalCoatingDateGridColumn,
            this.externalCoatingDateGridColumn,
            this.extraGridColumn});
            this.pipesSearchResultview.GridControl = this.pipesSearchReselt;
            this.pipesSearchResultview.Name = "pipesSearchResultview";
            this.pipesSearchResultview.OptionsView.ShowGroupPanel = false;
            // 
            // pipeNumberGridColumn
            // 
            this.pipeNumberGridColumn.Caption = "№";
            this.pipeNumberGridColumn.Name = "pipeNumberGridColumn";
            this.pipeNumberGridColumn.Visible = true;
            this.pipeNumberGridColumn.VisibleIndex = 0;
            // 
            // certificateNumberGridColumn
            // 
            this.certificateNumberGridColumn.Caption = "Certificate number";
            this.certificateNumberGridColumn.Name = "certificateNumberGridColumn";
            this.certificateNumberGridColumn.Visible = true;
            this.certificateNumberGridColumn.VisibleIndex = 1;
            // 
            // heatNumberGridColumn
            // 
            this.heatNumberGridColumn.Caption = "Heat no";
            this.heatNumberGridColumn.Name = "heatNumberGridColumn";
            this.heatNumberGridColumn.Visible = true;
            this.heatNumberGridColumn.VisibleIndex = 2;
            // 
            // statusSearchGridColumn
            // 
            this.statusSearchGridColumn.Caption = "Status";
            this.statusSearchGridColumn.Name = "statusSearchGridColumn";
            this.statusSearchGridColumn.Visible = true;
            this.statusSearchGridColumn.VisibleIndex = 3;
            // 
            // locationGridColumn
            // 
            this.locationGridColumn.Caption = "Location";
            this.locationGridColumn.Name = "locationGridColumn";
            this.locationGridColumn.Visible = true;
            this.locationGridColumn.VisibleIndex = 4;
            // 
            // weldingDateGridColumn
            // 
            this.weldingDateGridColumn.Caption = "Weld date";
            this.weldingDateGridColumn.Name = "weldingDateGridColumn";
            this.weldingDateGridColumn.Visible = true;
            this.weldingDateGridColumn.VisibleIndex = 5;
            // 
            // internalCoatingDateGridColumn
            // 
            this.internalCoatingDateGridColumn.Caption = "Internal coating date";
            this.internalCoatingDateGridColumn.Name = "internalCoatingDateGridColumn";
            this.internalCoatingDateGridColumn.Visible = true;
            this.internalCoatingDateGridColumn.VisibleIndex = 6;
            // 
            // externalCoatingDateGridColumn
            // 
            this.externalCoatingDateGridColumn.Caption = "External coating date";
            this.externalCoatingDateGridColumn.Name = "externalCoatingDateGridColumn";
            this.externalCoatingDateGridColumn.Visible = true;
            this.externalCoatingDateGridColumn.VisibleIndex = 7;
            // 
            // extraGridColumn
            // 
            this.extraGridColumn.Caption = "Extra";
            this.extraGridColumn.ColumnEdit = this.extraButton;
            this.extraGridColumn.Name = "extraGridColumn";
            this.extraGridColumn.Visible = true;
            this.extraGridColumn.VisibleIndex = 8;
            // 
            // extraButton
            // 
            this.extraButton.AutoHeight = false;
            this.extraButton.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.extraButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "extra inf", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.extraButton.Name = "extraButton";
            this.extraButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // pegNumberLabel
            // 
            this.pegNumberLabel.Location = new System.Drawing.Point(554, 10);
            this.pegNumberLabel.Name = "pegNumberLabel";
            this.pegNumberLabel.Size = new System.Drawing.Size(57, 13);
            this.pegNumberLabel.TabIndex = 49;
            this.pegNumberLabel.Text = "Peg number";
            // 
            // pegNumber
            // 
            this.pegNumber.Location = new System.Drawing.Point(554, 29);
            this.pegNumber.Name = "pegNumber";
            this.pegNumber.Size = new System.Drawing.Size(115, 20);
            this.pegNumber.TabIndex = 50;
            // 
            // MillPipeSearchXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 425);
            this.ControlBox = false;
            this.Controls.Add(this.pegNumber);
            this.Controls.Add(this.pegNumberLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.internalCoatingDate);
            this.Controls.Add(this.sizeGrade);
            this.Controls.Add(this.welding);
            this.Controls.Add(this.weldingDateLabel);
            this.Controls.Add(this.internalCoatingLabel);
            this.Controls.Add(this.externalCoatingDate);
            this.Controls.Add(this.externalCoatingLabel);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.pipeLocation);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.pipeStatus);
            this.Controls.Add(this.pipeStatusLabel);
            this.Controls.Add(this.pipeNumber);
            this.Controls.Add(this.pipeNumberLabel);
            this.Controls.Add(this.pipesSearchReselt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MillPipeSearchXtraForm";
            this.Text = "Mill - Find pipes";
            ((System.ComponentModel.ISupportInitialize)(this.internalCoatingDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internalCoatingDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeGrade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.welding.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.welding.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalCoatingDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalCoatingDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipesSearchReselt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipesSearchResultview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegNumber.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraEditors.DateEdit internalCoatingDate;
        private DevExpress.XtraEditors.ComboBoxEdit sizeGrade;
        private DevExpress.XtraEditors.DateEdit welding;
        private DevExpress.XtraEditors.LabelControl weldingDateLabel;
        private DevExpress.XtraEditors.LabelControl internalCoatingLabel;
        private DevExpress.XtraEditors.DateEdit externalCoatingDate;
        private DevExpress.XtraEditors.LabelControl externalCoatingLabel;
        private DevExpress.XtraEditors.LabelControl sizeLabel;
        private DevExpress.XtraEditors.TextEdit pipeLocation;
        private DevExpress.XtraEditors.LabelControl locationLabel;
        private DevExpress.XtraEditors.TextEdit pipeStatus;
        private DevExpress.XtraEditors.LabelControl pipeStatusLabel;
        private DevExpress.XtraEditors.TextEdit pipeNumber;
        private DevExpress.XtraEditors.LabelControl pipeNumberLabel;
        private DevExpress.XtraGrid.GridControl pipesSearchReselt;
        private DevExpress.XtraGrid.Views.Grid.GridView pipesSearchResultview;
        private DevExpress.XtraGrid.Columns.GridColumn pipeNumberGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn certificateNumberGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn heatNumberGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn statusSearchGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn locationGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn weldingDateGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn internalCoatingDateGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn externalCoatingDateGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn extraGridColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit extraButton;
        private DevExpress.XtraEditors.LabelControl pegNumberLabel;
        private DevExpress.XtraEditors.TextEdit pegNumber;


    }
}