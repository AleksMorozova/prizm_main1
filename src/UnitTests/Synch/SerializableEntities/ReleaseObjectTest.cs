using Moq;
using NUnit.Framework;
using Prizm.Domain.Entity.Mill;
using Prizm.Main.Synch.SerializableEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.UnitTests.Synch.SerializableEntities
{
    [TestFixture]
    public class ReleaseObjectTest
    {
        Guid id = Guid.NewGuid();
        const string NUMBER = "NUMBER";
        DateTime Date = DateTime.Now;
        ReleaseNote SetupMock()
        {
            Mock<ReleaseNote> moq = new Mock<ReleaseNote>();
            moq.SetupProperty(_ => _.Id, id);
            moq.SetupProperty(_ => _.Number, NUMBER);
            moq.SetupProperty(_ => _.IsActive, true);
            moq.SetupProperty(_ => _.Date, Date);
            moq.SetupProperty(_ => _.Shipped, true);

            return moq.Object;
        }

        void AssertReleaseNote(ReleaseNoteObject releaseNote)
        {
            Assert.AreEqual(id, releaseNote.Id);
            Assert.AreEqual(NUMBER, releaseNote.Number);
            Assert.IsTrue(releaseNote.Shipped);
            Assert.IsTrue(releaseNote.IsActive);
            Assert.AreEqual(Date, releaseNote.Date);
        }

        [Test]
        public void TestReleaseNoteObjectCopyConstructor()
        {
            ReleaseNoteObject releaseNote = new ReleaseNoteObject(SetupMock());

            AssertReleaseNote(releaseNote);
        }

        [Test]
        public void TestReleaseNoteObjectCasting()
        {
            ReleaseNoteObject releaseNote = SetupMock();

            AssertReleaseNote(releaseNote);
        }
    }
}
