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
using Prizm.Domain.Entity.Construction;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Languages;
using Prizm.Main.Properties;

namespace Prizm.Main.Forms.Joint.NewEdit
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class SelectDiameterDialog : PrizmForm
    {

        public int Diameter { get; set; }

        public SelectDiameterDialog()
        {
            InitializeComponent();

            Bitmap bmp = Resources.joint_icon;
            this.Icon = Icon.FromHandle(bmp.GetHicon());

            saveChosenDiameter.Enabled = false;
        }

        public SelectDiameterDialog(List<Connector> duplicates): this()
        {
            foreach (var t in duplicates)
            {
                diametersIntersection.Properties.Items.Add(t);
            }
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                new LocalizedItem(diametersIntersectionLayout, "SelectDiameterDialog_DiametersIntersectionLayout"),
                new LocalizedItem(saveChosenDiameter, "SelectDiameterDialog_SaveChosenDiameter"),
            };
        }

        #endregion // --- Localization ---

        private void diametersIntersection_SelectedIndexChanged(object sender, EventArgs e)
        {
            Diameter = ((Connector)diametersIntersection.EditValue).Diameter;
            saveChosenDiameter.Enabled = (diametersIntersection.EditValue != null);
        }
    }
}