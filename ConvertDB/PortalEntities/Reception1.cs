using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Reception1
    {
        public Reception1()
        {
            BasketDrugs = new HashSet<BasketDrug>();
            BedReceptions = new HashSet<BedReception>();
            DoctorAppointmentDetails = new HashSet<DoctorAppointmentDetail>();
            Payments = new HashSet<Payment>();
            Prescriptions = new HashSet<Prescription>();
            ReceptionAnswers = new HashSet<ReceptionAnswer>();
            ReceptionDetails = new HashSet<ReceptionDetail>();
            ReceptionDiagnoses = new HashSet<ReceptionDiagnosis>();
            ReceptionDrugs = new HashSet<ReceptionDrug>();
            ReceptionHistories = new HashSet<ReceptionHistory>();
            ReceptionSectionDoctors = new HashSet<ReceptionSectionDoctor>();
            ReceptionServices = new HashSet<ReceptionService>();
            ReceptionSigns = new HashSet<ReceptionSign>();
            Requests = new HashSet<Request>();
            SmsReceptions = new HashSet<SmsReception>();
            SpecialIllnessReceptions = new HashSet<SpecialIllnessReception>();
            VitalSigns = new HashSet<VitalSign>();
        }

        public long Id { get; set; }
        public int? PatientId { get; set; }
        public long? ReceptionId { get; set; }
        public DateTime? ReceptionDate { get; set; }
        public int? SectionId { get; set; }
        public int? ReceptionTypeId { get; set; }
        public int? HospitalizationDoctorId { get; set; }
        public int? DoctorId { get; set; }
        public DateTime? RefferDate { get; set; }
        public int? RefferReasonId { get; set; }
        public int? CurrentIllnessId { get; set; }
        public int? GeneralStatusId { get; set; }
        public string ChiefComplaints { get; set; }
        public string Advice { get; set; }
        public int? RefferFromId { get; set; }
        public string Note { get; set; }
        public int? PresenterId { get; set; }
        public int? RelationId { get; set; }
        public string ConsumeDrug { get; set; }
        public bool? IsHaveSign { get; set; }
        public DateTime? DateOfSign { get; set; }
        public DateTime? HospitalEnteryDate { get; set; }
        public DateTime? RecoveryDate { get; set; }
        public bool? IsResult { get; set; }
        public string ResultNote { get; set; }
        public int? ParentId { get; set; }
        public bool? IsVerify { get; set; }
        public DateTime? AnswerDate { get; set; }

        public virtual Illness CurrentIllness { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual GeneralStatus GeneralStatus { get; set; }
        public virtual Doctor HospitalizationDoctor { get; set; }
        public virtual Person Parent { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Presenter Presenter { get; set; }
        public virtual ReceptionType ReceptionType { get; set; }
        public virtual RefferFrom RefferFrom { get; set; }
        public virtual RelationShip Relation { get; set; }
        public virtual Section Section { get; set; }
        public virtual ICollection<BasketDrug> BasketDrugs { get; set; }
        public virtual ICollection<BedReception> BedReceptions { get; set; }
        public virtual ICollection<DoctorAppointmentDetail> DoctorAppointmentDetails { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
        public virtual ICollection<ReceptionAnswer> ReceptionAnswers { get; set; }
        public virtual ICollection<ReceptionDetail> ReceptionDetails { get; set; }
        public virtual ICollection<ReceptionDiagnosis> ReceptionDiagnoses { get; set; }
        public virtual ICollection<ReceptionDrug> ReceptionDrugs { get; set; }
        public virtual ICollection<ReceptionHistory> ReceptionHistories { get; set; }
        public virtual ICollection<ReceptionSectionDoctor> ReceptionSectionDoctors { get; set; }
        public virtual ICollection<ReceptionService> ReceptionServices { get; set; }
        public virtual ICollection<ReceptionSign> ReceptionSigns { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
        public virtual ICollection<SmsReception> SmsReceptions { get; set; }
        public virtual ICollection<SpecialIllnessReception> SpecialIllnessReceptions { get; set; }
        public virtual ICollection<VitalSign> VitalSigns { get; set; }
    }
}
