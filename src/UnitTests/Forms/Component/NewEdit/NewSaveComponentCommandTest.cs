using Prizm.Data.DAL.Construction;
using Prizm.Data.DAL.Mill;
using Prizm.Domain.Entity.Construction;
using Moq;
using NUnit.Framework;
using Prizm.Main.Documents;
using Prizm.Main.Forms;
using Prizm.Main.Forms.Component;
using Prizm.Main.Forms.Component.NewEdit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.UnitTests.Forms.Component.NewEdit
{
    [TestFixture]
    class NewSaveComponentCommandTest
    {
        [Test]
        public void TestNewSaveComponent()
        {
            var modifiableView = new Mock<IModifiable>();
            var notify = new Mock<IUserNotify>();


            var componentRepo = new Mock<IComponentRepository>();
            var componentTypeRepo = new Mock<IComponentTypeRepository>();
            var repoInspector = new Mock<IInspectorRepository>();

            var component = new Prizm.Domain.Entity.Construction.Component();

            componentRepo.Setup(x => x.GetActiveByNumber(component)).Returns(new List<Prizm.Domain.Entity.Construction.Component>());
            componentTypeRepo.Setup(x => x.GetAll()).Returns(new List<ComponentType>());
            componentTypeRepo.Setup(x => x.GetAll()).Returns(new List<ComponentType>());

            var componentsRepos = new Mock<IComponentRepositories>();

            componentsRepos.SetupGet(_ => _.ComponentRepo).Returns(componentRepo.Object);
            componentsRepos.SetupGet(_ => _.ComponentTypeRepo).Returns(componentTypeRepo.Object);
            componentsRepos.SetupGet(_ => _.RepoInspector).Returns(repoInspector.Object);


            modifiableView.SetupGet(x => x.IsModified).Returns(false);



            var viewModel = new ComponentNewEditViewModel(
                componentsRepos.Object,
                Guid.Empty,
                notify.Object);

            viewModel.Component = component;
            viewModel.ModifiableView = modifiableView.Object;

            var command = new NewSaveComponentCommand(
                viewModel,
                componentsRepos.Object,
                notify.Object);

            command.Execute();

            componentsRepos.Verify(_ => _.BeginTransaction(), Times.Once());
            componentRepo.Verify(_ => _.SaveOrUpdate(It.IsAny<Prizm.Domain.Entity.Construction.Component>()), Times.Once());
            componentsRepos.Verify(_ => _.Commit(), Times.Once());
            componentRepo.Verify(_ => _.Evict(It.IsAny<Prizm.Domain.Entity.Construction.Component>()), Times.Once());
        }
    }
}
