using Prizm.Data.DAL.Construction;
using Prizm.Data.DAL.Mill;
using Prizm.Data.DAL.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Joint
{
    public interface IConstructionRepository : IDisposable
    {
        IJointRepository RepoJoint { get; }
        IJointTestResultRepository RepoJointTestResult { get; }
        IJointWeldResultRepository RepoJointWeldResult { get; }
        IJointOperationRepository RepoJointOperation { get; }
        IInspectorRepository RepoInspector { get; }
        IWelderRepository RepoWelder { get; }

        IPipeRepository RepoPipe { get; }
        ISpoolRepository RepoSpool { get; }
        IComponentRepository RepoComponent { get; }

        void Commit();
        void BeginTransaction();
    }
}
