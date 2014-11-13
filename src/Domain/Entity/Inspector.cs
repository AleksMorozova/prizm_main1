using System;
using System.Collections.Generic;
using Domain.Entity.Mill;

namespace Domain.Entity
{
    public class Inspector : Item
    {
        public Inspector()
        {
            this.Results = new List<PipeTestResult>();
        }

        public virtual PersonName Name { get; set; }
        public virtual string Certificate { get; set; }
        public virtual DateTime CertificateExpiration { get; set; }

        public virtual ICollection<PipeTestResult> Results { get; set; }
    }
}