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
    public partial class ComponentSearchXtraForm : DevExpress.XtraEditors.XtraForm
    {
        public ComponentSearchXtraForm()
        {
            InitializeComponent();

            //please remove this data in real project
            #region demoData
            componentNumber.Text = "11-22-33";
            componentType.Text = "Valve";
            certificate.Text = "certificate";
            #endregion
        }
     }
}