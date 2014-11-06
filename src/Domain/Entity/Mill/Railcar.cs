using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Mill
{
    public class Railcar : Entity
    {
        public virtual string Number { get; set; }
        public virtual string Certificate { get; set; }
        public virtual string Destination { get; set; }
        public virtual DateTime ShippingDate { get; set; }
        public virtual DateTime DeliveryDate { get; set; }

        public virtual ICollection<Pipe> Pipes { get; set; }

        protected Railcar()
        {
            this.Pipes = new List<Pipe>();
        }
    }
}
