using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Domain.Entity.Setup
{
    public class PipeTestFrequency:Item
    {
        public virtual int Quantaty { get; set; }
        public virtual FrequencyMeasure Measure { get; set; }
    }
}
