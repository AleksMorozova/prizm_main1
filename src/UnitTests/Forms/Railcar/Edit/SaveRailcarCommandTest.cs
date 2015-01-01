using Prizm.Data.DAL.Mill;
using Prizm.Domain.Entity.Mill;
using Moq;
using NUnit.Framework;
using Prizm.Main.Documents;
using Prizm.Main.Forms;
using Prizm.Main.Forms.Railcar;
using Prizm.Main.Forms.Railcar.NewEdit;
using System.Collections.Generic;
using System;

namespace Prizm.UnitTests.Forms.Railcar.Edit
{
    [TestFixture]
    public class SaveRailcarCommandTest
    {
        [Test]
        public void TestSaveNewRailcar()
        {
            var notify = new Mock<IUserNotify>();
            var view = new Mock<IModifiable>();
            var railcarRepo = new Mock<IRailcarRepository>();
            var pipeRepo = new Mock<IPipeRepository>();
            pipeRepo.Setup(x => x.GetStored()).Returns(new List<Pipe>() { new Pipe() });
            var repos = new Mock<IRailcarRepositories>();
            repos.SetupGet(_ => _.PipeRepo).Returns(pipeRepo.Object);
            repos.SetupGet(_ => _.RailcarRepo).Returns(railcarRepo.Object);

            var viewModel = new RailcarViewModel(repos.Object, Guid.Empty, notify.Object);
            viewModel.ModifiableView = new Mock<IModifiable>().Object;
            viewModel.Railcar.Number = "Test Railcar";
            viewModel.ModifiableView = view.Object;
            viewModel.Railcar.Pipes.Add(new Pipe());
            var command = new SaveRailcarCommand(viewModel, repos.Object, notify.Object);

            command.Execute();

            repos.Verify(_ => _.BeginTransaction(), Times.Once());
            railcarRepo.Verify(_ => _.SaveOrUpdate(viewModel.Railcar), Times.Once());
            repos.Verify(_ => _.Commit(), Times.Once());
            railcarRepo.Verify(_ => _.Evict(viewModel.Railcar), Times.Once());
        }
    }
}