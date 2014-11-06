using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Mill
{
    public class Heat : Entity
    {
        public virtual PhysicalParameters PhysicalParameters { get; set; }
        public virtual ChemicalComposition ChemicalComposition { get; set; }
        public virtual ICollection<Plate> Plates { get; set; }

        protected Heat()
        {
            this.Plates = new List<Plate>();
        }
    }
}
