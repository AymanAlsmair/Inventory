using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTaskDataAccess.Generic
{
    public interface IGeneric<T> where T: class
    {
        void Insert(T obj);
        void Update(T obj);
        void Delete(int ID);
        T Load(int ID);
        List<T> LoadAll();
    }
}
