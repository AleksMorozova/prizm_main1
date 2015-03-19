﻿using Prizm.Data.DAL.Construction;
using Prizm.Domain.Entity.Construction;
using NHibernate;
using NHibernate.Exceptions;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;

namespace Prizm.Data.DAL.Hibernate
{
    public class JointRepository : AbstractHibernateRepository<Guid, Joint>, IJointRepository
    {
        [Inject]
        public JointRepository(ISession session)
            : base(session)
        {
        }
        
        #region IJointRepository Members
        
        public IList<Joint> GetActiveByNumber(Joint joint)
        {
            try
            {
                return session.QueryOver<Joint>().Where(_ => _.IsActive == true && _.Id != joint.Id && _.Number == joint.Number).List<Joint>();
            }
            catch (GenericADOException ex)
            {
                throw new RepositoryException("GetActiveByNumber", ex);
            }
        }

        public IList<Joint> GetJointsToExport()
        {
           try
           {
              return session.QueryOver<Joint>().Where(_ => _.ToExport).List<Joint>();
           }
           catch (GenericADOException ex)
           {
              throw new RepositoryException("GetJointsToExport", ex);
           }
        }

        public IList<JointBindingObject> QuickSearchByNumber(string number)
        {
           //var result = session.QueryOver<Joint>().WhereRestrictionOn(n => n.Number).IsLike(number, MatchMode.Start)
           //    .Select(Projections.ProjectionList()
           //                 .Add(Projections.Property("Id"), "id")
           //                 .Add(Projections.Property("Number"), "number"));
           //return result.List<Joint>;
            ICriteria crit = session.CreateCriteria<Joint>()
                        .SetProjection(Projections.ProjectionList()
                            .Add(Projections.Property("Id"), "id")
                            .Add(Projections.Property("Number"), "Number"))
                        .SetResultTransformer(Transformers.AliasToBean<JointBindingObject>());
            IList<JointBindingObject> results = crit.List<JointBindingObject>();
            return results;
        }

        public IList<Joint> SearchJoint(string jointNumber, IList<JointStatus> statuses, DateTime? from, DateTime? to, string peg, bool? status)
        {

            var jointWithWeld = QueryOver.Of<Joint>()
                .JoinQueryOver<JointWeldResult>(j => j.JointWeldResults)
                .Select(Projections.Distinct(Projections.Property<Joint>(j => j.JointWeldResults)));
            if(from != null && from != DateTime.MinValue)
            {
                jointWithWeld.Where(f => f.Date >= from);
            }
            if(to != null && to != DateTime.MinValue)
            {
                jointWithWeld.Where(t => t.Date <= to);
            }

            
            var q = session.QueryOver<Joint>();
            // joint number
            if(!string.IsNullOrWhiteSpace(jointNumber))
            {
                q.WhereRestrictionOn(n => n.Number).IsLike(jointNumber, MatchMode.Start);
            }
            // statuses
            if (statuses != null)
            {
                q.WhereRestrictionOn(x => x.Status).IsIn(statuses.ToArray());
            }
            // status
            if(status != null)
            {
                q.Where(x => x.IsActive == status);
            }
            //peg
            if(!string.IsNullOrWhiteSpace(peg))
            {
                int number = Convert.ToInt32(peg);
                q.Where(x => x.NumberKP == number);
            }

            
            q.WithSubquery
                .WhereProperty(j => j.JointWeldResults)
                .In(jointWithWeld);


            return q.List<Joint>();
        }

        #endregion
    }

    public class JointBindingObject
    {
        public virtual Guid Id { get; set; }
        public virtual string Number { get; set; }
    }
}
