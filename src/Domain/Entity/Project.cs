using Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    // FIX: remove??
    public class Project : Entity
    {
        public virtual string Title { get; set; }
        public virtual PersonName Client { get; set; }
        public virtual PersonName Designer { get; set; }
    }
}
