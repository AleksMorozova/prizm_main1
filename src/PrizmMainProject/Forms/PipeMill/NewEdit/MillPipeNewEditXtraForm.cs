using System;
using System.ComponentModel;
using DevExpress.XtraEditors;
using PrizmMain.DummyData;

using Ninject.Parameters;
using Ninject;

namespace PrizmMain.Forms.PipeMill.NewEdit
{
    public partial class MillPipeNewEditXtraForm : XtraForm
    {

        MillPipeNewEditViewModel viewModel;

        public MillPipeNewEditXtraForm(string pipeNumber)
        {
            InitializeComponent();

            viewModel = (MillPipeNewEditViewModel)Program
                .Kernel
                .Get<MillPipeNewEditViewModel>(
                new ConstructorArgument("pipeNumber", pipeNumber));
        }

        public MillPipeNewEditXtraForm(): this("") { }


        private void MillPipeNewEditXtraForm_Load(object sender, EventArgs e)
        {
            BindCommands();
            BindToViewModel();
        }


        private void BindToViewModel()
        {
            pipeNewEditBindingSource.DataSource = viewModel;

            pipeNumber.DataBindings.Add("EditValue", pipeNewEditBindingSource, "Number");

            length.DataBindings.Add("EditValue", pipeNewEditBindingSource, "Length");
            weight.DataBindings.Add("EditValue", pipeNewEditBindingSource, "Weight");
            diameter.DataBindings.Add("EditValue", pipeNewEditBindingSource, "Diameter");
            thickness.DataBindings.Add("EditValue", pipeNewEditBindingSource, "WallThickness");

            plateManufacturer.DataBindings.Add("EditValue", pipeNewEditBindingSource, "HeatNumber");

        }


        private void BindCommands()
        {
            saveButton.BindCommand(() => viewModel.NewEditCommand.Execute(), viewModel.NewEditCommand);
        }




    }

}