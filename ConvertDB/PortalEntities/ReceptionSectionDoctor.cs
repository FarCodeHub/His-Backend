using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class ReceptionSectionDoctor
    {
        public int Id { get; set; }
        public int? DoctorId { get; set; }
        public int? SectionId { get; set; }
        public long? ReceptionId { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsCurrent { get; set; }

        public virtual Doctor Doctor { get; set; }
        public virtual Reception1 Reception { get; set; }
        public virtual Section Section { get; set; }
    }
}
