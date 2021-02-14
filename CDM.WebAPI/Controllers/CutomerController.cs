using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using CDM.BAL.Manager;
using System.Web.Http;

namespace CDM.WebAPI.Controllers
{


    public class CutomerController : ApiController
    {
        private readonly ICustomerManager _custommanager;

        public CutomerController(ICustomerManager custommanager)
        {
            _custommanager = custommanager;
        }

        [HttpGet]
        [Route("api/getcustomer")]
        public IHttpActionResult getallcustomer()
        {
            var customer = _custommanager.GetAllCustomer();
            if(customer.Count == 0)
            {
                return NotFound();
            }
            return Json(customer);
        }

    }
}
