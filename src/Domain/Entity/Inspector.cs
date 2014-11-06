using Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Inspector : Entity
    {
        public virtual PersonName Name { get; set; }
        public virtual string Certificate { get; set; }
        public virtual DateTime CertificateExpiration { get; set; }

        public virtual ICollection<PipeTestResult> Results { get; set; }

        protected Inspector()
        {
            this.Results = new List<PipeTestResult>();  
        }
    }
}
