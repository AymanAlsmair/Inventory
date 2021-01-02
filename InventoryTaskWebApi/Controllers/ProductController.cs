using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using InventoryTaskDataAccess.Entities;
using InventoryTaskBusinessLogic.SpecificRepository;


namespace InventoryTaskWebApi.Controllers
{
    public class ProductController : ApiController
    {
        public void Post(Product obj)
        {
            IProductRepository ObjPro = new ProductRepository();
            ObjPro.Insert(obj);
        }
        public List<Product> Get()
        {
            IProductRepository ObjPro = new ProductRepository();
            return ObjPro.LoadAll();
        }

        [HttpGet]
        public Product Load(int ID)
        {
            IProductRepository ObjPro = new ProductRepository();
            return ObjPro.Load(ID);
        }

        [HttpPost]
        [Route("Product/Update")]
        public void Update(Product obj)
        {
            IProductRepository ObjPro = new ProductRepository();
            ObjPro.Update(obj);
        }

        [HttpPost]
        public void Delete(int ID)
        {
            IProductRepository ObjPro = new ProductRepository();
            ObjPro.Delete(ID);
        }

        [HttpPost]
        [Route("api/Product/UploadFiles")]
        public string UploadFiles()
        {
            HttpPostedFile file = HttpContext.Current.Request.Files[0];
            string rootPath = "~/UploadImage/" + file.FileName;
            string path = rootPath.Substring(1);
            file.SaveAs(HttpContext.Current.Server.MapPath(rootPath));
            return path;
        }
    }
}
