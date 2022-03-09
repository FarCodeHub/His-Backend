using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities.His.Entities
{
    public partial class Prescription
    {
        public Prescription()
        {
            PrescriptionDetailDrugs = new HashSet<PrescriptionDetailDrug>();
            PrescriptionDetailServices = new HashSet<PrescriptionDetailService>();
            PrescriptionServiceResults = new HashSet<PrescriptionServiceResult>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? ReceptionId { get; set; }
        public int? CenterId { get; set; }
        public int? MedicalStaffId { get; set; }
        public int? RoleId { get; set; }
        public DateTime? PrescriptionDate { get; set; }
        public string PostMedicalHistory { get; set; }
        public string Biography { get; set; }
        public string Diet { get; set; }
        public string InteractionsNote { get; set; }
        public string PharmacistNoteForNursing { get; set; }
        public string MainDoctorNote { get; set; }
        public string Note { get; set; }
        public int? VisitTypeId { get; set; }
        public int? PatientId { get; set; }
        public long? LocalId { get; set; }

        public virtual MedicalCenter Center { get; set; }
        public virtual MedicalStaff MedicalStaff { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Reception Reception { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<PrescriptionDetailDrug> PrescriptionDetailDrugs { get; set; }
        public virtual ICollection<PrescriptionDetailService> PrescriptionDetailServices { get; set; }
        public virtual ICollection<PrescriptionServiceResult> PrescriptionServiceResults { get; set; }
    }
}
