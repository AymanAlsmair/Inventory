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
    public class CategoryRepository : ICategoryRepository
    {
        public void Insert(Category obj)
        {
            IGeneric<Category> AttObj = new Generic<Category>();
            AttObj.Insert(obj);
        }
        public List<Category> LoadAll()
        {
            IGeneric<Category> AttObj = new Generic<Category>();
            return AttObj.LoadAll();
        }
        public void Delete(int ID)
        {
            IGeneric<Category> AttObj = new Generic<Category>();
            AttObj.Delete(ID);
        }
        public void Update(Category obj)
        {
            IGeneric<Category> AttObj = new Generic<Category>();
            AttObj.Update(obj);
        }

        public Category Load(int ID)
        {
            IGeneric<Category> AttObj = new Generic<Category>();
            return AttObj.Load(ID);
        }
    }
}
