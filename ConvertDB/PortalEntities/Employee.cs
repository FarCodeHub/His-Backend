using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Employee
    {
        public Employee()
        {
            PurchaseInvoicePurchasers = new HashSet<PurchaseInvoice>();
            PurchaseInvoiceTransferees = new HashSet<PurchaseInvoice>();
            RequestHistoryDeliveries = new HashSet<RequestHistory>();
            RequestHistoryReceives = new HashSet<RequestHistory>();
            SectionBosses = new HashSet<Section>();
            SectionSuperVisorPersonels = new HashSet<Section>();
            StoreTransferDeliveryUsers = new HashSet<StoreTransfer>();
            StoreTransferReceiveUsers = new HashSet<StoreTransfer>();
        }

        public int Id { get; set; }
        public int? PersonId { get; set; }
        public int? HospitalRoleTypeId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? EmploymentStartDate { get; set; }
        public string Note { get; set; }
        public bool? IsAdmin { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public string NoteLang2 { get; set; }

        public virtual Person Person { get; set; }
        public virtual ICollection<PurchaseInvoice> PurchaseInvoicePurchasers { get; set; }
        public virtual ICollection<PurchaseInvoice> PurchaseInvoiceTransferees { get; set; }
        public virtual ICollection<RequestHistory> RequestHistoryDeliveries { get; set; }
        public virtual ICollection<RequestHistory> RequestHistoryReceives { get; set; }
        public virtual ICollection<Section> SectionBosses { get; set; }
        public virtual ICollection<Section> SectionSuperVisorPersonels { get; set; }
        public virtual ICollection<StoreTransfer> StoreTransferDeliveryUsers { get; set; }
        public virtual ICollection<StoreTransfer> StoreTransferReceiveUsers { get; set; }
    }
}
