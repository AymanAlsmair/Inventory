using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryTaskDataAccess.Entities;


namespace InventoryTaskBusinessLogic.SpecificRepository
{
    public interface IOrderRepository
    {
        void Insert(Order obj);
        List<Order> LoadAll();
        void Update(Order obj);
        Order Load(int ID);
        void Delete(int ID);
    }
}
