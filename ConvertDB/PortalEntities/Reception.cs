using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Reception
    {
        public long ReceptionId { get; set; }
        public long? ReceptionCode { get; set; }
        public int? PatientId { get; set; }
        public int? PersonId { get; set; }
    }
}
