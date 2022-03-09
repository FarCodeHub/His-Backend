using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class DurationType
    {
        public DurationType()
        {
            DoctorAppointments = new HashSet<DoctorAppointment>();
            PrescriptionDetailDrugs = new HashSet<PrescriptionDetailDrug>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string TitleLang2 { get; set; }
        public int? DurationMinute { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsByQuantity { get; set; }
        public string Code { get; set; }

        public virtual ICollection<DoctorAppointment> DoctorAppointments { get; set; }
        public virtual ICollection<PrescriptionDetailDrug> PrescriptionDetailDrugs { get; set; }
    }
}
