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
    public partial class JointNewEditXtraForm : DevExpress.XtraEditors.XtraForm
    {
        public JointNewEditXtraForm()
        {
            InitializeComponent();
            jointNumber.Text = "1234556";
            loweringDate.Text = "10/17/2014";
            GPSLat.Text = "55.75972";
            GPSLong.Text = "37.61777";
            seaLevel.Text = "115";
            place.Text = "Pipe base";
            weldingDate.Text = "10/17/2014";
            inspector.Text = "Ivanov Ivan Ivanovich";
            welder.Text = "Petrov Petr Petrovich";
            welderNumber.Text = "25";
            inspection.Text = "10/17/2014";
        }

    }
}