using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using CDM.BAL.Manager;
using System.Web.Http;

namespace CDM.WebAPI.Controllers
{


    public class VehicleController : ApiController
    {
        private readonly IVehicleManager _Vehiclemanager;

        public VehicleController(IVehicleManager vehiclemanager)
        {
            _Vehiclemanager = vehiclemanager;
        }

        [HttpGet]
        [Route("api/getVehicle")]
        public IHttpActionResult getallVehicle()
        {
            var Vehicle = _Vehiclemanager.GetAllVehicle();
            if (Vehicle.Count == 0)
            {
                return NotFound();
            }
            return Json(Vehicle);
        }

    }
}
