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

            #region User & Role Setting
            var userDs = new PrizmMain.DummyData.UsersDummy();
            var userData = userDs.GetDummyUsers();
            users.DataSource = userData;

            var roleDs = new PrizmMain.DummyData.RolesDummy();
            var roleData = roleDs.GetRoles();
            roles.DataSource = roleData;


            #endregion

        }

        #region Role Setting
        private void editRoleButton_Click(object sender, EventArgs e)
        {
            //TODO: change for normal logic
            var editForm = new RolesPrivilegeEditXtraForm(false);
            editForm.ShowDialog();
        }

        private void roleAddButton_Click(object sender, EventArgs e)
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
            var editUser = new UserInfoXtraForm(false);
            editUser.ShowDialog();
        }

        private void userAddButton_Click(object sender, EventArgs e)
        {
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