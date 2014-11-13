using System.Collections.Generic;

namespace Domain.Entity.Setup
{
    public class User
    {
        public User()
        {
            this.Roles = new List<Role>();
        }

        public virtual int UserID { get; set; }
        public virtual string Login { get; set; }
        public virtual string Password { get; set; }
        public virtual PersonName Name { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}