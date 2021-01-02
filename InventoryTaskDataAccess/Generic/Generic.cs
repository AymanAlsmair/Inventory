using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryTaskDataAccess.Context;
using System.Data.Entity;

namespace InventoryTaskDataAccess.Generic
{
    public class Generic<T> : IGeneric<T> where T:class
    {
        public void Insert(T obj)
        {
            InventoryContext context = new InventoryContext();
            context.Set<T>().Add(obj);
            context.SaveChanges();
        }

        public void Update(T obj)
        {
            InventoryContext context = new InventoryContext();
            context.Set<T>().Attach(obj);
            context.Entry(obj).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int ID)
        {
            InventoryContext context = new InventoryContext();
            var a = context.Set<T>().Find(ID);
            context.Set<T>().Remove(a);
            context.SaveChanges();
        }

        public T Load(int ID)
        {
            InventoryContext context = new InventoryContext();
            return context.Set<T>().Find(ID);
        }

        public List<T> LoadAll()
        {
            InventoryContext context = new InventoryContext();
            return context.Set<T>().ToList();
        }
    }
}
