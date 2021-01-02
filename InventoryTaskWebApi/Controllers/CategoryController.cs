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
    public class CategoryController : ApiController
    {
        public void Post(Category obj)
        {
            ICategoryRepository ObjCatg = new CategoryRepository();
            ObjCatg.Insert(obj);
        }

        public List<Category> Get()
        {
            ICategoryRepository ObjCatg = new CategoryRepository();
            return ObjCatg.LoadAll();
        }
        [HttpPost]
        public void Delete(int ID)
        {
            ICategoryRepository ObjCatg = new CategoryRepository();
            ObjCatg.Delete(ID);
        }

        [HttpGet]
        public Category Load(int ID)
        {
            ICategoryRepository ObjCatg = new CategoryRepository();
            return ObjCatg.Load(ID);
        }

        [HttpPost]
        [Route("Category/Update")]
        public void Update(Category obj)
        {
            ICategoryRepository ObjCatg = new CategoryRepository();
            ObjCatg.Update(obj);
        }
    }
}
