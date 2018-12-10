using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.interfaces.dal
{
    public interface ICRUD<T>
    {
        void create(T entity);
        T read(int id);
        IEnumerable<T> readAll();
        void udate(T entity);
        void delete(T entity);
        void deleteById(int id);
    }
}
