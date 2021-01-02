using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using InventoryTaskDataAccess.Entities;
using InventoryTaskBusinessLogic.SpecificRepository;
using InventoryTaskDataAccess.DTO;



namespace InventoryTaskWebApi.Controllers
{
    public class AttributesController : ApiController
    {
        //public List<Attributes> Get()
        //{
        //    IAttributeRepository Objatt = new AttributeRepository();
        //    return Objatt.LoadAll();
        //}

        public List<VMattribute> Get()
        {
            IAttributeRepository Objatt = new AttributeRepository();
            return Objatt.LoadData();
        }
    }
}
