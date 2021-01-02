using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryTaskDataAccess.Entities;

namespace InventoryTaskDataAccess.DTO
{
    public class VMattribute
    {
        public Attributes attVM { set; get; }
        public int count { set; get; }
    }
}
