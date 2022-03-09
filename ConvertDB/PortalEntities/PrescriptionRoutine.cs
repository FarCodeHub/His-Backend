using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class PrescriptionRoutine
    {
        public PrescriptionRoutine()
        {
            PrescriptionDrugRoutines = new HashSet<PrescriptionDrugRoutine>();
            PrescriptionServiceRoutines = new HashSet<PrescriptionServiceRoutine>();
        }

        public long Id { get; set; }
        public int? SectionId { get; set; }
        public string Title { get; set; }
        public int? PanelTypeId { get; set; }
        public bool? IsDrugType { get; set; }

        public virtual PanelType PanelType { get; set; }
        public virtual ICollection<PrescriptionDrugRoutine> PrescriptionDrugRoutines { get; set; }
        public virtual ICollection<PrescriptionServiceRoutine> PrescriptionServiceRoutines { get; set; }
    }
}
