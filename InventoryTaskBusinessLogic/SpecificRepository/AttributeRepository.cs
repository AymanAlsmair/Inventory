using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryTaskDataAccess.Entities;
using InventoryTaskDataAccess.Context;
using InventoryTaskDataAccess.Generic;
using InventoryTaskDataAccess.DTO;

namespace InventoryTaskBusinessLogic.SpecificRepository
{
    public class AttributeRepository : IAttributeRepository
    {
        public List<VMattribute> LoadData()
        {
            InventoryContext context = new InventoryContext();
            List<VMattribute> li = new List<VMattribute>();
            Attributes att = new Attributes();


                var x = from D in context.att
                        join E in context.att_val
                        on D.ID equals E.att_id into G
                        select new
                        {D.ID, ATTRIBUTE_Name = D.ATTRIBUTE_Name, Status = D.Status, count = G.Count() };

            
            
            foreach (var item in x)
            {
                VMattribute obj = new VMattribute();
                obj.attVM = new Attributes();
                obj.attVM.ID = item.ID;
                obj.attVM.ATTRIBUTE_Name = item.ATTRIBUTE_Name;
                obj.attVM.Status = item.Status;
                obj.count = item.count;
                
                li.Add(obj);

            }
            return li;
        }
    }
}
