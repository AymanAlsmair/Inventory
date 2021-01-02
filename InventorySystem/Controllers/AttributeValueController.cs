using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventorySystem.Controllers
{
    public class AttributeValueController : Controller
    {
        // GET: AttributeValue
        public ActionResult Index(int id)
        {
            ViewBag.ID = id;
            return View("AttValue");
        }
    }
}