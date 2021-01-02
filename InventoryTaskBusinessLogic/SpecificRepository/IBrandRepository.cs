using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryTaskDataAccess.Entities;

namespace InventoryTaskBusinessLogic.SpecificRepository
{
    public interface IBrandRepository
    {
        void Insert(Brand obj);
        List<Brand> LoadAll();
        void Delete(int ID);
        void Update(Brand obj);
        Brand Load(int ID);
    }
}
