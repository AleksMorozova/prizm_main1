using Data.DAL.Mill;
using Data.DAL.Setup;
using DevExpress.Mvvm.DataAnnotations;
using PrizmMain.Commands;
using PrizmMain.Forms.Settings.ViewTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.Settings
{
    public class SaveSettingsCommand: ICommand 
    {
        readonly ISettingsRepositories repos;
        readonly SettingsViewModel viewModel;

        public SaveSettingsCommand(SettingsViewModel viewModel, ISettingsRepositories repos) 
        {
            this.viewModel = viewModel; 
            this.repos = repos;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            repos.BeginTransaction();
            SaveWelders();  
            repos.PipeSizeTypeRepo.SaveOrUpdate(viewModel.CurrentPipeMillSizeType);
            repos.Commit();
            repos.PipeSizeTypeRepo.Evict(viewModel.CurrentPipeMillSizeType);
            //viewModel.NewPipeMillSizeType();
        }

        public bool CanExecute()
        {
           return true;
        }

        void SaveWelders()
        {
           if (viewModel.Welders != null)
           {
              viewModel.Welders.ForEach<WelderViewType>(_ => repos.WelderRepo.SaveOrUpdate(_.Welder));
           }
        }
    }
}
