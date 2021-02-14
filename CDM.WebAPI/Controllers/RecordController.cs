using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using CDM.BAL.Manager;
using System.Web.Http;

namespace CDM.WebAPI.Controllers
{


    public class RecordController : ApiController
    {
        private readonly IRecordManager _Recordmanager;

        public RecordController(IRecordManager recordmanager)
        {
            _Recordmanager = recordmanager;
        }

        [HttpGet]
        [Route("api/getRecord")]
        public IHttpActionResult getallRecord()
        {
            var Record = _Recordmanager.GetAllRecord();
            if (Record.Count == 0)
            {
                return NotFound();
            }
            return Json(Record);
        }

    }
}
