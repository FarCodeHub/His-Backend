using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class WayOfPrescription
    {
        public WayOfPrescription()
        {
            PrescriptionDetailDrugs = new HashSet<PrescriptionDetailDrug>();
            PrescriptionDrugRoutines = new HashSet<PrescriptionDrugRoutine>();
            RequestDetails = new HashSet<RequestDetail>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string TitleLang2 { get; set; }
        public string Note { get; set; }
        public bool? IsAdmin { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public string NoteLang2 { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<PrescriptionDetailDrug> PrescriptionDetailDrugs { get; set; }
        public virtual ICollection<PrescriptionDrugRoutine> PrescriptionDrugRoutines { get; set; }
        public virtual ICollection<RequestDetail> RequestDetails { get; set; }
    }
}
