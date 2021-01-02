using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryTaskDataAccess.Entities;

namespace InventoryTaskBusinessLogic.SpecificRepository
{
    public interface ICategoryRepository
    {
        void Insert(Category obj);
        List<Category> LoadAll();
        void Delete(int ID);
        void Update(Category obj);
        Category Load(int ID);
    }
}
