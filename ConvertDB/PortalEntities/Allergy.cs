using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Allergy
    {
        public Allergy()
        {
            PatientExtraInfos = new HashSet<PatientExtraInfo>();
            PrescriptionAllergies = new HashSet<PrescriptionAllergy>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string TitleLang2 { get; set; }
        public string LocalCode { get; set; }
        public string Note { get; set; }
        public bool? IsAdmin { get; set; }
        public string NoteLang2 { get; set; }
        public int? IcdCodeId { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<PatientExtraInfo> PatientExtraInfos { get; set; }
        public virtual ICollection<PrescriptionAllergy> PrescriptionAllergies { get; set; }
    }
}
