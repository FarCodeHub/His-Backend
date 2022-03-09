using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Role
    {
        public Role()
        {
            BasketDrugs = new HashSet<BasketDrug>();
            BloodStatusHistories = new HashSet<BloodStatusHistory>();
            Payments = new HashSet<Payment>();
            PrescriptionDetailDrugHistories = new HashSet<PrescriptionDetailDrugHistory>();
            PrescriptionDetailServiceHistories = new HashSet<PrescriptionDetailServiceHistory>();
            PrescriptionDrugCharts = new HashSet<PrescriptionDrugChart>();
            PrescriptionServiceCharts = new HashSet<PrescriptionServiceChart>();
            Prescriptions = new HashSet<Prescription>();
            PurchaseInvoices = new HashSet<PurchaseInvoice>();
            ReceptionDiagnosisHistories = new HashSet<ReceptionDiagnosisHistory>();
            ReceptionHistories = new HashSet<ReceptionHistory>();
            RequestHistories = new HashSet<RequestHistory>();
            Requests = new HashSet<Request>();
            RolePermissions = new HashSet<RolePermission>();
            SamplingHistories = new HashSet<SamplingHistory>();
            StoreEntries = new HashSet<StoreEntry>();
            StoreTransfers = new HashSet<StoreTransfer>();
            Templates = new HashSet<Template>();
            UserPermissions = new HashSet<UserPermission>();
            UserRolePermissions = new HashSet<UserRolePermission>();
            UserRoles = new HashSet<UserRole>();
            VitalSigns = new HashSet<VitalSign>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string TitleLang2 { get; set; }
        public int? RoleGroupId { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsAdmin { get; set; }
        public string Note { get; set; }
        public string NoteLang2 { get; set; }

        public virtual RoleGroup RoleGroup { get; set; }
        public virtual ICollection<BasketDrug> BasketDrugs { get; set; }
        public virtual ICollection<BloodStatusHistory> BloodStatusHistories { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<PrescriptionDetailDrugHistory> PrescriptionDetailDrugHistories { get; set; }
        public virtual ICollection<PrescriptionDetailServiceHistory> PrescriptionDetailServiceHistories { get; set; }
        public virtual ICollection<PrescriptionDrugChart> PrescriptionDrugCharts { get; set; }
        public virtual ICollection<PrescriptionServiceChart> PrescriptionServiceCharts { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; set; }
        public virtual ICollection<ReceptionDiagnosisHistory> ReceptionDiagnosisHistories { get; set; }
        public virtual ICollection<ReceptionHistory> ReceptionHistories { get; set; }
        public virtual ICollection<RequestHistory> RequestHistories { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
        public virtual ICollection<RolePermission> RolePermissions { get; set; }
        public virtual ICollection<SamplingHistory> SamplingHistories { get; set; }
        public virtual ICollection<StoreEntry> StoreEntries { get; set; }
        public virtual ICollection<StoreTransfer> StoreTransfers { get; set; }
        public virtual ICollection<Template> Templates { get; set; }
        public virtual ICollection<UserPermission> UserPermissions { get; set; }
        public virtual ICollection<UserRolePermission> UserRolePermissions { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<VitalSign> VitalSigns { get; set; }
    }
}
