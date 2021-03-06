﻿using System;
using System.Collections.Generic;

namespace Prizm.Domain.Entity.Mill
{
    public class PurchaseOrder : Item
    {
        public PurchaseOrder()
        {
            this.Pipes = new List<Pipe>();
        }

        public virtual string Number { get; set; }
        public virtual DateTime Date { get; set; }

        public virtual IList<Pipe> Pipes { get; set; }

        public override string ToString()
        {
            return Number;
        }
    }
}