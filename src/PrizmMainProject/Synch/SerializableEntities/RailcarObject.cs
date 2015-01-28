using Prizm.Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prizm.Main.Synch.SerializableEntities
{
   [XmlType("Railcar")]
   public class RailcarObject
   {
      public RailcarObject()
      {
      }

      public RailcarObject(Railcar railcar)
      {
         this.Id = railcar.Id;
         this.IsActive = railcar.IsActive;
         this.Number = railcar.Number;
         this.Certificate = railcar.Certificate;
         this.Destination = railcar.Destination;
         this.IsShipped = railcar.IsShipped;
         this.ReleaseNote = railcar.ReleaseNote;
      }

      public static implicit operator RailcarObject(Railcar railcar)
      {
         return railcar != null ? new RailcarObject(railcar) : null;
      }

      [XmlAttribute("Id")]
      public Guid Id { get; set; }

      [XmlAttribute("IsActive")]
      public bool IsActive { get; set; }

      [XmlAttribute("Number")]
      public string Number { get; set; }

      [XmlAttribute("Certificate")]
      public string Certificate { get; set; }

      [XmlAttribute("Destination")]
      public string Destination { get; set; }

      [XmlAttribute("ShippingDate")]
      public DateTime ShippingDate { get; set; }

      [XmlAttribute("IsShipped")]
      public bool IsShipped { get; set; }

      [XmlAttribute("ReleaseNote")]
      public ReleaseNote ReleaseNote { get; set; }

   }
}
