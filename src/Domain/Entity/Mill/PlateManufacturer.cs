using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Mill
{
    public class PlateManufacturer : Entity
    {
        public virtual string Name { get; set; }
        public virtual ICollection<Heat> Heats { get; set; }

        protected PlateManufacturer() 
        {
            this.Heats = new List<Heat>();
        }
     
    }
}
