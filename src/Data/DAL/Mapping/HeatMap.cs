using Domain.Entity.Mill;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Mapping
{
    class HeatMap : SubclassMap<Heat>
    {
        public HeatMap()
        {
            Table("Heat");
            Map(_ => _.Number).Column("number");
            Map(_ => _.SteelGrade).Column("steelGrade");
            //References(_ => _.PhysicalParameters).Column("physicalParameterId").Cascade.All();
            //References(_ => _.ChemicalComposition).Column("chemicalCompositionId").Cascade.None();
            //HasMany(_ => _.Plates).KeyColumn("id").Inverse();
        }
    }
}
