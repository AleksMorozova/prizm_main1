using Moq;
using NUnit.Framework;
using Prizm.Main.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.UnitTests.Commands
{
   [TestFixture]
   public class CommandInfoTest
   {
      [Test]
      public void TestExecute()
      {
         Mock<ICommand> testCommand = new Mock<ICommand>();
         testCommand.Setup(c => c.CanExecute()).Returns(true);

         CommandInfo ci = new CommandInfo();
         ci.Executor(testCommand.Object);
         ci.Execute();

         testCommand.Verify(c => c.Execute(), Times.Once());
      }

      [Test]
      public void TestExecuteWhenCanExecuteIsFalse()
      {
         Mock<ICommand> testCommand = new Mock<ICommand>();
         testCommand.Setup(c => c.CanExecute()).Returns(false);

         CommandInfo ci = new CommandInfo();
         ci.Executor(testCommand.Object);
         ci.Execute();

         testCommand.Verify(c => c.Execute(), Times.Never());
      }

      [Test]
      [ExpectedException(typeof(InvalidOperationException))]
      public void TestExecuteWithoutExecutor()
      {
         CommandInfo ci = new CommandInfo();
         ci.Execute();
      }

      [Test]
      public void TestCanExecute()
      {
         Mock<ICommand> testCommand = new Mock<ICommand>();
         testCommand.Setup(c => c.CanExecute()).Returns(true);

         CommandInfo ci = new CommandInfo();
         ci.Executor(testCommand.Object);
         bool canExec = ci.CanExecute();

         Assert.IsTrue(canExec);

         testCommand.Verify(c => c.CanExecute(), Times.Once());
      }
      
      [Test]
      public void TestCanExecuteWithoutExecutor()
      {
         CommandInfo ci = new CommandInfo();
         bool canExec = ci.CanExecute();
         Assert.IsFalse(canExec);
      }

      [Test]
      public void TestRefreshState()
      {
         var attacher = new Mock<IAttacher>();
         CommandInfo ci = new CommandInfo();
         ci.AttachTo(attacher.Object);

         ci.RefreshState();
         attacher.Verify(a => a.RefreshState(), Times.Once());
      }

      [Test]
      public void TestDisposeDestroyAttachers()
      {
         var attacher = new Mock<IAttacher>();
         CommandInfo ci = new CommandInfo();
         ci.AttachTo(attacher.Object);

         ci.Dispose();
         attacher.Verify(a => a.Dispose(), Times.Once());
      }
   }
}
