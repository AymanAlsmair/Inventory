using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventorySystem.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index(int ID = 0)
        {
            
            ViewBag.ID = ID;
            return View("createorder");
        }

        public ActionResult Manage_Ordedr()
        {
            return View("ManageOrdedr");
        }
    }
}