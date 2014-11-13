using System;

namespace Domain.Entity.Mill
{
    public class Railcar : Item
    {
        public virtual string Number { get; set; }
        public virtual string Certificate { get; set; }
        public virtual string Destination { get; set; }
        public virtual DateTime ShippingDate { get; set; }
        public virtual DateTime DeliveryDate { get; set; }

        //TODO: back reference to pipes
    }
}