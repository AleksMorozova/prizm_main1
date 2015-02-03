using Prizm.DAL.Hibernate;
using Prizm.Data.DAL;
using Prizm.DAL.Hibernate;
using Prizm.Data.DAL;
using Prizm.Data.DAL.Construction;
using Prizm.Data.DAL.Hibernate;
using Prizm.Data.DAL.Mill;
using NHibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Component
{
    public class ComponentRepositories : IComponentRepositories
    {
        ISession session;
        private readonly IComponentRepository componentRepo;
        private readonly IComponentTypeRepository componentTypeRepo;
        private readonly IInspectorRepository repoInspector;
        private readonly IFileRepository fileRepo;


        [Inject]
        public ComponentRepositories(ISession session)
        {
            this.session = session;
            this.componentRepo = new ComponentRepository(session);
            this.componentTypeRepo = new ComponentTypeRepository(session);
            this.repoInspector = new InspectorRepository(session);
            this.fileRepo = new FileRepository(session);
        }

        public IComponentRepository ComponentRepo
        {
            get { return componentRepo; }
        }

        public IComponentTypeRepository ComponentTypeRepo
        {
            get { return componentTypeRepo; }
        }

        public IInspectorRepository RepoInspector
        {
            get { return repoInspector; }
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

        public IFileRepository FileRepo
        {
            get { return fileRepo; }
        }

        public IFileRepository FileRepo
        {
            get { return fileRepo; }
        }

        public void Rollback()
        {
            session.Transaction.Rollback();
        }
    }
}
