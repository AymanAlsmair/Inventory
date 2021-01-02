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
    public class CountryController : ApiController
    {
        public List<Country> Get()
        {
            ICountryRepository ObjCount = new CountryRepository();
            return ObjCount.LoadAll();
        }
    }
}
