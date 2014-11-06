using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Mill
{
    public class PipeTestResult : Entity
    {
        public virtual PipeTest Operation { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual ICollection<Inspector> Inspectors { get; set; }


        public virtual ICollection<Pipe> Pipes { get; set; }

        protected PipeTestResult()
        {
            this.Pipes = new List<Pipe>();
            this.Inspectors = new List<Inspector>();
        }
    }
}
