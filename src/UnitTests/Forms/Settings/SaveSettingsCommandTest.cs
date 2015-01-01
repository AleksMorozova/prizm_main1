using Prizm.Data.DAL.Setup;
using Prizm.Data.DAL.Mill;
using Prizm.Data.DAL;
using Prizm.Domain.Entity.Setup;
using Moq;
using NUnit.Framework;
using Prizm.Main.Forms.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Domain.Entity;
using Prizm.Domain.Entity.Mill;
using Prizm.Main.Forms;
using Prizm.Data.DAL.Security;
using Prizm.Domain.Entity.Security;
using Prizm.Main.Documents;
using Prizm.Data.DAL.Construction;
using Prizm.Domain.Entity.Construction;


namespace Prizm.UnitTests.Forms.Settings
{
    [TestFixture]
    public class SaveSettingsCommandTest
    {
        [Test]
        public void TestSaveSettings()
        {
            var notify = new Mock<IUserNotify>();

            var repoPipeSize = new Mock<IMillPipeSizeTypeRepository>();
            var repoPipeTests = new Mock<IPipeTestRepository>();
            var repoWelders = new Mock<IWelderRepository>();
            var repoInspectors = new Mock<IInspectorRepository>();
            var repoManufacturers = new Mock<IPlateManufacturerRepository>();
            var repoProjectSetting = new Mock<IProjectRepository>();
            var repoUsers = new Mock<IUserRepository>();
            var repoRoles = new Mock<IRoleRepository>();
            var repoPerms = new Mock<IPermissionRepository>();
            var repoCategory = new Mock<ICategoryRepository>();
            var repoJointOperation = new Mock<IJointOperationRepository>();
            var repoCertificateType = new Mock<ICertificateTypeRepository>();
            var repoComponentType = new Mock<IComponentTypeRepository>();

            var testProjectSetting = new Project();
            var testSizeType = new PipeMillSizeType();
            var testWelder = new Welder();
            var testManufacturer = new PlateManufacturer();
            var testInspector = new Inspector();
            var testUser = new User();
            var testRole = new Role();
            var testPerm = new Permission();
            var modifiableView = new Mock<IModifiable>();
            var jointOperations = new JointOperation();

            repoPipeSize.Setup(_ => _.GetAll()).Returns(new List<PipeMillSizeType>() { testSizeType });
            repoWelders.Setup(_ => _.GetAll()).Returns(new List<Welder>() { testWelder });
            repoManufacturers.Setup(_ => _.GetAll()).Returns(new List<PlateManufacturer>() { testManufacturer });
            repoProjectSetting.Setup(_ => _.GetSingle()).Returns(testProjectSetting);
            repoInspectors.Setup(_ => _.GetAll()).Returns(new List<Inspector>() { testInspector });
            repoUsers.Setup(_ => _.GetAll()).Returns(new List<User>() { testUser });
            repoRoles.Setup(_ => _.GetAll()).Returns(new List<Role>() { testRole });
            repoPerms.Setup(_ => _.GetAll()).Returns(new List<Permission>() { testPerm });
            repoJointOperation.Setup(_ => _.GetAll()).Returns(new List<JointOperation>() { jointOperations });
            repoCategory.Setup(x => x.GetAll()).Returns(new List<Category>() { new Category() });
            repoCertificateType.Setup(x => x.GetAll()).Returns(new List<InspectorCertificateType>() { new InspectorCertificateType() });
            repoComponentType.Setup(x => x.GetAll()).Returns(new List<ComponentType>() { new ComponentType() });

            Mock<ISettingsRepositories> settingsRepos = new Mock<ISettingsRepositories>();
            settingsRepos.SetupGet(_ => _.PipeSizeTypeRepo).Returns(repoPipeSize.Object);
            settingsRepos.SetupGet(_ => _.PipeTestRepo).Returns(repoPipeTests.Object);
            settingsRepos.SetupGet(_ => _.WelderRepo).Returns(repoWelders.Object);
            settingsRepos.SetupGet(_ => _.PlateManufacturerRepo).Returns(repoManufacturers.Object);
            settingsRepos.SetupGet(_ => _.ProjectRepo).Returns(repoProjectSetting.Object);
            settingsRepos.SetupGet(_ => _.InspectorRepo).Returns(repoInspectors.Object);
            settingsRepos.SetupGet(_ => _.UserRepo).Returns(repoUsers.Object);
            settingsRepos.SetupGet(_ => _.RoleRepo).Returns(repoRoles.Object);
            settingsRepos.SetupGet(_ => _.PermissionRepo).Returns(repoPerms.Object);
            settingsRepos.SetupGet(_ => _.JointRepo).Returns(repoJointOperation.Object);
            settingsRepos.SetupGet(x => x.СategoryRepo).Returns(repoCategory.Object);
            settingsRepos.SetupGet(x => x.CertificateTypeRepo).Returns(repoCertificateType.Object);
            settingsRepos.SetupGet(x => x.ComponentTypeRepo).Returns(repoComponentType.Object);

            var viewModel = new SettingsViewModel(settingsRepos.Object, notify.Object);
            viewModel.ModifiableView = modifiableView.Object;
            viewModel.LoadData();
            viewModel.ModifiableView = modifiableView.Object;

            var command = new SaveSettingsCommand(viewModel, settingsRepos.Object, notify.Object);

            command.Execute();

            settingsRepos.Verify(_ => _.BeginTransaction(), Times.Once());
            repoPipeSize.Verify(_ => _.SaveOrUpdate(testSizeType), Times.Once());
            settingsRepos.Verify(_ => _.Commit(), Times.Once());
            repoPipeSize.Verify(_ => _.Evict(testSizeType), Times.Once());
            repoWelders.Verify(_ => _.SaveOrUpdate(testWelder), Times.Once());
            repoWelders.Verify(_ => _.Evict(testWelder), Times.Once());
            repoManufacturers.Verify(_ => _.SaveOrUpdate(testManufacturer), Times.Once());
            repoManufacturers.Verify(_ => _.Evict(testManufacturer), Times.Once());
            repoProjectSetting.Verify(_ => _.SaveOrUpdate(testProjectSetting), Times.Once());
            repoProjectSetting.Verify(_ => _.Evict(testProjectSetting), Times.Once());
            repoInspectors.Verify(_ => _.SaveOrUpdate(testInspector), Times.Once());
            repoInspectors.Verify(_ => _.Evict(testInspector), Times.Once());
            repoUsers.Verify(_ => _.SaveOrUpdate(testUser), Times.Once());
            repoUsers.Verify(_ => _.Evict(testUser), Times.Once());
            repoRoles.Verify(_ => _.SaveOrUpdate(testRole), Times.Once());
            repoRoles.Verify(_ => _.Evict(testRole), Times.Once());
        }
    }
}
