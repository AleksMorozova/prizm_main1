using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Setup
{
    public class User
    {
        protected User()
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
