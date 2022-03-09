using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class PrescriptionSetting
    {
        public long Id { get; set; }
        public int? VisitTypeId { get; set; }
        public int? ServiceId { get; set; }
        public int? ServiceGroupId { get; set; }
        public int? SectionId { get; set; }

        public virtual Section Section { get; set; }
        public virtual Service Service { get; set; }
        public virtual Service ServiceGroup { get; set; }
        public virtual VisitType VisitType { get; set; }
    }
}
