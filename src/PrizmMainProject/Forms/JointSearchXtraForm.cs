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
using PrizmMain.DummyData; //remove

namespace PrizmMain.Forms
{
    public partial class JointSearchXtraForm : DevExpress.XtraEditors.XtraForm
    {
        public JointSearchXtraForm()
        {
            InitializeComponent();
            gridControlSerchResult.DataSource= JointsDummy.GetAllJoints();
            resultView.PopulateColumns();
        }
    }
}