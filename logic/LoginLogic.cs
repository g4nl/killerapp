using dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    public class LoginLogic
    {
        public static bool login (string username, string password)
        {
            return (DatabaseAcces.user.login(username, password) != null);
        }
    }
}
