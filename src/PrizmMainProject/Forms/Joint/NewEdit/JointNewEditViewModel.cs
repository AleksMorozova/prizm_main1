using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
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

namespace Prizm.Main.Forms.Joint.NewEdit
{
    public class JointNewEditViewModel : ViewModelBase, ISupportModifiableView, IDisposable
    {
        private const int connectedElementsCount = 2;
        private Part[] connectedElements = new Part[connectedElementsCount];

        private readonly IConstructionRepository repoConstruction;
        private readonly Prizm.Data.DAL.IMillReportsRepository adoRepo;
        private readonly IUserNotify notify;
        private readonly SaveJointCommand saveJointCommand;
        private readonly NewSaveJointCommand newSaveJointCommand;
        private readonly ExtractOperationsCommand extractOperationsCommand;
        private readonly JointDeactivationCommand jointdeactivationCommand;
        private IModifiable modifiableView;
        private IValidatable validatableView;
        private DataTable pieces;
        private BindingList<JointTestResult> jointTestResults;
        private BindingList<JointWeldResult> jointWeldResults;
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
            Prizm.Data.DAL.IMillReportsRepository adoRepo)
        {
            this.repoConstruction = repoConstruction;
            this.JointId = id;
            this.notify = notify;
            this.adoRepo = adoRepo;

            #region Commands
            saveJointCommand =
              ViewModelSource.Create(() => new SaveJointCommand(repoConstruction, this, notify));
            newSaveJointCommand =
              ViewModelSource.Create(() => new NewSaveJointCommand(repoConstruction, this, notify));
            extractOperationsCommand =
                ViewModelSource.Create(() => new ExtractOperationsCommand(repoConstruction, this));
            jointdeactivationCommand = 
                ViewModelSource.Create(() => new JointDeactivationCommand(repoConstruction, this, notify));
            #endregion

            Inspectors = repoConstruction.RepoInspector.GetAll();
            Welders = repoConstruction.RepoWelder.GetAll();
            Pieces = adoRepo.GetPipelineElements();
            extractOperationsCommand.Execute();
            if(id == Guid.Empty)
            {
                NewJoint();
            }
            else
            {
                this.Joint = repoConstruction.RepoJoint.Get(id);

                FirstElement = SetPartConnectors(Joint.FirstElement);
                SecondElement = SetPartConnectors(Joint.SecondElement);

                JointDisconnection();

                var weldResults = repoConstruction.RepoJointWeldResult.GetByJoint(this.Joint);
                if (weldResults != null)
                {
                    jointWeldResults = new BindingList<JointWeldResult>(weldResults);
                }
                var testResults = repoConstruction.RepoJointTestResult.GetByJoint(this.Joint);
                if (testResults != null)
                {
                    jointTestResults = new BindingList<JointTestResult>(testResults);
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
                return String.Empty;

            return String.Join(",", (from inspector in inspectors select inspector.Name.LastName).ToArray<string>());
        }

        internal string FormatWelderList(IList<Welder> welders)
        {
            if (welders == null)
                return String.Empty;

            return String.Join(",", (from welder in welders select welder.Name.LastName).ToArray<string>());
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
        #endregion

        # region Joint
        public bool IsNotActive
        {
            get
            {
                return Joint.IsNotActive;
            }
            set
            {
                if (value != Joint.IsNotActive)
                {
                    Joint.IsNotActive = value;
                    RaisePropertyChanged("IsNotActive");
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
            get
            {                
                return (Joint.FirstElement == null) ? Guid.Empty : Joint.FirstElement.Id;
            }
            set
            {
                Joint.FirstElement = FindElementById(value);
                RaisePropertyChanged("FirstElement");
            }
        }

        public Guid SecondElementId
        {
            get
            {
                return (Joint.SecondElement == null) ? Guid.Empty : Joint.SecondElement.Id;
            }
            set
            {
                Joint.SecondElement = FindElementById(value);
                RaisePropertyChanged("SecondElement");
            }
        }

        public PartData FirstElement
        {
            get { return Joint.FirstElement; }
            set
            {
                if (value != Joint.FirstElement)
                {
                    Joint.FirstElement = value;
                    RaisePropertyChanged("FirstElement");
                }
            }
        }

        public PartData SecondElement
        {
            get { return Joint.SecondElement; }
            set
            {
                if (value != Joint.SecondElement)
                {
                    Joint.SecondElement = value;
                    RaisePropertyChanged("SecondElement");
                }
            }
        }

        private PartData FindElementById(Guid id)
        {
            return (from PartData p in PartDataList where p.Id == id select p).FirstOrDefault();
        }


        #region ===== Makeing The Connection =====

        public bool MakeTheConnection()
        {
            connectedElements[0] = GetPart(FirstElement);
            connectedElements[1] = GetPart(SecondElement);

            int commonDiameter = GetCommonDiameter(FirstElement, SecondElement);

            if (FirstElement.Id == Guid.Empty ||
                SecondElement.Id == Guid.Empty ||
                commonDiameter == -1)
            {
                return false;
            }

            foreach (var part in connectedElements)
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
                    if (part.ConstructionStatus != PartConstructionStatus.Welded)
                    {
                        part.ConstructionStatus = PartConstructionStatus.Welded;
                    }
                    else
                    {
                        part.IsAvailableToJoint = false;
                    }
                }
            }

            return true;
        }

        public void JointDisconnection()
        {
            DisconnectTheElement(GetPart(FirstElement));
            DisconnectTheElement(GetPart(SecondElement));
        }

        private bool DisconnectTheElement(Part part)
        {
            if (part == null)
            {
                return false;
            }

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

            return true;
        }

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

            return part;
        }

        #region ---- Intersect of diameters ----

        private int GetCommonDiameter(PartData firstElement, PartData secondElement)
        {
            var duplicates =
                firstElement.Connectors
                .Intersect(secondElement.Connectors, new ConnectorComparer())
                .ToList<construction.Connector>();

            if (duplicates.Count == 0)
            {
                return -1;
            }
            else if (duplicates.Count == 1)
            {
                return duplicates.First<construction.Connector>(x => true).Diameter;
            }
            else
            {
                var choiceDiameter = new ChoiceConnectedDiameter(duplicates);

                if (choiceDiameter.ShowDialog() == DialogResult.OK)
                {
                    return choiceDiameter.Diameter;
                }
                else
                {
                    return -1;
                }
            }
        }

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

        #endregion---- Intersect of diameters ----

        #endregion ===============================

        private bool isCanDeactivate;
        public bool IsCanDeactivate
        {
            get { return isCanDeactivate; }
            set 
            {
                if(isCanDeactivate != value)
                {
                    isCanDeactivate = value;
                    RaisePropertyChanged("IsCanDeactivate");
                }
            }
        }
        public void CheckDeactivation()
        {
            IsCanDeactivate = JointDeactivationCommand.CanExecute();
        }
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

                    PartData p = new PartData();

                    foreach (DataRow row in Pieces.Rows)
                    {
                        if (tempId != row.Field<Guid>("id")
                            && tempNumber != row.Field<string>("number"))
                        {
                            p = CreatePartDataByRow(row);

                            SetPartConnectors(p, row);

                            list.Add(p);

                            tempId = row.Field<Guid>("id");
                            tempNumber = row.Field<string>("number");
                        }
                        else
                        {
                            SetPartConnectors(p, row);
                        }
                    }
                }
                return list;
            }

            set { list = value; }
        }

        #region ---- PartsData creation at loading ---- 
        private PartData CreatePartDataByRow(DataRow row)
        {
            return
                new PartData()
                {
                    Id = row.Field<Guid>("id"),
                    Number = row.Field<string>("number"),
                    PartType = (PartType)Enum.Parse(typeof(PartType), row.Field<string>("type")),
                    Length = row.Field<int>("length"),
                    PartTypeDescription = row.Field<string>("typeTranslated"),
                    WallThickness = Convert.ToSingle(row.Field<double>("wallThickness")),
                    Diameter = row.Field<int>("diameter"),

                    ConstructionStatus = (PartConstructionStatus)Enum
                    .Parse(typeof(PartConstructionStatus), 
                    row.Field<string>("constructionStatus"))
                };
        }

        private PartData CreatePartDataByPart(Part part)
        {
            PartData partData = new PartData()
                {
                    Id = part.Id,
                    Number = part.Number,
                    ConstructionStatus =  part.ConstructionStatus,
                };

            if (part is construction.Component)
            {
                partData.PartType = PartType.Component;
                partData.Length = part.Length;

                partData.PartTypeDescription
                    = ((construction.Component)part).Type.Name;
            }
            else if (part is Pipe)
            {
                partData.PartType = PartType.Pipe;
                partData.Length = part.Length;

                partData.PartTypeDescription
                    = Resources.ResourceManager.GetString(Enum.GetName(typeof(PartType), PartType.Pipe));
            }
            else
            {
                partData.PartType = PartType.Spool;
                partData.Length = part.Length;

                partData.PartTypeDescription
                    = Resources.ResourceManager.GetString(Enum.GetName(typeof(PartType), PartType.Spool));
            }

            return partData;
        }

        private PartData SetPartConnectors(PartData partData)
        {
            var part = GetPart(partData);

            if (PartDataList == null)
            {
                PartDataList = new BindingList<PartData>();
            }

            if (PartDataList.Where<PartData>(x => x.Id == partData.Id).Count<PartData>() == 0)
            {
                PartDataList.Add(CreatePartDataByPart(part));
            }

            return PartDataList.First<PartData>(x => x.Id == partData.Id);
        }

        private void SetPartConnectors(PartData part, DataRow row)
        {
            if (part.Connectors == null)
            {
                part.Connectors = new List<Connector>();
            }

            if (part.PartType == PartType.Component)
            {
                var cnt = new Connector() { Diameter = row.Field<int>("diameter") };

                part.Connectors.Add(cnt);

                SetConnectorsCountString(part);
            }
            else
            {
                var cnt = new Connector() { Diameter = part.Diameter };

                part.Connectors.Add(cnt);

                if (part.ConstructionStatus != PartConstructionStatus.Welded)
                {
                    part.Connectors.Add(cnt);
                }

                SetConnectorsCountString(part);
            }
        }

        private void SetConnectorsCountString(PartData part)
        {
            string diameterList = string.Empty;

            foreach (var c in part.Connectors)
            {
                if (diameterList == string.Empty)
                {
                    diameterList = Convert.ToString(c.Diameter);
                }
                else
                {
                    diameterList = string.Concat(diameterList, ", ", Convert.ToString(c.Diameter));
                }
            }

            part.ConnectorsCount = string.Concat(part.Connectors.Count, "(", diameterList, ")");
        }
        #endregion

        public void NewJoint()
        {
            this.Joint = new construction.Joint();
            Joint.FirstElement = new PartData();
            Joint.SecondElement = new PartData();
            this.Joint.IsActive = true;
            this.Joint.Status = JointStatus.Welded;
            this.JointTestResults = new BindingList<JointTestResult>();
            this.JointWeldResults = new BindingList<JointWeldResult>();
            this.Number = String.Empty;
            this.LoweringDate = DateTime.MinValue;

        }
    }
}
