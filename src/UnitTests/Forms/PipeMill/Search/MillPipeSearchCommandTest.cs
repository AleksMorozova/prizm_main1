using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Data.DAL.Setup;
using Prizm.Data.DAL.Mill;
using Moq;
using NUnit.Framework;
using Prizm.Main.Forms.Railcar.NewEdit;
using Prizm.Main.Forms.PipeMill.NewEdit;
using Prizm.Main.Forms.PipeMill.Search;
using Prizm.Main.Forms.PipeMill;
using NHibernate.Criterion;
using Prizm.Domain.Entity.Setup;
using Prizm.Main.Forms;
using NHibernate;
using NHibernate.Transform;

namespace Prizm.UnitTests.Forms.PipeMill.Search
{
    [TestFixture]
    public class MillPipeSearchCommandTest
    {
        [Test]
        public void TestMillPipeSearchCommand()
        {
            var iQuery = new Mock<IQuery>();
            var iSQLQuery = new Mock<ISQLQuery>();

            var notify = new Mock<IUserNotify>();
            var repoPipe = new Mock<IPipeRepository>();
            var repoPlate = new Mock<IPlateRepository>();
            var repoHeat = new Mock<IHeatRepository>();
            var repoWeld = new Mock<IWeldRepository>();
            var repoPipeType = new Mock<IMillPipeSizeTypeRepository>();
            var repoPurchaseOrder = new Mock<IPurchaseOrderRepository>();
            var repoWelder = new Mock<IWelderRepository>();
            var repoPipeTestResult = new Mock<IPipeTestResultRepository>();
            var repoPipeTest = new Mock<IPipeTestRepository>();
            var repoInspector = new Mock<IInspectorRepository>();

            Mock<IMillRepository> millRepos = new Mock<IMillRepository>();
            millRepos.SetupGet(_ => _.RepoPipe).Returns(repoPipe.Object);
            millRepos.SetupGet(_ => _.RepoPlate).Returns(repoPlate.Object);
            millRepos.SetupGet(_ => _.RepoHeat).Returns(repoHeat.Object);
            millRepos.SetupGet(_ => _.RepoWeld).Returns(repoWeld.Object);
            millRepos.SetupGet(_ => _.RepoPipeType).Returns(repoPipeType.Object);
            millRepos.SetupGet(_ => _.RepoPurchaseOrder).Returns(repoPurchaseOrder.Object);
            millRepos.SetupGet(_ => _.WelderRepo).Returns(repoWelder.Object);
            millRepos.SetupGet(_ => _.RepoPipeTestResult).Returns(repoPipeTestResult.Object);
            millRepos.SetupGet(_ => _.RepoPipeTest).Returns(repoPipeTest.Object);
            millRepos.SetupGet(_ => _.RepoInspector).Returns(repoInspector.Object);



            var pipes = new List<Prizm.Domain.Entity.Mill.Pipe>()
            {
                new Prizm.Domain.Entity.Mill.Pipe { Number = "test-1" },
                new Prizm.Domain.Entity.Mill.Pipe { Number = "test-3" }
            };

            var viewModel = new MillPipeSearchViewModel(millRepos.Object, notify.Object);
            viewModel.PipeNumber = "Test Number";
            viewModel.CheckedPipeTypes = new List<PipeMillSizeType>();

            iQuery.Setup(x => x.List<Prizm.Domain.Entity.Mill.Pipe>())
                .Returns(pipes).Verifiable();

            iSQLQuery.Setup(x => x.SetResultTransformer(It.IsAny<IResultTransformer>()))
                .Returns(iQuery.Object).Verifiable();

            repoPipe.Setup(x => x.CreateSQLQuery(It.IsAny<string>()))
                .Returns(iSQLQuery.Object).Verifiable();

            var command = new MillPipeSearchCommand(viewModel, repoPipe.Object, notify.Object);

            command.Execute();

            repoPipe.Verify(x => x.CreateSQLQuery(It.IsAny<string>()), Times.Once());

            Assert.AreEqual(
                repoPipe.Object
                .CreateSQLQuery(It.IsAny<string>())
                .SetResultTransformer(It.IsAny<IResultTransformer>())
                .List<Prizm.Domain.Entity.Mill.Pipe>(), pipes);

        }

    }
}
