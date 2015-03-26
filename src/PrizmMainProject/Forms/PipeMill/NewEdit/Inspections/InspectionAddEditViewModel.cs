using DevExpress.Mvvm;
using Ninject;
using Prizm.Data.DAL.Hibernate;
using Prizm.Data.DAL.Mill;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Mill;
using Prizm.Domain.Entity.Setup;
using Prizm.Main.Common;
using Prizm.Main.Languages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.PipeMill.NewEdit.Inspections
{
    public class InspectionAddEditViewModel : ViewModelBase
    {
        private readonly ICannedMessageRepository cannedMessageRepo;

        private IList<PipeTest> availableTests = new BindingList<PipeTest>();
        private IList<Inspector> inspectors = new BindingList<Inspector>();
        private IList<string> cannedMessageStrings = new BindingList<string>();
        private PipeTestResult testResult;
        public IList<EnumWrapper<PipeTestResultStatus>> statuses;
        public InspectionAddEditViewModel(IList<PipeTest> tests, IList<Inspector> inspectors,
            PipeTestResult current, IList<Main.Common.EnumWrapper<PipeTestResultStatus>> statuses)
        {
            this.cannedMessageRepo = Program.Kernel.Get<ICannedMessageRepository>();

            this.cannedMessageStrings = cannedMessageRepo.GetAll()
                .Where<CannedMessage>(x => x.Language == Program.LanguageManager.CurrentCulture.Name)
                .Select<CannedMessage, string>(y => y.Text).ToList<string>();


            this.SetupViewModelState(tests, inspectors, current, statuses);
        }

        public void SetupViewModelState(
            IList<PipeTest> tests, 
            IList<Inspector> inspectors, 
            PipeTestResult current, 
            IList<EnumWrapper<PipeTestResultStatus>> statuses)
        {
            this.availableTests = tests.Where(_ => _.IsActive).OrderBy(_ => _.Code).ToList<PipeTest>();
            this.inspectors = inspectors;
            this.statuses = statuses;
            if (current == null)
            {
                TestResult = new PipeTestResult();
                TestResult.Operation = new PipeTest();
                TestResult.Status = PipeTestResultStatus.Scheduled;
                this.status = TestResult.Status;
                this.factBool = false;
                this.date = DateTime.Now;

                if (this.availableTests != null && this.availableTests.Count > 0)
                    TestResult.Operation = this.availableTests[0];
            }
            else
            {
                TestResult = current;
                switch (current.Operation.ResultType)
                {
                    case PipeTestResultType.Boolean:
                        factBool = (current.Value != null && current.Value.Equals("True")) ? true : false;
                        break;
                    case PipeTestResultType.String:
                        factString = current.Value;
                        break;
                    case PipeTestResultType.Diapason:
                        factLimit = current.Value;
                        break;
                    case PipeTestResultType.Undefined:
                        break;
                    default:
                        break;
                }

                date = (current.Date == null) ? DateTime.Now : current.Date.Value;

                status = current.Status;
            }
            if (testResult.Value == null)
            {
                testResult.Value = string.Empty;
            }
        }

        #region Test
        public IList<Inspector> Inspectors
        {
            get { return inspectors; }
            set
            {
                if(value != inspectors)
                {
                    inspectors = value;
                    RaisePropertyChanged("Inspectors");
                }
            }
        }

        public IList<PipeTest> Tests
        {
            get { return availableTests; }
            set
            {
                if(value != availableTests)
                {
                    availableTests = value;
                    RaisePropertyChanged("Tests");
                }
            }
        }

        public PipeTest Test
        {
            get { return testResult.Operation; }
            set
            {
                if(value != testResult.Operation)
                {
                    testResult.Operation = value;
                    RaisePropertyChanged("Test");
                }
            }
        }

        public string Code
        {
            get { return testResult.Operation.Code; }
            set
            {
                if(value != testResult.Operation.Code)
                {
                    testResult.Operation.Code = value;
                    RaisePropertyChanged("Code");
                }
            }
        }

        public string Category
        {
            get { return testResult.Operation.Category.Name; }
            set
            {
                if(value != testResult.Operation.Category.Name)
                {
                    testResult.Operation.Category.Name = value;
                    RaisePropertyChanged("Category");
                }
            }
        }

        public string Name
        {
            get { return testResult.Operation.Name; }
            set
            {
                if(value != testResult.Operation.Name)
                {
                    testResult.Operation.Name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }

        public string Expected
        {
            get
            {
                string expStr = string.Empty;
                switch(testResult.Operation.ResultType)
                {
                    case PipeTestResultType.Boolean:
                        expStr = (testResult.Operation.BoolExpected) ? Program.LanguageManager.GetString(StringResources.Yes) : Program.LanguageManager.GetString(StringResources.No);
                        break;
                    case PipeTestResultType.String:
                        expStr = testResult.Operation.StringExpected;
                        break;
                    case PipeTestResultType.Diapason:
                        expStr = testResult.Operation.MinExpected + " - " + testResult.Operation.MaxExpected;
                        break;
                    case PipeTestResultType.Undefined:
                        break;
                    default:
                        break;
                }
                return expStr;
            }
            set { }
        }

        private string GetResult()
        {
            string expStr = string.Empty;
            switch(testResult.Operation.ResultType)
            {
                case PipeTestResultType.Boolean:
                    expStr = testResult.Operation.BoolExpected.ToString();
                    break;
                case PipeTestResultType.String:
                    expStr = testResult.Operation.StringExpected;
                    break;
                case PipeTestResultType.Diapason:
                    expStr = testResult.Operation.MinExpected + " - " + testResult.Operation.MaxExpected;
                    break;
                case PipeTestResultType.Undefined:
                    break;
                default:
                    break;
            }
            return expStr;

        }
        #endregion

        #region Result
        public PipeTestResult TestResult
        {
            get { return testResult; }
            set
            {
                if(value != testResult)
                {
                    testResult = value;
                    RaisePropertyChanged("TestResult");
                }
            }
        }

        public PipeTest Operation
        {
            get { return testResult.Operation; }
            set
            {
                if(value != testResult.Operation)
                {
                    testResult.Operation = value;
                    RaisePropertyChanged("Operation");
                }
            }
        }

        PipeTestResultStatus status;
        public PipeTestResultStatus Status
        {
            get { return status; }
            set
            {
                if(value != status)
                {
                    status = value;
                    RaisePropertyChanged("Status");
                }
            }
        }

        DateTime date;
        public DateTime Date
        {
            get { return date; }
            set
            {
                if (value != date)
                {
                    date = value;
                    RaisePropertyChanged("Date");
                }
            }
        }

        bool factBool;
        public bool FactBool
        {
            get
            {
                return factBool;
            }
            set
            {
                if(factBool != value)
                {
                    factBool = value;
                    RaisePropertyChanged("FactBool");
                }
            }
        }

        string factString;
        public string FactString
        {
            get { return factString; }
            set
            {
                if(value != factString)
                {
                    factString = value;
                    RaisePropertiesChanged("FactString");
                }
            }
        }

        string factLimit;
        public string FactLimit
        {
            get { return factLimit; }
            set
            {
                if(value != factLimit)
                {
                    factLimit = value;
                    RaisePropertiesChanged("FactLimit");
                }
            }
        }


        #endregion

        public int StatusIndex
        {
            get { return (int)Status - 1; }
            set
            {
                if (value != (int)Status - 1)
                {
                    Status = (PipeTestResultStatus)value + 1;
                    RaisePropertyChanged("StatusIndex");
                }
            }
        }


        public IList<string> CannedMessages
        {
            get { return cannedMessageStrings; }
        }


        internal void ChangeTest(string code)
        {
            var test = availableTests.FirstOrDefault(x => x.Code == code);
            Operation = test;
        }

        internal IList<Inspector> SelectInspectors()
        {
            return testResult.Inspectors;
        }
    }
}
