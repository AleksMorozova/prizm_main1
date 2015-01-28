using Prizm.Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prizm.Main.Synch.SerializableEntities
{
    [XmlType("ReleaseNote")]
    public class ReleaseNoteObject
    {
        public ReleaseNoteObject()
        {
        }

        public ReleaseNoteObject(ReleaseNote releaseNote)
        {
          this.Id = releaseNote.Id;
          this.IsActive = releaseNote.IsActive;
          this.Number = releaseNote.Number;
          this.Date = releaseNote.Date;
          this.Shipped = releaseNote.Shipped;
        }
        public static implicit operator ReleaseNoteObject(ReleaseNote releaseNote)
        {
            return releaseNote != null ? new ReleaseNoteObject(releaseNote) : null;
        }

        [XmlAttribute("Id")]
        public Guid Id { get; set; }

        [XmlAttribute("IsActive")]
        public bool IsActive { get; set; }

        [XmlAttribute("Number")]
        public string Number { get; set; }

        [XmlAttribute("Date")]
        public DateTime Date { get; set; }

        [XmlAttribute("Shipped")]
        public bool Shipped { get; set; }

    }
}
