using Prizm.Domain.Entity.Construction;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Mapping
{
    public class ConnectorMap : SubclassMap<Connector>
    {
        public ConnectorMap()
        {
            Map(_ => _.Diameter).Column("diameter");
            Map(_ => _.WallThickness).Column("wallThickness");

            References<Joint>(x => x.Joint).Column("jointId").Cascade.All();
            References<Component>(x => x.Component).Column("componentId");
        }
    }
}
