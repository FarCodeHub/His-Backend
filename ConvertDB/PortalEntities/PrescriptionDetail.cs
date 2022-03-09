using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class PrescriptionDetail
    {
        public long? ReceptionId { get; set; }
        public long PrescriptionId { get; set; }
        public long? PrescriptionDetailDrugId { get; set; }
        public long? PrescriptionDetailServiceId { get; set; }
    }
}
