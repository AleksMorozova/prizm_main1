using Data.DAL.Mill;
using Domain.Entity.Mill;
using NHibernate;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Hibernate
{
    public class HeatRepository : AbstractHibernateRepository<Guid,Heat>, IHeatRepository
    {
        [Inject]
        public HeatRepository(ISession session)
            : base(session)
        {

        }

        public Heat GetByNumber(string number)
        {
            return session.QueryOver<Heat>().Where(n => n.Number == number).Take(1).SingleOrDefault();
        }
    }
}
