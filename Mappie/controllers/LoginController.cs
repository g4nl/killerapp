using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappie.controllers
{
    public class LoginController
    {
        public static void Login(string username, string password)
        {
            logic.LoginLogic.login(username, password);
        }
    }
}
