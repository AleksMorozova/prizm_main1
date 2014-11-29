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

namespace PrizmMain.Forms.PipeMill.Heat
{
    public partial class HeatNumberXtraForm : DevExpress.XtraEditors.XtraForm
    {

        public HeatNumberXtraForm()
        {
            InitializeComponent();
        }

        public string Number { get { return number.Text; } }
    }
}