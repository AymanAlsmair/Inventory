using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryTaskDataAccess.Entities;

namespace InventoryTaskBusinessLogic.SpecificRepository
{
    public interface IAttributeValueRepository
    {
        void Insert(AttributeValue obj);
        List<AttributeValue> LoadTab(int ID);
        void Delete(int ID);
        void Update(AttributeValue obj);
        AttributeValue Load(int ID);
    }
}
