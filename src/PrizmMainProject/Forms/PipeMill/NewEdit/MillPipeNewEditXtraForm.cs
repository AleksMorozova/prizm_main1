using System;
using System.ComponentModel;
using DevExpress.XtraEditors;
using PrizmMain.DummyData;
using PrizmMain.Forms.PipeMill.Heat;
using Ninject;
using Ninject.Parameters;
using System.Windows.Forms;

namespace PrizmMain.Forms.PipeMill.NewEdit
{
    public partial class MillPipeNewEditXtraForm : XtraForm
    {
        public MillPipeNewEditXtraForm()
        {
            InitializeComponent();
            pipeNumber.Text = "125276";
            pipeSize.Text = "1219х17,5; 20,6; 27,0мм";
            heatNumber.Text = "4573278";
            purchaseOrder.Text = "3647787";
            purchaseOrderDate.Text = "10.10.2014";
            pipeCreationDate.Text = "04.11.2014";
            millStatus.Text = "на складе";
            length.Text = "4215";
            weight.Text = "2414";
            diameter.Text = "525";
            thickness.Text = "63";
            plateManufacturer.Text = "Завод 1";
            plateThickness.Text = "124";
            steelGrade.Text = "10Г2А";

            coatingType.Properties.Items.Add("наружное");
            coatingType.Properties.Items.Add("внутреннее");

            millStatus.Properties.Items.Add("в производстве");
            millStatus.Properties.Items.Add("на складе");
            millStatus.Properties.Items.Add("отгружена");

            pipeSize.Properties.Items.Add("1100х20; 15 15,0мм");
            pipeSize.Properties.Items.Add("1219х17,5; 20,6; 27,0мм");

            heatNumber.Properties.Items.Add("2136215");
            heatNumber.Properties.Items.Add("2363634");

            purchaseOrder.Properties.Items.Add("2576214");
            purchaseOrder.Properties.Items.Add("3682554");

            var inspectionDs = new InspectionDummy();
            BindingList<Inspection> inspectionData = inspectionDs.GetDummyInspection();
            inspectionOperation.DataSource = inspectionData;

            var coatingList = new BindingList<Coating>
            {
                new Coating {Date = "18.10.2014", Type = "наружное"},
                new Coating {Date = "20.10.2014", Type = "внутреннее"}
            };

            coatingHistory.DataSource = coatingList;

            var weldingDs = new WeldersDummy();
            BindingList<weldHistory> weldingData = weldingDs.GetCmpDummy();
            weldingHistory.DataSource = weldingData;
        }

        private void editHeatButton_Click(object sender, EventArgs e)
        {
            using (var heatForm = (HeatXtraForm)Program.Kernel.Get<HeatXtraForm>(new ConstructorArgument("heatNumber", heatNumber.Text)))
            {
                if (heatForm.ShowDialog() == DialogResult.OK)
                {
                    //TODO: refresh Heat data
                }
            }
           
        }
    }


    public class Coating
    {
        public string date;
        public string type;

        public String Date
        {
            get { return date; }
            set { date = value; }
        }

        public String Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}