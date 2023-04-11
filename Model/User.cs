using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimum_Tech.Model
{
    internal class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public Access Level { get; set; }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }

    enum Access 
    {
        Admin, Guest, User
    }
}
