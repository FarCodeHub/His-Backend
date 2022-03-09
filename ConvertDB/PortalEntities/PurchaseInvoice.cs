using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class PurchaseInvoice
    {
        public PurchaseInvoice()
        {
            PurchaseInvoiceDetails = new HashSet<PurchaseInvoiceDetail>();
            StoreEntries = new HashSet<StoreEntry>();
        }

        public int Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Code { get; set; }
        public int? PurchaserId { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public int? StoreId { get; set; }
        public string Delivery { get; set; }
        public int? UserId { get; set; }
        public int? TransfereeId { get; set; }
        public int? DistributionCompanyId { get; set; }
        public string OutInvoiceCode { get; set; }
        public decimal? TotalDiscount { get; set; }
        public decimal? OtherDiscount { get; set; }
        public decimal? TotalTax { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? PaymentablePrice { get; set; }
        public string Note { get; set; }
        public int? RoleId { get; set; }

        public virtual Company DistributionCompany { get; set; }
        public virtual Employee Purchaser { get; set; }
        public virtual Role Role { get; set; }
        public virtual Section Store { get; set; }
        public virtual Employee Transferee { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<PurchaseInvoiceDetail> PurchaseInvoiceDetails { get; set; }
        public virtual ICollection<StoreEntry> StoreEntries { get; set; }
    }
}
