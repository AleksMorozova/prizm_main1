using Prizm.Data.DAL;
using Prizm.Data.DAL.Construction;
using Prizm.Data.DAL.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Component
{
    public interface IComponentRepositories : IDisposable
    {
        IComponentRepository ComponentRepo { get; }
        IComponentTypeRepository ComponentTypeRepo { get; }
        IInspectorRepository RepoInspector { get; }
        IFileRepository FileRepo { get; }

        void Commit();
        void BeginTransaction();
    }
}
