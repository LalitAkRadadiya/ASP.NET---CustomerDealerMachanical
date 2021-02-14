using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using CDM.BAL.Manager;
using System.Web.Http;

namespace CDM.WebAPI.Controllers
{


    public class JobCardController : ApiController
    {
        private readonly IJobCardManager _JobCardmanager;

        public JobCardController(IJobCardManager jobCardmanager)
        {
            _JobCardmanager = jobCardmanager;
        }

        [HttpGet]
        [Route("api/getJobCard")]
        public IHttpActionResult getallJobCard()
        {
            var JobCard = _JobCardmanager.GetAllJobCard();
            if (JobCard.Count == 0)
            {
                return NotFound();
            }
            return Json(JobCard);
        }

    }
}
