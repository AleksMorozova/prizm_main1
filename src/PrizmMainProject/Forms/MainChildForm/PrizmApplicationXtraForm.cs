using System;
using System.Collections.Generic;
using System.Windows.Forms;

using DevExpress.XtraBars;
using DevExpress.XtraEditors;

using Ninject.Parameters;
using Ninject;

using PrizmMain.Forms.Component.NewEdit;
using PrizmMain.Forms.Component.Search;
using PrizmMain.Forms.Joint.NewEdit;
using PrizmMain.Forms.Joint.Search;
using PrizmMain.Forms.PipeIncoming;
using PrizmMain.Forms.PipeMill.NewEdit;
using PrizmMain.Forms.PipeMill.Search;
using PrizmMain.Forms.Railcar.NewEdit;
using PrizmMain.Forms.Railcar.Search;
using PrizmMain.Forms.Reports.Construction;
using PrizmMain.Forms.Reports.Incoming;
using PrizmMain.Forms.Reports.Mill;
using PrizmMain.Forms.Settings;
using PrizmMain.Forms.Spool;

using PrizmMain.Properties;
using DevExpress.XtraBars.Alerter;

namespace PrizmMain.Forms.MainChildForm
{
    public partial class PrizmApplicationXtraForm : XtraForm, IUserNotify
    {
        private static uint FramesCanOpen = 20;
        private readonly Dictionary<string, List<ChildForm>> childForms = new Dictionary<string, List<ChildForm>>();

        public PrizmApplicationXtraForm()
        {
            InitializeComponent();

            //TODO
            // should be deleted after demo test
            //==========================================================
            languageBarListItem.ShowChecks = true;
            languageBarListItem.Strings.Add("English (customizable)");
            languageBarListItem.Strings.Add("English (US)");
            languageBarListItem.Strings.Add("Русский");
            languageBarListItem.Strings.Add("Chinese (中國)");
            languageBarListItem.DataIndex = 2;
            //==========================================================
        }

        /// <summary>
        /// Checks if given form type is single. Expected type name of the form derived from ChildForm and used as a child window.
        /// Single means to have only one opened child window if this type at a time.
        /// </summary>
        /// <param name="formTypeName"></param>
        /// <returns></returns>
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
        /// <param name="formType"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
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
            form.Show();
            form.WindowState = FormWindowState.Normal;
            form.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Creation of child form. Can be used from outside to pass some parameters to newly created forms (i.e. pipe number).
        /// After creation, form shows.
        /// </summary>
        /// <param name="formType">exact type of form</param>
        /// <param name="parameters">input parameters passed to the newly created form</param>
        public void CreateChildForm(System.Type formType, params IParameter[] parameters)
        {
            ChildForm form = CreateReturnChildForm(formType, parameters);
            if (form != null)
            {
                ShowChildForm(form);
            }
        }

        /// <summary>
        /// Create and show Settings child form. Starting tab page is set or first page if page doesn't exist.
        /// </summary>
        /// <param name="page">number of starting page</param>
        /// <param name="parameters">form input parameters if any</param>
        public void CreateSettingsChildForm(int page, params IParameter[] parameters)
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
        }

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

        private void barButtonItemInspectionFindComponentry_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(ComponentSearchXtraForm));
        }

        private void barButtonItemNewJoint_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(JointNewEditXtraForm));
        }

        private void barButtonItemFindEditJoints_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(JointSearchXtraForm));
        }

        private void barButtonItemConstructionReports_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(ConstructionReportsXtraForm));
        }

        private void barButtonItemSetingsProject_ItemClick(object sender, ItemClickEventArgs e)
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
            CreateSettingsChildForm(page: 3);
        }

        private void barButtonItemRoles_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateSettingsChildForm(page: 4);
        }

        private void barButtonItemSettingsDictionaries_ItemClick(object sender, ItemClickEventArgs e)
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

        private void barButtonItemFindEditShipRailcars_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(RailcarSearchXtraForm));
        }

        private void barButtonItemInspectionFindEditPipes_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(InspectionPipeSearchEditXtraForm));
        }

        private void barButtonItemSpool_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(SpoolsXtraForm));
        }

        private void barButtonItemConstructionFindEditComponentry_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(ComponentSearchXtraForm));
        }

        private void barButtonItemConstructionFindEditPipes_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateChildForm(typeof(InspectionPipeSearchEditXtraForm));
        }


        #region IUserNotify
        public void ShowError(string text, string header)
        {
            XtraMessageBox.Show(text, header, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowWarning(string text, string header)
        {
            XtraMessageBox.Show(text, header, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void ShowInfo(string text, string header)
        {
            XtraMessageBox.Show(text, header, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool ShowYesNo(string text, string header)
        {
            return (DialogResult.Yes == XtraMessageBox.Show(text, header, MessageBoxButtons.YesNo, MessageBoxIcon.Question));
        }

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

        public void ShowSuccess(string text, string header)
        {
            AlertInfo ai = new AlertInfo(header,text);
            //TODO: add image and custom buttons if necessity
            alertControl.Show(this, ai);
        }

        public void ShowFailure(string text, string header)
        {
            AlertInfo ai = new AlertInfo(header, text);
            //TODO: add image and custom buttons if necessity
            alertControl.Show(this, ai);
        }
        #endregion


    }
}