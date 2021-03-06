﻿using Prizm.Data.DAL.Mill;
using Prizm.Domain.Entity.Mill;
using NHibernate;
using NHibernate.Exceptions;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Hibernate
{
    public class PurchaseOrderRepository : AbstractHibernateRepository<Guid, PurchaseOrder>, IPurchaseOrderRepository
    {
        [Inject]
        public PurchaseOrderRepository(ISession session)
            : base(session)
        {

        }

        public PurchaseOrder GetByNumber(string number)
        {
            try
            {
                return session.QueryOver<PurchaseOrder>().Where(_ => _.Number == number).Take(1).SingleOrDefault();
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("GetByNumber", ex);
            }
        }
    }
}
