using Prizm.Data.DAL.Mill;
using Moq;
using NHibernate.Criterion;
using NUnit.Framework;
using Prizm.Main.Forms;
using Prizm.Main.Forms.Railcar.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Data.DAL.Setup;
using Prizm.Main.Forms.Railcar.NewEdit;
using Prizm.Main.Forms.PipeMill.NewEdit;
using Prizm.Main.Forms.PipeMill.Search;
using Prizm.Main.Forms.PipeMill;
using Prizm.Domain.Entity.Setup;
using NHibernate;
using NHibernate.Transform;



namespace Prizm.UnitTests.Forms.Railcar.Search
{

    [TestFixture]
    public class SearchRailcarCommandTest
    {

        [Test]
        public void TestSearchRailcarCommand()
        {

            var iQuery = new Mock<IQuery>();
            var iSQLQuery = new Mock<ISQLQuery>();


            var railcars = new List<Prizm.Main.Forms.Railcar.Search.Railcar>()
            {
                new Prizm.Main.Forms.Railcar.Search.Railcar { Number = "test-1" },
                new Prizm.Main.Forms.Railcar.Search.Railcar { Number = "test-3" }
            };

            var railcars2 = new List<Prizm.Main.Forms.Railcar.Search.Railcar>()
            {
                new Prizm.Main.Forms.Railcar.Search.Railcar { Number = "test-0" },
                new Prizm.Main.Forms.Railcar.Search.Railcar { Number = "test-3" }
            };


            var repo = new Mock<IRailcarRepository>();
            var notify = new Mock<IUserNotify>();
            var viewmodel = new RailcarSearchViewModel(repo.Object, notify.Object);


            iQuery.Setup(x => x.List<Prizm.Main.Forms.Railcar.Search.Railcar>())
               .Returns(railcars).Verifiable();

            iSQLQuery.Setup(x => x.SetResultTransformer(It.IsAny<IResultTransformer>()))
                .Returns(iQuery.Object).Verifiable();

            repo.Setup(x => x.CreateSQLQuery(It.IsAny<string>()))
                .Returns(iSQLQuery.Object).Verifiable();


            var command = new SearchRailcarCommand(viewmodel, repo.Object, notify.Object);

            //check if command executed
            command.Execute();

            repo.Verify(x => x.CreateSQLQuery(It.IsAny<string>()), Times.Once());

            //check SQL query result
            Assert.AreEqual(
                repo.Object
                .CreateSQLQuery(It.IsAny<string>())
                .SetResultTransformer(It.IsAny<IResultTransformer>())
                .List<Prizm.Main.Forms.Railcar.Search.Railcar>(), railcars);

        }
    }

}