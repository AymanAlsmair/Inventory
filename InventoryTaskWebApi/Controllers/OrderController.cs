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
    public class OrderController : ApiController
    {
        public void Post(Order obj)
        {
            obj.Pill_NO = Guid.NewGuid().ToString();
            IOrderRepository ObjOrder = new OrderRepository();
            ObjOrder.Insert(obj);
        }
        public List<Order> Get()
        {
            IOrderRepository ObjOrder = new OrderRepository();
            return ObjOrder.LoadAll();
        }
        [HttpGet]
        public Order Load(int ID)
        {
            IOrderRepository ObjOrder = new OrderRepository();
            return ObjOrder.Load(ID);
        }

        [HttpPost]
        [Route("Order/Update")]
        public void Update(Order obj)
        {
            IOrderRepository ObjOrder = new OrderRepository();
            ObjOrder.Update(obj);
        }

        [HttpPost]
        public void Delete(int ID)
        {
            IOrderRepository ObjOrder = new OrderRepository();
            ObjOrder.Delete(ID);
        }
    }
}
