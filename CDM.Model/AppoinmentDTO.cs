using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDM.Model
{
    public class AppoinmentDTO
    {
        public int AppintmentId { get; set; }
        public int ServiceId { get; set; }
        public int DealerId { get; set; }
        public int CustomerId { get; set; }
        public System.DateTime BookingDateTime { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
}
