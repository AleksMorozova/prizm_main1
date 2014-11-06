using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Mill
{
    public class Weld : Entity
    {
        public virtual DateTime Date { get; set; }
        public virtual ICollection<Welder> Welders { get; set; }

        protected Weld()
        {
            this.Welders = new List<Welder>();
        }
    }
}
