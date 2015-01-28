using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject.Parameters;
using Prizm.Main;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Forms.Notifications;
using Prizm.Main.Forms.PipeMill.NewEdit;
using Prizm.Main.Forms.Settings;
using Prizm.Main.Languages;
using Prizm.Main.Properties;


namespace PrizmMain.Forms.Notifications
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class NotificationXtraForm : ChildForm
    {

        // Fields
        private NotificationViewModel viewModel;

        // Methods
        public NotificationXtraForm()
        {
            this.components = null;
            this.InitializeComponent();
            Bitmap bmp = Resources.warning;
            this.Icon = Icon.FromHandle(bmp.GetHicon());
        }

        private void NotificationXtraForm_Load(object sender, EventArgs e)
        {
            viewModel = (NotificationViewModel)Program.Kernel.GetService(typeof(NotificationViewModel));
            BindToViewModel();

        }

        private void BindToViewModel()
        {
            notificationBindingSource.DataSource = viewModel;
            gridControlMessage.DataBindings.Add("DataSource", notificationBindingSource, "Notification");
        }

        private void gridControlMessage_DoubleClick(object sender, EventArgs e)
        {
            int selectedItem = gridViewNotification.GetFocusedDataSourceRowIndex();

            var parent = this.MdiParent as PrizmApplicationXtraForm;
            var id = viewModel.Notification[selectedItem].Id;

           
            OpenEditorForm(id, viewModel.Notification[selectedItem].TypeNotification);
            
    
        }

        private void OpenEditorForm(Guid id, TypeNotification typeNotification)
        {
            Type typeEditor = null;
            int page = -1;
            switch (typeNotification)
            {
                case TypeNotification.DublicatePipeNumber:
                    typeEditor = typeof(MillPipeNewEditXtraForm);
                    break;
                case TypeNotification.ExpiredCertificate:
                    typeEditor = typeof(SettingsXtraForm);
                    page = 5;
                    break;
                case TypeNotification.WelderCrtificateExpired:
                    typeEditor = typeof(SettingsXtraForm);
                    page = 4;
                    break;
                default:
                    throw new NotImplementedException();
                    //break; // unreachable code
            }

            var parent = this.MdiParent as PrizmApplicationXtraForm;

            if (typeEditor == typeof(SettingsXtraForm) && page >= 0)
            {
                parent.CreateSettingsChildForm(page);
            }
            else
            {
                parent.OpenChildForm(typeEditor, id);
            }
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                // layout items
                //new LocalizedItem(pipeNumberLayout, "NewEditPipe_PipeNumberLabel"),

                // controls
                //new LocalizedItem(attachmentsButton, "NewEditPipe_AttachmentsButton"),

                // grid column headers
                //new LocalizedItem(weldersGridColumn, "NewEditPipe_WeldersColumnHeader"),

                // layout control groups
                //new LocalizedItem(plateLayoutControlGroup, "NewEditPipe_PlateGroup"),

                // other
            };
        }

        #endregion // --- Localization ---

        private void NotificationXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewModel.Dispose();
            viewModel = null;
        }




    }
}
