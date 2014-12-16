﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using PrizmMain.Documents;
using PrizmMain.Forms;
using Data.DAL.Construction;
using Data.DAL.Setup;
using Data.DAL.Mill;
using PrizmMain.Forms.Joint;
using PrizmMain.Forms.Joint.NewEdit;
using Data.DAL;
using Domain.Entity.Setup;
using System.ComponentModel;

namespace UnitTests.Forms.Joint.NewEdit
{

    [TestFixture]
    class JointNewEditCommandTest
    {
        [Test]
        public void TestJointNewEdit()
        {
            var modifiableView = new Mock<IModifiable>();
            var notify = new Mock<IUserNotify>();
            var repoJoint = new Mock<IJointRepository>();
            var repoJointTestResult = new Mock<IJointTestResultRepository>();
            var repoJointWeldResult = new Mock<IJointWeldResultRepository>();
            var repoJointOperation =  new Mock< IJointOperationRepository>();
            var repoInspector = new Mock<IInspectorRepository>();
            var repoWelder = new Mock<IWelderRepository>();
            var repoAdo = new Mock<IMillReportsRepository>();

            var joint = new Domain.Entity.Construction.Joint();
            BindingList<JointOperation> operations = new BindingList<JointOperation>(); 

            Mock<IConstructionRepository> repoConstruction = new Mock<IConstructionRepository>();
            repoConstruction.SetupGet(_ => _.RepoJoint).Returns(repoJoint.Object);
            repoConstruction.SetupGet(_ => _.RepoJointTestResult).Returns(repoJointTestResult.Object);
            repoConstruction.SetupGet(_ => _.RepoJointWeldResult).Returns(repoJointWeldResult.Object);
            repoConstruction.SetupGet(_ => _.RepoJointOperation).Returns(repoJointOperation.Object);
            repoConstruction.SetupGet(_ => _.RepoInspector).Returns(repoInspector.Object);
            repoConstruction.SetupGet(_ => _.RepoWelder).Returns(repoWelder.Object);
            repoJointOperation.Setup(_ => _.GetControlOperations()).Returns(operations);
            repoJointOperation.Setup(_ => _.GetRepairOperations()).Returns(operations);

            modifiableView.SetupGet(x => x.IsModified).Returns(false);

            var viewModel = new JointNewEditViewModel(repoConstruction.Object, notify.Object, Guid.Empty, repoAdo.Object);
            viewModel.Joint = joint;
            viewModel.ModifiableView = modifiableView.Object;
            var command = new SaveJointCommand(repoConstruction.Object,viewModel, notify.Object);
            command.Execute();
            repoConstruction.Verify(_ => _.BeginTransaction(), Times.Once());
            repoJoint.Verify(_ => _.SaveOrUpdate(It.IsAny<Domain.Entity.Construction.Joint>()), Times.Once());
            repoConstruction.Verify(_ => _.Commit(), Times.Once());
            repoJoint.Verify(_ => _.Evict(It.IsAny<Domain.Entity.Construction.Joint>()), Times.Once());
        }
    }
}
