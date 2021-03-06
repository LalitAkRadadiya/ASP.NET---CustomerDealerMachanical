﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDM.Model
{
    public class MechanicDTO
    {
        public int MechanicId { get; set; }
        public string MechanicName { get; set; }
        public string ContactNo { get; set; }
        public string Make { get; set; }
        public string EmailId { get; set; }
        public bool isActive { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public int DealerId { get; set; }

    }
}
