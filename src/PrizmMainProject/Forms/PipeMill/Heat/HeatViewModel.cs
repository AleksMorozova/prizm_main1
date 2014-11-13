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

namespace PrizmMain.Forms.PipeMill.Heat
{
    public class HeatViewModel : ViewModelBase, IDisposable
    {
        private readonly IHeatRepository heatRepo;
        private readonly SaveHeatCommand saveCommand;
        
        [Inject]
        public HeatViewModel(IHeatRepository heatRepository, string heatNumber)
        {
            this.heatRepo = heatRepository;
            saveCommand = ViewModelSource.Create(() => new SaveHeatCommand(this, heatRepo));

            if (string.IsNullOrWhiteSpace(heatNumber))
            {
                NewHeat(heatNumber);
            }
            else
            {
                var answer = heatRepo.GetByNumber(heatNumber);
                if (answer == null)
                {
                    NewHeat(heatNumber);
                }
                else
                {
                    Heat = answer;
                }
            }
        }

        public Domain.Entity.Mill.Heat Heat { get; set; }

        public string Number
        {
            get { return Heat.Number; }
            set
            {
                if (value != Heat.Number)
                {
                    Heat.Number = value;
                    RaisePropertyChanged("Number");
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

        public ChemicalComposition Chemical
        {
            get { return Heat.ChemicalComposition; }
            set
            {
                if (value != Heat.ChemicalComposition)
                {
                    Heat.ChemicalComposition = value;
                    RaisePropertyChanged("ChemicalComposition");
                }
            }
        }

        public PhysicalParameters Phisical
        {
            get { return Heat.PhysicalParameters; }
            set
            {
                if (value != Heat.PhysicalParameters)
                {
                    Heat.PhysicalParameters = value;
                    RaisePropertyChanged("PhysicalParameters");
                }
            }
        }

        public ICommand SaveCommand
        {
            get { return saveCommand; }
        }


        public void Dispose()
        {
            heatRepo.Dispose();
        }

        public void NewHeat(string number)
        {
            if (Heat == null)
            {
                Heat = new Domain.Entity.Mill.Heat();
                Heat.Number = number;
                Heat.SteelGrade = string.Empty;
                Heat.PhysicalParameters = new PhysicalParameters();
                Heat.ChemicalComposition = new ChemicalComposition();
            }
        }
    }
}
