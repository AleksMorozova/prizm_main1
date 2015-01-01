using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.PipeMill.Search
{
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.DataAnnotations;
    using DevExpress.Mvvm.POCO;
    using Ninject;
    using Prizm.Main.Commands;
    using System;
    using System.Windows.Forms;
    using Prizm.Data.DAL.Mill;
    using Prizm.Domain.Entity.Mill;
    using Prizm.Main.Common;
    using Prizm.Data.DAL.Setup;
    using Prizm.Domain.Entity.Setup;
using Prizm.Main.Properties;


    public class MillPipeSearchViewModel : ViewModelBase, IDisposable
    {
        private readonly IUserNotify notify;
        readonly ICommand searchCommand;

        readonly IMillRepository repoMill;

        private IList<Prizm.Domain.Entity.Mill.Pipe> pipes;
        private IList<EnumWrapper<PipeMillStatus>> statusTypes;
        public IList<EnumWrapper<PipeMillStatus>> CheckedStatusTypes;
        private IList<PipeMillSizeType> pipeTypes;
        private IList<PipeMillSizeType> checkedPipeTypes 
            = new List<PipeMillSizeType>();

        public string[] ActivityArray = { Resources.PipeStatusComboAll, Resources.PipeStatusComboActive, Resources.PipeStatusComboUnactive };


        private string pipeNumber; 

        private EnumWrapper<PipeMillStatus> pipeMillStatus;

        [Inject]
        public MillPipeSearchViewModel(
            IMillRepository repoMill,
            IUserNotify notify)
        {
            this.repoMill = repoMill;
            this.notify = notify;

            searchCommand = ViewModelSource.Create<MillPipeSearchCommand>(
                () => new MillPipeSearchCommand(this, repoMill.RepoPipe, notify));

            pipeTypes = repoMill.RepoPipeType.GetAll();
            checkedPipeTypes = repoMill.RepoPipeType.GetAll();

            LoadPipeMillStatuses();

            Activity = ActivityArray[0];
        }

        #region Properties
        private string activity;
        public string Activity
        {
            get { return activity; }
            set
            {
                if (value != activity)
                {
                    activity = value;
                    RaisePropertyChanged("Activity");
                }
            }
        }

        public IList<Prizm.Domain.Entity.Mill.Pipe> Pipes
        {
            get
            {
                return pipes;
            }
            set
            {
                if (value != pipes)
                {
                    pipes = value;
                    RaisePropertyChanged("Pipes");
                }
            }
        }

        public string PipeNumber
        {
            get
            {
                return pipeNumber;
            }
            set
            {
                if (value != pipeNumber)
                {
                    pipeNumber = value;
                    RaisePropertyChanged("PipeNumber");
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

        public IList<PipeMillSizeType> CheckedPipeTypes
        {
            get { return checkedPipeTypes; }
            set
            {
                if (value != checkedPipeTypes)
                {
                    checkedPipeTypes = value;
                    RaisePropertyChanged("CheckedPipeTypes");
                }
            }
        }

        public EnumWrapper<PipeMillStatus> PipeMillStatus
        {
            get
            {
                return pipeMillStatus;
            }
            set
            {
                if (value != pipeMillStatus)
                {
                    pipeMillStatus = value;
                    RaisePropertyChanged("PipeMillStatus");
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
        #endregion

        public ICommand SearchCommand
        {
            get { return searchCommand; }
        }

        public void Dispose()
        {
            repoMill.Dispose();
        }

        private void LoadPipeMillStatuses()
        {
            StatusTypes = new List<EnumWrapper<PipeMillStatus>>();
            CheckedStatusTypes = new List<EnumWrapper<PipeMillStatus>>();

            foreach (string statusTypeName in Enum.GetNames(typeof(PipeMillStatus)))
            {
                if (statusTypeName != Enum.GetName(typeof(PipeMillStatus), Prizm.Domain.Entity.Mill.PipeMillStatus.Undefined))
                {
                    StatusTypes.Add(new EnumWrapper<PipeMillStatus>() { Name = statusTypeName });
                    CheckedStatusTypes.Add(new EnumWrapper<PipeMillStatus>() { Name = statusTypeName });
                }
            }
        }

    }
}
