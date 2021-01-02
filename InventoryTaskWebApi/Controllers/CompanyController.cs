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
    public class CompanyController : ApiController
    {
        public void Post(Company obj)
        {
            ICompanyRepoitory ObjComp = new CompanyRepoitory();
            ObjComp.Insert(obj);
        }

        [HttpGet]
        public Company Load(int ID)
        {
            ICompanyRepoitory ObjComp = new CompanyRepoitory();
            return ObjComp.Load(ID);
        }

    }
}
