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
    public class StoreController : ApiController
    {
        public void Post(Store obj)
        {
            IStoreRepository ObjStor = new StoreRepository();
            ObjStor.Insert(obj);
        }
        public List<Store> Get()
        {
            IStoreRepository ObjStor = new StoreRepository();
            return ObjStor.LoadAll();
        }
        [HttpPost]
        public void Delete(int ID)
        {
            IStoreRepository ObjStor = new StoreRepository();
            ObjStor.Delete(ID);
        }
        [HttpGet]
        public Store Load(int ID)
        {
            IStoreRepository ObjStor = new StoreRepository();
            return ObjStor.Load(ID);
        }

        [HttpPost]
        [Route("Store/Update")]
        public void Update(Store obj)
        {
            IStoreRepository ObjStor = new StoreRepository();
            ObjStor.Update(obj);
        }
    }
}
