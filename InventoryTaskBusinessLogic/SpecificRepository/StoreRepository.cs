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
    public class StoreRepository : IStoreRepository
    {
        public void Insert(Store obj)
        {
            IGeneric<Store> AttObj = new Generic<Store>();
            AttObj.Insert(obj);
        }
        public List<Store> LoadAll()
        {
            IGeneric<Store> AttObj = new Generic<Store>();
            return AttObj.LoadAll();
        }
        public void Delete(int ID)
        {
            IGeneric<Store> AttObj = new Generic<Store>();
            AttObj.Delete(ID);
        }
        public void Update(Store obj)
        {
            IGeneric<Store> AttObj = new Generic<Store>();
            AttObj.Update(obj);
        }

        public Store Load(int ID)
        {
            IGeneric<Store> AttObj = new Generic<Store>();
            return AttObj.Load(ID);
        }
    }
}
