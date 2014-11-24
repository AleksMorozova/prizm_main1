using Data.DAL.Mill;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Ninject;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Railcar.Search
{
    public class RailcarSearchViewModel : ViewModelBase, IDisposable
    {
        private readonly IRailcarRepository repo;
        private readonly SearchRailcarCommand searchCommand;
        private readonly IUserNotify notify;

        private List<Domain.Entity.Mill.Railcar> railcars;

        [Inject]
        public RailcarSearchViewModel(IRailcarRepository repo, IUserNotify notify)
        {
            railcars = new List<Domain.Entity.Mill.Railcar>();
            this.repo = repo;
            this.notify = notify;
            searchCommand = ViewModelSource.Create(() => new SearchRailcarCommand(this, repo, notify));
            searchCommand.Execute();
        }

        public List<Domain.Entity.Mill.Railcar> Railcars {
            get { return railcars;}
            set
            {
                if (value != railcars)
                {
                    railcars = value;
                    RaisePropertyChanged("Railcars");
                }
            }
            }

        #region Search Fields
        private string railcarNumber = "";
        public string RailcarNumber
        {
            get { return railcarNumber; }
            set
            {
                if (value != railcarNumber)
                {
                    railcarNumber = value;
                    RaisePropertyChanged("RailcarNumber");
                }
            }
        }

        private string receiver = "";
        public string Receiver
        {
            get { return receiver; }
            set
            {
                if (value != receiver)
                {
                    receiver = value;
                    RaisePropertyChanged("Receiver");
                }
            }
        }

        private string certificate = "";
        public string Certificate
        {
            get { return certificate; }
            set
            {
                if (value != certificate)
                {
                    certificate = value;
                    RaisePropertyChanged("Certificate");
                }
            }
        }

        private DateTime shippingDate = DateTime.MinValue;
        public DateTime ShippingDate
        {
            get { return shippingDate; }
            set
            {
                if (value != shippingDate)
                {
                    shippingDate = value;
                    RaisePropertyChanged("ShippingDate");
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
            repo.Dispose();
        }
    }
}
