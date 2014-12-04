using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class TestResult <T> : Item
    {
        public virtual DateTime? Date { get; set; }
        public virtual string Value { get; set; }
        public virtual  T Status { get; set; }
        public virtual IList<Inspector> Inspectors { get; set; }

        public virtual int Order { get; set; }

        public TestResult()
        {
            this.Inspectors = new List<Inspector>();
        }
    }
}
