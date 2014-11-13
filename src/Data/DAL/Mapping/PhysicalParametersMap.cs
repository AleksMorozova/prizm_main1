using Domain.Entity.Mill;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Mapping
{
    class PhysicalParametersMap : SubclassMap<PhysicalParameters>
    {
        public PhysicalParametersMap()
        {
            Table("PhysicalParameters");
        }
    }
}
