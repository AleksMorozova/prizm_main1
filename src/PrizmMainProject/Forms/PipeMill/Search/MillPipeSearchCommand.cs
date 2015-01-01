using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prizm.Main.Commands;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using Prizm.Data.DAL.Mill;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using Prizm.Domain.Entity.Setup;
using Prizm.Domain.Entity.Mill;
using Prizm.Main.Properties;
using Prizm.Data.DAL;

namespace Prizm.Main.Forms.PipeMill.Search
{
    public class MillPipeSearchCommand : ICommand
    {
        private readonly IPipeRepository repo;
        private readonly MillPipeSearchViewModel viewModel;
        private readonly IUserNotify notify;

        public MillPipeSearchCommand(
            MillPipeSearchViewModel viewModel,
            IPipeRepository repo,
            IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repo = repo;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            repo.Clear();

            try
            {
                var pipes = new List<Prizm.Domain.Entity.Mill.Pipe>();

                var query = repo
                    .CreateSQLQuery(PipeQuery.BuildSql(
                    viewModel.PipeNumber,
                    viewModel.CheckedPipeTypes,
                    viewModel.Activity,
                    viewModel.CheckedStatusTypes))
                    .SetResultTransformer(PipeQuery.Transformer);

                var qpipes = query.List<Prizm.Domain.Entity.Mill.Pipe>();

                foreach (var item in qpipes)
                {
                    pipes.Add(item);
                }

                viewModel.Pipes = pipes;
            }
            catch (RepositoryException ex)
            {
                notify.ShowFailure(ex.InnerException.Message, ex.Message);
            }
        }


        public bool CanExecute()
        {
            return true;
        }

        public virtual bool IsExecutable { get; set; }
    }
}
