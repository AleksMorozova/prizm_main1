using System.ComponentModel;
using DevExpress.XtraEditors;
using PrizmMain.DummyData;
using System;

using Ninject.Parameters;
using Ninject;
using PrizmMain.Forms.PipeMill.NewEdit;
using PrizmMain.Forms.MainChildForm;

namespace PrizmMain.Forms.PipeMill.Search
{
    public partial class MillPipeSearchXtraForm : XtraForm
    {
        private MillPipeSearchViewModel viewModel;

        public MillPipeSearchXtraForm()
        {
            InitializeComponent();
        }

        private void BindToViewModel()
        {
            MillPipeSearchBindingSource.DataSource = viewModel;
            pipesSearchResult.DataBindings.Add("DataSource", MillPipeSearchBindingSource, "Pipes");

            pipeNumber.DataBindings.Add("EditValue", MillPipeSearchBindingSource, "PipeNumber");


        }

        private void BindCommands()
        {
            searchButton.BindCommand(() => viewModel.SearchCommand.Execute(), viewModel.SearchCommand);
        }

        private void MillPipeSearchXtraForm_Load(object sender, System.EventArgs e)
        {
            viewModel = (MillPipeSearchViewModel)Program.Kernel.GetService(typeof(MillPipeSearchViewModel));

            BindCommands();
            BindToViewModel();
        }

        private void pipeRepositoryButtonEdit_Click(object sender, System.EventArgs e)
        {

            int selectedPipe = pipesSearchResultView
                .GetFocusedDataSourceRowIndex();

            var edit = (XtraForm)Program
                .Kernel
                .Get<MillPipeNewEditXtraForm>(
                new ConstructorArgument(
                    "pipeNumber", 
                    viewModel.Pipes[selectedPipe].Number));

            var parent = this.MdiParent as PrizmApplicationXtraForm;
            parent.CreateFormChild(edit);

        }



    }
}