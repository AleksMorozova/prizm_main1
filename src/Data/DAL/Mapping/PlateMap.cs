using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity.Mill;
using FluentNHibernate.Mapping;

namespace Data.DAL.Mapping
{
    public class PlateMap: SubclassMap<Plate>
    {
        public PlateMap()
        {
            Map(x => x.Number).Column("number");
            Map(x => x.Thickness).Column("thickness");


            References(x => x.Heat).Column("heatId").Cascade.None();

            HasOne(x => x.Pipe).Cascade.All().PropertyRef("Plate");


        }
    }
}
