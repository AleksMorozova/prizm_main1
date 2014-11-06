using Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Welder : Entity
    {
        public virtual string Certificate { get; set; }
        public virtual DateTime CertificateExpitation { get; set; }
        public virtual string Stamp { get; set; }
        public virtual int Grade { get; set; }

        public virtual PersonName Name { get; set; }
        public ICollection<Weld> Welds { get; set; }

        protected Welder()
        {
            this.Welds = new List<Weld>();
        }
    }
}
