using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryTaskDataAccess.Entities;
using InventoryTaskDataAccess.DTO;


namespace InventoryTaskBusinessLogic.SpecificRepository
{
    public interface IAttributeRepository
    {
        //List<Attributes> LoadAll();
        List<VMattribute> LoadData();
    }
}
