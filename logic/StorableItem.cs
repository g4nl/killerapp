using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.objects
{
    public class StorableItem
    {
        public int Id { get; private set; }

        public StorableItem(int id)
        {
            Id = id;
        }
    }
}
