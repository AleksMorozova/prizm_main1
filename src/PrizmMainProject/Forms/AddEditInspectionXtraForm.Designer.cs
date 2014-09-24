namespace PrizmMain.Forms
{
    partial class AddEditInspectionXtraForm
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridInspectionPlant = new DevExpress.XtraGrid.GridControl();
            this.gridViewInspectionMasterPlant = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnCodePlant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNamePlant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridInspectionResultPlant = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.checkedComboBoxInspectionTypePlant = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.labelInspectionsPlant = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.checkedComboBoxInspectionTypeCustomer = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.labelInspectionsCustomer = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.checkedComboBoxInspectionTypeOther = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.labelInspectionsOther = new DevExpress.XtraEditors.LabelControl();
            this.gridInspectionCustomer = new DevExpress.XtraGrid.GridControl();
            this.gridInspectionResultCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridViewInspectionMasterCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridInspectionOther = new DevExpress.XtraGrid.GridControl();
            this.gridViewInspectionResultOther = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridViewInspectionMasterOther = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInspectionPlant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInspectionMasterPlant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInspectionResultPlant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxInspectionTypePlant.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxInspectionTypeCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxInspectionTypeOther.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInspectionCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInspectionResultCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInspectionMasterCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInspectionOther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInspectionResultOther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInspectionMasterOther)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.gridInspectionPlant);
            this.groupControl1.Controls.Add(this.checkedComboBoxInspectionTypePlant);
            this.groupControl1.Controls.Add(this.labelInspectionsPlant);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(300, 446);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Inspecton Plant";
            // 
            // gridInspectionPlant
            // 
            gridLevelNode1.LevelTemplate = this.gridInspectionResultPlant;
            gridLevelNode1.RelationName = "Level1";
            this.gridInspectionPlant.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridInspectionPlant.Location = new System.Drawing.Point(5, 69);
            this.gridInspectionPlant.MainView = this.gridViewInspectionMasterPlant;
            this.gridInspectionPlant.Name = "gridInspectionPlant";
            this.gridInspectionPlant.Size = new System.Drawing.Size(290, 369);
            this.gridInspectionPlant.TabIndex = 2;
            this.gridInspectionPlant.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewInspectionMasterPlant,
            this.gridInspectionResultPlant});
            // 
            // gridViewInspectionMasterPlant
            // 
            this.gridViewInspectionMasterPlant.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnCodePlant,
            this.gridColumnNamePlant});
            this.gridViewInspectionMasterPlant.GridControl = this.gridInspectionPlant;
            this.gridViewInspectionMasterPlant.Name = "gridViewInspectionMasterPlant";
            this.gridViewInspectionMasterPlant.OptionsCustomization.AllowGroup = false;
            this.gridViewInspectionMasterPlant.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnCodePlant
            // 
            this.gridColumnCodePlant.Caption = "Code";
            this.gridColumnCodePlant.Name = "gridColumnCodePlant";
            this.gridColumnCodePlant.Visible = true;
            this.gridColumnCodePlant.VisibleIndex = 0;
            // 
            // gridColumnNamePlant
            // 
            this.gridColumnNamePlant.Caption = "Name";
            this.gridColumnNamePlant.Name = "gridColumnNamePlant";
            this.gridColumnNamePlant.Visible = true;
            this.gridColumnNamePlant.VisibleIndex = 1;
            // 
            // gridInspectionResultPlant
            // 
            this.gridInspectionResultPlant.GridControl = this.gridInspectionPlant;
            this.gridInspectionResultPlant.Name = "gridInspectionResultPlant";
            // 
            // checkedComboBoxInspectionTypePlant
            // 
            this.checkedComboBoxInspectionTypePlant.EditValue = "Select inspection types";
            this.checkedComboBoxInspectionTypePlant.Location = new System.Drawing.Point(5, 43);
            this.checkedComboBoxInspectionTypePlant.Name = "checkedComboBoxInspectionTypePlant";
            this.checkedComboBoxInspectionTypePlant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxInspectionTypePlant.Size = new System.Drawing.Size(290, 20);
            this.checkedComboBoxInspectionTypePlant.TabIndex = 1;
            // 
            // labelInspectionsPlant
            // 
            this.labelInspectionsPlant.Location = new System.Drawing.Point(5, 24);
            this.labelInspectionsPlant.Name = "labelInspectionsPlant";
            this.labelInspectionsPlant.Size = new System.Drawing.Size(75, 13);
            this.labelInspectionsPlant.TabIndex = 0;
            this.labelInspectionsPlant.Text = "Inspection type";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl2.Controls.Add(this.gridInspectionCustomer);
            this.groupControl2.Controls.Add(this.checkedComboBoxInspectionTypeCustomer);
            this.groupControl2.Controls.Add(this.labelInspectionsCustomer);
            this.groupControl2.Location = new System.Drawing.Point(318, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(300, 446);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Inspection Customer";
            // 
            // checkedComboBoxInspectionTypeCustomer
            // 
            this.checkedComboBoxInspectionTypeCustomer.EditValue = "Select inspection types";
            this.checkedComboBoxInspectionTypeCustomer.Location = new System.Drawing.Point(5, 43);
            this.checkedComboBoxInspectionTypeCustomer.Name = "checkedComboBoxInspectionTypeCustomer";
            this.checkedComboBoxInspectionTypeCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxInspectionTypeCustomer.Size = new System.Drawing.Size(290, 20);
            this.checkedComboBoxInspectionTypeCustomer.TabIndex = 2;
            // 
            // labelInspectionsCustomer
            // 
            this.labelInspectionsCustomer.Location = new System.Drawing.Point(5, 24);
            this.labelInspectionsCustomer.Name = "labelInspectionsCustomer";
            this.labelInspectionsCustomer.Size = new System.Drawing.Size(75, 13);
            this.labelInspectionsCustomer.TabIndex = 2;
            this.labelInspectionsCustomer.Text = "Inspection type";
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl3.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl3.Controls.Add(this.gridInspectionOther);
            this.groupControl3.Controls.Add(this.checkedComboBoxInspectionTypeOther);
            this.groupControl3.Controls.Add(this.labelInspectionsOther);
            this.groupControl3.Location = new System.Drawing.Point(624, 12);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(300, 446);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Inspestion Other";
            // 
            // checkedComboBoxInspectionTypeOther
            // 
            this.checkedComboBoxInspectionTypeOther.EditValue = "Select inspection types";
            this.checkedComboBoxInspectionTypeOther.Location = new System.Drawing.Point(5, 43);
            this.checkedComboBoxInspectionTypeOther.Name = "checkedComboBoxInspectionTypeOther";
            this.checkedComboBoxInspectionTypeOther.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxInspectionTypeOther.Size = new System.Drawing.Size(290, 20);
            this.checkedComboBoxInspectionTypeOther.TabIndex = 3;
            // 
            // labelInspectionsOther
            // 
            this.labelInspectionsOther.Location = new System.Drawing.Point(5, 24);
            this.labelInspectionsOther.Name = "labelInspectionsOther";
            this.labelInspectionsOther.Size = new System.Drawing.Size(75, 13);
            this.labelInspectionsOther.TabIndex = 3;
            this.labelInspectionsOther.Text = "Inspection type";
            // 
            // gridInspectionCustomer
            // 
            gridLevelNode2.LevelTemplate = this.gridInspectionResultCustomer;
            gridLevelNode2.RelationName = "Level1";
            this.gridInspectionCustomer.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gridInspectionCustomer.Location = new System.Drawing.Point(5, 69);
            this.gridInspectionCustomer.MainView = this.gridViewInspectionMasterCustomer;
            this.gridInspectionCustomer.Name = "gridInspectionCustomer";
            this.gridInspectionCustomer.Size = new System.Drawing.Size(290, 369);
            this.gridInspectionCustomer.TabIndex = 3;
            this.gridInspectionCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridInspectionResultCustomer,
            this.gridViewInspectionMasterCustomer});
            // 
            // gridInspectionResultCustomer
            // 
            this.gridInspectionResultCustomer.GridControl = this.gridInspectionCustomer;
            this.gridInspectionResultCustomer.Name = "gridInspectionResultCustomer";
            // 
            // gridViewInspectionMasterCustomer
            // 
            this.gridViewInspectionMasterCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridViewInspectionMasterCustomer.GridControl = this.gridInspectionCustomer;
            this.gridViewInspectionMasterCustomer.Name = "gridViewInspectionMasterCustomer";
            this.gridViewInspectionMasterCustomer.OptionsCustomization.AllowGroup = false;
            this.gridViewInspectionMasterCustomer.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Code";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridInspectionOther
            // 
            gridLevelNode3.LevelTemplate = this.gridViewInspectionResultOther;
            gridLevelNode3.RelationName = "Level1";
            this.gridInspectionOther.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode3});
            this.gridInspectionOther.Location = new System.Drawing.Point(5, 69);
            this.gridInspectionOther.MainView = this.gridViewInspectionMasterOther;
            this.gridInspectionOther.Name = "gridInspectionOther";
            this.gridInspectionOther.Size = new System.Drawing.Size(290, 369);
            this.gridInspectionOther.TabIndex = 4;
            this.gridInspectionOther.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewInspectionResultOther,
            this.gridViewInspectionMasterOther});
            // 
            // gridViewInspectionResultOther
            // 
            this.gridViewInspectionResultOther.GridControl = this.gridInspectionOther;
            this.gridViewInspectionResultOther.Name = "gridViewInspectionResultOther";
            // 
            // gridViewInspectionMasterOther
            // 
            this.gridViewInspectionMasterOther.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gridViewInspectionMasterOther.GridControl = this.gridInspectionOther;
            this.gridViewInspectionMasterOther.Name = "gridViewInspectionMasterOther";
            this.gridViewInspectionMasterOther.OptionsCustomization.AllowGroup = false;
            this.gridViewInspectionMasterOther.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Code";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Name";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // AddEditInspectionXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 466);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "AddEditInspectionXtraForm";
            this.Text = "AddEditInspectionXtraForm";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInspectionPlant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInspectionMasterPlant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInspectionResultPlant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxInspectionTypePlant.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxInspectionTypeCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxInspectionTypeOther.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInspectionCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInspectionResultCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInspectionMasterCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInspectionOther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInspectionResultOther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInspectionMasterOther)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxInspectionTypePlant;
        private DevExpress.XtraEditors.LabelControl labelInspectionsPlant;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gridInspectionPlant;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInspectionMasterPlant;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxInspectionTypeCustomer;
        private DevExpress.XtraEditors.LabelControl labelInspectionsCustomer;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxInspectionTypeOther;
        private DevExpress.XtraEditors.LabelControl labelInspectionsOther;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCodePlant;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNamePlant;
        private DevExpress.XtraGrid.Views.Grid.GridView gridInspectionResultPlant;
        private DevExpress.XtraGrid.GridControl gridInspectionCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridInspectionResultCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInspectionMasterCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.GridControl gridInspectionOther;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInspectionResultOther;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInspectionMasterOther;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}