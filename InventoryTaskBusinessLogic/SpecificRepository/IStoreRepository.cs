using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryTaskDataAccess.Entities;

namespace InventoryTaskBusinessLogic.SpecificRepository
{
    public interface IStoreRepository
    {
        void Insert(Store obj);
        List<Store> LoadAll();
        void Delete(int ID);
        void Update(Store obj);
        Store Load(int ID);
    }
}
