using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity.Mill;
using FluentNHibernate.Mapping;

namespace Data.DAL.Mapping
{
    public class HeatMap: SubclassMap<Heat>
    {
        public HeatMap()
        {
            Map(x => x.Number).Column("number");

            HasMany(x => x.Plates).KeyColumn("heatId").Inverse().Cascade.All();


        }
    }
}
