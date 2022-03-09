using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.HisDBEntities
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
        public int? LocalId { get; set; }

        public virtual Prescription Prescription { get; set; }
    }
}
