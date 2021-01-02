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
    public class BrandController : ApiController
    {
        public void Post(Brand obj)
        {
            IBrandRepository ObjBrand = new BrandRepository();
            ObjBrand.Insert(obj);
        }

        
        public List<Brand> Get()
        {
            IBrandRepository ObjBrand = new BrandRepository();
            return ObjBrand.LoadAll();
        }

        [HttpPost]
        public void Delete(int ID)
        {
            IBrandRepository ObjBrand = new BrandRepository();
            ObjBrand.Delete(ID);
        }

        [HttpGet]
        public Brand Load(int ID)
        {
            IBrandRepository ObjBrand = new BrandRepository();
            return ObjBrand.Load(ID);
        }

        [HttpPost]
        [Route("Brand/Update")]
        public void Update(Brand obj)
        {
            IBrandRepository ObjBrand = new BrandRepository();
            ObjBrand.Update(obj);
        }
    }
}
