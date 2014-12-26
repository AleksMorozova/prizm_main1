using Prizm.Data.DAL.Construction;
using Prizm.Data.DAL.Hibernate;
using Prizm.Data.DAL.Mill;
using Prizm.Data.DAL.Setup;
using NHibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Joint
{
    public class ConstructionRepository : IConstructionRepository
    {
        private readonly IJointRepository repoJoint;
        private readonly IJointTestResultRepository repoJointTestResult;
        private readonly IJointWeldResultRepository repoJointWeldResult;
        private readonly IJointOperationRepository repoJointOperation;
        private readonly IInspectorRepository repoInspector;
        private readonly IWelderRepository repoWelder;

        private readonly IPipeRepository repoPipe;
        private readonly ISpoolRepository repoSpool;
        private readonly IComponentRepository repoComponent;

        private readonly ISession session;

        [Inject]
        public ConstructionRepository(ISession session)
        {
            this.session = session;
            this.repoJoint = new JointRepository(session);
            this.repoJointTestResult = new JointTestResultRepository(session);
            this.repoJointWeldResult = new JointWeldResultRepository(session);
            this.repoJointOperation = new JointOperationRepository(session);
            this.repoInspector = new InspectorRepository(session);
            this.repoWelder = new WelderRepository(session);

            this.repoPipe = new PipeRepository(session);
            this.repoSpool = new SpoolRepository(session);
            this.repoComponent = new ComponentRepository(session);
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


        public IPipeRepository RepoPipe
        {
            get { return repoPipe; }
        }

        public ISpoolRepository RepoSpool
        {
            get { return repoSpool; }
        }

        public IComponentRepository RepoComponent
        {
            get { return repoComponent; }
        }


        public IJointRepository RepoJoint
        {
            get { return repoJoint; }
        }

        public IJointTestResultRepository RepoJointTestResult
        {
            get { return repoJointTestResult; }
        }

        public IJointOperationRepository RepoJointOperation
        {
            get { return repoJointOperation; }
        }

        public IInspectorRepository RepoInspector
        {
            get { return repoInspector; }
        }

        public IWelderRepository RepoWelder
        {
            get { return repoWelder; }
        }

        public IJointWeldResultRepository RepoJointWeldResult
        {
            get { return repoJointWeldResult; }
        }
    }
}
