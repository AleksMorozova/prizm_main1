using System;
using System.Collections.Generic;

namespace Domain.Entity.Mill
{
    public class PurchaseOrder : Item
    {
        public PurchaseOrder()
        {
            this.Pipes = new List<Pipe>();
        }

        public virtual string Number { get; set; }
        public virtual DateTime Date { get; set; }

        public virtual ICollection<Pipe> Pipes { get; set; }
    }
}