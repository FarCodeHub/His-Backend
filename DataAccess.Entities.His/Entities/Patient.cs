using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities.His.Entities
{
    public partial class Patient
    {
        public Patient()
        {
            PatientExtraInfos = new HashSet<PatientExtraInfo>();
            PatientFiles = new HashSet<PatientFile>();
            Prescriptions = new HashSet<Prescription>();
            Receptions = new HashSet<Reception>();
        }

        public int Id { get; set; }
        public int? PersonId { get; set; }
        public int? BloodGroupBaseId { get; set; }
        public int? InternalId { get; set; }
        public string Note { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? Hisno { get; set; }
        public string FileNo { get; set; }
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public string Allergies { get; set; }
        public int? LocalId { get; set; }

        public virtual BaseValue BloodGroupBase { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<PatientExtraInfo> PatientExtraInfos { get; set; }
        public virtual ICollection<PatientFile> PatientFiles { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
        public virtual ICollection<Reception> Receptions { get; set; }
    }
}
