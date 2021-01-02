using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTaskDataAccess.Entities
{
    public class Currency
    {
        public int ID { set; get; }
        public string Name { set; get; }

        public List<Company> cny { set; get; }
    }
}
