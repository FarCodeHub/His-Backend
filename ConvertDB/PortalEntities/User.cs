using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class User
    {
        public User()
        {
            AnswerServiceInsertUsers = new HashSet<AnswerService>();
            AnswerServiceUsers = new HashSet<AnswerService>();
            BasketDrugs = new HashSet<BasketDrug>();
            BloodStatusHistories = new HashSet<BloodStatusHistory>();
            FileTags = new HashSet<FileTag>();
            Payments = new HashSet<Payment>();
            PrescriptionDetailDrugHistories = new HashSet<PrescriptionDetailDrugHistory>();
            PrescriptionDetailDrugs = new HashSet<PrescriptionDetailDrug>();
            PrescriptionDetailServiceHistories = new HashSet<PrescriptionDetailServiceHistory>();
            PrescriptionDetailServices = new HashSet<PrescriptionDetailService>();
            PrescriptionDrugChartFunctors = new HashSet<PrescriptionDrugChart>();
            PrescriptionDrugChartUsers = new HashSet<PrescriptionDrugChart>();
            PrescriptionDrugChartWitnesses = new HashSet<PrescriptionDrugChart>();
            PrescriptionServiceChartFunctors = new HashSet<PrescriptionServiceChart>();
            PrescriptionServiceChartUsers = new HashSet<PrescriptionServiceChart>();
            PrescriptionServiceChartWitnesses = new HashSet<PrescriptionServiceChart>();
            Prescriptions = new HashSet<Prescription>();
            PurchaseInvoices = new HashSet<PurchaseInvoice>();
            ReceptionDiagnosisHistories = new HashSet<ReceptionDiagnosisHistory>();
            ReceptionHistories = new HashSet<ReceptionHistory>();
            ReceptionServices = new HashSet<ReceptionService>();
            RequestHistories = new HashSet<RequestHistory>();
            Requests = new HashSet<Request>();
            SamplingHistories = new HashSet<SamplingHistory>();
            Samplings = new HashSet<Sampling>();
            SmsCenterCharges = new HashSet<SmsCenterCharge>();
            StoreEntries = new HashSet<StoreEntry>();
            StoreTransfers = new HashSet<StoreTransfer>();
            Templates = new HashSet<Template>();
            UserCardCodes = new HashSet<UserCardCode>();
            UserPermissions = new HashSet<UserPermission>();
            UserRolePermissions = new HashSet<UserRolePermission>();
            UserRoles = new HashSet<UserRole>();
            VitalSigns = new HashSet<VitalSign>();
        }

        public int Id { get; set; }
        public int? PersonId { get; set; }
        public long? CardCodeId { get; set; }
        public bool? IsActive { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsLimitByIp { get; set; }
        public bool? IsVerify { get; set; }
        public string MacAddress { get; set; }
        public bool? IsSync { get; set; }
        public int? SmsUserId { get; set; }
        public string SmsToken { get; set; }

        public virtual CardCode CardCode { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<AnswerService> AnswerServiceInsertUsers { get; set; }
        public virtual ICollection<AnswerService> AnswerServiceUsers { get; set; }
        public virtual ICollection<BasketDrug> BasketDrugs { get; set; }
        public virtual ICollection<BloodStatusHistory> BloodStatusHistories { get; set; }
        public virtual ICollection<FileTag> FileTags { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<PrescriptionDetailDrugHistory> PrescriptionDetailDrugHistories { get; set; }
        public virtual ICollection<PrescriptionDetailDrug> PrescriptionDetailDrugs { get; set; }
        public virtual ICollection<PrescriptionDetailServiceHistory> PrescriptionDetailServiceHistories { get; set; }
        public virtual ICollection<PrescriptionDetailService> PrescriptionDetailServices { get; set; }
        public virtual ICollection<PrescriptionDrugChart> PrescriptionDrugChartFunctors { get; set; }
        public virtual ICollection<PrescriptionDrugChart> PrescriptionDrugChartUsers { get; set; }
        public virtual ICollection<PrescriptionDrugChart> PrescriptionDrugChartWitnesses { get; set; }
        public virtual ICollection<PrescriptionServiceChart> PrescriptionServiceChartFunctors { get; set; }
        public virtual ICollection<PrescriptionServiceChart> PrescriptionServiceChartUsers { get; set; }
        public virtual ICollection<PrescriptionServiceChart> PrescriptionServiceChartWitnesses { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; set; }
        public virtual ICollection<ReceptionDiagnosisHistory> ReceptionDiagnosisHistories { get; set; }
        public virtual ICollection<ReceptionHistory> ReceptionHistories { get; set; }
        public virtual ICollection<ReceptionService> ReceptionServices { get; set; }
        public virtual ICollection<RequestHistory> RequestHistories { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
        public virtual ICollection<SamplingHistory> SamplingHistories { get; set; }
        public virtual ICollection<Sampling> Samplings { get; set; }
        public virtual ICollection<SmsCenterCharge> SmsCenterCharges { get; set; }
        public virtual ICollection<StoreEntry> StoreEntries { get; set; }
        public virtual ICollection<StoreTransfer> StoreTransfers { get; set; }
        public virtual ICollection<Template> Templates { get; set; }
        public virtual ICollection<UserCardCode> UserCardCodes { get; set; }
        public virtual ICollection<UserPermission> UserPermissions { get; set; }
        public virtual ICollection<UserRolePermission> UserRolePermissions { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<VitalSign> VitalSigns { get; set; }
    }
}
