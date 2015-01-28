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
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Commands;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.Audit
{
    [System.ComponentModel.DesignerCategory("Form")] 
    public partial class AuditXtraForm : ChildForm
    {
        private AuditViewModel viewModel;
        private ICommandManager commandManager = new CommandManager();
        
        public AuditXtraForm()
        {
            InitializeComponent();
            viewModel = (AuditViewModel)Program.Kernel.GetService(typeof(AuditViewModel));
        }

        private void AuditXtraForm_Load(object sender, EventArgs e)
        {
            BindCommands();
            BindToViewModel();
        }

        private void BindToViewModel()
        {
            foreach (var u in viewModel.UsersList)
            {
                user.Properties.Items.Add(u);
            }
            startDate.DataBindings.Add("EditValue", viewModel, "StartDate");
            endDate.DataBindings.Add("EditValue", viewModel, "EndDate");
            auditResults.DataBindings.Add("DataSource", viewModel, "AuditResults");
            user.DataBindings.Add("EditValue", viewModel, "SelectedUser");
            number.DataBindings.Add("EditValue", viewModel, "Number");
            number.SetAsIdentifier();
        }

        private void BindCommands()
        {
            commandManager["Search"].Executor(viewModel.SearchCommand).AttachTo(search);
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>() 
                { 
                    // layout items
                    new LocalizedItem(numberLayout, "Audit_ElementNumberLabel"),
                    new LocalizedItem(periodLabelLayout,"Audit_PeriodLabel"),
                    new LocalizedItem(startDateLayout,"Audit_StartDateLabel"),
                    new LocalizedItem(endDateLayout,"Audit_EndDateLabel"),
                    new LocalizedItem(userLayout,"Audit_UserLabel"),

                    // controls
                    new LocalizedItem(search, "Audit_SearchButton"),

                    // grid column headers
                    new LocalizedItem(userGridColumn, "Audit_UserColumnHeader"),
                    new LocalizedItem(dateGridColumn, "Audit_DateColumnHeader"),
                    new LocalizedItem(entityGridColumn, "Audit_EntityColumnHeader"),
                    new LocalizedItem(oldValueGridColumn, "Audit_OldValueColumnHeader"),
                    new LocalizedItem(newValueGridColumn, "Audit_NewValueColumnHeader"),
                    new LocalizedItem(fieldGridColumn, "Audit_FieldColumnHeader"),
                    new LocalizedItem(numberColumn, "Audit_NumberColumnHeader"),

                    // layout control groups
                    new LocalizedItem(searchParametersLayoutGroup, "Audit_SearchParametersGroup"),

                    // radiogroup
                    new LocalizedItem(radioPeriodUser, new string [] {"Audit_RadioPeriod", "Audit_RadioUser"}),
                };
        }

        #endregion // --- Localization ---

        private void AuditXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            commandManager.Dispose();
            viewModel.Dispose();
            viewModel = null;
        }


        private void tracingModeRadioGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadioGroup edit = sender as RadioGroup;

            if (edit.SelectedIndex == 0)
            {
                startDate.Enabled = true;
                endDate.Enabled = true;

                user.Enabled = false;

                viewModel.TracingMode = TracingModeEnum.TracingByPeriod;
            }
            else
            {
                user.Enabled = true;

                startDate.Enabled = false;
                endDate.Enabled = false;

                viewModel.TracingMode = TracingModeEnum.TracingByUser;
            }
        }


    }
}