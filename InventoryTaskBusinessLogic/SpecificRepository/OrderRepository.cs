using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryTaskDataAccess.Entities;
using InventoryTaskDataAccess.Context;
using InventoryTaskDataAccess.Generic;


namespace InventoryTaskBusinessLogic.SpecificRepository
{
    public class OrderRepository : IOrderRepository
    {
        public void Insert(Order obj)
        {
            IGeneric<Order> AttObj = new Generic<Order>();
            AttObj.Insert(obj);
        }
        public List<Order> LoadAll()
        {
            IGeneric<Order> AttObj = new Generic<Order>();
            return AttObj.LoadAll();
        }
        public void Update(Order obj)
        {
            IGeneric<Order> AttObj = new Generic<Order>();
            AttObj.Update(obj);
        }

        public Order Load(int ID)
        {
            IGeneric<Order> AttObj = new Generic<Order>();
            return AttObj.Load(ID);
        }
        public void Delete(int ID)
        {
            IGeneric<Order> AttObj = new Generic<Order>();
            AttObj.Delete(ID);
        }
    }
}
