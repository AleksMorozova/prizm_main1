using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    // TODO: Name convert Funtion (property)
    public class PersonName : Entity
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string MiddleName { get; set; }

        public string GetFullName() 
        {
            throw new NotImplementedException();
        }

        public string GetShortName()
        {
            throw new NotImplementedException();
        }
    }
}
