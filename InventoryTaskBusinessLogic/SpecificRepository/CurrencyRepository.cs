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
    public class CurrencyRepository : ICurrencyRepository
    {
        public List<Currency> LoadAll()
        {
            IGeneric<Currency> AttObj = new Generic<Currency>();
            return AttObj.LoadAll();
        }
    }
}
