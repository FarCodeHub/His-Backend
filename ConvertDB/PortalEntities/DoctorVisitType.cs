using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class DoctorVisitType
    {
        public int Id { get; set; }
        public int? VisitTypeId { get; set; }
        public int? DoctorId { get; set; }

        public virtual Doctor Doctor { get; set; }
        public virtual VisitType VisitType { get; set; }
    }
}
