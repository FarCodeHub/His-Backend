using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class PurchaseInvoiceDetail
    {
        public PurchaseInvoiceDetail()
        {
            StoreEntryDetails = new HashSet<StoreEntryDetail>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public int? PurchaseInvoiceId { get; set; }
        public int? DrugId { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int? PackagingTypeId { get; set; }
        public int? PackagingQuantity { get; set; }
        public int? Quantity { get; set; }
        public int? Award { get; set; }
        public decimal? AwardProfit { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? SalesPrice { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Tax { get; set; }
        public decimal? TotalPrice { get; set; }
        public int? Returned { get; set; }

        public virtual Drug Drug { get; set; }
        public virtual PackagingType PackagingType { get; set; }
        public virtual PurchaseInvoice PurchaseInvoice { get; set; }
        public virtual ICollection<StoreEntryDetail> StoreEntryDetails { get; set; }
    }
}
