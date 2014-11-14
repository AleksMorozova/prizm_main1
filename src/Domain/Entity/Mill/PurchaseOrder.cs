using System;
using System.Collections.Generic;

namespace Domain.Entity.Mill
{
    public class PurchaseOrder : Item
    {
        public PurchaseOrder(string number, DateTime date) : this()
        {
            this.Number = number;
            this.Date = date;
        }

        protected PurchaseOrder()
        {
            this.Pipes = new List<Pipe>();
        }

        public virtual string Number { get; set; }
        public virtual DateTime Date { get; set; }

        public virtual IList<Pipe> Pipes { get; set; }
    }
}