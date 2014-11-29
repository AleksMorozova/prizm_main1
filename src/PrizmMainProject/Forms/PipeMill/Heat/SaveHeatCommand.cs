using Data.DAL.Mill;
using DevExpress.Mvvm.DataAnnotations;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.PipeMill.Heat
{
    public class SaveHeatCommand : ICommand
    {
        private readonly HeatViewModel viewModel;
        private readonly IHeatRepositories repo;

        public SaveHeatCommand(HeatViewModel viewModel, IHeatRepositories repo)
        {
            this.viewModel = viewModel;
            this.repo = repo;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            var heat = viewModel.Heat;

            repo.BeginTransaction();
            repo.HeatRepo.SaveOrUpdate(heat);
            repo.Commit();
            repo.HeatRepo.Evict(heat);

            //TODO: is old!!!
            //repo.BeginTransaction();
            //repo.HeatRepo.Save(viewModel.Heat);
            //repo.Commit();
            //repo.HeatRepo.Evict(viewModel.Heat);
            //viewModel.NewHeat(string.Empty);
        }

        public bool CanExecute()
        {
            return true;
        }
        public virtual bool IsExecutable { get; set; }
    }
}
