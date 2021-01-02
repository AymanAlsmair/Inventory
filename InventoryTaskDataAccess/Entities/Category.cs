using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTaskDataAccess.Entities
{
    public class Category
    {
        public int ID { set; get; }
        public string Category_Name { set; get; }
        public string Status { set; get; }
    }
}
