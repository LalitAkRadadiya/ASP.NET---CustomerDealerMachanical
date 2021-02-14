using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using CDM.BAL.Manager;
using System.Web.Http;

namespace CDM.WebAPI.Controllers
{


    public class AppoinmentController : ApiController
    {
        private readonly IAppoinmentManager _Appoinmentmanager;

        public AppoinmentController(IAppoinmentManager appoinmentmanager)
        {
            _Appoinmentmanager = appoinmentmanager;
        }

        [HttpGet]
        [Route("api/getappoinment")]
        public IHttpActionResult getallappoinment()
        {
            var Appoinment = _Appoinmentmanager.GetAllAppoinment();
            if(Appoinment.Count == 0)
            {
                return NotFound();
            }
            return Json(Appoinment);
        }

    }
}
