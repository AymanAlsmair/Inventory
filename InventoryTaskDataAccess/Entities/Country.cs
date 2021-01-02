using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTaskDataAccess.Entities
{
    public class Country
    {
        public int ID { set; get; }
        public string Name { set; get; }

        public List<Company> comp { set; get; }
    }
}
