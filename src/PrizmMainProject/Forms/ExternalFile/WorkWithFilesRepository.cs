using NHibernate;
using Ninject;
using Prizm.DAL.Hibernate;
using Prizm.Data.DAL;
using Prizm.Data.DAL.Hibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.ExternalFile
{
    public class WorkWithFilesRepository : IWorkWithFilesRepository
    {
        private readonly IProjectRepository repoProject;
        private readonly IFileRepository repoFile;

        private readonly ISession session;

        [Inject]
        public WorkWithFilesRepository(ISession session)
        {
            this.session = session;
            this.repoProject = new ProjectRepository(session);
            this.repoFile = new FileRepository(session);
        }


        public void Commit()
        {
            session.Transaction.Commit();
        }

        public void BeginTransaction()
        {
            session.BeginTransaction();
        }

        public void Dispose()
        {
            session.Dispose();
        }

        public IProjectRepository RepoProject
        {
            get { return repoProject; }
        }

        public IFileRepository RepoFile
        {
            get { return repoFile; }
        }
    }
}
