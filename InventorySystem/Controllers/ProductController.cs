using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventorySystem.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index(int ID = 0)
        {
            ViewBag.ID = ID;
            return View("ProductView");
        }

        public ActionResult Manage_Product()
        {
            return View("MangPro");
        }
    }
}