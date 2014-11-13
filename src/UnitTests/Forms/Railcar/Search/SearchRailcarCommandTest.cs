using Data.DAL.Mill;
using Moq;
using NUnit.Framework;
using PrizmMain.Forms.Railcar.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Forms.Railcar.Search
{
    [TestFixture]
    public class SearchRailcarCommandTest
    {

        [Test]
        public void TestSearchRailcar() 
        {
            var railcars = new List<Domain.Entity.Mill.Railcar>()
            {
                new Domain.Entity.Mill.Railcar {Number="test number",Certificate="test certificate", 
                Destination="test destination"}
            };
            var repo = new Mock<IRailcarRepository>();
            repo.Setup(_ => _.GetByCriteria(It.IsAny<NHibernate.Criterion.DetachedCriteria>()))
                .Returns(railcars).Verifiable();

            var viewModel = new RailcarSearchViewModel(repo.Object);
            var command = new SearchRailcarCommand(viewModel, repo.Object);
            var criteria = NHibernate.Criterion.DetachedCriteria.For<Domain.Entity.Mill.Railcar>();

            command.Execute();

            repo.VerifyAll();
        }
    }
}
