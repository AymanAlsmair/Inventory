using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryTaskDataAccess.Entities;

namespace InventoryTaskBusinessLogic.SpecificRepository
{
    public interface ICompanyRepoitory
    {
        void Insert(Company obj);
        Company Load(int ID);
    }
}
