using System;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using Ninject;
using Ninject.Parameters;

using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity;
using Prizm.Main.Forms.MainChildForm;
using System.Collections.Generic;
using Prizm.Main.Properties;
using Prizm.Main.Common;
using Prizm.Main.Forms.ExternalFile;
using Prizm.Main.Commands;
using Prizm.Main.Documents;
using Prizm.Main.Security;
using DevExpress.XtraGrid.Views.Base;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.Railcar.NewEdit
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class RailcarNewEditXtraForm : ChildForm, IValidatable, INewEditEntityForm
    {
        private Guid id;
        private ICommandManager commandManager = new CommandManager();
        private RailcarViewModel viewModel;
        private Dictionary<PipeMillStatus, string> statusTypeDict
            = new Dictionary<PipeMillStatus, string>();
        ISecurityContext ctx = Program.Kernel.Get<ISecurityContext>();

        public bool IsMatchedByGuid(Guid id) { return this.id == id; }

        public RailcarNewEditXtraForm(Guid id)
        {
            this.id = id;

            InitializeComponent();
            viewModel = (RailcarViewModel)Program.Kernel.Get<RailcarViewModel>(new ConstructorArgument("id", id));
            viewModel.ModifiableView = this;
            viewModel.validatableView = this;
            viewModel.PropertyChanged += (s, e) => IsModified = true;

            releaseNoteDate.Properties.NullDate = DateTime.MinValue;
            releaseNoteDate.Properties.NullText = string.Empty;

            this.releaseNoteDate.SetRequiredText();
            this.releaseNoteNumber.SetRequiredText();
            SetControlsTextLength();
            this.certificateNumber.SetAsIdentifier();
            this.pipeNumberLookUp.SetAsIdentifier();
            this.releaseNoteNumber.SetAsIdentifier();
            attachmentsButton.Enabled = ctx.HasAccess(global::Domain.Entity.Security.Privileges.AddAttachments);
        }

        public RailcarNewEditXtraForm()
            : this(Guid.Empty)
        {

        }

        private void RailcarNewEditXtraForm_Load(object sender, EventArgs e)
        {
            BindCommands();
            BindToViewModel();
            IsModified = false;
            IsEditMode = !viewModel.Shipped;
        }

        #region --- Localization ---

        protected override List<LocalizedItem> CreateLocalizedItems()
        {
            return new List<LocalizedItem>()
            {
                // layout items
                new LocalizedItem(releasedNoteNumberLayout, "RailcarNewEdit_ReleaseNumberLabel"),
                new LocalizedItem(releasedNoteDateLayout, "RailcarNewEdit_ReleaseDateLabel"),
                new LocalizedItem(railcarNumberLayout, "RailcarNewEdit_RailcarNumberLabel"),
                new LocalizedItem(certificateNumberLayout, "RailcarNewEdit_CertificateLabel"),
                new LocalizedItem(layoutControlDestination, "RailcarNewEdit_DestinationLabel"),

                //buttons
                new LocalizedItem(addPipeButton, "RailcarNewEdit_AddPipeButton"),
                new LocalizedItem(removePipe, "RailcarNewEdit_RemovePipeButton"),
                new LocalizedItem(attachmentsButton, "RailcarNewEdit_AttachmentsButton"),
                new LocalizedItem(shipButton, "RailcarNewEdit_ShipButton"),
                new LocalizedItem(unshipButton, "RailcarNewEdit_UnshipButton"),
                new LocalizedItem(saveButton, "RailcarNewEdit_SaveButton"),

                //columns
                new LocalizedItem(pipeNumberGridColumn, "RailcarNewEdit_PipeNumberColumn"),
                new LocalizedItem(pipeSizeGridColumn, "RailcarNewEdit_PipeTypeSizeColumn"),
                new LocalizedItem(pipeStatusGridColumn, "RailcarNewEdit_PipeStatusColumn")
            };
        }

        #endregion // --- Localization ---

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;

            railcarNumber.Properties.DataSource = viewModel.Railcars;
            railcarNumber.DataBindings.Add("EditValue", bindingSource, "Railcar");
            certificateNumber.DataBindings.Add("EditValue", bindingSource, "Certificate");
            destination.DataBindings.Add("EditValue", bindingSource, "Destination");
            pipesList.DataBindings.Add("DataSource", bindingSource, "Pipes");
            releaseNoteNumber.DataBindings.Add("EditValue", bindingSource, "Number");
            releaseNoteDate.DataBindings.Add("EditValue", bindingSource, "Date");

            pipeNumberLookUp.Properties.DataSource = viewModel.AllPipes;
            pipeNumberLookUp.Properties.DisplayMember = "Number";
            pipeNumberLookUp.Properties.ValueMember = "Id";
        }

        private void BindCommands()
        {
            commandManager["Save"].Executor(viewModel.SaveCommand).AttachTo(saveButton);
            commandManager["Ship"].Executor(viewModel.ShipCommand).AttachTo(shipButton);
            commandManager["Unship"].Executor(viewModel.UnshipCommand).AttachTo(unshipButton);
            commandManager.RefreshVisualState();

            viewModel.SaveCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;
            viewModel.ShipCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;
            viewModel.UnshipCommand.RefreshVisualStateEvent += commandManager.RefreshVisualState;

            // TODO(odem): Is BindCommands() a correct method for initializing dictionary for lookup?
            statusTypeDict.Clear();
            statusTypeDict.Add(PipeMillStatus.Produced, Resources.Produced);
            statusTypeDict.Add(PipeMillStatus.Shipped, Resources.Shipped);
            statusTypeDict.Add(PipeMillStatus.Stocked, Resources.Stocked);
            repositoryGridLookUpEditStatus.DataSource = statusTypeDict;
        }

        private void RailcarNewEditXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            commandManager.Dispose();
            viewModel.Dispose();
            viewModel = null;
        }

        private void addPipeButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(pipeNumberLookUp.Text))
            {
                return;
            }
            viewModel.AddPipe((Guid)pipeNumberLookUp.EditValue);
            viewModel.pipesList.Add(viewModel.pipeToAdd, viewModel.Railcar);
            pipesList.RefreshDataSource();
            IsModified = true;
            commandManager.RefreshVisualState();

        }

        private void removePipe_Click(object sender, EventArgs e)
        {
            string number = pipesListView.GetRowCellValue(pipesListView.FocusedRowHandle, "Number") as string;
            if(!string.IsNullOrEmpty(number))
            {
                viewModel.RemovePipe(number);
                pipesList.RefreshDataSource();
                IsModified = true;
                commandManager.RefreshVisualState();
            }
        }

        private void repositoryGridLookUpEditStatus_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if(e.Value is PipeMillStatus)
            {
                e.DisplayText = statusTypeDict[(PipeMillStatus)e.Value];
            }
        }

        private void shippedDate_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
        }

        private void SetControlsTextLength()
        {
            railcarNumber.Properties.MaxLength = LengthLimit.MaxRailcarNumber;
            destination.Properties.MaxLength = LengthLimit.MaxRailcarDestination;
            certificateNumber.Properties.MaxLength = LengthLimit.MaxRailcarCertificate;
            releaseNoteNumber.Properties.MaxLength = LengthLimit.MaxReleaseNoteNumber;
        }

        private void ButtonRefresh()
        {
            commandManager.RefreshVisualState();
        }

        private void RailcarNewEditXtraForm_Activated(object sender, EventArgs e)
        {
            viewModel.GetStoredPipes();
            pipeNumberLookUp.Properties.DataSource = viewModel.AllPipes;
            pipeNumberLookUp.Refresh();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ExternalFilesXtraForm filesForm = new ExternalFilesXtraForm(viewModel.Railcar.Id, IsEditMode);
            if(viewModel.FilesFormViewModel == null)
            {
                viewModel.FilesFormViewModel = filesForm.ViewModel;
            }
            else
            {
                filesForm.ViewModel = viewModel.FilesFormViewModel;
            }
            filesForm.ShowDialog();
        }

        #region IValidatable Members

        bool IValidatable.Validate()
        {
            return dxValidationProvider.Validate();
        }

        #endregion

        private void railcarNumber_EditValueChanged(object sender, EventArgs e)
        {
            viewModel.Number = railcarNumber.EditValue.ToString();
            commandManager.RefreshVisualState();
        }

        private void shipButton_Click(object sender, EventArgs e)
        {

        }

        private void releaseNoteNumber_EditValueChanged(object sender, EventArgs e)
        {

            commandManager.RefreshVisualState();
        }

        private void releaseNoteDate_EditValueChanged(object sender, EventArgs e)
        {

            commandManager.RefreshVisualState();
        }

        private void railcarNumber_QueryCloseUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var currentRailcar = sender as LookUpEdit;
            viewModel.Railcar = currentRailcar.EditValue as Prizm.Domain.Entity.Mill.Railcar;

        }

        private void railcarNumber_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            Prizm.Domain.Entity.Mill.Railcar r = new Prizm.Domain.Entity.Mill.Railcar
            {
                Number = railcarNumber.Text,
                Certificate = viewModel.Certificate,
                Destination = viewModel.Destination
            };

            viewModel.Railcars.Add(r);
            viewModel.Railcar = r;
        }

        private void railcarNumber_EditValueChanged_1(object sender, EventArgs e)
        {
            certificateNumber.Refresh();
            destination.Refresh();
        }
    }
}