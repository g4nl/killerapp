using domain.interfaces.dal;
using domain.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal.repositories
{
    public class UserRepository : IUserRepository
    {
        IUserRepository ctx = new contexts.UserContext();

        public void create(User entity)
        {
            ctx.create(entity);
        }

        public void delete(User entity)
        {
            ctx.delete(entity);
        }

        public void deleteById(int id)
        {
            ctx.deleteById(id);
        }

        public User login(string username, string password)
        {
            return ctx.login(username, password);
        }

        public User read(int id)
        {
            return ctx.read(id);
        }

        public IEnumerable<User> readAll()
        {
            return ctx.readAll();
        }

        public void udate(User entity)
        {
            ctx.udate(entity);
        }
    }
}
