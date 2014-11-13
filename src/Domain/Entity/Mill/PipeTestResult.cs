using System;
using System.Collections.Generic;

namespace Domain.Entity.Mill
{
    public class PipeTestResult : Item
    {
        public PipeTestResult()
        {
            this.Pipes = new List<Pipe>();
            this.Inspectors = new List<Inspector>();
        }

        public virtual PipeTest Operation { get; set; }
        public virtual DateTime Date { get; set; }

        public virtual ICollection<Inspector> Inspectors { get; set; }
        public virtual ICollection<Pipe> Pipes { get; set; }
    }
}