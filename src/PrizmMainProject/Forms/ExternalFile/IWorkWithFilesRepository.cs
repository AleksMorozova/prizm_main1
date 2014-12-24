using Prizm.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.ExternalFile
{
    public interface IWorkWithFilesRepository : IDisposable
    {
        IFileRepository RepoFile { get; }
        IProjectRepository RepoProject { get; }

        void Commit();
        void BeginTransaction();
    }
}
