using System;

namespace Domain.Entity
{
    // TODO: Name convert Funtion (property)
    public class PersonName : Item
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string MiddleName { get; set; }

    }
}