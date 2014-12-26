namespace Prizm.Main.Forms.Joint.NewEdit
{
    partial class ChoiceConnectedDiameter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoiceConnectedDiameter));
            this.diameterChoiceLayout = new DevExpress.XtraLayout.LayoutControl();
            this.diametersIntersection = new DevExpress.XtraEditors.ComboBoxEdit();
            this.saveChosenDiameter = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlDiameterChoose = new DevExpress.XtraLayout.LayoutControlGroup();
            this.saveChosenDiameterLayout = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceUnderControls = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.diametersIntersectionLayout = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.diameterChoiceLayout)).BeginInit();
            this.diameterChoiceLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diametersIntersection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlDiameterChoose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveChosenDiameterLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceUnderControls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diametersIntersectionLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // diameterChoiceLayout
            // 
            this.diameterChoiceLayout.Controls.Add(this.diametersIntersection);
            this.diameterChoiceLayout.Controls.Add(this.saveChosenDiameter);
            this.diameterChoiceLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diameterChoiceLayout.Location = new System.Drawing.Point(0, 0);
            this.diameterChoiceLayout.Name = "diameterChoiceLayout";
            this.diameterChoiceLayout.Root = this.layoutControlDiameterChoose;
            this.diameterChoiceLayout.Size = new System.Drawing.Size(353, 71);
            this.diameterChoiceLayout.TabIndex = 0;
            // 
            // diametersIntersection
            // 
            this.diametersIntersection.Location = new System.Drawing.Point(19, 28);
            this.diametersIntersection.Name = "diametersIntersection";
            this.diametersIntersection.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.diametersIntersection.Size = new System.Drawing.Size(192, 20);
            this.diametersIntersection.StyleController = this.diameterChoiceLayout;
            this.diametersIntersection.TabIndex = 6;
            this.diametersIntersection.SelectedIndexChanged += new System.EventHandler(this.diametersIntersection_SelectedIndexChanged);
            // 
            // saveChosenDiameter
            // 
            this.saveChosenDiameter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveChosenDiameter.Image = ((System.Drawing.Image)(resources.GetObject("saveChosenDiameter.Image")));
            this.saveChosenDiameter.Location = new System.Drawing.Point(229, 26);
            this.saveChosenDiameter.Name = "saveChosenDiameter";
            this.saveChosenDiameter.Size = new System.Drawing.Size(105, 22);
            this.saveChosenDiameter.StyleController = this.diameterChoiceLayout;
            this.saveChosenDiameter.TabIndex = 5;
            this.saveChosenDiameter.Text = "Сохранить";
            // 
            // layoutControlDiameterChoose
            // 
            this.layoutControlDiameterChoose.CustomizationFormText = "layoutControlDiameterChoose";
            this.layoutControlDiameterChoose.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlDiameterChoose.GroupBordersVisible = false;
            this.layoutControlDiameterChoose.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceUnderControls,
            this.diametersIntersectionLayout,
            this.saveChosenDiameterLayout,
            this.emptySpaceItem2});
            this.layoutControlDiameterChoose.Location = new System.Drawing.Point(0, 0);
            this.layoutControlDiameterChoose.Name = "layoutControlDiameterChoose";
            this.layoutControlDiameterChoose.Size = new System.Drawing.Size(353, 71);
            this.layoutControlDiameterChoose.Text = "layoutControlDiameterChoose";
            this.layoutControlDiameterChoose.TextVisible = false;
            // 
            // saveChosenDiameterLayout
            // 
            this.saveChosenDiameterLayout.Control = this.saveChosenDiameter;
            this.saveChosenDiameterLayout.CustomizationFormText = "saveChosenDiameterLayout";
            this.saveChosenDiameterLayout.Location = new System.Drawing.Point(210, 14);
            this.saveChosenDiameterLayout.Name = "saveChosenDiameterLayout";
            this.saveChosenDiameterLayout.Size = new System.Drawing.Size(123, 26);
            this.saveChosenDiameterLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(7, 7, 0, 0);
            this.saveChosenDiameterLayout.Text = "saveChosenDiameterLayout";
            this.saveChosenDiameterLayout.TextSize = new System.Drawing.Size(0, 0);
            this.saveChosenDiameterLayout.TextToControlDistance = 0;
            this.saveChosenDiameterLayout.TextVisible = false;
            // 
            // emptySpaceUnderControls
            // 
            this.emptySpaceUnderControls.AllowHotTrack = false;
            this.emptySpaceUnderControls.CustomizationFormText = "emptySpaceUnderControls";
            this.emptySpaceUnderControls.Location = new System.Drawing.Point(0, 40);
            this.emptySpaceUnderControls.Name = "emptySpaceUnderControls";
            this.emptySpaceUnderControls.Size = new System.Drawing.Size(333, 11);
            this.emptySpaceUnderControls.Text = "emptySpaceUnderControls";
            this.emptySpaceUnderControls.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(210, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(123, 14);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // diametersIntersectionLayout
            // 
            this.diametersIntersectionLayout.Control = this.diametersIntersection;
            this.diametersIntersectionLayout.CustomizationFormText = "Выбор диаметра соединения";
            this.diametersIntersectionLayout.Location = new System.Drawing.Point(0, 0);
            this.diametersIntersectionLayout.Name = "diametersIntersectionLayout";
            this.diametersIntersectionLayout.Size = new System.Drawing.Size(210, 40);
            this.diametersIntersectionLayout.Spacing = new DevExpress.XtraLayout.Utils.Padding(7, 7, 0, 0);
            this.diametersIntersectionLayout.Text = "Выбор диаметра соединения";
            this.diametersIntersectionLayout.TextLocation = DevExpress.Utils.Locations.Top;
            this.diametersIntersectionLayout.TextSize = new System.Drawing.Size(147, 13);
            // 
            // ChoiceConnectedDiameter
            // 
            this.AcceptButton = this.saveChosenDiameter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 71);
            this.Controls.Add(this.diameterChoiceLayout);
            this.Name = "ChoiceConnectedDiameter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChoiceDiameterOfConnections";
            ((System.ComponentModel.ISupportInitialize)(this.diameterChoiceLayout)).EndInit();
            this.diameterChoiceLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diametersIntersection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlDiameterChoose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveChosenDiameterLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceUnderControls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diametersIntersectionLayout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl diameterChoiceLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlDiameterChoose;
        private DevExpress.XtraEditors.SimpleButton saveChosenDiameter;
        private DevExpress.XtraLayout.LayoutControlItem saveChosenDiameterLayout;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceUnderControls;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.ComboBoxEdit diametersIntersection;
        private DevExpress.XtraLayout.LayoutControlItem diametersIntersectionLayout;
    }
}