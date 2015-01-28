using Prizm.Data.DAL;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Prizm.Domain.Entity.Mill;
using Ninject;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Data.DAL.Mill;
using Prizm.Main.Properties;
using Prizm.Main.Common;

namespace Prizm.Main.Forms.Reports.Mill
{
    public class MillReportsViewModel : ViewModelBase
    {
        readonly IMillReportsRepository repo;
        readonly ICategoryRepository repoCategory;
        private readonly IUserNotify notify;
        public DateTime startDate;
        public DateTime endDate;
        readonly CreateReportCommand createCommand;
        readonly PreviewReportCommand previewCommand;
        public object previewSource;
        private BindingList<Category> inspectionCategories;
        public List<Guid> SearchIds = new List<Guid>();
        public List<string> SearchStatuses= new List <string>();
        public BindingList<EnumWrapper<MillReportType>> ReportTypes = new BindingList<EnumWrapper<MillReportType>>();
        private BindingList<EnumWrapper<PipeTestResultStatus>> statuses = new BindingList<EnumWrapper<PipeTestResultStatus>>();
        private Prizm.Domain.Entity.Mill.MillReportType selectedReportType = Prizm.Domain.Entity.Mill.MillReportType.ByCategories;

        [Inject]
        public MillReportsViewModel(IMillReportsRepository repo, IUserNotify notify, ICategoryRepository repoCategory)
        {
            this.repo = repo;
            this.notify = notify;
            this.repoCategory = repoCategory;
            createCommand = ViewModelSource.Create<CreateReportCommand>(() => new CreateReportCommand(this, repo, notify));
            previewCommand = ViewModelSource.Create<PreviewReportCommand>(() => new PreviewReportCommand(this, repo, notify));
            GetAllCategories();
            LoadAllReportTypes();
            LoadAllStatuses();
        }

        private void LoadAllReportTypes()
        {
            foreach (string reportType in Enum.GetNames(typeof(MillReportType)))
            {

                ReportTypes.Add(new EnumWrapper<MillReportType>(reportType));
            }
        }

        public object PreviewSource
        {
            get
            {
                return previewSource;
            }
            set
            {
                if (value != previewSource)
                {
                    previewSource = value;
                    RaisePropertyChanged("PreviewSource");
                }
            }
        }

        public DateTime StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                if (value != startDate)
                {
                    startDate = value;
                    RaisePropertyChanged("StartDate");
                }
            }
        }

        public DateTime EndDate
        {
            get
            {
                return endDate;
            }
            set
            {
                if (value != endDate)
                {
                    endDate = value;
                    RaisePropertyChanged("EndDate");
                }
            }
        }

        public ICommand CreateCommand
        {
            get
            {
                return createCommand;
            }
        }

        public ICommand PreviewCommand
        {
            get { return previewCommand; }
        }

        private void GetAllCategories()
        {
            var categories = this.repoCategory.GetAll();
            if (categories != null)
                inspectionCategories = new BindingList<Category>(categories);
        }

        public BindingList<Category> InspectionCategories
        {
            get
            {
                return inspectionCategories;
            }
        }

        public MillReportType SelectedReportType
        {
            get
            {
                return selectedReportType;
            }
            set
            {
                if (value != selectedReportType)
                {
                    selectedReportType = value;
                    RaisePropertyChanged("SelectedReportType");
                }
            }

        }

        public BindingList<EnumWrapper<PipeTestResultStatus>> Statuses
        {
            get
            {
                return statuses;
            }
        }

        private void LoadAllStatuses()
        {
            foreach (string status in Enum.GetNames(typeof(PipeTestResultStatus)))
            {
                if (status != Enum.GetName(typeof(PipeTestResultStatus), Prizm.Domain.Entity.Mill.PipeTestResultStatus.Undef))
                statuses.Add(new EnumWrapper<PipeTestResultStatus>()
                {
                    Name = status
                }
                );
            }
        }
    }
}