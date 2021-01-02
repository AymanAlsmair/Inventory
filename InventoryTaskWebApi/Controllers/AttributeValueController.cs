using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using InventoryTaskDataAccess.Entities;
using InventoryTaskBusinessLogic.SpecificRepository;


namespace InventoryTaskWebApi.Controllers
{
    public class AttributeValueController : ApiController
    {
        public void Post(AttributeValue obj)
        {
            IAttributeValueRepository ObjAttVal = new AttributeValueRepository();
            ObjAttVal.Insert(obj);
        }

        public List<AttributeValue> Get(int ID)
        {
            IAttributeValueRepository ObjAttVal = new AttributeValueRepository();
            return ObjAttVal.LoadTab(ID);
        }
        [HttpPost]
        public void Delete(int ID)
        {
            IAttributeValueRepository ObjAttVal = new AttributeValueRepository();
            ObjAttVal.Delete(ID);
        }
        [HttpPost]
        [Route("AttributeValue/Update")]
        public void Update(AttributeValue obj)
        {
            IAttributeValueRepository ObjAttVal = new AttributeValueRepository();
            ObjAttVal.Update(obj);
        }

        [HttpGet]
        [Route("AttributeValue/Load")]
        public AttributeValue Load(int ID)
        {
            IAttributeValueRepository ObjAttVal = new AttributeValueRepository();
            return ObjAttVal.Load(ID);
        }
    }
}
