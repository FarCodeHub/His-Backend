using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class PrescriptionPanel
    {
        public PrescriptionPanel()
        {
            PrescriptionDetailDrugs = new HashSet<PrescriptionDetailDrug>();
            PrescriptionDetailServices = new HashSet<PrescriptionDetailService>();
        }

        public long Id { get; set; }
        public long? PrescriptionId { get; set; }
        public string Title { get; set; }
        public int? Period { get; set; }
        public DateTime? StartDate { get; set; }
        public bool? IsJustOnTime { get; set; }
        public bool? IsDrugType { get; set; }

        public virtual Prescription Prescription { get; set; }
        public virtual ICollection<PrescriptionDetailDrug> PrescriptionDetailDrugs { get; set; }
        public virtual ICollection<PrescriptionDetailService> PrescriptionDetailServices { get; set; }
    }
}
