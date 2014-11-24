using Data.DAL.Mill;
using Moq;
using NHibernate.Criterion;
using NUnit.Framework;
using PrizmMain.Forms;
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
        List<Domain.Entity.Mill.Railcar> railcars;
        Mock<IRailcarRepository> repo;
        Mock<IUserNotify> notify;
        SearchRailcarCommand command;
        RailcarSearchViewModel viewModel;

        [SetUp]
        public void Init()
        {
            railcars = new List<Domain.Entity.Mill.Railcar>()
            {
                new Domain.Entity.Mill.Railcar {Number="test number",Certificate="test certificate", 
                Destination="test destination"}
            };

            repo = new Mock<IRailcarRepository>();
            repo.Setup(_ => _.GetByCriteria(It.IsAny<NHibernate.Criterion.DetachedCriteria>()))
                .Returns(railcars);
            notify = new Mock<IUserNotify>();
            viewModel = new RailcarSearchViewModel(repo.Object,notify.Object);
            command = new SearchRailcarCommand(viewModel, repo.Object, notify.Object);
        }

        [Test]
        public void RailcarSearchEmptyCriteria() 
        {
            var criteria = NHibernate.Criterion.DetachedCriteria.For<Domain.Entity.Mill.Railcar>();

            command.Execute();

            repo.Verify(_ => _.GetByCriteria(criteria), Times.Never());
        }

        [Test]
        public void RailcarSearchFilledCriteria()
        {
            viewModel.Certificate = "Cerificare";

            command.Execute();

            repo.Verify(_ => _.GetByCriteria(It.IsAny<NHibernate.Criterion.DetachedCriteria>()));
        }
    }
}
