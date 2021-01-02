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
    public class BrandRepository : IBrandRepository
    {
        public void Insert(Brand obj)
        {
            IGeneric<Brand> AttObj = new Generic<Brand>();
            AttObj.Insert(obj);
        }

        public List<Brand> LoadAll()
        {
            IGeneric<Brand> AttObj = new Generic<Brand>();
            return AttObj.LoadAll();
        }

        public void Delete(int ID)
        {
            IGeneric<Brand> AttObj = new Generic<Brand>();
            AttObj.Delete(ID);
        }

        public void Update(Brand obj)
        {
            IGeneric<Brand> AttObj = new Generic<Brand>();
            AttObj.Update(obj);
        }

        public Brand Load(int ID)
        {
            IGeneric<Brand> AttObj = new Generic<Brand>();
            return AttObj.Load(ID);
        }
    }
}
