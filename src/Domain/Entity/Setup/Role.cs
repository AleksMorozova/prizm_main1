using System;
using System.Collections.Generic;

namespace Domain.Entity.Setup
{
    public class Role
    {
        protected Role()
        {
            this.Users = new List<User>();
        }

        public virtual int RoleID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
