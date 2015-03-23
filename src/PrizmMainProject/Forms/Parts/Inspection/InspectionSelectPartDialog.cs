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
using Prizm.Main.Forms.Parts.Search;
using Prizm.Main.Forms.MainChildForm;
using Prizm.Main.Languages;
using Prizm.Main.Properties;
using Prizm.Main.Common;
using Prizm.Domain.Entity.Construction;

namespace Prizm.Main.Forms.Parts.Inspection
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class InspectionSelectPartDialog : PrizmForm
    {
        BindingList<Part> parts;
        PartInspectionViewModel viewModel;
        private List<string> localizedPartTypes = new List<string>();
        public InspectionSelectPartDialog(BindingList<Part> parts, PartInspectionViewModel viewModel)
        {
            InitializeComponent();
            this.SetupForm(parts, viewModel);
        }
        public void SetupForm(BindingList<Part> parts, PartInspectionViewModel viewModel)
        {
            this.parts = parts;
            this.viewModel = viewModel;
        }
        private void NumbersDialog_Load(object sender, EventArgs e)
        {
            localizedPartTypes.Clear();
            foreach (var item in EnumWrapper<PartType>.EnumerateItems(skip0: true))
            {
                localizedPartTypes.Add(item.Item2);
            }
            searchResults.DataSource = parts;
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                new LocalizedItem(searchResultsLayout, StringResources.InspectionSelectPartDialog_SearchResultsLabel.Id),
                new LocalizedItem(cancelButton, StringResources.InspectionSelectPartDialog_CancelButton.Id),
                new LocalizedItem(acceptButton, StringResources.InspectionSelectPartDialog_InspectionButton.Id),
                // grid column headers
                new LocalizedItem(numberCol, StringResources.InspectionSelectPartDialog_NumberColumnHeader.Id),
                new LocalizedItem(typeCol, StringResources.InspectionSelectPartDialog_TypeColumnHeader.Id),
                //grid column with enum
                new LocalizedItem(searchResultsView, localizedPartTypes, new  string [] {StringResources.PartTypePipe.Id, StringResources.PartTypeSpool.Id, StringResources.PartTypeComponent.Id}),

                // header
                new LocalizedItem(this, localizedHeader, new string[] {
                    StringResources.InspectionSelectPartDialog_Title.Id} )
            };
        }

        #endregion // --- Localization ---
        private void acceptButton_Click(object sender, EventArgs e)
        {
            Part selectedElement = searchResultsView.GetRow(searchResultsView.FocusedRowHandle) as Part;
            if (selectedElement != null)
            {
                viewModel.SelectedElement = selectedElement;
            }
            this.Close();
        }

        private void searchResultsView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.Name == typeCol.Name && e.Value != null)
            {
                PartType result;
                if (Enum.TryParse<PartType>(e.Value.ToString(), out result))
                {
                    e.DisplayText = (result == PartType.Undefined) ? "" : localizedPartTypes[(int)result - 1]; //-1 because we skip 0
                }
            }
        }

        private void searchResultsView_DoubleClick(object sender, EventArgs e)
        {
            acceptButton_Click(sender, e);
        }

    }
}