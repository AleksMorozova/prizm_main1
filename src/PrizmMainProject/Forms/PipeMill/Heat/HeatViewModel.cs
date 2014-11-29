using Data.DAL.Mill;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Entity.Mill;
using PrizmMain.Commands;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using System.ComponentModel;
using System.Windows.Forms;
using PrizmMain.Properties;

namespace PrizmMain.Forms.PipeMill.Heat
{
    public class HeatViewModel : ViewModelBase, IDisposable
    {
        private readonly IHeatRepositories repo;
        private readonly SaveHeatCommand saveCommand;

        [Inject]
        public HeatViewModel(IHeatRepositories heatRepository, string heatNumber)
        {
            this.repo = heatRepository;
            saveCommand = ViewModelSource.Create(() => new SaveHeatCommand(this, repo));

            if (string.IsNullOrWhiteSpace(heatNumber))
            {
                CreateHeat();
            }
            else
            {
                if (heatNumber.Equals(Resources.NewHeatCombo))
                {
                    CreateHeat();
                }
                else
                {
                    var heat = GetHeatByNumber(heatNumber);
                    if (heat != null)
                    {
                        Heat = heat;
                        SetupManufacturers();
                        heats = new List<Domain.Entity.Mill.Heat>() { heat };
                    }
                    else
                    {
                        CreateHeat();
                    }
                }

            }
        }
        #region Property
        Domain.Entity.Mill.Heat heat;
        public Domain.Entity.Mill.Heat Heat
        {
            get { return heat; }
            set
            {
                if (value != heat)
                {
                    heat = value;
                    RaisePropertyChanged("Heat");
                }
            }
        }

        public PlateManufacturer PlateManufacturer
        {
            get
            {
                if (heat.PlateManufacturer != null)
                {
                    return heat.PlateManufacturer;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (value != heat.PlateManufacturer)
                {
                    heat.PlateManufacturer = value;
                    RaisePropertyChanged("PlateManufacturer");
                }
            }
        }

        public string SteelGrade
        {
            get { return Heat.SteelGrade; }
            set
            {
                if (value != Heat.SteelGrade)
                {
                    Heat.SteelGrade = value;
                    RaisePropertyChanged("SteelGrade");
                }
            }
        }

        IList<Domain.Entity.Mill.Heat> heats;
        public IList<Domain.Entity.Mill.Heat> Heats
        {
            get { return heats; }
        }
        
        IList<PlateManufacturer> manufacrurers;
        public IList<PlateManufacturer> Manufacrurers
        {
            get { return manufacrurers; }
        }

        #endregion

        private void HeatsList()
        {
            SetupHeats();
            SetupManufacturers();
            heat = heats[0];
            
        }

        private void SetupHeats()
        {
            heats = new List<Domain.Entity.Mill.Heat>(repo.HeatRepo.GetAll().ToList());
        }

        private void SetupManufacturers()
        {
            manufacrurers = new List<PlateManufacturer>(repo.PlateManRepo.GetAll().ToList());
        }

        public ICommand SaveCommand
        {
            get { return saveCommand; }
        }


        public void Dispose()
        {
            repo.Dispose();
        }

        public void NewHeat(string number)
        {
            var heatFromDb = GetHeatByNumber(number);
            if (heatFromDb != null)
            {
                HeatsList();
                return;
            }
            SetupManufacturers();
            Heat = new Domain.Entity.Mill.Heat() 
            {
                IsActive = true, 
                Number=number,
                SteelGrade = string.Empty,
                PlateManufacturer = manufacrurers[0]
            };

            
            heats = new List<Domain.Entity.Mill.Heat>() { Heat };

        }

        internal Domain.Entity.Mill.Heat GetHeatByNumber(string number)
        {
            return repo.HeatRepo.GetByNumber(number);
        }

        internal void GetHeatById(Guid id)
        {
            Heat = repo.HeatRepo.Get(id);
        }

        internal void SetHeat(Guid guid)
        {
            Heat = heats.Where(x => x.Id == guid).FirstOrDefault();
        }

        internal void CreateHeat()
        {
            var numberForm = new HeatNumberXtraForm();
            
                if (numberForm.ShowDialog() == DialogResult.OK)
                {
                    NewHeat(numberForm.Number);
                }
                else
                {
                    HeatsList();
                }
            

        }
    }
}
