using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PrizmMain.Forms
{
    public partial class PrizmApplicationXtraForm : DevExpress.XtraEditors.XtraForm
    {
        private HashSet<Form> childForms = new HashSet<Form>();

        private static uint FramesCanOpen = 1;
 
        public PrizmApplicationXtraForm()
        {
            InitializeComponent();
        }


        private void CreateFormChild(DevExpress.XtraEditors.XtraForm frmChild)
        {
            if (FramesCanOpen > 0)
            {
                childForms.Add(frmChild);
                frmChild.MdiParent = this;
                frmChild.Show();
                frmChild.WindowState = FormWindowState.Normal;
                frmChild.WindowState = FormWindowState.Maximized;
                FramesCanOpen--;
            }
        }

        private void CreateSettingsFormChild(SettingsXtraForm frmChild, int tabPage) 
        {
            frmChild.settings.SelectedTabPage = frmChild.settings.TabPages[tabPage];
            CreateFormChild(frmChild);
        }

        private void barButtonClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // TODO: documents manager
            Form child = this.ActiveMdiChild;
            if (child != null)
            {
                child.Close();
                childForms.Remove(child);
                FramesCanOpen++;
            }
        }

        private void barButtonItemNewPipe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateFormChild(new MillPipeNewEditXtraForm());
        }

        private void barButtonItemNewRailcar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateFormChild(new RailcarNewEditXtraForm());
        }

        private void barButtonItemMillFindEditPipes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateFormChild(new MillPipeSearchXtraForm());
        }

        private void barButtonItemMillReports_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateFormChild(new MillReportsXtraForm());
        }

        private void barButtonItemNewComponent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateFormChild(new ComponentNewEditXtraForm());

        }

        private void barButtonItemInspectionReports_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateFormChild(new InspectionReportsXtraForm());
        }

        private void barButtonItemInspectionFindComponentry_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateFormChild(new ComponentSearchXtraForm());
        }

        private void barButtonItemNewJoint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateFormChild(new JointNewEditXtraForm());
        }

        private void barButtonItemFindEditJoints_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateFormChild(new JointSearchXtraForm());
        }

        private void barButtonItemConstructionReports_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateFormChild(new ConstructionReportsXtraForm());

        }

        private void barButtonItemSetingsProject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateSettingsFormChild(new Forms.SettingsXtraForm(), 0);
        }

        private void barButtonItemSettingsPipeline_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateSettingsFormChild(new Forms.SettingsXtraForm(), 2);
        }

        private void barButtonItemSettingsPipe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateSettingsFormChild(new Forms.SettingsXtraForm(), 1);
        }

        private void barButtonItemSettingsUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateSettingsFormChild(new Forms.SettingsXtraForm(), 3);
        }

        private void barButtonItemSettingsDictionaries_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateSettingsFormChild(new Forms.SettingsXtraForm(), 5);
        }

        private void barButtonItemFindEditShipRailcars_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateFormChild(new RailcarSearchXtraForm());
        }

        private void barButtonItemInspectionFindEditPipes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateFormChild(new InspectionPipeSearchEditXtraForm());
        }

        private void barButtonItemSpool_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateFormChild(new SpoolsXtraForm());
        }

        private void barButtonItemConstructionFindEditPipes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateFormChild(new InspectionPipeSearchEditXtraForm());
        }

        private void barButtonItemConstructionFindEditComponentry_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateFormChild(new ComponentSearchXtraForm());
        }

        private void barButtonItemRoles_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateSettingsFormChild(new Forms.SettingsXtraForm(), 4);
        }


    }
}