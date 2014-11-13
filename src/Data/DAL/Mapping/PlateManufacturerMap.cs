using Domain.Entity.Mill;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Mapping
{
    public class PlateManufacturerMap : SubclassMap<PlateManufacturer>
    {
        public PlateManufacturerMap()
        {
            Table("PlateManufacturer");
            Map(_ => _.Number).Column("number");
            HasMany(_ => _.Heats).KeyColumn("id").Inverse();
        }
    }
}
