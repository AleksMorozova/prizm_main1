<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.DummyData
{
    class UsersDummy
    {
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.DummyData
{
    public class UsersDummy
    {
        public BindingList<User> GetDummyUsers()
        {
            var role = new RolesDummy();

            var roles = new BindingList<Role>();
            roles = role.GetRoles();

            var users = new BindingList<User>
            {
                new User{Id= 0,LastName="Smirnov",FirstName="Artem",MiddleName="Egorovich",
                Login="asmir",Password="ssgdfg",Role=roles[0]},
                new User{Id= 1,LastName="Ivanov",FirstName="Alexander",MiddleName="Semenovich",
                Login="aiva",Password="xcvbgfs",Role=roles[1]},
                new User{Id= 2,LastName="Kuznetsov",FirstName="Maxim",MiddleName="Dmitryovich",
                Login="kuzma",Password="dfsgxcfg4",Role=roles[2]},
                new User{Id= 3,LastName="Sokolov",FirstName="Danil",MiddleName="Yaroslavovich",
                Login="soda",Password="xcvbnxdghs",Role=roles[3]},
                new User{Id= 4,LastName="Popov",FirstName="Mihail",MiddleName="Romanovich",
                Login="pomi",Password="seiurxcty",Role=roles[1]},
                new User{Id= 5,LastName="Lebedev",FirstName="Dmitry",MiddleName="Maximovich",
                Login="ledmi",Password="sfghvdfgh",Role=roles[2]},
                new User{Id= 6,LastName="Kozlov",FirstName="Kyril",MiddleName="Borisovich",
                Login="kyrko",Password="dgfhdfghdfg",Role=roles[3]},
                new User{Id= 7,LastName="Novikov",FirstName="Nikita",MiddleName="Pavlovich",
                Login="nino",Password="dgfhdfghdfg",Role=roles[1]},
                new User{Id= 8,LastName="Morozov",FirstName="Roman",MiddleName="Stepanovich",
                Login="romor",Password="dgfhdfghdfg",Role=roles[2]},
                new User{Id= 9,LastName="Frolov",FirstName="Yaroslav",MiddleName="Sergeevich",
                Login="froyas",Password="dgfhdfghdfg",Role=roles[3]}
        };
            return users;
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}
>>>>>>> master
