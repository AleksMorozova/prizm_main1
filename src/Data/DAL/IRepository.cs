using System;
using System.Collections.Generic;

namespace Data.DAL
{
    public interface IRepository<TKey, TEntity> : IDisposable where TEntity : class
    {
        TEntity Get(TKey key);
        IList<TEntity> GetAll();
        IList<TEntity> GetByCriteria(NHibernate.Criterion.DetachedCriteria criteria);
        void Clear();
        void Save(TEntity entity);
        void SaveOrUpdate(TEntity entity);
        void Merge(TEntity entity);
        void Delete(TEntity entity);
        void Evict(TEntity entity);
        void Flush();
        void BeginTransaction();
        void Commit();
        void Rollback();
        bool IsTransactionActive();

    }
}