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
    public class AttributeValueRepository : IAttributeValueRepository
    {
        public void Insert(AttributeValue obj)
        {
            IGeneric<AttributeValue> AttObj = new Generic<AttributeValue>();
            AttObj.Insert(obj);
        }
        public List<AttributeValue> LoadTab(int ID)
        {
            InventoryContext context = new InventoryContext();
            var x = context.att_val.Where(a => a.att_id == ID);
            return x.ToList();
        }
        public void Delete(int ID)
        {
            IGeneric<AttributeValue> AttObj = new Generic<AttributeValue>();
            AttObj.Delete(ID);
        }
        public void Update(AttributeValue obj)
        {
            IGeneric<AttributeValue> AttObj = new Generic<AttributeValue>();
            AttObj.Update(obj);
        }
        public AttributeValue Load(int ID)
        {
            IGeneric<AttributeValue> AttObj = new Generic<AttributeValue>();
            return AttObj.Load(ID);
        }
    }
}
