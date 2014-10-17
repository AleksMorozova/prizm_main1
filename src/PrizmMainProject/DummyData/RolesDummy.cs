using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.DummyData
{
    public class RolesDummy
    {
        public BindingList<Privilege> GetAllPrivileges() 
        {
            return new BindingList<Privilege>
            {
                new Privilege{Id=0,Name="millset",Description="Can setup mill"},
                new Privilege{Id=1,Name="construct",Description="Can setup constructions"},
                new Privilege{Id=2,Name="useredit",Description="Can edit user"},
                new Privilege{Id=3,Name="roleedit",Description="Can edit user role"},
                new Privilege{Id=4,Name="addpipe",Description="Can add pipe in mill"},
                new Privilege{Id=5,Name="addcomponent",Description="Can add componentry"},
                new Privilege{Id=6,Name="editdic",Description="Can edit dictionary"},
                new Privilege{Id=7,Name="addjoint",Description="Can add joint"},
                new Privilege{Id=8,Name="editjoint",Description="Can  edit  joint"},
                new Privilege{Id=9,Name="deljoi",Description="Can delete joint"},
                new Privilege{Id=10,Name="deluser",Description="Can delete user"}
            };
        }

        public BindingList<Role> GetRoles() 
        {
            var priveleges = GetAllPrivileges();

            var roles = new BindingList<Role>
            {
                new Role 
                {
                    Id = 0, Name="Administrator", Description = "syestem administrator",
                    Privileges = new BindingList<Privilege>
                    {
                        priveleges[0],priveleges[3],priveleges[5],priveleges[2],priveleges[8]
                    },
                },

                new Role 
                {
                    Id = 1, Name="Operator", Description = "program operator",
                    Privileges = new BindingList<Privilege>
                    {
                        priveleges[3],priveleges[2],priveleges[5],priveleges[7],priveleges[8]
                    },
                },

                new Role 
                {
                    Id = 2, Name="Inspector", Description = "construction inspector",
                    Privileges = new BindingList<Privilege>
                    {
                        priveleges[1],priveleges[2],priveleges[4],priveleges[9],priveleges[10]
                    },
                },

                new Role 
                {
                    Id = 3, Name="Auditor", Description = "audit manager",
                    Privileges = new BindingList<Privilege>
                    {
                        priveleges[6],priveleges[5],priveleges[8],priveleges[7],priveleges[3]
                    },
                },

            };

            return roles;
        }

        public Role GetRole(int id) 
        {
            var roles = GetRoles();
            return roles[0];
        }

    }

    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<Privilege> Privileges { get; set; }

        public bool Equals(Role other)
        {
            if (this.Id == other.Id) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    public class Privilege
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
    }
}
