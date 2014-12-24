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
using Prizm.Domain.Entity.Setup;
using Prizm.Main.Common;
using Ninject;
using Prizm.Main.Properties;

namespace Prizm.Main.Forms.MainChildForm.FirstSetupForm
{
    public partial class FirstSetupXtraForm : DevExpress.XtraEditors.XtraForm
    {
        FirstSetupViewModel viewModel;
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

        [Inject]
        public FirstSetupXtraForm(FirstSetupViewModel vm)
        {
            InitializeComponent();
            viewModel = vm;
            this.Text += ": [" + viewModel.Type + "]";
        }

        private void FirstSetupXtraForm_Load(object sender, EventArgs e)
        {
            BindToViewModel();
            pipeNumberMaskRulesLabel.Text = Resources.Mask_Label;
            folderBrowserDialog.Description = Resources.DLG_SELECT_PATH_HEADER;
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;

            type.DataBindings.Add("EditValue", bindingSource, "Type");
            projectName.DataBindings.Add("EditValue", bindingSource, "ProjectTitle");
            fileSize.DataBindings.Add("EditValue", bindingSource, "Size");
            mill.DataBindings.Add("EditValue", bindingSource, "MillName");
            pipeMask.DataBindings.Add("EditValue", bindingSource, "MillPipeNumberMask");
            login.DataBindings.Add("EditValue", bindingSource, "Login");
            pass.DataBindings.Add("EditValue", bindingSource, "Password");
            lastName.DataBindings.Add("EditValue", bindingSource, "LastName");
            firstName.DataBindings.Add("EditValue", bindingSource, "FirstName");
            middleName.DataBindings.Add("EditValue", bindingSource, "MiddleName");
            dataPath.DataBindings.Add("EditValue", bindingSource, "ExternalFilesPath");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            viewModel.IsSaved = false;
            if(validationProvider.Validate())
            {
                viewModel.SaveCommand.Execute();
            }
            if(viewModel.IsSaved)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void FirstSetupXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewModel.Dispose();
        }

        private void selectPathButton_Click(object sender, EventArgs e)
        {
             
             DialogResult result = folderBrowserDialog.ShowDialog();
             if (result == DialogResult.OK)
             {
                 viewModel.ExternalFilesPath = folderBrowserDialog.SelectedPath;
             }
        }
    }
}