using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prizm.Domain.Entity;
using FluentNHibernate.Mapping;

namespace Prizm.Data.DAL.Mapping
{
    public class PartMap : SubclassMap<Part>
    {
        public PartMap()
        {
            Map(x => x.Number).Column("number");
            Map(x => x.Length).Column("length");
            Map(x => x.IsAvailableToJoint).Column("isAvailableToJoint");

            Map(x => x.InspectionStatus).Column("inspectionStatus");
            Map(x => x.ConstructionStatus).Column("constructionStatus");
        }
    }
}
