using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.HisDBEntities
{
    public partial class Reception
    {
        public Reception()
        {
            Prescriptions = new HashSet<Prescription>();
            RequestServices = new HashSet<RequestService>();
        }

        public long Id { get; set; }
        public int? ParentId { get; set; }
        public int? ServiceTypeId { get; set; }
        public int? CenterId { get; set; }
        public int? PatientId { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? RefferDate { get; set; }
        public int? RefferReasonId { get; set; }
        public int? CurrentIllnessId { get; set; }
        public int? GeneralStatusId { get; set; }
        public string ChiefComplaints { get; set; }
        public string Advice { get; set; }
        public string Note { get; set; }
        public bool? IsResult { get; set; }
        public string ResultNote { get; set; }
        public bool? IsVerify { get; set; }
        public DateTime? AnswerDate { get; set; }
        public int? RefferFromId { get; set; }
        public int? RelationId { get; set; }
        public int? PresenterId { get; set; }
        public string ConsumeDrug { get; set; }
        public bool? IsHaveSign { get; set; }
        public DateTime? DateOfSign { get; set; }
        public DateTime? HospitalEnteryDate { get; set; }
        public DateTime? RecoveryDate { get; set; }
        public int? DoctorId { get; set; }
        public long? LocalId { get; set; }

        public virtual MedicalCenter Center { get; set; }
        public virtual MedicalStaff Doctor { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
        public virtual ICollection<RequestService> RequestServices { get; set; }
    }
}
