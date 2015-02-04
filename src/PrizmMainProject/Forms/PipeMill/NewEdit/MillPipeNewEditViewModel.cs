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
using Prizm.Main.Security;


namespace Prizm.Main.Forms.PipeMill.NewEdit
{
    public class MillPipeNewEditViewModel : ViewModelBase, ISupportModifiableView, IDisposable
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(MillPipeNewEditViewModel));

        private PipeMillSizeType currentType;

        private string mill;
        private readonly IMillRepository repoMill;

        private IList<Prizm.Domain.Entity.Mill.Heat> heats;
        private IList<PurchaseOrder> purchaseOrders;
        private IList<PipeMillSizeType> pipeTypes;
        private IList<EnumWrapper<PipeMillStatus>> statusTypes;
        private BindingList<PipeTestResult> pipeTestResults;
        private readonly ISecurityContext ctx;
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
        private IValidatable validatableView;
        public ExternalFilesViewModel FilesFormViewModel { get; set; }
        private bool isNew;
        public Pipe Pipe { get; set; }
        public Guid PipeId { get; set; }
        public Project Project { get; set; }

        public IList<Welder> Welders { get; set; }
        public BindingList<EnumWrapper<PipeTestResultStatus>> TestResultStatuses = new BindingList<EnumWrapper<PipeTestResultStatus>>();
        public IList<Inspector> Inspectors { get; set; }
        public BindingList<PipeTest> AvailableTests;
        bool recalculateWeight = false;

        [Inject]
        public MillPipeNewEditViewModel(IMillRepository repoMill, Guid id, IUserNotify notify, ISecurityContext ctx)
        {
            this.repoMill = repoMill;
            this.notify = notify;
            this.PipeId = id;
            this.ctx = ctx;

            #region Commands creation
            pipeDeactivationCommand =
                ViewModelSource.Create(() => new PipeDeactivationCommand(this, repoMill, notify, ctx));

            newSavePipeCommand =
                ViewModelSource.Create(() => new NewSavePipeCommand(this, repoMill, notify,ctx));

            savePipeCommand =
                ViewModelSource.Create(() => new SavePipeCommand(this, repoMill, notify, ctx));

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
            }

            Welders = repoMill.WelderRepo.GetAll();
            if (this.Welders == null || this.Welders.Count <= 0)
                log.Warn(string.Format("Pipe (id:{0}) creation: List of Welders is NULL or empty", id));

            Inspectors = repoMill.RepoInspector.GetAll();
            if (this.Inspectors == null || this.Inspectors.Count <= 0)
                log.Warn(string.Format("Pipe (id:{0}) creation: List of Inspectors is NULL or empty", id));

            GetAvailableTests();

            foreach(string controlTypeName in Enum.GetNames(typeof(PipeTestResultStatus)))
            {
                if(controlTypeName != Enum.GetName(typeof(PipeTestResultStatus), PipeTestResultStatus.Undefined))
                    TestResultStatuses.Add(new EnumWrapper<PipeTestResultStatus>()
                    {
                        Value = (PipeTestResultStatus)Enum.Parse(typeof(PipeTestResultStatus), controlTypeName)
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
            if (tests != null)
            {
                AvailableTests = new BindingList<PipeTest>(tests);
            }
            else
            {
                log.Warn(string.Format("List of Pipe Tests for type {0} is NULL.", Pipe.Type));
            }
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
                if(value != Pipe.Coats)
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
                if(value != Pipe.Coats)
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
                if(value != statusTypes)
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
                if(value != purchaseOrders)
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
                if(value != heats)
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
                if(value != pipeTypes)
                {
                    pipeTypes = value;
                    RaisePropertyChanged("PipeTypes");
                }
            }
        }
        #endregion

        #region Pipe

        public bool PipeIsActive
        {
            get { return Pipe.IsActive; }
            set
            {
                if(value != Pipe.IsActive)
                {
                    Pipe.IsActive = value;
                    RaisePropertyChanged("PipeIsActive");
                }
            }
        }

        public string Number
        {
            get { return Pipe.Number; }
            set
            {
                if(value != Pipe.Number)
                {
                    Pipe.Number = value;
                    RaisePropertyChanged("Number");
                }
            }
        }

        //length from control operation
        public int PipeLength
        {
            get { return Pipe.Length; }
            set
            {
                if(value != Pipe.Length)
                {
                    Pipe.Length = value;
                    RaisePropertyChanged("PipeLength");
                }
            }
        }

        public float Weight
        {
            get
            {
                if(recalculateWeight)
                {
                    Pipe.RecalculateWeight();
                }
                return Pipe.Weight;
            }
            set
            {
                if(value != Pipe.Weight)
                {
                    Pipe.Weight = value;
                    RaisePropertyChanged("Weight");
                }
            }
        }

        public string Mill
        {
            get { return Pipe.Mill; }
            set
            {
                if(value != Pipe.Mill)
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
                if(value != Pipe.ProductionDate)
                {
                    Pipe.ProductionDate = value;
                    RaisePropertyChanged("ProductionDate");
                }
            }
        }

        public PipeMillStatus PipeStatus
        {
            get
            {
                return Pipe.Status;
            }
            set
            {
                if(value != Pipe.Status)
                {
                    Pipe.Status = value;
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
                if(value != Pipe.PurchaseOrder)
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
                if(value != Pipe.Plate)
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
                if(value != Plate.Number)
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
                if(Math.Abs(value - Plate.Thickness) > Constants.WallThicknessPrecision)
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
                if(value != Plate.Heat)
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
                if(value != Heat.SteelGrade)
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
                if(value != Heat.PlateManufacturer)
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
                if(value != PlateManufacturer.Name)
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
                if(value != Pipe.Railcar)
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

        #endregion

        #region PipeMillSizeType

        public PipeMillSizeType PipeMillSizeType
        {
            get { return Pipe.Type; }
            set
            {
                if(value != Pipe.Type)
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
                if(value != pipeTestResults)
                {
                    pipeTestResults = value;
                    RaisePropertyChanged("PipeTestResults");
                    RaisePropertyChanged("PipeLength");
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
            currentType = new PipeMillSizeType();
            extractPurchaseOrderCommand.Execute();
            extractHeatsCommand.Execute();
            extractPipeTypeCommand.Execute();

            this.isNew = true;
            this.Pipe = new Pipe();
            this.PipePurchaseOrder = null;
            this.Heat = null;
            this.PlateNumber = string.Empty;
            this.Pipe.IsActive = true;
            this.Pipe.IsAvailableToJoint = true;
            this.Pipe.Status = PipeMillStatus.Produced;
            this.Pipe.ConstructionStatus = Domain.Entity.Construction.PartConstructionStatus.Pending;
            this.Pipe.InspectionStatus = Domain.Entity.Construction.PartInspectionStatus.Pending;
            this.Pipe.Project = repoMill.RepoProject.GetSingle();

            this.Number = string.Empty;
            this.Mill = string.Empty;

            this.WallThickness = 0;
            this.Weight = 0;
            this.Length = 0;
            this.Diameter = 0;
            this.PipeTestResults = new BindingList<PipeTestResult>();

            this.Pipe.Mill = mill;
            this.Pipe.ToExport = false;
        }

        public void Dispose()
        {
            repoMill.Dispose();
            ModifiableView = null;
            if(FilesFormViewModel != null)
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
            List<PipeTestResult> sortedResult = new List<PipeTestResult>();

            // Sorting rules:
            // Sheduled inspections  - first of all sorted by code
            // Other status inspection - sort by date. Inspections with some date sorting by code.
            // inspections with some date & code sotting by order
            #region Sorting inspections
            var sheduledResult = from result in foundTestResults
                                 orderby result.Operation.Code
                                 where result.Status == PipeTestResultStatus.Scheduled
                                 select result;

            var otherResult = from result in foundTestResults
                              orderby result.Date, result.Operation.Code, result.Order
                              where result.Status != PipeTestResultStatus.Scheduled
                              select result;

            sortedResult.AddRange(sheduledResult);
            sortedResult.AddRange(otherResult);
            #endregion

            pipeTestResults = new BindingList<PipeTestResult>(sortedResult);
        }

        internal string FormatWeldersList(IList<Welder> welders)
        {
            if(welders == null)
                return string.Empty;

            return String.Join(",", (from welder in welders select welder.Name.LastName).ToArray<string>());
        }

        /// <summary>
        /// Customize displaying inspectors name in grid cell : show only last name
        /// </summary>
        internal string FormatInspectorList(IList<Inspector> inspectors)
        {
            if(inspectors == null)
                return string.Empty;

            return String.Join(",", (from inspector in inspectors select inspector.Name.LastName).ToArray<string>());
        }

        /// <summary>
        /// Creates predefined pipe test results for all active required availableTests for concrete pipe mill size type
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
            foreach(var requiredTest in requiredTests)
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
            foreach(PipeTestResult test in pipeTestResults)
            {
                if((test.Status == PipeTestResultStatus.Failed)
                    || (test.Status == PipeTestResultStatus.Passed)
                    || (test.Status == PipeTestResultStatus.Repair)
                    )
                {
                    count++;
                }
            }
            return count;
        }


        private void LoadPipeMillStatuses()
        {
            StatusTypes = new List<EnumWrapper<PipeMillStatus>>();

            foreach(var item in EnumWrapper<PipeMillStatus>.EnumerateItems(skip0:true))
            {
                StatusTypes.Add(new EnumWrapper<PipeMillStatus>(item.Item2));
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

        public IValidatable ValidatableView
        {
            get { return validatableView; }
            set { validatableView = value; }
        }

        public bool CheckStatus()
        {
            bool resultValue = true;

            List<string> testsResults = orderTestResult();

            if(Pipe.Status == PipeMillStatus.Stocked)
            {
                if(Pipe.Railcar != null)
                {
                    if(testsResults.Contains(PipeTestResultStatus.Failed.ToString())
                        || testsResults.Contains(PipeTestResultStatus.Scheduled.ToString())
                        || testsResults.Contains(PipeTestResultStatus.Repair.ToString())
                        )
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
            if(testsResults.Contains(PipeTestResultStatus.Failed.ToString())
                || testsResults.Contains(PipeTestResultStatus.Scheduled.ToString())
                || testsResults.Contains(PipeTestResultStatus.Repair.ToString())
                )
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

            foreach(var result in query)
            {
                var lastOperation =
                    from p in Pipe.PipeTestResult
                    where p.Date == result.Date && p.Operation.Name == result.Key
                    select p;

                if(lastOperation.Count() >= 2)
                {
                    int maxOrder = lastOperation.Max(o => o.Order);

                    var lastOperation2 =
                        from p in lastOperation
                        where p.Order == maxOrder
                        select p;

                    foreach(var t in lastOperation2)
                    {
                        testsResults.Add(t.Status.ToString());
                    }
                }
                else
                {
                    foreach(var t in lastOperation)
                    {
                        testsResults.Add(t.Status.ToString());
                    }
                }
            }

            return testsResults;
        }

        public PipeMillSizeType CurrentType
        {
            get
            {
                return currentType;
            }
            set
            {
                if(value != currentType)
                {
                    currentType = value;
                    RaisePropertyChanged("CurrentType");
                    RaisePropertyChanged("Length");
                    RaisePropertyChanged("Diameter");
                    RaisePropertyChanged("Thickness");

                    Pipe.Diameter = Pipe.Type.Diameter;
                    Pipe.WallThickness = Pipe.Type.Thickness;
                    Pipe.Length = this.PipeLength;
                }
            }
        }

        //Length from pipeMillsizeType parameters
        public int Length
        {
            get
            {
                if(CurrentType != null) { return CurrentType.Length; } else { return 0; }

            }
            set
            {
                if(value != CurrentType.Length)
                {
                    CurrentType.Length = value;
                    RaisePropertyChanged("Length");
                }
            }
        }

        public int Diameter
        {
            get
            {
                if(CurrentType != null) { return CurrentType.Diameter; } else { return 0; }
            }
            set
            {
                if(value != CurrentType.Diameter)
                {
                    CurrentType.Diameter = value;
                    RaisePropertyChanged("Diameter");
                }
            }
        }

        public int WallThickness
        {
            get
            {
                if(CurrentType != null)
                {
                    return CurrentType.Thickness;
                }
                else { return 0; }
            }
            set
            {
                if(value != CurrentType.Thickness)
                {
                    CurrentType.Thickness = value;
                    RaisePropertyChanged("WallThickness");
                }
            }
        }


        public int GetLengthFromOperation()
        {
            recalculateWeight = true;
            List<PipeTestResult> lengthOperation = new List<PipeTestResult>();
            List<PipeTestResult> lengthOperation2 = new List<PipeTestResult>();
            List<PipeTestResult> lengthOperation3 = new List<PipeTestResult>();

            //group by category
            foreach(PipeTestResult t in Pipe.PipeTestResult)
            {
                if(t.Operation.Category.Type==FixedCategory.Length && t.Status == PipeTestResultStatus.Passed)
                    lengthOperation.Add(t);
            }

            //group by date
            foreach(PipeTestResult t in lengthOperation)
            {
                if(t.Date >= lengthOperation.Max(d => d.Date))
                    lengthOperation2.Add(t);
            }

            //group by order
            if(lengthOperation2.Count() >= 2)
            {
                foreach(PipeTestResult t in lengthOperation2)
                {
                    if(t.Order >= lengthOperation2.Max(d => d.Order))
                        lengthOperation3.Add(t);
                }
            }

            else
            {
                foreach(PipeTestResult t in lengthOperation2)
                {
                    this.PipeLength = Convert.ToInt32(t.Value);
                    //Pipe.Length = Convert.ToInt32(t.Value);
                }
            }

            foreach(PipeTestResult t in lengthOperation3)
            {
                this.PipeLength = Convert.ToInt32(t.Value);
                //Pipe.Length = Convert.ToInt32(t.Value);
            }

            Pipe.RecalculateWeight();
            return Pipe.Length;
        }

        public PipeTestResultStatus CheckOperationStatus(List<PipeTestResult> lengthOperation)
        {
            PipeTestResultStatus result = PipeTestResultStatus.Scheduled;
            var lastOperation =
               from p in lengthOperation
               where p.Date == lengthOperation.Max(d => d.Date)
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
                    result = t.Status;
                }
            }
            else
            {
                foreach (var t in lastOperation)
                {
                    result = t.Status;
                }
            }

            return result;
        }

        public void UpdatePipeSubStatus()
        {
            List<PipeTestResult> weldOperation = new List<PipeTestResult>();
            List<string> weldTestsResults = new List<string>();
            List<PipeTestResult> internalCoatOperation = new List<PipeTestResult>();
            List<string> internalCoatTestsResults = new List<string>();
            List<PipeTestResult> externalCoatOperation = new List<PipeTestResult>();
            List<string> externalCoatTestsResults = new List<string>();
            //group by Weld category
            foreach (PipeTestResult t in Pipe.PipeTestResult)
            {
                if (t.Operation.Category.Type == FixedCategory.Weld)
                {
                    weldOperation.Add(t);
                    weldTestsResults.Add(t.Status.ToString());
                }
            }

            //group by ExternalCoat category
            foreach (PipeTestResult t in Pipe.PipeTestResult)
            {
                if (t.Operation.Category.Type == FixedCategory.ExternalCoat)
                {
                    externalCoatOperation.Add(t);
                    externalCoatTestsResults.Add(t.Status.ToString());
                }
            }

            //group by InternalCoat category
            foreach (PipeTestResult t in Pipe.PipeTestResult)
            {
                if (t.Operation.Category.Type == FixedCategory.InternalCoat)
                {
                    internalCoatOperation.Add(t);
                    internalCoatTestsResults.Add(t.Status.ToString());
                }
            }

            Pipe.WeldSubStatus=UpdateSubStatus(weldOperation, weldTestsResults);
            Pipe.InternalCoatSubStatus = UpdateSubStatus(internalCoatOperation, internalCoatTestsResults);
            Pipe.ExternalCoatSubStatus = UpdateSubStatus(externalCoatOperation, externalCoatTestsResults);
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

        public PipeMillSubStatus UpdateSubStatus(List<PipeTestResult> allResults, List<string> testsResult) 
        {
            if (allResults.Count > 0)
            {
                PipeTestResultStatus resultStatus = CheckOperationStatus(allResults);
                if (resultStatus == PipeTestResultStatus.Scheduled)
                {
                    return PipeMillSubStatus.Scheduled;
                }
                else
                {
                    if (resultStatus == PipeTestResultStatus.Failed)
                    {
                        return PipeMillSubStatus.Failed;
                    }
                    else
                    {
                        if (resultStatus == PipeTestResultStatus.Passed && testsResult.Contains(PipeTestResultStatus.Repair.ToString()))
                        {
                            return PipeMillSubStatus.WithRepair;
                        }
                        else
                        {
                            return PipeMillSubStatus.Passed;
                        }
                    }
                }
            }
            else
            {
                return PipeMillSubStatus.Undefined;
            }
        }
    }
}
