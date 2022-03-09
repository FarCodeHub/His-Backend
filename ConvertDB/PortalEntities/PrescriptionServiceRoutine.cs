using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class PrescriptionServiceRoutine
    {
        public long Id { get; set; }
        public int? ServiceId { get; set; }
        public int? Number { get; set; }
        public long? PrescriptionRoutineId { get; set; }
        public int? Period { get; set; }
        public string Note { get; set; }

        public virtual PrescriptionRoutine PrescriptionRoutine { get; set; }
        public virtual Service Service { get; set; }
    }
}
