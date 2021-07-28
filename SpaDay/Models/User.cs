using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        //public string DateTime = 
        public User()
        {

        }

        public User(string u, string e, string p)
        {
            Username = u;
            Email = e;
            Password = p;
        }

    }
}
