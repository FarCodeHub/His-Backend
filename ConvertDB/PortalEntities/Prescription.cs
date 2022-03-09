using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Prescription
    {
        public Prescription()
        {
            PrescriptionAllergies = new HashSet<PrescriptionAllergy>();
            PrescriptionDetailDrugHistories = new HashSet<PrescriptionDetailDrugHistory>();
            PrescriptionDetailDrugs = new HashSet<PrescriptionDetailDrug>();
            PrescriptionDetailPharmacistNotes = new HashSet<PrescriptionDetailPharmacistNote>();
            PrescriptionDetailServiceHistories = new HashSet<PrescriptionDetailServiceHistory>();
            PrescriptionDetailServices = new HashSet<PrescriptionDetailService>();
            PrescriptionDiets = new HashSet<PrescriptionDiet>();
            PrescriptionPanels = new HashSet<PrescriptionPanel>();
            PrescriptionServiceResults = new HashSet<PrescriptionServiceResult>();
            PrescriptionShares = new HashSet<PrescriptionShare>();
            PrescriptionSigns = new HashSet<PrescriptionSign>();
            ReceptionDiagnoses = new HashSet<ReceptionDiagnosis>();
            ReceptionServices = new HashSet<ReceptionService>();
            Requests = new HashSet<Request>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? ReceptionId { get; set; }
        public int? SectionId { get; set; }
        public int? DoctorId { get; set; }
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

        public virtual Doctor Doctor { get; set; }
        public virtual Reception1 Reception { get; set; }
        public virtual Role Role { get; set; }
        public virtual Section Section { get; set; }
        public virtual User User { get; set; }
        public virtual VisitType VisitType { get; set; }
        public virtual ICollection<PrescriptionAllergy> PrescriptionAllergies { get; set; }
        public virtual ICollection<PrescriptionDetailDrugHistory> PrescriptionDetailDrugHistories { get; set; }
        public virtual ICollection<PrescriptionDetailDrug> PrescriptionDetailDrugs { get; set; }
        public virtual ICollection<PrescriptionDetailPharmacistNote> PrescriptionDetailPharmacistNotes { get; set; }
        public virtual ICollection<PrescriptionDetailServiceHistory> PrescriptionDetailServiceHistories { get; set; }
        public virtual ICollection<PrescriptionDetailService> PrescriptionDetailServices { get; set; }
        public virtual ICollection<PrescriptionDiet> PrescriptionDiets { get; set; }
        public virtual ICollection<PrescriptionPanel> PrescriptionPanels { get; set; }
        public virtual ICollection<PrescriptionServiceResult> PrescriptionServiceResults { get; set; }
        public virtual ICollection<PrescriptionShare> PrescriptionShares { get; set; }
        public virtual ICollection<PrescriptionSign> PrescriptionSigns { get; set; }
        public virtual ICollection<ReceptionDiagnosis> ReceptionDiagnoses { get; set; }
        public virtual ICollection<ReceptionService> ReceptionServices { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
    }
}
