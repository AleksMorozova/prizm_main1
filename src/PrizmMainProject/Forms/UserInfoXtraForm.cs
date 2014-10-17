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
using PrizmMain.DummyData;

namespace PrizmMain.Forms
{
    public partial class UserInfoXtraForm : DevExpress.XtraEditors.XtraForm
    {

        public UserInfoXtraForm()
        {
            InitializeComponent();

            var reposirory = new RolesDummy();
            var roles = reposirory.GetRoles();

            foreach (var item in roles)
            {
                userRoleComboBox.Properties.Items.Add(item.Name);
            }
        }

        public UserInfoXtraForm(bool isNew)
        {
            InitializeComponent();

            if (isNew)
            {
                return;
            }

            var repository = new UsersDummy();
            var user = repository.GetUser(2);

            lastName.Text = user.LastName;
            firstName.Text = user.FirstName;
            middleName.Text = user.MiddleName;

            login.Text = user.Login;
            password.Text = user.Password;
            confirmPassword.Text = user.Password;
            userRoleComboBox.Properties.Items.Add(user.Role.Name);
            userRoleComboBox.SelectedIndex = 0;
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}