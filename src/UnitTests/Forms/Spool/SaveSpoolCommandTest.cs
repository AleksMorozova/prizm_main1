using Prizm.Data.DAL.Construction;
using Prizm.Data.DAL.Mill;
using Moq;
using NUnit.Framework;
using Prizm.Main.Documents;
using Prizm.Main.Forms;
using Prizm.Main.Forms.Spool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.UnitTests.Forms.Spool
{
    [TestFixture]
    class SaveSpoolCommandTest
    {
        [Test]
        public void TestSaveCommand()
        {
            var modifiableView = new Mock<IModifiable>();
            var notify = new Mock<IUserNotify>();

            var spoolRepo = new Mock<ISpoolRepository>();
            var pipeRepo = new Mock<IPipeRepository>();
            var inspectorRepo = new Mock<IInspectorRepository>();

            var spool = new Prizm.Domain.Entity.Construction.Spool();
            var pipe = new Prizm.Domain.Entity.Mill.Pipe();

            spoolRepo.Setup(x => x.GetAvailablePipes()).Returns(new List<Prizm.Domain.Entity.Mill.Pipe>());

            var spoolRepos = new Mock<ISpoolRepositories>();

            spoolRepos.SetupGet(_ => _.PipeRepo).Returns(pipeRepo.Object);
            spoolRepos.SetupGet(_ => _.RepoInspector).Returns(inspectorRepo.Object);
            spoolRepos.SetupGet(_ => _.SpoolRepo).Returns(spoolRepo.Object);


            modifiableView.SetupGet(x => x.IsModified).Returns(false);


            var viewModel = new SpoolViewModel(
                spoolRepos.Object,
                Guid.Empty,
                notify.Object);

            viewModel.Spool = spool;
            viewModel.Pipe = pipe;

            viewModel.ModifiableView = modifiableView.Object;

            var command = new SaveSpoolCommand(
                viewModel,
                spoolRepos.Object,
                notify.Object);

            viewModel.Spool.Length = 124;
            viewModel.canCut = true;
            viewModel.Pipe.Number = "Test";

            command.Execute();

            spoolRepos.Verify(_ => _.BeginTransaction(), Times.Once());
            spoolRepo.Verify(_ => _.SaveOrUpdate(It.IsAny<Prizm.Domain.Entity.Construction.Spool>()), Times.Once());
            spoolRepos.Verify(_ => _.Commit(), Times.Once());
            spoolRepo.Verify(_ => _.Evict(It.IsAny<Prizm.Domain.Entity.Construction.Spool>()), Times.Once());
        }
    }
}
