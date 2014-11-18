using System;
using System.Collections.Generic;
using Domain.Entity.Mill;

namespace Domain.Entity
{
    public class Welder : Item
    {
        public Welder()
        {
        }

        public virtual string Certificate { get; set; }
        public virtual DateTime? CertificateExpitation { get; set; }
        public virtual string Stamp { get; set; }
        public virtual int Grade { get; set; }
        public virtual PersonName Name { get; set; }
    }
}