using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.HisDBEntities
{
    public partial class MedicalStaff
    {
        public MedicalStaff()
        {
            CenterStaffs = new HashSet<CenterStaff>();
            MedicalStaffCertificates = new HashSet<MedicalStaffCertificate>();
            MedicalStaffSpecialities = new HashSet<MedicalStaffSpeciality>();
            Prescriptions = new HashSet<Prescription>();
            Receptions = new HashSet<Reception>();
            RequestServices = new HashSet<RequestService>();
            ScheduleDetails = new HashSet<ScheduleDetail>();
            Schedules = new HashSet<Schedule>();
        }

        public int Id { get; set; }
        public int PersonId { get; set; }
        public int TypeBaseId { get; set; }
        public DateTime EmployeeDate { get; set; }
        public string MedicalSystemNo { get; set; }
        public string Note { get; set; }
        public int? LocalId { get; set; }

        public virtual Person Person { get; set; }
        public virtual BaseValue TypeBase { get; set; }
        public virtual ICollection<CenterStaff> CenterStaffs { get; set; }
        public virtual ICollection<MedicalStaffCertificate> MedicalStaffCertificates { get; set; }
        public virtual ICollection<MedicalStaffSpeciality> MedicalStaffSpecialities { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
        public virtual ICollection<Reception> Receptions { get; set; }
        public virtual ICollection<RequestService> RequestServices { get; set; }
        public virtual ICollection<ScheduleDetail> ScheduleDetails { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
