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
        public static void login (string username, string password)
        {
            DatabaseAcces.user.login(username, password);
        }
    }
}
