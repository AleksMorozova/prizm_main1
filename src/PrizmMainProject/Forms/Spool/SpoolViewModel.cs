using Prizm.Data.DAL.Construction;
using Prizm.Data.DAL.Mill;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Construction;
using Prizm.Domain.Entity.Mill;
using Ninject;
using Prizm.Main.Commands;
using Prizm.Main.Documents;
using Prizm.Main.Forms.PipeMill;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Main.Forms.ExternalFile;
using Prizm.Main.Properties;
using Prizm.Main.Security;

namespace Prizm.Main.Forms.Spool
{
    public class SpoolViewModel : ViewModelBase, IDisposable, ISupportModifiableView
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(SpoolViewModel));

        private readonly ISpoolRepositories repos;
        readonly ICommand searchCommand;
        readonly ICommand saveCommand;
        readonly ICommand deactivateCommand;
        public string pipeNumber;
        public string spoolNumber;
        public int pipeLength;
        public int spoolLength;
        readonly IUserNotify notify;
        private IModifiable modifiableView;
        public Prizm.Domain.Entity.Construction.Spool Spool { get; set; }
        public BindingList<Pipe> allPipes { get; set; }
        public ExternalFilesViewModel FilesFormViewModel { get; set; }
        private readonly ISecurityContext ctx;
        private bool isNew;

        [Inject]
        public SpoolViewModel(ISpoolRepositories repos, Guid id, IUserNotify notify, ISecurityContext ctx)
        {
            this.repos = repos;
            this.ctx = ctx;
            this.notify = notify;
            this.Inspectors = repos.RepoInspector.GetAll();

            if (this.Inspectors == null || this.Inspectors.Count <= 0)
                log.Warn(string.Format("Spool (id:{0}) creation: List of Inspectors is NULL or empty", id));

            searchCommand = ViewModelSource.Create<EditPipeForCutCommand>(
              () => new EditPipeForCutCommand(this, repos, notify));

            saveCommand = ViewModelSource.Create<SaveSpoolCommand>(
            () => new SaveSpoolCommand(this, repos, notify, ctx));

            deactivateCommand = ViewModelSource.Create<SpoolDeactivationCommand>(
                () => new SpoolDeactivationCommand(repos, this, notify, ctx));

            allPipes = new BindingList<Pipe>();

            foreach (Pipe p in repos.PipeRepo.GetAvailableForCutPipes())
            {
                allPipes.Add(p);
            }

            if(id == Guid.Empty)
            {
                NewSpool();
            }
            else
            {
                Spool = repos.SpoolRepo.Get(id);
            }
        }

        public string SpoolNumber
        {
            get 
            { 
                return Spool.Number;
            }
            set
            {
                if (value != Spool.Number)
                {
                    Spool.Number = value;
                    RaisePropertyChanged("SpoolNumber");
                }
            }
        }

        public string PipeNumber
        {
            get
            {
                return Spool.PipeNumber;
            }
            set
            {
                if (value != Spool.PipeNumber)
                {
                    Spool.PipeNumber = value;
                    RaisePropertyChanged("PipeNumber");
                }
            }
        }

        public Pipe SpoolPipe
        {
            get { return Spool.Pipe; }
            set
            {
                if (value != Spool.Pipe)
                {
                    Spool.Pipe = value;
                    RaisePropertyChanged("PipeNumber");
                }
            }
        }

        public int PipeLength
        {
            get
            {
                return Spool.Pipe.Length;
            }
            set
            {
                if (value != Spool.Pipe.Length)
                {
                    Spool.Pipe.Length = value;
                    RaisePropertyChanged("PipeLength");
                }
            }
        }

        public int SpoolLength
        {
            get { return Spool.Length; }
            set
            {
                if (value != Spool.Length)
                {
                    Spool.Length = value;
                    Pipe.Length = Pipe.Length - Spool.Length;
                    Pipe.RecalculateWeight();
                    RaisePropertyChanged("SpoolLength");
                    RaisePropertyChanged("CanCut");
                }
            }
        }

        public bool SpoolIsActive
        {
            get { return Spool.IsActive; }
            set 
            {
                if (value != Spool.IsActive)
                {
                    Spool.IsActive = value;
                    RaisePropertyChanged("SpoolIsActive");
                }
            }
        }

        public Pipe Pipe
        {
            get
            {
                return Spool.Pipe;
            }
            set
            {
                if (value != Spool.Pipe)
                {
                    Spool.Pipe = value;
                    RaisePropertyChanged("SpoolLength");
                }
            }
        }

        public Documents.IModifiable ModifiableView
        {
            get
            {
                return modifiableView;
            }
            set
            {
                modifiableView = value;
            }
        }

        public bool CanCut
        {
            get { return (Pipe.Length - Spool.Length) > 0; }
        }

        public IList<Inspector> Inspectors { get; set; }
        public BindingList<InspectionTestResult> InspectionTestResults
        {
            get
            {
                return
                    (Spool.InspectionTestResults is BindingList<InspectionTestResult>
                    ? (BindingList<InspectionTestResult>)Spool.InspectionTestResults
                    : new BindingList<InspectionTestResult>(Spool.InspectionTestResults));
            }
            set
            {
                if (value != Spool.InspectionTestResults)
                {
                    Spool.InspectionTestResults = value;
                    RaisePropertyChanged("InspectionTestResults");
                }
            }
        }

        /// <summary>
        /// Customize displaying inspectors name in grid cell : show only last name
        /// </summary>
        internal string FormatInspectorList(IList<Inspector> inspectors)
        {
            if (inspectors == null)
            {
                return string.Empty;
            }

            return String.Join(",", (from inspector in inspectors select inspector.Name.LastName).ToArray<string>());
        }

        public void Dispose()
        {
            repos.Dispose();
            ModifiableView = null;
            if (FilesFormViewModel != null)
            {
                FilesFormViewModel.Dispose();
            }
        }

        public bool IsNew 
        {
            get { return isNew; }
            set
            {
                if (value != isNew)
                { isNew = value; }
            }
        }

        public void NewSpool() 
        {
            this.isNew = true;
            Spool = new Prizm.Domain.Entity.Construction.Spool();
            Spool.Number = string.Empty;
            Spool.InspectionTestResults = new BindingList<InspectionTestResult>();
            Spool.Pipe = new Pipe();
            Spool.ConstructionStatus = PartConstructionStatus.Pending;
            Spool.InspectionStatus = PartInspectionStatus.Pending;
            Pipe = new Pipe();
            
        }
        #region ---- Commands ----
        public ICommand SearchCommand
        {
            get { return searchCommand; }
        }

        public ICommand SaveCommand
        {
            get { return saveCommand; }
        }

        public ICommand DeactivateCommand
        {
            get { return deactivateCommand; }
        }
        #endregion
    }
}
