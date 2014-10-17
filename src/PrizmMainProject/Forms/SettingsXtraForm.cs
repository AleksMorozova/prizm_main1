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
    public partial class SettingsXtraForm : DevExpress.XtraEditors.XtraForm
    {
        public SettingsXtraForm()
        {
            InitializeComponent();

            #region Role Setting
            // User & Role dummy data init
            var ds = new PrizmMain.DummyData.UsersDummy();
            var data = ds.GetDummyUsers();

            users.DataSource = data;


            #endregion


        }

        #region Role Setting
        private void editRoleButton_Click(object sender, EventArgs e)
        {
            //TODO: change for normal logic
            var editForm = new RolesPrivilegeEditXtraForm();
            editForm.ShowDialog();
        }
        #endregion

        #region User setting
        private void userEditButton_Click(object sender, EventArgs e)
        {
            //TODO: change for normal logic
            var editUser = new UserInfoXtraForm();
            editUser.ShowDialog();
        }
        #endregion


        private void editItem_Click(object sender, EventArgs e)
        {
            //TODO: change for normal logic
            var editDictionary = new SettingsEditDictionaryXtraForm();
            editDictionary.ShowDialog();
        }
    }
}