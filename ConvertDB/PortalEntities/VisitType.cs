using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class VisitType
    {
        public VisitType()
        {
            DoctorVisitTypes = new HashSet<DoctorVisitType>();
            PrescriptionGroupSettings = new HashSet<PrescriptionGroupSetting>();
            PrescriptionSettings = new HashSet<PrescriptionSetting>();
            Prescriptions = new HashSet<Prescription>();
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

        public virtual ICollection<DoctorVisitType> DoctorVisitTypes { get; set; }
        public virtual ICollection<PrescriptionGroupSetting> PrescriptionGroupSettings { get; set; }
        public virtual ICollection<PrescriptionSetting> PrescriptionSettings { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
    }
}
