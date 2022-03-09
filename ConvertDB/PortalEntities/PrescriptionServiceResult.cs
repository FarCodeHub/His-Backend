using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class PrescriptionServiceResult
    {
        public long Id { get; set; }
        public long PrescriptionId { get; set; }
        public int? ServiceId { get; set; }
        public string Result { get; set; }
        public string Result2 { get; set; }
        public int? UnitId { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual Prescription Prescription { get; set; }
        public virtual Service Service { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
