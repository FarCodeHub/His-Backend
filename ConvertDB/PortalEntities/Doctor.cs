using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Doctor
    {
        public Doctor()
        {
            DoctorAppointments = new HashSet<DoctorAppointment>();
            DoctorCertificates = new HashSet<DoctorCertificate>();
            DoctorDegrees = new HashSet<DoctorDegree>();
            DoctorVisitTypes = new HashSet<DoctorVisitType>();
            Prescriptions = new HashSet<Prescription>();
            Reception1Doctors = new HashSet<Reception1>();
            Reception1HospitalizationDoctors = new HashSet<Reception1>();
            ReceptionDetailPatoDoctors = new HashSet<ReceptionDetail>();
            ReceptionDetailPrescriptionDoctors = new HashSet<ReceptionDetail>();
            ReceptionDrugs = new HashSet<ReceptionDrug>();
            ReceptionHistories = new HashSet<ReceptionHistory>();
            ReceptionSectionDoctors = new HashSet<ReceptionSectionDoctor>();
            ReceptionServices = new HashSet<ReceptionService>();
            Requests = new HashSet<Request>();
        }

        public int Id { get; set; }
        public string MedicalSystemNo { get; set; }
        public int? CenterId { get; set; }
        public int? PersonId { get; set; }
        public int? ExpertiseId { get; set; }
        public int? ScientificlevelId { get; set; }
        public DateTime? CreditDate { get; set; }
        public DateTime? CooperationDate { get; set; }
        public string PhoneClinic { get; set; }
        public string AddressClinic { get; set; }
        public bool? IsEmergency { get; set; }
        public bool? IsOutpatient { get; set; }
        public bool? IsHospitalization { get; set; }
        public bool? IsSurgeryRoom { get; set; }
        public bool? IsActive { get; set; }
        public decimal? CostVisit { get; set; }
        public string Note { get; set; }
        public int? DoctorDegreeId { get; set; }

        public virtual Center Center { get; set; }
        public virtual DoctorDegree DoctorDegree { get; set; }
        public virtual Expertise Expertise { get; set; }
        public virtual Person Person { get; set; }
        public virtual Scientificlevel Scientificlevel { get; set; }
        public virtual ICollection<DoctorAppointment> DoctorAppointments { get; set; }
        public virtual ICollection<DoctorCertificate> DoctorCertificates { get; set; }
        public virtual ICollection<DoctorDegree> DoctorDegrees { get; set; }
        public virtual ICollection<DoctorVisitType> DoctorVisitTypes { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
        public virtual ICollection<Reception1> Reception1Doctors { get; set; }
        public virtual ICollection<Reception1> Reception1HospitalizationDoctors { get; set; }
        public virtual ICollection<ReceptionDetail> ReceptionDetailPatoDoctors { get; set; }
        public virtual ICollection<ReceptionDetail> ReceptionDetailPrescriptionDoctors { get; set; }
        public virtual ICollection<ReceptionDrug> ReceptionDrugs { get; set; }
        public virtual ICollection<ReceptionHistory> ReceptionHistories { get; set; }
        public virtual ICollection<ReceptionSectionDoctor> ReceptionSectionDoctors { get; set; }
        public virtual ICollection<ReceptionService> ReceptionServices { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
    }
}
