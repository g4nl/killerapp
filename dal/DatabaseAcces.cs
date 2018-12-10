using domain.interfaces.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public static class DatabaseAcces
    {
        public static IUserRepository user = new repositories.UserRepository();
    }
}
