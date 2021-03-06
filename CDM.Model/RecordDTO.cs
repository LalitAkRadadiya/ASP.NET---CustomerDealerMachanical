﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDM.Model
{
    public class RecordDTO
    {
        public long RecordId { get; set; }
        public string CustomerName { get; set; }
        public string DealerName { get; set; }
        public string DealerContactNo { get; set; }
        public string MechanicName { get; set; }
        public string MechanicContactNo { get; set; }
        public string ServiceName { get; set; }
        public System.DateTime StartDateTime { get; set; }
        public System.DateTime EndDateTime { get; set; }
        public double TotalPrice { get; set; }
        public string LicensePlate { get; set; }
        public int DealerId { get; set; }
        public int CustomerId { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
    }
}
