using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryTaskDataAccess.Entities;


namespace InventoryTaskBusinessLogic.SpecificRepository
{
    public interface IProductRepository
    {
        void Insert(Product obj);
        List<Product> LoadAll();
        void Update(Product obj);
        Product Load(int ID);
        void Delete(int ID);
    }
}
