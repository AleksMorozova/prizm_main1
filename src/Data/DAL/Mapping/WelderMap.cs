using Domain.Entity;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Mapping
{
    class WelderMap : SubclassMap<Welder>
    {
        public WelderMap()
        {
            Table("Welder");
            Map(_ => _.Certificate).Column("certificate");
            Map(_ => _.CertificateExpitation).Column("certificateExpiration");
            Map(_ => _.Stamp).Column("stamp");
            Map(_ => _.Grade).Column("grade");
            Component<PersonName>(x => x.Name, m =>
               {
                  m.Map(x => x.FirstName).Column("firstName");
                  m.Map(x => x.MiddleName).Column("middleName");
                  m.Map(x => x.LastName).Column("lastName");
               });
        }
    }
}
