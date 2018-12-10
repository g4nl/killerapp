using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.objects
{
    public class User : StorableItem
    {
        public string Username { get; private set; }
        public string Password { get; private set; }

        public User(int id, string username, string password) : base(id)
        {
            Username = username;
            Password = password;
        }
    }
} 
