using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class RequestDetail1
    {
        public long Id { get; set; }
        public long? RequestId { get; set; }
        public long? LabReceptionId { get; set; }
        public int? ServiceId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Duration { get; set; }
        public bool? IsNoSample { get; set; }
        public long? PrescriptionDetailServiceId { get; set; }
        public string Note { get; set; }
    }
}
