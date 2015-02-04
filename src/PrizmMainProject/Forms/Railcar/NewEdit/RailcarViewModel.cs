using System;
using Prizm.Data.DAL.Mill;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Ninject;
using Prizm.Main.Commands;
using System.ComponentModel;
using Prizm.Domain.Entity.Mill;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using Prizm.Main.Properties;
using System.Windows.Forms;
using Prizm.Data.DAL;
using Prizm.Main.Documents;
using Prizm.Main.Forms.ExternalFile;
using Prizm.Domain.Entity;
using Prizm.Main.Security;
using Prizm.Main.Languages;

namespace Prizm.Main.Forms.Railcar.NewEdit
{
    public class RailcarViewModel : ViewModelBase, ISupportModifiableView, IDisposable
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(RailcarViewModel));

        public BindingList<Pipe> ReleaseNotePipes { get; set; }
        private Prizm.Domain.Entity.Mill.Railcar railcar = new Domain.Entity.Mill.Railcar();
        private readonly IRailcarRepositories repos;
        private readonly IUserNotify notify;
        private readonly SaveRailcarCommand saveCommand;
        private readonly ShipRailcarCommand shipCommand;
        private readonly UnshipRailcarCommand unshipCommand;
        private readonly ISecurityContext ctx;
        private List<Pipe> allPipes;
        IModifiable modifiableView;
        public IValidatable validatableView { get; set; }
        public ExternalFilesViewModel FilesFormViewModel { get; set; }
        public Dictionary<Pipe, Prizm.Domain.Entity.Mill.Railcar> pipesList =
           new Dictionary<Pipe, Prizm.Domain.Entity.Mill.Railcar>();
        public Pipe pipeToAdd;
        private bool isNew;

        [Inject]
        public RailcarViewModel(IRailcarRepositories repos, Guid id, IUserNotify notify, ISecurityContext ctx)
        {
            this.repos = repos;
            this.notify = notify;
            this.ctx = ctx;

            GetStoredPipes();

            saveCommand = ViewModelSource.Create(() => new SaveRailcarCommand(this, repos, notify,ctx));
            shipCommand = ViewModelSource.Create(() => new ShipRailcarCommand(this, repos, notify));
            unshipCommand = ViewModelSource.Create(() => new UnshipRailcarCommand(this, repos, notify, ctx));

            if (id == Guid.Empty)
            {
                NewRailcar();
                ReleaseNotePipes = new BindingList<Pipe>();
            }
            else
            {
                ReleaseNote = repos.ReleaseNoteRepo.Get(id);
                LoadData(id);
            }
           
        }

        public void LoadData(Guid id)
        {
            ReleaseNotePipes = new BindingList<Pipe>();
            if (ReleaseNote != null)
            {
                GetAllPipes(id);
            }
            else
            {
                ReleaseNotePipes = new BindingList<Pipe>();
                log.Warn(string.Format("List of Pipes in Release Note (id:{0}) is NULL.", id));
            }
        }

        private void GetAllPipes(Guid id)
        {
            if (ReleaseNotePipes == null)
            {
                ReleaseNotePipes = new BindingList<Pipe>();
                log.Warn(string.Format("List of Pipes in Release Note (id:{0}) is NULL.", id));
            }

            IList<Pipe> pipes = repos.ReleaseNoteRepo.GetReleasedNotePipe(id);
            foreach (var p in pipes)
            {
                ReleaseNotePipes.Add(p);
            }
        }


        public List<Pipe> AllPipes
        {
            get { return allPipes; }
        }

        //public Prizm.Domain.Entity.Mill.Railcar Railcar { get; set; }
        public ReleaseNote ReleaseNote { get; set; }

        #region Release Note

        public bool Shipped
        {
            get { return ReleaseNote.Shipped; }
            set
            {
                if (value != ReleaseNote.Shipped)
                {
                    ReleaseNote.Shipped = value;
                    RaisePropertyChanged("Shipped");
                    modifiableView.IsEditMode = !value;
                }
            }
        }

        public string Number
        {
            get { return ReleaseNote.Number; }
            set
            {
                if (value != ReleaseNote.Number)
                {
                    ReleaseNote.Number = value;
                    RaisePropertyChanged("Number");
                }
            }
        }

        public DateTime Date
        {
            get
            {
                return ReleaseNote.Date;
            }
            set
            {
                if (value != ReleaseNote.Date)
                {
                    ReleaseNote.Date = value;
                    RaisePropertyChanged("Date");
                }
            }
        }

        public IList<Prizm.Domain.Entity.Mill.Railcar> Railcars
        {
            get { return ReleaseNote.Railcars; }
            set
            {
                if (value != ReleaseNote.Railcars)
                {
                    int index = ReleaseNote.Railcars.IndexOf(railcar);
                    if (index > 0)
                    {
                        ReleaseNote.Railcars[index] = railcar;
                    }
                    else
                    {
                        ReleaseNote.Railcars.Add(railcar);
                    }

                    ReleaseNote.Railcars = value;
                    RaisePropertyChanged("Railcars");
                }
            }
        }

        # endregion

        #region Railcar Note

        public Prizm.Domain.Entity.Mill.Railcar Railcar
        {
            get { return railcar; }
            set
            {
                if (value != railcar)
                {
                    railcar = value;
                    RaisePropertyChanged("Railcar");
                    RaisePropertyChanged("Certificate");
                    RaisePropertyChanged("Destination");
                }
            }
        }
        public string RailcarNumber
        {
            get
            {
                if (railcar != null)
                {
                    return railcar.Number;
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                if (value != railcar.Number)
                {
                    railcar.Number = value;
                    RaisePropertyChanged("RailcarNumber");
                }
            }
        }
        public string Destination
        {
            get
            {
                if (railcar != null)
                {
                    return railcar.Destination;
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                if (value != railcar.Destination)
                {
                    railcar.Destination = value;
                    RaisePropertyChanged("Destination");
                }
            }
        }
        public string Certificate
        {
            get
            {
                if (railcar != null)
                {
                    return railcar.Certificate;
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                if (value != railcar.Certificate)
                {
                    railcar.Certificate = value;
                    RaisePropertyChanged("Certificate");
                }
            }
        }
        public IList<Pipe> Pipes
        {
            get
            {
                if (railcar != null)
                {
                    return railcar.Pipes;
                }
                else
                {
                    return new List<Pipe>();
                }
            }
            set
            {
                if (value != railcar.Pipes)
                {
                    railcar.Pipes = value;
                    RaisePropertyChanged("Pipes");
                }
            }
        }

        # endregion Railcar Note

        #region Commands
        public ICommand SaveCommand
        {
            get { return saveCommand; }
        }

        public ICommand ShipCommand
        {
            get { return shipCommand; }
        }

        public ICommand UnshipCommand
        {
            get { return unshipCommand; }
        } 
        #endregion

        public void Dispose()
        {
            repos.Dispose();
            ModifiableView = null;
            if (FilesFormViewModel != null)
            {
                FilesFormViewModel.Dispose();
            }
        }

        public void AddPipe(Guid id)
        {
            foreach (var pipe in Pipes)
	        {
                if (pipe.Id == id)
	            {
		        return;
	            }
	        }
            GetStoredPipes();

            pipeToAdd = allPipes.Find(_ => _.Id.Equals(id));

            if (!(pipeToAdd.Railcar == null))
            {
                notify.ShowError(
                    Program.LanguageManager.GetString(StringResources.ReleaseNoteNewEdit_ErrorAddingPipeAlreadyInRailcar)
                        + " " + pipeToAdd.Railcar.Number,
                    Program.LanguageManager.GetString(StringResources.Message_ErrorHeader));
            }
            else
            {
                Pipes.Add(pipeToAdd);
                ReleaseNotePipes.Add(pipeToAdd);
                AllPipes.Remove(pipeToAdd);
            }

            
        }

        public void RemovePipe(string number)
        {
            if (Railcar.IsShipped)
            {
                notify.ShowError(
                    Program.LanguageManager.GetString(StringResources.ReleaseNoteNewEdit_UnshipFirst), 
                    Program.LanguageManager.GetString(StringResources.Message_ErrorHeader));
                return;
            }

            foreach (var pipe in Pipes)
            {
                if (pipe.Number == number)
                {
                    try
                    {
                        pipesList.Remove(pipe);
                        Pipes.Remove(pipe);
                        AllPipes.Add(pipe);
                        ReleaseNotePipes.Remove(pipe);
                        pipe.Railcar = null;
                        repos.PipeRepo.Merge(pipe);
                        break;
                    }
                    catch (RepositoryException ex)
                    {
                        notify.ShowFailure(ex.InnerException.Message, ex.Message);
                    }
                }
            }
        }

        public void NewRailcar()
        {
            this.isNew = true;
            if (ReleaseNote == null)
            {
                ReleaseNote = new ReleaseNote { Shipped = false, IsActive = true };
            }

            Number = string.Empty;
            Railcars = new List<Prizm.Domain.Entity.Mill.Railcar>();
        }

        public void GetStoredPipes()
        {
            try
            {
                var tmp = new List<Pipe>(repos.PipeRepo.GetStored());
                allPipes = tmp;
                if (this.allPipes == null || this.allPipes.Count <= 0)
                    log.Warn( "List of Stored Pipes in Release Note is NULL or empty" );
            }
            catch (RepositoryException ex)
            {
                log.Error(string.Format("Unable to retrieve stored pipe: ", ex.InnerException.Message, ex.Message));
                notify.ShowFailure(ex.InnerException.Message, ex.Message);
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

        public bool IsNew 
        { 
            get { return isNew; }
            set
            {
                if (value != isNew)
                {
                    isNew = value;
                }
            }
        }
    }
}