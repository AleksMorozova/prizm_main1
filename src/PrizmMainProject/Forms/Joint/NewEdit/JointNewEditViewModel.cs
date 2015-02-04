using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraCharts.Native;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Construction;
using Prizm.Domain.Entity.Setup;
using Ninject;
using Prizm.Main.Commands;
using Prizm.Main.Documents;
using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using construction = Prizm.Domain.Entity.Construction;
using System.Windows.Forms;
using Prizm.Main.Forms.ExternalFile;
using Prizm.Domain.Entity.Mill;
using Prizm.Main.Common;
using Prizm.Main.Security;

namespace Prizm.Main.Forms.Joint.NewEdit
{
    public class JointNewEditViewModel : ViewModelBase, ISupportModifiableView, IDisposable
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(JointNewEditViewModel));

        private readonly IConstructionRepository repoConstruction;
        private readonly Prizm.Data.DAL.IMillReportsRepository adoRepo;
        private readonly IUserNotify notify;
        private readonly ISecurityContext ctx;
        private readonly SaveJointCommand saveJointCommand;
        private readonly NewSaveJointCommand newSaveJointCommand;
        private readonly ExtractOperationsCommand extractOperationsCommand;
        private readonly JointDeactivationCommand jointdeactivationCommand;
        private readonly JointCutCommand jointCutCommand;
        private readonly SaveOrUpdateJointCommand saveOrUpdateJointCommand;
        private IModifiable modifiableView;
        private IValidatable validatableView;
        private DataTable pieces;
        private BindingList<JointTestResult> jointTestResults;
        private BindingList<JointWeldResult> jointWeldResults;
        private JointStatus jointStatus = JointStatus.Welded;
        private bool isNew;
        private PartData firstElement;
        private PartData secondElement;

        public construction.Joint Joint { get; set; }
        public Guid JointId { get; set; }
        public BindingList<JointOperation> ControlOperations;
        public BindingList<JointOperation> RepairOperations;
        public IList<Inspector> Inspectors { get; set; }
        public IList<Welder> Welders { get; set; }
        public ExternalFilesViewModel FilesFormViewModel { get; set; }


        [Inject]
        public JointNewEditViewModel(
            IConstructionRepository repoConstruction, 
            IUserNotify notify, 
            Guid id, 
            Prizm.Data.DAL.IMillReportsRepository adoRepo,
            ISecurityContext ctx)
        {
            this.repoConstruction = repoConstruction;
            this.JointId = id;
            this.notify = notify;
            this.adoRepo = adoRepo;
            this.ctx = ctx;

            #region Commands
            saveOrUpdateJointCommand =
                ViewModelSource.Create(() => new SaveOrUpdateJointCommand(repoConstruction, this, notify, ctx));
            saveJointCommand =
              ViewModelSource.Create(() => new SaveJointCommand(repoConstruction, this, notify, ctx));
            newSaveJointCommand =
              ViewModelSource.Create(() => new NewSaveJointCommand(repoConstruction, this, notify, ctx));
            extractOperationsCommand =
                ViewModelSource.Create(() => new ExtractOperationsCommand(repoConstruction, this));
            jointdeactivationCommand = 
                ViewModelSource.Create(() => new JointDeactivationCommand(repoConstruction, this, notify, ctx));
            jointCutCommand =
                ViewModelSource.Create(() => new JointCutCommand(repoConstruction, this, notify));
            #endregion

            Inspectors = repoConstruction.RepoInspector.GetAll();
            if (this.Inspectors == null || this.Inspectors.Count <= 0)
                log.Warn(string.Format("Joint (id:{0}) creation: List of Inspectors is NULL or empty", this.JointId));

            Welders = repoConstruction.RepoWelder.GetAll();
            if (this.Welders == null || this.Welders.Count <= 0)
                log.Warn(string.Format("Joint (id:{0}) creation: List of Welders is NULL or empty", this.JointId));

            Pieces = adoRepo.GetPipelineElements();
            if (this.Pieces == null || this.Pieces.Rows.Count <= 0)
                log.Warn(string.Format("Joint (id:{0}) creation: Data Table of Pieces is NULL or empty", this.JointId));

            extractOperationsCommand.Execute();

            if(id == Guid.Empty)
            {
                NewJoint();
            }
            else
            {
                this.Joint = repoConstruction.RepoJoint.Get(id);

                if (Joint.FirstElement != null
                    && Joint.SecondElement != null
                    && Joint.Status != Domain.Entity.Construction.JointStatus.Withdrawn)
                {
                    this.firstElement = GetPartDataFromList(Joint.FirstElement, GetPart(Joint.FirstElement));
                    this.secondElement = GetPartDataFromList(Joint.SecondElement, GetPart(Joint.SecondElement));

                    Joint.FirstElement = this.firstElement;
                    Joint.SecondElement = this.secondElement;
                }
                else
                {
                    log.Warn(string.Format("Joint #{0} do not has connected Parts or is Withdrawn.", Joint.Number));
                }

                var weldResults = repoConstruction.RepoJointWeldResult.GetByJoint(this.Joint);
                if (weldResults != null)
                {
                    jointWeldResults = new BindingList<JointWeldResult>(weldResults);
                }
                else
                {
                    log.Warn(string.Format("Joint #{0} do not have Welding Results.", Joint.Number));
                }

                var testResults = repoConstruction.RepoJointTestResult.GetByJoint(this.Joint);
                if (testResults != null)
                {
                    jointTestResults = new BindingList<JointTestResult>(testResults);
                }
                else
                {
                    log.Warn(string.Format("Joint #{0} do not have Test Results.", Joint.Number));
                }
            }
        }

        public void Dispose()
        {
            repoConstruction.Dispose();
            ModifiableView = null;
            if (FilesFormViewModel != null)
            {
                FilesFormViewModel.Dispose();
            }
        }

        internal string FormatInspectorList(IList<Inspector> inspectors)
        {
            if (inspectors == null)
                return string.Empty;

            return String.Join(",", (from inspector in inspectors select inspector.Name.LastName).ToArray<string>());
        }

        internal string FormatWelderList(IList<Welder> welders)
        {
            if(welders == null)
                return string.Empty;

            return String.Join(",", (from welder in welders select welder.Name.LastName).ToArray<string>());
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

        #region Commands
        public ICommand SaveJointCommand
        {
            get { return saveJointCommand; }
        }

        public ICommand ExtractOperationsCommand
        {
            get { return extractOperationsCommand; }
        }

        public ICommand NewSaveJointCommand
        {
            get { return newSaveJointCommand; }
        }

        public ICommand JointDeactivationCommand
        {
            get { return jointdeactivationCommand; }
        }

        public ICommand JointCutCommand
        {
            get { return jointCutCommand; }
        }

        public ICommand SaveOrUpdateJointCommand
        {
            get { return saveOrUpdateJointCommand; }
        }
        #endregion

        # region Joint

        public bool JointIsActive
        {
            get { return Joint.IsActive; }
            set
            {
                if (value != Joint.IsActive)
                {
                    Joint.IsActive = value;
                    RaisePropertyChanged("JointIsActive");
                }
            }
        }

        public string Number
        {
            get { return Joint.Number; }
            set
            {
                if (value != Joint.Number)
                {
                    Joint.Number = value;
                    RaisePropertyChanged("Number");
                }
            }
        }

        public DateTime LoweringDate
        {
            get
            {
                if (Joint.LoweringDate.HasValue)
                {
                    return Joint.LoweringDate.Value;
                }
                else
                {
                    return DateTime.MinValue;
                }
            }
            set
            {
                if (value != Joint.LoweringDate)
                {
                    Joint.LoweringDate = value;
                    RaisePropertyChanged("LoweringDate");
                    RaisePropertyChanged("JointConstructionStatus");
                }
            }
        }

        public float GpsHeight
        {
            get { return Joint.GpsHeight; }
            set
            {
                if (value != Joint.GpsHeight)
                {
                    Joint.GpsHeight = value;
                    RaisePropertyChanged("GpsHeight");
                }
            }
        }

        public double GpsLatitude
        {
            get { return Joint.GpsLatitude; }
            set
            {
                if (value != Joint.GpsLatitude)
                {
                    Joint.GpsLatitude = value;
                    RaisePropertyChanged("GpsLatitude");
                }
            }
        }

        public double GpsLongitude
        {
            get { return Joint.GpsLongitude; }
            set
            {
                if (value != Joint.GpsLongitude)
                {
                    Joint.GpsLongitude = value;
                    RaisePropertyChanged("GpsLongitude");
                }
            }
        }

        public int NumberKP
        {
            get { return Joint.NumberKP; }
            set
            {
                if (value != Joint.NumberKP)
                {
                    Joint.NumberKP = value;
                    RaisePropertyChanged("NumberKP");
                }
            }
        }

        public float DistanceFromKP
        {
            get { return Joint.DistanceFromKP; }
            set
            {
                if (value != Joint.DistanceFromKP)
                {
                    Joint.DistanceFromKP = value;
                    RaisePropertyChanged("DistanceFromKP");
                }
            }
        }

        public BindingList<JointTestResult> JointTestResults
        {
            get { return jointTestResults; }
            set
            {
                if (value != jointTestResults)
                {
                    jointTestResults = value;
                    RaisePropertyChanged("JointTestResults");
                }
            }
        }

        public BindingList<JointWeldResult> JointWeldResults
        {
            get { return jointWeldResults; }
            set
            {
                if (value != jointWeldResults)
                {
                    jointWeldResults = value;
                    RaisePropertyChanged("JointWeldResults");
                }
            }
        }

        public Guid FirstElementId
        {
            get { return (this.FirstElement == null) ? Guid.Empty : this.FirstElement.Id; }
            set
            {
                this.FirstElement = FindElementById(value);
                RaisePropertyChanged("FirstElement");
            }
        }

        public Guid SecondElementId
        {
            get { return (this.SecondElement == null) ? Guid.Empty : this.SecondElement.Id; }
            set
            {
                this.SecondElement = FindElementById(value);
                RaisePropertyChanged("SecondElement");
            }
        }

        public PartData FirstElement
        {
            get { return firstElement; }
            set
            {
                if (value != firstElement)
                {
                    firstElement = value;
                    RaisePropertyChanged("FirstElement");
                }
            }
        }

        public PartData SecondElement
        {
            get { return secondElement; }
            set
            {
                if (value != secondElement)
                {
                    secondElement = value;
                    RaisePropertyChanged("SecondElement");
                }
            }
        }

        private PartData FindElementById(Guid id)
        {
            return PartDataList != null ? PartDataList.FirstOrDefault<PartData>(x => x.Id == id) : null;
        }

        public JointStatus JointConstructionStatus
        {
            get 
            {
                if (LoweringDate != DateTime.MinValue)
                {
                    Joint.Status = JointStatus.Lowered;
                }
                if (Joint.JointWeldResults.Where(_ => _.Date == JointWeldResults.Max(x => x.Date)).Any(x => x.Operation.Type == JointOperationType.Withdraw))
                {
                    Joint.Status = JointStatus.Withdrawn;
                }

                jointStatus = Joint.Status;

                return jointStatus; 
            }
            set 
            {
                if (value != Joint.Status)
                {
                    jointStatus = value;
                    Joint.Status = value;
                    RaisePropertyChanged("JointConstructionStatus");
                }
            }
        }

        #region ===== Makeing The Connection =====
        /// <summary>
        /// This method joint FirstElement and SecondElement
        /// </summary>
        /// <returns>The method retuns ability of joint creation</returns>
        public bool MakeTheConnection()
        {
            if (this.Joint.FirstElement.Id == firstElement.Id && this.Joint.SecondElement.Id == secondElement.Id)
            { 
                return true; 
            }

            if (this.Joint.FirstElement.Number != null || this.Joint.SecondElement.Number != null) 
            { 
                this.JointDisconnection(); 
            }

            Joint.FirstElement = firstElement;
            Joint.SecondElement = secondElement;

            var jointElements = new List<Part> { GetPart(firstElement), GetPart(secondElement) };

            int commonDiameter = GetCommonDiameter(firstElement, secondElement);

            if (FirstElement.Id == Guid.Empty ||
                SecondElement.Id == Guid.Empty ||
                commonDiameter == -1)
            {
                return false;
            }

            foreach (var part in jointElements)
            {
                if (part is construction.Component)
                {
                    construction.Component component = part as construction.Component;

                    foreach (var con in component.Connectors)
                    {
                        if (con.Diameter == commonDiameter &&
                            (con.Joint == null || con.Joint.Id == Guid.Empty))
                        {
                            con.Joint = Joint;
                            break;
                        }
                    }
                }
                else
                {
                    if (part.ConstructionStatus == PartConstructionStatus.Pending)
                    {
                        switch (Joint.Status)
                        {
                            case JointStatus.Lowered: part.ConstructionStatus = PartConstructionStatus.Lowered;
                                break;
                            case JointStatus.Welded: part.ConstructionStatus = PartConstructionStatus.Welded;
                                break;
                            default: part.ConstructionStatus = PartConstructionStatus.Pending;
                                break;
                        }
                    }
                    else
                    {
                        part.IsAvailableToJoint = false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// This method Sets connectors of the Part elements correspond PartData FirstElement 
        /// and SecondElement in "is available to joint" state. 
        /// </summary>
        public void JointDisconnection()
        {
            var jointElements = new List<Part> { GetPart(this.Joint.FirstElement), GetPart(this.Joint.SecondElement) };

            foreach (var part in jointElements)
            {
                if (part == null) continue;

                if (part is construction.Component)
                {
                    var component = part as construction.Component;

                    foreach (var connector in component.Connectors)
                    {
                        if (connector.Joint != null)
                        {
                            if (connector.Joint.Id == this.Joint.Id &&
                                connector.Joint.Id != Guid.Empty ||
                                connector.Joint == this.Joint)
                            {
                                connector.Joint = null;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    if (part.IsAvailableToJoint == false)
                    {
                        part.IsAvailableToJoint = true;
                    }
                    else
                    {
                        part.ConstructionStatus = PartConstructionStatus.Pending;
                    }
                }
            }
        }

        /// <summary>
        /// This method returns the element Part by the specified element 
        /// PartData according to its type: Spool, Pipe or Component
        /// </summary>
        /// <param name="partData"></param>
        /// <returns>corespond element Part</returns>
        private Part GetPart(PartData partData)
        {
            Part part;

            if (partData.PartType == PartType.Component)
            {
                part = repoConstruction.RepoComponent.Get(partData.Id);
            }
            else if (partData.PartType == PartType.Pipe)
            {
                part = repoConstruction.RepoPipe.Get(partData.Id);
            }
            else
            {
                part = repoConstruction.RepoSpool.Get(partData.Id);
            }

            if (part == null)
                log.Warn(string.Format("Part id:{0} is not found in the database", partData.Id));

            return part;
        }

        /// <summary>
        /// The method returns a value coinciding the diameter of joined elements. 
        /// In the case of multiple coinciding diameters the joined diameter selects by user. 
        /// If there is no coinciding the method returns -1.
        /// </summary>
        /// <param name="firstElement">the first connectable element</param>
        /// <param name="secondElement">the second connectable element</param>
        /// <returns></returns>
        private int GetCommonDiameter(PartData firstElement, PartData secondElement)
        {
            int commonDiameter;

            var duplicates =
                firstElement.Connectors
                .Intersect(secondElement.Connectors, new ConnectorComparer())
                .ToList<construction.Connector>();

            if (duplicates.Count == 0)
            {
                commonDiameter = - 1;
            }
            else if (duplicates.Count == 1)
            {
                commonDiameter = duplicates.First<construction.Connector>(x => true).Diameter;
            }
            else
            {
                var choiceDiameter = new SelectDiameterDialog(duplicates);

                if (choiceDiameter.ShowDialog() == DialogResult.OK)
                {
                    commonDiameter = choiceDiameter.Diameter;
                }
                else
                {
                    commonDiameter = - 1;
                }
            }

            return commonDiameter;
        }

        /// <summary>
        /// The specific Comparer for Intersect method of connectors List,
        /// which checks by the diameter value
        /// </summary>
        private class ConnectorComparer : IEqualityComparer<construction.Connector>
        {
            public bool Equals(construction.Connector x, construction.Connector y)
            {
                if (Object.ReferenceEquals(x, y))
                    return true;

                if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                    return false;

                return x.Diameter == y.Diameter;
            }

            public int GetHashCode(construction.Connector connector)
            {
                if (Object.ReferenceEquals(connector, null))
                    return 0;

                return connector.Diameter.GetHashCode();
            }

        }

        #endregion ===============================


        #endregion


        public DataTable Pieces
        {
            get
            {
                return pieces;
            }
            set
            {
                if (value != pieces)
                {
                    value.Columns.Add("typeTranslated", typeof(String));
                    foreach (DataRow record in value.Rows)
                    {
                        string typeResourceValue;

                        if (record.Field<string>("type") != "Component")
                        {
                            typeResourceValue = Resources.ResourceManager.GetString(record.Field<string>("type"));
                        }
                        else
                        {
                            typeResourceValue = record.Field<string>("componentTypeName");
                        }

                        record.SetField("typeTranslated", typeResourceValue);
                        pieces = value;
                        RaisePropertyChanged("Pieces");
                    }
                }
            }
        }

        private BindingList<PartData> list = null;

        public BindingList<PartData> PartDataList
        {
            get
            {
                if (list == null && Pieces != null)
                {
                    Guid tempId = Guid.Empty;
                    string tempNumber = string.Empty;

                    list = new BindingList<PartData>();

                    PartData partData = new PartData();

                    foreach (DataRow row in Pieces.Rows)
                    {
                        if (tempId != row.Field<Guid>("id")
                            && tempNumber != row.Field<string>("number"))
                        {
                            partData = new PartData(row);

                            partData.SetPartConnectors(row);

                            list.Add(partData);

                            tempId = row.Field<Guid>("id");
                            tempNumber = row.Field<string>("number");
                        }
                        else
                        {
                            partData.SetPartConnectors(row);
                        }
                    }
                }
                return list;
            }

            set { list = value; }
        }

        /// <summary>
        /// The method gets PartData from list if current element has isAvaliableToJoint = true 
        /// (if isAvaliableToJoint = false element will be added to list)
        /// </summary>
        /// <param name="partData">current PartData-element</param>
        /// <param name="part">corresponding Part-element</param>
        /// <returns>PartData-element from this.PartDataList</returns>
        private PartData GetPartDataFromList(PartData partData, Part part)
        {
            if (PartDataList == null) { PartDataList = new BindingList<PartData>(); }

            if (PartDataList.Where<PartData>(x => x.Id == partData.Id).Count<PartData>() == 0)
            {
                PartData p = new PartData(part, this.Joint.Id);

                if (partData.PartType == PartType.Pipe)
                {
                    p.PartTypeDescription
                        = Resources.ResourceManager.GetString(Enum.GetName(typeof(PartType), PartType.Pipe));
                }
                else if (partData.PartType == PartType.Spool)
                {
                    p.PartTypeDescription
                        = Resources.ResourceManager.GetString(Enum.GetName(typeof(PartType), PartType.Spool));
                }

                list.Add(p);
            }
            else
            {
                var connector = new Connector();

                if (part is construction.Component)
                {
                    if (Joint.IsActive)
                    {
                        connector.Diameter = ((construction.Component)part)
                            .Connectors
                            .First<Connector>(x => x.Joint != null && x.Joint.Id == this.Joint.Id)
                            .Diameter;
                    }
                }
                else if (part is Pipe)
                {
                    connector.Diameter = ((Pipe)part).Diameter;
                }
                else
                {
                    connector.Diameter = ((construction.Spool)part).Pipe.Diameter;
                }
                
                PartDataList.First<PartData>(x => x.Id == partData.Id).Connectors.Add(connector);

            }
            return PartDataList.First<PartData>(x => x.Id == partData.Id);
        }

        public void NewJoint()
        {
            this.isNew = true;
            this.Joint = new construction.Joint();
            Joint.FirstElement = new PartData();
            Joint.SecondElement = new PartData();
            this.Joint.IsActive = true;
            this.Joint.Status = jointStatus;
            this.JointTestResults = new BindingList<JointTestResult>();
            if (repoConstruction.RepoJointOperation.GetRequiredWeld() != null)
            {
                JointWeldResult requredWeldResult = new JointWeldResult()
                {
                    IsActive = true,
                    Operation = repoConstruction.RepoJointOperation.GetRequiredWeld(),
                    Joint = this.Joint
                };
                jointWeldResults = new BindingList<JointWeldResult>() { requredWeldResult };
                this.Joint.JointWeldResults.Add(requredWeldResult);
            }
            else 
            {
                this.JointWeldResults = new BindingList<JointWeldResult>();
            }
            this.Number = String.Empty;
            this.LoweringDate = DateTime.MinValue;
            this.Joint.ToExport = false;
        }

        public void RefreshJointComponents()
        {
            Pieces = adoRepo.GetPipelineElements();
        }

        public void JointCut()
        {
            var jointElements = new List<Part> { GetPart(this.Joint.FirstElement), GetPart(this.Joint.SecondElement) };

            if (jointElements.Where<Part>(x => x == null).Count<Part>() == 0)
            {
                var jointCutDialog = new JointCutDialog(jointElements.First(), jointElements.Last());

                if (jointCutDialog.ShowDialog() == DialogResult.OK)
                {
                    this.JointCutCommand.Execute();
                }
            }
        }

    }
}
