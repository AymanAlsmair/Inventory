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
    public class CountryRepository : ICountryRepository
    {
        public List<Country> LoadAll()
        {
            IGeneric<Country> AttObj = new Generic<Country>();
            return AttObj.LoadAll();
        }
    }
}
