using Data.DAL.Mill;
using Moq;
using NUnit.Framework;
using PrizmMain.Forms.Railcar.NewEdit;

namespace UnitTests.Forms.Railcar.Edit
{
    [TestFixture]
    public class SaveRailcarCommandTest
    {
        [Test]
        public void TestSaveRailcar()
        {
            var repo = new Mock<IRailcarRepository>();
            var viewModel = new RailcarViewModel(repo.Object,"");

            var command = new SaveRailcarCommand(viewModel, repo.Object);

            command.Execute();

            repo.Verify(_ => _.BeginTransaction(), Times.Once());
            repo.Verify(_ => _.Save(viewModel.Railcar), Times.Once());
            repo.Verify(_ => _.Commit(), Times.Once());
            repo.Verify(_ => _.Evict(viewModel.Railcar), Times.Once());
        }
    }
}