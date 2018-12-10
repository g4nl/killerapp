using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.interfaces.dal
{
    public interface IUserRepository : ICRUD<objects.User>
    {
        objects.User login(string username, string password);
    }
}
