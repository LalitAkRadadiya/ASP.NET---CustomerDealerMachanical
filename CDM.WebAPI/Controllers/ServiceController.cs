using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using CDM.BAL.Manager;
using System.Web.Http;

namespace CDM.WebAPI.Controllers
{


    public class ServiceController : ApiController
    {
        private readonly IServiceManager _Servicemanager;

        public ServiceController(IServiceManager servicemanager)
        {
            _Servicemanager = servicemanager;
        }

        [HttpGet]
        [Route("api/getService")]
        public IHttpActionResult getallService()
        {
            var Service = _Servicemanager.GetAllService();
            if (Service.Count == 0)
            {
                return NotFound();
            }
            return Json(Service);
        }

    }
}
