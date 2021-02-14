using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using CDM.BAL.Manager;
using System.Web.Http;

namespace CDM.WebAPI.Controllers
{


    public class MechanicController : ApiController
    {
        private readonly IMechanicManager _Mechanicmanager;

        public MechanicController(IMechanicManager mechanicmanager)
        {
            _Mechanicmanager = mechanicmanager;
        }

        [HttpGet]
        [Route("api/getMechanic")]
        public IHttpActionResult getallMechanic()
        {
            var Mechanic = _Mechanicmanager.GetAllMechanic();
            if (Mechanic.Count == 0)
            {
                return NotFound();
            }
            return Json(Mechanic);
        }

    }
}
