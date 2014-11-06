using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Entity
    {
        public Guid Id { get; protected set; }

        public bool IsActive { get; set; }
    }
}
