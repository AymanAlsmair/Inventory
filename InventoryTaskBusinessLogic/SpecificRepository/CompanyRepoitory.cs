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
    public class CompanyRepoitory : ICompanyRepoitory
    {
        public void Insert(Company obj)
        {
            IGeneric<Company> AttObj = new Generic<Company>();
            AttObj.Insert(obj);
        }

        public Company Load(int ID)
        {
            IGeneric<Company> AttObj = new Generic<Company>();
            return AttObj.Load(ID);
        }
    }
}
