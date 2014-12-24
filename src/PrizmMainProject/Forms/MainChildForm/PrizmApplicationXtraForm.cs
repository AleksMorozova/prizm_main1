using System;
using System.Collections.Generic;
using System.Windows.Forms;

using DevExpress.XtraBars;
using DevExpress.XtraEditors;

using Ninject.Parameters;
using Ninject;

using Prizm.Main.Forms.Component.NewEdit;
using Prizm.Main.Forms.Joint.NewEdit;
using Prizm.Main.Forms.Joint.Search;
using Prizm.Main.Forms.PipeMill.NewEdit;
using Prizm.Main.Forms.PipeMill.Search;
using Prizm.Main.Forms.Railcar.NewEdit;
using Prizm.Main.Forms.Railcar.Search;
using Prizm.Main.Forms.Reports.Construction;
using Prizm.Main.Forms.Reports.Incoming;
using Prizm.Main.Forms.Reports.Mill;
using Prizm.Main.Forms.Settings;
using Prizm.Main.Forms.Spool;

using Prizm.Main.Properties;
using DevExpress.XtraBars.Alerter;
using Prizm.Main.Forms.PipeMill.Heat;
using Prizm.Main.Forms.Audit;
using Prizm.Main.Forms.Parts.Search;
using Prizm.Main.Forms.Parts.Inspection;
using Prizm.Main.Forms.Common;
using PrizmMain.Forms.Notifications;
using DevExpress.XtraSplashScreen;

namespace Prizm.Main.Forms.MainChildForm
{
    public partial class PrizmApplicationXtraForm : XtraForm, IUserNotify
    {
        private static uint FramesCanOpen = 20;
        private readonly Dictionary<string, List<ChildForm>> childForms = new Dictionary<string, List<ChildForm>>();
        private PrizmApplicationViewModel viewModel;

        public PrizmApplicationXtraForm()
        {
            InitializeComponent();

            //TODO
            // should be deleted after demo test
            //==========================================================
            languageBarListItem.ShowChecks = true;
            languageBarListItem.Strings.Add("English");
            languageBarListItem.Strings.Add("Русский");
            languageBarListItem.Strings.Add("Chinese (中國)");
            languageBarListItem.DataIndex = 2;
            //==========================================================
        }

        /// <summary>
        /// Checks if given form type is single. Expected type name of the form derived from ChildForm and used as a child window.
        /// Single means to have only one opened child window if this type at a time.
        /// </summary>
        /// <param name="formTypeName">string representation of form type name, for example "SettingsXtraForm"</param>
        /// <returns>true if form is "single" in terms of this application</returns>
        private bool IsSingle(string formTypeName)
        {
            bool isSingle = false;

            switch (formTypeName)
            {
                case "SettingsXtraForm":
                    isSingle = true;
                    break;
                default:
                    break;
            }
            return isSingle;
        }

        /// <summary>
        /// Creates and returns an instance of child form of given form type. Given 
        /// </summary>
        /// <param name="formType">type of form to be created, for example SettingsXtraForm</param>
        /// <param name="parameters">additional parameters for new child form</param>
        /// <returns>reference to newly created child form</returns>
        private ChildForm CreateReturnChildForm(System.Type formType, params IParameter[] parameters)
        {
            ChildForm newlyCreatedForm = null;

            if (typeof(ChildForm).IsAssignableFrom(formType))
            {
                if (!childForms.ContainsKey(formType.Name))
                {
                    childForms.Add(formType.Name, new List<ChildForm>());
                }
                List<ChildForm> forms = childForms[formType.Name];

                if (IsSingle(formType.Name) && forms.Count > 0)
                {
                    // no more forms could be created. activate existing form
                    forms[0].Activate();
                }
                else if (FramesCanOpen < 1)
                {
                    this.ShowError(Resources.IDS_NO_MORE_DOCUMENTS, Resources.DLG_ERROR_HEADER);
                }
                else
                {
                    newlyCreatedForm = (ChildForm)Program.Kernel.Get(formType, parameters);
                    childForms[formType.Name].Add(newlyCreatedForm);
                    newlyCreatedForm.MdiParent = this;
                    newlyCreatedForm.FormClosed += ChildClosedEventHandler;
                    FramesCanOpen--;
                }
            }
            else
            {
                throw new ApplicationException(String.Format("Could not create child form {0} because not of child type.", formType.Name));
            }
            return newlyCreatedForm;
        }

        /// <summary>
        /// Cleans child form if it was closed
        /// </summary>
        /// <param name="sender">child form expected</param>
        /// <param name="arguments"></param>
        public void ChildClosedEventHandler(object sender, EventArgs arguments)
        {
            if (typeof(ChildForm).IsAssignableFrom(sender.GetType()))
            {
                foreach (var childType in childForms)
                {
                    if (childType.Value.Remove((ChildForm)sender))
                    {
                        FramesCanOpen++;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Show existing child form.
        /// </summary>
        /// <param name="form"></param>
        private void ShowChildForm(ChildForm form)
        {
            try
            {
                ShowProcessing();
                form.Show();
                form.WindowState = FormWindowState.Normal;
                form.WindowState = FormWindowState.Maximized;
            }
            finally
            {
                HideProcessing();
            }
        }

        /// <summary>
        /// Creation of child form. Can be used from outside to pass some parameters to newly created forms (i.e. pipe number).
        /// After creation, form shows.
        /// </summary>
        /// <param name="formType">exact type of form</param>
        /// <param name="parameters">input parameters passed to the newly created form</param>
        public void CreateChildForm(System.Type formType, params IParameter[] parameters)
        {
            try
            {
                ShowProcessing();
                ChildForm form = CreateReturnChildForm(formType, parameters);
                if (form != null)
                {
                    ShowChildForm(form);
                }
            }
            finally
            {
                HideProcessing();
            }
        }

        /// <summary>
        /// Create and show Settings child form. Starting tab page is set or first page if page doesn't exist.
        /// </summary>
        /// <param name="page">number of starting page</param>
        /// <param name="parameters">form input parameters if any</param>
        public void CreateSettingsChildForm(int page, params IParameter[] parameters)
        {
            try
            {
                SettingsXtraForm form = (SettingsXtraForm)CreateReturnChildForm(typeof(SettingsXtraForm), parameters);

                if (form != null)
                {
                    if (form.settings.TabPages.Count > page)
                    {
                        form.settings.SelectedTabPage = form.settings.TabPages[page];
                    }
                    ShowChildForm(form);
                }
                else
                {
                    var forms = childForms[typeof(SettingsXtraForm).Name];

                    if (forms.Count > 0)
                    {
                        SettingsXtraForm f = (SettingsXtraForm)forms[0];
                        f.settings.SelectedTabPage = f.settings.TabPages[page];
                        f.Activate();
                    }      
                }
            }
            finally
            {
                HideProcessing();
            }
        }

        #region Menu buttons
        private void barButtonItemNewPipe_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(MillPipeNewEditXtraForm));
        }

        private void barButtonItemNewRailcar_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(RailcarNewEditXtraForm));
        }

        private void barButtonItemMillFindEditPipes_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(MillPipeSearchXtraForm));
        }

        private void barButtonItemMillReports_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(MillReportsXtraForm));
        }

        private void barButtonItemNewComponent_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(ComponentNewEditXtraForm));
        }

        private void barButtonItemInspectionReports_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(InspectionReportsXtraForm));
        }

        private void barButtonItemNewJoint_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(JointNewEditXtraForm));
        }

        private void barButtonItemFindEditJoints_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(JointSearchXtraForm));
        }

        private void barButtonItemPartIncomingInspection_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(PartInspectionXtraForm));
        }

        private void barButtonItemConstructionReports_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(ConstructionReportsXtraForm));
        }

        private void barButtonItemSettingsProject_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsChildForm(page: 0);
        }

        private void barButtonItemSettingsPipeline_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsChildForm(page: 2);
        }

        private void barButtonItemSettingsPipe_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsChildForm(page: 1);
        }

        private void barButtonItemSettingsUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsChildForm(page: 4);
        }

        private void barButtonItemRoles_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsChildForm(page: 5);
        }

        private void barButtonItemSettingsWelders_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsChildForm(page: 6);
        }

        private void barButtonItemSettingsInspectors_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsChildForm(page: 7);
        }

        private void barButtonItemComponentry_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsChildForm(page: 3);
        }

        private void barButtonItemFindEditShipRailcars_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(RailcarSearchXtraForm));
        }

        private void barButtonItemInspectionFindEditPipes_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(PartSearchXtraForm));
        }

        private void barButtonItemSpool_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(SpoolsXtraForm));
        }

        private void barButtonItemFindEditParts_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(PartSearchXtraForm));
        }

        private void barButtonItemAudit_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(AuditXtraForm));
        }
        #endregion


        #region IUserNotify
        /// <summary>
        /// Error message that requires user confirmation (OK)
        /// </summary>
        /// <param name="text"></param>
        /// <param name="header"></param>
        public void ShowError(string text, string header)
        {
            XtraMessageBox.Show(text, header, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// Warning message that requires user confirmation (OK)
        /// </summary>
        /// <param name="text">message body</param>
        /// <param name="header">message header</param>
        public void ShowWarning(string text, string header)
        {
            XtraMessageBox.Show(text, header, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        /// <summary>
        /// Informational message that requires user confirmation (OK)
        /// </summary>
        /// <param name="text">message body</param>
        /// <param name="header">message header</param>
        public void ShowInfo(string text, string header)
        {
            XtraMessageBox.Show(text, header, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Message that requires user confirmation or denial (yes/no)
        /// </summary>
        /// <param name="text">message body</param>
        /// <param name="header">message header</param>
        /// <returns>true if yes, false if no</returns>
        public bool ShowYesNo(string text, string header)
        {
            return (DialogResult.Yes == XtraMessageBox.Show(text, header, MessageBoxButtons.YesNo, MessageBoxIcon.Question));
        }
        /// <summary>
        /// Message that requires user confirmation, denial or operation cancellation (yes/no/cancel)
        /// </summary>
        /// <param name="text">message body</param>
        /// <param name="header">message header</param>
        /// <returns>1 if yes, 0 if no, -1 if cancel</returns>
        public int ShowYesNoCancel(string text, string header)
        {
            DialogResult dlg = XtraMessageBox.Show(text, header, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            sbyte result;
            switch (dlg)
            {
                case DialogResult.Cancel:
                    result = -1;
                    break;
                case DialogResult.No:
                    result = 0;
                    break;
                case DialogResult.Yes:
                    result = 1;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(string.Format("Unknown dialog answer - {0}",dlg));
            }
            return result;
        }
        /// <summary>
        /// Message about success, that doesn't require user confirmation.
        /// </summary>
        /// <param name="text">message body</param>
        /// <param name="header">message header</param>
        public void ShowSuccess(string text, string header)
        {
            StatusNotifyText(text);

        }
        /// <summary>
        /// Message about failure, that doesn't require user confirmation.
        /// </summary>
        /// <param name="text">message body</param>
        /// <param name="header">message header</param>
        public void ShowFailure(string text, string header)
        {
            StatusNotifyText(text);
        }
        /// <summary>
        /// Informational message, that doesn't require user confirmation.
        /// </summary>
        /// <param name="text">message body</param>
        /// <param name="header">message header</param>
        public void ShowNotify(string text, string header)
        {
            StatusNotifyText(text);
        }

        private void StatusNotifyText(string s)
        {
            var main = Program.MainForm as PrizmApplicationXtraForm;
            var str = string.Format("[{0}] - {1}", DateTime.Now.ToShortTimeString().Trim(), s);
            main.UpdateStatusBar(str);
        }

        private int currentProcessingStep;
        private int targetProcessingSteps;

        /// <summary>
        /// Show wait form. Call it at times when UI thread will be unresponsible
        /// For now used 1. on Executing commands through the CommandManager
        ///              2. when creating and showing child forms
        /// </summary>
        /// <param name="text">message body, optional</param>
        /// <param name="header">message header, optional</param>
        /// <param name="steps">overall steps provide to show progress bar, and on each step call IncProcessingState(), optional</param>
        public void ShowProcessing(string text = "", string header = "", int steps = 0)
        {
            targetProcessingSteps = steps;
            currentProcessingStep = 0;
            SplashScreenManager.ShowForm(this, typeof(AppWaitForm), false, false, false);
            if (!string.IsNullOrEmpty(header))
                SplashScreenManager.Default.SetWaitFormCaption(header);
            if (!string.IsNullOrEmpty(text))
                SplashScreenManager.Default.SetWaitFormDescription(text);
            this.Update();
        }

        /// <summary>
        /// Hide wait form, when UI thread will be responsible again
        /// </summary>
        public void HideProcessing()
        {
            SplashScreenManager.CloseForm(false);
        }

        /// <summary>
        /// Update progress on wait form, should be called on each processing step
        /// of the long processing with known number of steps.
        /// To init progress on the wait form you should previously call ShowProcessing(, , steps) 
        /// </summary>
        public void IncProcessingState()
        {
            currentProcessingStep++;
            float percent = (float)currentProcessingStep / targetProcessingSteps * 100;
            SplashScreenManager.Default.SetWaitFormDescription(percent.ToString() + "%");
        }
        #endregion

        private void PrizmApplicationXtraForm_Load(object sender, EventArgs e)
        {
            viewModel = (PrizmApplicationViewModel)Program.Kernel.GetService(typeof(PrizmApplicationViewModel));

            this.Text = string.Concat(this.Text, " [", viewModel.WorkstationType.Text, "]");

            if (!string.IsNullOrEmpty(viewModel.ProjectSettings.Title))
            {
                this.Text = string.Concat(this.Text, " [", viewModel.ProjectSettings.Title, "]");
            }
        }

        private void barButtonItemAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            //CreateChildForm(typeof(AboutXtraForm));
            AboutXtraForm form = new AboutXtraForm();
            form.ShowDialog();
        }

        private void barButtonItemExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        public void UpdateStatusBar(string text) 
        {
            notifyBarStaticItem.Caption = text;
            notifyHistory.Items.Add(text);
        }

        private void notifyBarStaticItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            flyoutPanel.ShowPopup();
        }

        private void barButtonStatusNotifications_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(NotificationXtraForm));
        }

    }
}