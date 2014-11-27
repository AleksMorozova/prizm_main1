using Data.DAL.Mill;
using DevExpress.Mvvm.POCO;
using Ninject;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using Domain.Entity.Mill;
using Domain.Entity.Setup;
using NHibernate.Criterion;
using System.ComponentModel;
using Domain.Entity;
using PrizmMain.Properties;
using PrizmMain.Common;


namespace PrizmMain.Forms.PipeMill.NewEdit
{
    public class MillPipeNewEditViewModel : ViewModelBase, IDisposable
    {
        private readonly IMillRepository repoMill;

        private bool pipeIsActive;

        private IList<Domain.Entity.Mill.Heat> heats;
        private IList<PurchaseOrder> purchaseOrders;
        private IList<PipeMillSizeType> pipeTypes;
        private IList<EnumWrapper<PipeMillStatus>> statusTypes;
        private IList<PipeTestResult> pipeTestResults;

        private readonly NewSavePipeCommand newSavePipeCommand;
        private readonly SavePipeCommand savePipeCommand;
        private readonly ExtractHeatsCommand extractHeatsCommand;
        private readonly ExtractPurchaseOrderCommand extractPurchaseOrderCommand;
        private readonly ExtractPipeTypeCommand extractPipeTypeCommand;
        private readonly IUserNotify notify;

        public Pipe Pipe { get; set; }
        public IList<Welder> Welders { get; set; }
        public BindingList<PipeTestResultStatusWrapper> TestResultStatuses = new BindingList<PipeTestResultStatusWrapper>();
        public IList<Inspector> Inspectors { get; set; }
        

        [Inject]
        public MillPipeNewEditViewModel(IMillRepository repoMill, Guid pipeId, IUserNotify notify)
        {
            this.repoMill = repoMill;
            this.notify = notify;

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

            if (pipeId == Guid.Empty)
            {
                NewPipe();
            }
            else
            {
                extractPurchaseOrderCommand.Execute();
                extractHeatsCommand.Execute();
                extractPipeTypeCommand.Execute();
                Pipe = repoMill.RepoPipe.Get(pipeId);
                GetAllPipeTestResults();
            }

            Welders = repoMill.WelderRepo.GetAll();
            
            Inspectors =repoMill.RepoInspector.GetAll();

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

        public IList<Domain.Entity.Mill.Heat> Heats
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

        #region Pipe

        public bool PipeIsDeactivated
        {
            get 
            {
                pipeIsActive = Pipe.IsActive;
                return !pipeIsActive; 
            }
            set
            {
                if (value == Pipe.IsActive)
                {
                    Pipe.IsActive = !value;
                    RaisePropertyChanged("PipeIsDeactivated");
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
                    RaisePropertyChanged("Length");
                }
            }
        }

        public int Weight
        {
            get { return Pipe.Weight; }
            set
            {
                if (value != Pipe.Weight)
                {
                    Pipe.Weight = value;
                    RaisePropertyChanged("Weight");
                }
            }
        }

        public int WallThickness
        {
            get { return Pipe.WallThickness; }
            set
            {
                if (value != Pipe.WallThickness)
                {
                    Pipe.WallThickness = value;
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

        public EnumWrapper<PipeMillStatus> PipeStatus
        {
            get
            {
                if (StatusTypes.Any<EnumWrapper<PipeMillStatus>>(x => x.Value == Pipe.Status))
                {
                    return StatusTypes.First<EnumWrapper<PipeMillStatus>>(x => x.Value == Pipe.Status);
                }
                return null;
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

        public DateTime PurchaseOrderDate
        {
            get
            {
                if (PipePurchaseOrder == null)
                {
                    return DateTime.MinValue;
                }

                return PipePurchaseOrder.Date;
            }
            set
            {
                if (value != PipePurchaseOrder.Date)
                {
                    PipePurchaseOrder.Date = value;
                    RaisePropertyChanged("PurchaseOrderDate");
                }
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

        public int PlateThickness
        {
            get { return Plate.Thickness; }
            set
            {
                if (value != Plate.Thickness)
                {
                    Plate.Thickness = value;
                    RaisePropertyChanged("PlateThickness");
                }
            }
        }

        #endregion

        #region Heat

        public Domain.Entity.Mill.Heat Heat
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
                if (Heat == null)
                {
                    return string.Empty;
                }
                return Heat.SteelGrade;
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

        #endregion

        #region Railcar
        public Domain.Entity.Mill.Railcar Railcar
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
                if (Railcar == null)
                {
                    return string.Empty;
                }
                return Railcar.Number;
            }
        }

        public string RailcarCertificate
        {
            get
            {
                if (Railcar == null)
                {
                    return string.Empty;
                }
                return Railcar.Certificate;
            }
        }

        public string RailcarDestination
        {
            get
            {
                if (Railcar == null)
                {
                    return string.Empty;
                }
                return Railcar.Destination;
            }
        }

        public string RailcarShippingDate
        {
            get
            {
                      if (Railcar == null || Railcar.ShippingDate == null)
                {
                    return string.Empty;
                }

                return Railcar.ShippingDate.Value.ToShortDateString();
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
        public IList<PipeTestResult> PipeTestResults
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
        

        public void NewPipe()
        {
            extractPurchaseOrderCommand.Execute();
            extractHeatsCommand.Execute();
            extractPipeTypeCommand.Execute();

            this.Pipe = new Pipe();

            this.PlateNumber = string.Empty;
            this.Pipe.IsActive = true;
            this.Pipe.Status = PipeMillStatus.Produced;

            this.Number = string.Empty;
            this.Mill = string.Empty;
            this.WallThickness = 0;
            this.Weight = 0;
            this.Length = 0;
            this.Diameter = 0;
            this.PipeTestResults = new List<PipeTestResult>();

        }

        public void Dispose()
        {
            repoMill.Dispose();
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
        public List<PipeTestResult> GetRequired(PipeMillSizeType millSizeType)
        {
            List<PipeTestResult> requiredTestResults = new List<PipeTestResult>();
            var criteria = NHibernate.Criterion.DetachedCriteria
                .For<PipeTest>()
                .Add(Restrictions.Eq("IsRequired", true))
                .Add(Restrictions.Eq("pipeType", millSizeType))
                .Add(Restrictions.Eq("IsActive", true));
            IList<PipeTest> requiredTests = repoMill.RepoPipeTest.GetByCriteria(criteria);
            foreach (var requiredTest in requiredTests)
            {
                PipeTestResult requiredResult = new PipeTestResult()
                {
                    Operation = requiredTest,
                    IsActive = true,
                    Status = PipeTestResultStatus.Scheduled,
                    Pipe = Pipe,
                    Inspectors = new BindingList<Domain.Entity.Inspector>()
                };
                requiredTestResults.Add(requiredResult);
            }
            return requiredTestResults;
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
    }
}
