using DevExpress.XtraRichEdit.Model;
using Prizm.Data.DAL.Mill;
using DevExpress.Mvvm.POCO;
using Ninject;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity.Setup;
using NHibernate.Criterion;
using System.ComponentModel;
using Prizm.Domain.Entity;
using Prizm.Main.Properties;
using Prizm.Main.Common;
using Prizm.Main.Documents;
using Prizm.Main.Forms.ExternalFile;


namespace Prizm.Main.Forms.PipeMill.NewEdit
{
    public class MillPipeNewEditViewModel : ViewModelBase, ISupportModifiableView, IDisposable
    {
        private string mill;
        private readonly IMillRepository repoMill;

        private IList<Prizm.Domain.Entity.Mill.Heat> heats;
        private IList<PurchaseOrder> purchaseOrders;
        private IList<PipeMillSizeType> pipeTypes;
        private IList<EnumWrapper<PipeMillStatus>> statusTypes;
        private BindingList<PipeTestResult> pipeTestResults;

        private readonly PipeDeactivationCommand pipeDeactivationCommand;
        private readonly NewSavePipeCommand newSavePipeCommand;
        private readonly SavePipeCommand savePipeCommand;
        private readonly ExtractHeatsCommand extractHeatsCommand;
        private readonly ExtractPurchaseOrderCommand extractPurchaseOrderCommand;
        private readonly ExtractPipeTypeCommand extractPipeTypeCommand;
        private readonly GetPipeCommand getPipeCommand;
        private readonly GetProjectCommand getProjectCommand;
        private readonly IUserNotify notify;
        private IModifiable modifiableView;
        public ExternalFilesViewModel FilesFormViewModel { get; set; }

        public Pipe Pipe { get; set; }
        public Guid PipeId { get; set; }
        public Project Project { get; set; }

        public IList<Welder> Welders { get; set; }
        public BindingList<PipeTestResultStatusWrapper> TestResultStatuses = new BindingList<PipeTestResultStatusWrapper>();
        public IList<Inspector> Inspectors { get; set; }
        public BindingList<PipeTest> AvailableTests;
        bool recalculateWeight = false;

        private bool canDeactivatePipe = false;
        public bool CanDeactivatePipe
        {
            get
            {
                return canDeactivatePipe;
            }
            set
            {
                if (value != canDeactivatePipe)
                {
                    canDeactivatePipe = value;
                    RaisePropertyChanged("CanDeactivatePipe");
                }
            }
        }

        public bool IsNew { get { return (this.Pipe.Id == Guid.Empty); } }

        [Inject]
        public MillPipeNewEditViewModel(IMillRepository repoMill, Guid id, IUserNotify notify)
        {
            this.repoMill = repoMill;
            this.notify = notify;
            this.PipeId = id;

            #region Commands creation
            pipeDeactivationCommand =
                ViewModelSource.Create(() => new PipeDeactivationCommand(this, repoMill, notify));

            newSavePipeCommand =
                ViewModelSource.Create(() => new NewSavePipeCommand(this, repoMill, notify));

            savePipeCommand =
                ViewModelSource.Create(() => new SavePipeCommand(this, repoMill, notify));

            extractHeatsCommand =
                ViewModelSource.Create(() => new ExtractHeatsCommand(this, repoMill.RepoHeat));

            extractPurchaseOrderCommand =
                ViewModelSource.Create(() => new ExtractPurchaseOrderCommand(this, repoMill.RepoPurchaseOrder));

            extractPipeTypeCommand =
                ViewModelSource.Create(() => new ExtractPipeTypeCommand(this, repoMill.RepoPipeType));

            getPipeCommand =
                ViewModelSource.Create(() => new GetPipeCommand(this, repoMill));

            getProjectCommand =
                ViewModelSource.Create(() => new GetProjectCommand(this, repoMill.RepoProject));
            #endregion

            this.GetProjectCommand.Execute();
            this.mill = Project.MillName;

            if(id == Guid.Empty)
            {
                NewPipe();
            }
            else
            {
                extractPurchaseOrderCommand.Execute();
                extractHeatsCommand.Execute();
                extractPipeTypeCommand.Execute();
                getPipeCommand.Execute();
                GetAllPipeTestResults();
                this.CanDeactivatePipe = pipeDeactivationCommand.CanExecute();
            }

            
            Welders = repoMill.WelderRepo.GetAll();
            
            Inspectors = repoMill.RepoInspector.GetAll();

            GetAvailableTests();

            foreach (string controlTypeName in Enum.GetNames(typeof(PipeTestResultStatus)))
            {
                if (controlTypeName != Enum.GetName(typeof(PipeTestResultStatus), PipeTestResultStatus.Undef))
                    TestResultStatuses.Add(new PipeTestResultStatusWrapper()
                    {
                        Value = (PipeTestResultStatus)Enum.Parse(typeof(PipeTestResultStatus), controlTypeName),
                        Text = Resources.ResourceManager.GetString(controlTypeName)
                    }
                    );
            }
            
            LoadPipeMillStatuses();
        }

        /// <summary>
        /// Gets control operations that can be added for current pipe (based on pipe size type)
        /// </summary>
        private void GetAvailableTests()
        {
            var tests = this.repoMill.RepoPipeTest.GetByMillSizeType(Pipe.Type);
            if (tests!=null)
            AvailableTests = new BindingList<PipeTest>(tests);
        }

        #region Collection-like properties
        public BindingList<Coat> Coats
        {
            get
            {
                return
                    (Pipe.Coats is BindingList<Coat>
                    ? (BindingList<Coat>)Pipe.Coats
                    : new BindingList<Coat>(Pipe.Coats));
            }
            set
            {
                if (value != Pipe.Coats)
                {
                    Pipe.Coats = value;
                    RaisePropertyChanged("Coats");
                }
            }
        }

        public BindingList<Weld> Welds
        {
            get
            {
                return
                    (Pipe.Welds is BindingList<Weld>
                    ? (BindingList<Weld>)Pipe.Welds
                    : new BindingList<Weld>(Pipe.Welds));
            }
            set
            {
                if (value != Pipe.Coats)
                {
                    Pipe.Welds = value;
                    RaisePropertyChanged("Welds");
                }
            }
        }

        public IList<EnumWrapper<PipeMillStatus>> StatusTypes
        {
            get { return statusTypes; }
            set
            {
                if (value != statusTypes)
                {
                    statusTypes = value;
                    RaisePropertyChanged("StatusTypes");
                }
            }
        }

        public IList<PurchaseOrder> PurchaseOrders
        {
            get { return purchaseOrders; }
            set
            {
                if (value != purchaseOrders)
                {
                    purchaseOrders = value;
                    RaisePropertyChanged("PurchaseOrders");
                }
            }
        }

        public IList<Prizm.Domain.Entity.Mill.Heat> Heats
        {
            get { return heats; }
            set
            {
                if (value != heats)
                {
                    heats = value;
                    RaisePropertyChanged("Heats");
                }
            }
        }

        public IList<PipeMillSizeType> PipeTypes
        {
            get { return pipeTypes; }
            set
            {
                if (value != pipeTypes)
                {
                    pipeTypes = value;
                    RaisePropertyChanged("PipeTypes");
                }
            }
        }
        #endregion

        #region Pipe

        public bool IsNotActive
        {
            get 
            {
                return Pipe.IsNotActive; 
            }
            set
            {
                if (value != Pipe.IsNotActive)
                {
                    Pipe.IsNotActive = value;
                    RaisePropertyChanged("IsNotActive");
                }
            }
        }

        public string Number
        {
            get { return Pipe.Number; }
            set
            {
                if (value != Pipe.Number)
                {
                    Pipe.Number = value;
                    RaisePropertyChanged("Number");
                }
            }
        }

        public int Diameter
        {
            get { return Pipe.Diameter; }
            set
            {
                if (value != Pipe.Diameter)
                {
                    Pipe.Diameter = value;
                    recalculateWeight = true;
                    RaisePropertyChanged("Diameter");
                }
            }
        }

        public int Length
        {
            get { return Pipe.Length; }
            set
            {
                if (value != Pipe.Length)
                {
                    Pipe.Length = value;
                    recalculateWeight = true; 
                    RaisePropertyChanged("Length");
                }
            }
        }

        public float Weight
        {
            get
            {
                if (recalculateWeight) 
                {
                    Pipe.RecalculateWeight();
                }
                return Pipe.Weight; 
            }
            set
            {
                if (value != Pipe.Weight)
                {
                    Pipe.Weight = value;
                    RaisePropertyChanged("Weight");
                }
            }
        }

        public float WallThickness
        {
            get { return Pipe.WallThickness; }
            set
            {
                if (Math.Abs(value - Math.Round(Pipe.WallThickness, 2)) > Constants.WallThicknessPrecision)
                {
                    Pipe.WallThickness = value;
                    recalculateWeight = true;
                    RaisePropertyChanged("WallThickness");
                }
            }
        }

        public string Mill
        {
            get { return Pipe.Mill; }
            set
            {
                if (value != Pipe.Mill)
                {
                    Pipe.Mill = value;
                    RaisePropertyChanged("Mill");
                }
            }
        }

        public DateTime ProductionDate
        {
            get 
            {
                return Pipe.ProductionDate; 
            }
            set
            {
                if (value != Pipe.ProductionDate)
                {
                    Pipe.ProductionDate = value;
                    RaisePropertyChanged("ProductionDate");
                }
            }
        }

        public EnumWrapper<PipeMillStatus> PipeStatus
        {
            get
            {
                return (StatusTypes.Any<EnumWrapper<PipeMillStatus>>(x => x.Value == Pipe.Status)
                    ? StatusTypes.First<EnumWrapper<PipeMillStatus>>(x => x.Value == Pipe.Status)
                    : null);
            }
            set
            {
                if (value != null && value.Value != Pipe.Status)
                {
                    Pipe.Status = value.Value;
                    RaisePropertyChanged("PipeStatus");
                }
            }
        }

        #endregion

        #region PurchaseOrder

        public PurchaseOrder PipePurchaseOrder
        {
            get { return Pipe.PurchaseOrder; }
            set
            {
                if (value != Pipe.PurchaseOrder)
                {
                    Pipe.PurchaseOrder = value;
                    RaisePropertyChanged("PipePurchaseOrder");
                }
            }
        }

        public string PurchaseOrderDate
        {
            get
            {
                return (PipePurchaseOrder == null
                    ? string.Empty
                    : PipePurchaseOrder.Date.ToShortDateString());
            }
        }

        #endregion

        #region Plate

        public Plate Plate
        {
            get { return Pipe.Plate; }
            set
            {
                if (value != Pipe.Plate)
                {
                    Pipe.Plate = value;
                    RaisePropertyChanged("Plate");
                }
            }
        }

        public string PlateNumber
        {
            get { return Plate.Number; }
            set
            {
                if (value != Plate.Number)
                {
                    Plate.Number = value;
                    RaisePropertyChanged("PlateNumber");
                }
            }
        }

        public float PlateThickness
        {
            get { return Plate.Thickness; }
            set
            {
                if (Math.Abs(value - Plate.Thickness) > Constants.WallThicknessPrecision)
                {
                    Plate.Thickness = value;
                    RaisePropertyChanged("PlateThickness");
                }
            }
        }

        #endregion

        #region Heat

        public Prizm.Domain.Entity.Mill.Heat Heat
        {
            get { return Plate.Heat; }
            set
            {
                if (value != Plate.Heat)
                {
                    Plate.Heat = value;
                    RaisePropertyChanged("Heat");
                }
            }
        }

        public string SteelGrade
        {
            get
            {
                return (Heat == null
                    ? string.Empty
                    : Heat.SteelGrade);
            }
            set
            {
                if (value != Heat.SteelGrade)
                {
                    Heat.SteelGrade = value;
                    RaisePropertyChanged("SteelGrade");
                }
            }
        }

        public PlateManufacturer PlateManufacturer
        {
            get
            {
                return (Heat == null
                    ? null
                    : Heat.PlateManufacturer);
            }
            set
            {
                if (value != Heat.PlateManufacturer)
                {
                    Heat.PlateManufacturer = value;
                    RaisePropertyChanged("PlateManufacturer");
                }
            }
        }

        public string PlateManufacturerName
        {
            get
            {
                return (string.IsNullOrEmpty(PlateManufacturer.Name)
                    ? string.Empty
                    : PlateManufacturer.Name);
            }
            set
            {
                if (value != PlateManufacturer.Name)
                {
                    Heat.PlateManufacturer.Name = value;
                    RaisePropertyChanged("PlateManufacturer");
                }
            }
        }

        #endregion

        #region Railcar
        public Prizm.Domain.Entity.Mill.Railcar Railcar
        {
            get { return Pipe.Railcar; }
            set
            {
                if (value != Pipe.Railcar)
                {
                    Pipe.Railcar = value;
                    RaisePropertyChanged("Railcar");
                }
            }
        }

        public string RailcarNumber
        {
            get
            {
                return (Railcar == null
                    ? string.Empty
                    : Railcar.Number);
            }
        }

        public string RailcarCertificate
        {
            get
            {
                return (Railcar == null
                    ? string.Empty
                    : Railcar.Certificate);
            }
        }

        public string RailcarDestination
        {
            get
            {
                return (Railcar == null
                    ? string.Empty
                    : Railcar.Destination);
            }
        }

        public string RailcarShippingDate
        {
            get
            {
                return (Railcar == null || Railcar.ShippingDate == null
                    ? string.Empty
                    : Railcar.ShippingDate.Value.ToShortDateString());
            }
        }
        #endregion

        #region PipeMillSizeType

        public PipeMillSizeType PipeMillSizeType
        {
            get { return Pipe.Type; }
            set
            {
                if (value != Pipe.Type)
                {
                    Pipe.Type = value;
                    RaisePropertyChanged("PipeMillSizeType");
                }
            }
        }


        #endregion

        #region PipeTestResults
        public BindingList<PipeTestResult> PipeTestResults
        {
            get { return pipeTestResults; }
            set
            {
                if (value != pipeTestResults)
                {
                    pipeTestResults = value;
                    RaisePropertyChanged("PipeTestResults");
                }
            }
        }
        #endregion

        #region Commands
        public ICommand NewSavePipeCommand
        {
            get { return newSavePipeCommand; }
        }

        public ICommand ExtractHeatsCommand
        {
            get { return extractHeatsCommand; }
        }

        public ICommand ExtractPurchaseOrderCommand
        {
            get { return extractPurchaseOrderCommand; }
        }

        public ICommand SavePipeCommand
        {
            get { return savePipeCommand; }
        }

        public ICommand PipeDeactivationCommand
        {
            get { return pipeDeactivationCommand; }
        }

        public ICommand GetProjectCommand
        {
            get { return getProjectCommand; }
        }
        #endregion

        public void NewPipe()
        {
            extractPurchaseOrderCommand.Execute();
            extractHeatsCommand.Execute();
            extractPipeTypeCommand.Execute();

            this.Pipe = new Pipe();
            this.PipePurchaseOrder = null;
            this.Heat = null;

            this.PlateNumber = string.Empty;
            this.Pipe.IsActive = true;
            this.Pipe.Status = PipeMillStatus.Produced;

            this.Number = string.Empty;
            this.Mill = string.Empty;

            this.WallThickness = 0;
            this.Weight = 0;
            this.Length = 0;
            this.Diameter = 0;
            this.PipeTestResults = new BindingList<PipeTestResult>();

            this.CanDeactivatePipe = false;
            this.Pipe.Mill = mill;
        }

        public void Dispose()
        {
            repoMill.Dispose();
            ModifiableView = null;
            if (FilesFormViewModel != null)
            {
                FilesFormViewModel.Dispose();
            }
        }

        /// <summary>
        /// Gets for current pipe all linked pipe test results and sets them to its property
        /// </summary>
        void GetAllPipeTestResults()
        {
            var criteria = NHibernate.Criterion.DetachedCriteria
                .For<PipeTestResult>().
                Add((Restrictions.Eq("Pipe", Pipe)));
            var foundTestResults = repoMill.RepoPipeTestResult.GetByCriteria(criteria).ToList();
            pipeTestResults = new BindingList<PipeTestResult>(foundTestResults);
            
        }

        internal string FormatWeldersList(IList<Welder> welders)
        {
            if (welders == null)
                return String.Empty;

            return String.Join(",", (from welder in welders select welder.Name.LastName).ToArray<string>());
        }

        /// <summary>
        /// Customize displaying inspectors name in grid cell : show only last name
        /// </summary>
        internal string FormatInspectorList(IList<Inspector> inspectors)
        {
            if (inspectors == null)
                return String.Empty;

            return String.Join(",", (from inspector in inspectors select inspector.Name.LastName).ToArray<string>());
        }

        /// <summary>
        /// Creates predefined pipe test results for all active required tests for concrete pipe mill size type
        /// </summary>
        /// <param name="millSizeType"></param>
        public BindingList<PipeTestResult> GetRequired(PipeMillSizeType millSizeType)
        {
            BindingList<PipeTestResult> requiredTestResults = new BindingList<PipeTestResult>();
            var criteria = NHibernate.Criterion.DetachedCriteria
                .For<PipeTest>()
                .Add(Restrictions.Eq("IsRequired", true))
                .Add(Restrictions.Eq("pipeType", millSizeType))
                .Add(Restrictions.Eq("IsActive", true));
            IList<PipeTest> requiredTests = repoMill.RepoPipeTest.GetByCriteria(criteria);
            GetAvailableTests();
            foreach (var requiredTest in requiredTests)
            {
                PipeTestResult requiredResult = new PipeTestResult()
                {
                    Operation = requiredTest,
                    IsActive = true,
                    Status = PipeTestResultStatus.Scheduled,
                    Pipe = Pipe,
                    Inspectors = new BindingList<Prizm.Domain.Entity.Inspector>()
                };
                requiredTestResults.Add(requiredResult);
                requiredResult.Order++;
            }
            return requiredTestResults;
        }

        public int IsAnyInspectionResult()
        {
            int count = 0; 
            foreach (PipeTestResult test in pipeTestResults)
            {
                if ((test.Status == PipeTestResultStatus.Failed) || 
                    (test.Status == PipeTestResultStatus.Passed))
                {
                    count++;
                }
            }
            return count;
        }


        private void LoadPipeMillStatuses()
        {
            StatusTypes = new List<EnumWrapper<PipeMillStatus>>();

            foreach (string statusTypeName in Enum.GetNames(typeof(PipeMillStatus)))
            {
                if (statusTypeName != Enum.GetName(typeof(PipeMillStatus), PipeMillStatus.Undefined))
                {
                    StatusTypes.Add(new EnumWrapper<PipeMillStatus>() { Name = statusTypeName });
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

         public bool CheckStatus()
         {
             bool resultValue = true;

             List<string> testsResults = orderTestResult();

             if (Pipe.Status == PipeMillStatus.Stocked)
             {
                 if (Pipe.Railcar != null)
                 {
                     if (testsResults.Contains(PipeTestResultStatus.Failed.ToString()) || testsResults.Contains(PipeTestResultStatus.Scheduled.ToString()))
                     {
                         resultValue = false;
                     }
                     else
                     {
                         Pipe.Status = PipeMillStatus.Stocked;
                         resultValue = true;
                     }
                 }
                 else 
                 {
                     ChangePipeStatus(testsResults);
                     resultValue = true;
                 }
             }

             else
             {
                 ChangePipeStatus(testsResults);
                 resultValue = true;
             }

             return resultValue;
         }

         /// <summary>
         /// Change Pipe status according to pipe test results
         /// </summary>
         public void ChangePipeStatus(List<string> testsResults)
         {
             if (testsResults.Contains(PipeTestResultStatus.Failed.ToString()) || testsResults.Contains(PipeTestResultStatus.Scheduled.ToString()))
             {
                 Pipe.Status = PipeMillStatus.Produced;
             }
             else
             {
                 Pipe.Status = PipeMillStatus.Stocked;
             }
         }

         /// <summary>
         /// Returns list of ordered Pipe test results
         /// </summary>
         public List<string> orderTestResult()
         {
             List<string> testsResults = new List<string>();

             // order by operation name
             var query = Pipe.PipeTestResult.GroupBy(test => test.Operation.Name, (name, results) => new
             {
                 Key = name, // operation name
                 Date = results.Max(t => t.Date) // max date in group
             });

             foreach (var result in query)
             {
                 var lastOperation =
                     from p in Pipe.PipeTestResult
                     where p.Date == result.Date && p.Operation.Name == result.Key
                     select p;

                 if (lastOperation.Count() >= 2)
                 {
                     int maxOrder = lastOperation.Max(o => o.Order);

                     var lastOperation2 =
                         from p in lastOperation
                         where p.Order == maxOrder
                         select p;

                     foreach (var t in lastOperation2)
                     {
                         testsResults.Add(t.Status.ToString());
                     }
                 }
                 else
                 {
                     foreach (var t in lastOperation)
                     {
                         testsResults.Add(t.Status.ToString());
                     }
                 }
             }

             return testsResults;
         }
    }
}
