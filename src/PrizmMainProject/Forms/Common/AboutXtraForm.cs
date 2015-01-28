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
using System.Reflection;
using Prizm.Main.Properties;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.Common
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class AboutXtraForm : PrizmForm
    {
        public AboutXtraForm()
        {
            InitializeComponent();
            Bitmap bmp = Resources.prizma_appIcon_32;
            this.Icon = Icon.FromHandle(bmp.GetHicon());
        }

        private void AboutXtraForm_Load(object sender, EventArgs e)
        {
            this.titleLabel.Text = Resources.AboutForm_TitleLabel;
        }
        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>() 
                { 
                    new LocalizedItem(labelVersion, "About_VersionLabel"),
                    new LocalizedItem(assemblyLabel, "About_AssemblyLabel"),

                    new LocalizedItem(acceptButton, "About_AcceptButton")
                };
        }

        #endregion // --- Localization ---
    }
}