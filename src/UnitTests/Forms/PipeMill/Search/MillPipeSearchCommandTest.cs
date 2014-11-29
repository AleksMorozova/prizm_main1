using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Data.DAL.Mill;
using Moq;
using NUnit.Framework;
using PrizmMain.Forms.Railcar.NewEdit;
using PrizmMain.Forms.PipeMill.NewEdit;
using PrizmMain.Forms.PipeMill.Search;
using NHibernate.Criterion;
using PrizmMain.Forms.PipeMill;

namespace UnitTests.Forms.PipeMill.Search
{
    [TestFixture]
    public class MillPipeSearchCommandTest
    {
        [Test]
        public void TestMillPipeSearchCommand()
        {
            var repo = new Mock<IPipeRepository>();
            var repoGlob = new Mock<IMillRepository>();

            var pipes = new List<Domain.Entity.Mill.Pipe>();
            {
                new Domain.Entity.Mill.Pipe { Number = "test-1" };
                new Domain.Entity.Mill.Pipe { Number = "test-3" };
            };

            repo.Setup(_ => _.GetByCriteria(It.IsAny<NHibernate.Criterion.DetachedCriteria>()))
                .Returns(pipes).Verifiable();

            var criteria = NHibernate.Criterion.DetachedCriteria
              .For<Domain.Entity.Mill.Pipe>()
              .Add(Restrictions.Like("Number", "test-1", MatchMode.Anywhere));



            var viewModel = new MillPipeSearchViewModel(repoGlob.Object);

            var command = new MillPipeSearchCommand(viewModel, repo.Object);



            command.Execute();



            repo.Verify(x => x.GetByCriteria(It.IsAny<DetachedCriteria>()), Times.Once());

            Assert.AreEqual(repo.Object.GetByCriteria(criteria), pipes);

        }

    }
}
