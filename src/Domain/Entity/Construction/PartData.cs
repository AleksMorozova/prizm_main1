using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity.Construction
{
    public class PartData
    {
        public virtual Guid Id { get; set; }
        public virtual PartType PartType { get; set; }
        public virtual string Number { get; set; }
        public virtual string PartTypeDescription { get; set; }
        public virtual int Length { get; set; }
        public virtual float WallThickness { get; set; }
        public virtual int Diameter { get; set; }
                       

    }
}
