using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

using System.ComponentModel;


namespace Data.DAL.Hibernate
{
    public class HibernateUtil
    {
        private static ISessionFactory sessionFactory;

        public static void Initialize(string connectionString)
        {
            
            sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(connectionString)
                
                .ShowSql())
                
                .Mappings(_ => _.FluentMappings.AddFromAssemblyOf<HibernateUtil>())
                .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return sessionFactory.OpenSession();
        }
    }
}