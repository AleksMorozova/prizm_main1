using NHibernate;
using System.Collections.Generic;

namespace Data.DAL.Hibernate
{
    public abstract class AbstractHibernateRepository<TKey, TEntity> : IRepository<TKey, TEntity>
        where TEntity : class
    {
        protected readonly ISession session;

        protected AbstractHibernateRepository(ISession session)
        {
            this.session = session;
        }

        public TEntity Get(TKey key)
        {
            return session.Get<TEntity>(key);
        }

        public void Save(TEntity entity)
        {
            session.Save(entity);
        }

        public IList<TEntity> GetAll()
        {
            return session.CreateCriteria<TEntity>().List<TEntity>();
        }

        public IList<TEntity> GetByCriteria(NHibernate.Criterion.DetachedCriteria criteria)
        {
            return criteria.GetExecutableCriteria(session).List<TEntity>();
        }

        public void SaveOrUpdate(TEntity entity)
        {
            session.SaveOrUpdate(entity);
        }

        public void Delete(TEntity entity)
        {
            session.Delete(entity);
        }

        public void Evict(TEntity entity)
        {
            session.Evict(entity);
        }

        public void Flush()
        {
            session.Flush();
        }

        public void Commit()
        {
            if (IsTransactionActive())
            {
                session.Transaction.Commit();
            }
        }

        public void Rollback()
        {
            if (IsTransactionActive())
            {
                session.Transaction.Rollback();
            }
        }

        public void BeginTransaction()
        {
            session.BeginTransaction();
        }

        public bool IsTransactionActive()
        {
            return session.Transaction.IsActive;
        }

        public void Dispose()
        {
            session.Dispose();
        }
    }
}