using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using CDM.BAL.Manager;
using System.Web.Http;

namespace CDM.WebAPI.Controllers
{


    public class DealerController : ApiController
    {
        private readonly IDealerManager _Dealermanager;

        public DealerController(IDealerManager dealermanager)
        {
            _Dealermanager = dealermanager;
        }

        [HttpGet]
        [Route("api/getDealer")]
        public IHttpActionResult getalldealer()
        {
            var Dealer = _Dealermanager.GetAllDealer();
            if (Dealer.Count == 0)
            {
                return NotFound();
            }
            return Json(Dealer);
        }

    }
}
