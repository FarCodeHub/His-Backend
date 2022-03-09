using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities.His.Entities
{
    public partial class RequestService
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public long? ReceptionId { get; set; }
        public int? ServiceTypeId { get; set; }
        public int? MedicalStaffId { get; set; }
        public int? ScheduleId { get; set; }
        public DateTime CreateTime { get; set; }
        public int Status { get; set; }
        public long? DetailReceptionId { get; set; }
        public long? PrescriptionId { get; set; }
        public long? RequestId { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public int? ServiceChildId { get; set; }
        public string SectionDiscount { get; set; }
        public decimal? TotalPrice { get; set; }
        public int? DoctorId { get; set; }
        public int? DoctorPercent { get; set; }
        public int? PriceMethodTypeId { get; set; }
        public string Note { get; set; }
        public decimal? PatientShare { get; set; }
        public decimal? TechnicalShare { get; set; }
        public decimal? PrescriptionShare { get; set; }
        public decimal? Providershare { get; set; }
        public decimal? ExtraPayment { get; set; }
        public decimal? DoctorDiscount { get; set; }
        public decimal? FinalPrice { get; set; }
        public int? SectionId { get; set; }
        public int? StatusId { get; set; }
        public long? ParentReceptionServiceId { get; set; }
        public long? PrescriptionDetailServiceId { get; set; }
        public int? AnswerUserId { get; set; }

        public virtual MedicalStaff MedicalStaff { get; set; }
        public virtual Reception Reception { get; set; }
        public virtual Schedule Schedule { get; set; }
        public virtual ServiceType ServiceType { get; set; }
    }
}
