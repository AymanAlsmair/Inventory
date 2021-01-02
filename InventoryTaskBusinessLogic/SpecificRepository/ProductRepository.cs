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
    public class ProductRepository : IProductRepository
    {
        public void Insert(Product obj)
        {
            IGeneric<Product> AttObj = new Generic<Product>();
            AttObj.Insert(obj);
        }

        public List<Product> LoadAll()
        {
            IGeneric<Product> AttObj = new Generic<Product>();
            return AttObj.LoadAll();
        }
        public void Update(Product obj)
        {
            IGeneric<Product> AttObj = new Generic<Product>();
            AttObj.Update(obj);
        }

        public Product Load(int ID)
        {
            IGeneric<Product> AttObj = new Generic<Product>();
            return AttObj.Load(ID);
        }
        public void Delete(int ID)
        {
            IGeneric<Product> AttObj = new Generic<Product>();
            AttObj.Delete(ID);
        }
    }
}
