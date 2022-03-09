﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class PrescriptionSign
    {
        public long Id { get; set; }
        public int? SignId { get; set; }
        public long? PrescriptionId { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual Prescription Prescription { get; set; }
        public virtual Sign Sign { get; set; }
    }
}
