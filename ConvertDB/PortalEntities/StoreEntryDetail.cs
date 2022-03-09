using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class StoreEntryDetail
    {
        public long Id { get; set; }
        public int? StoreEntryId { get; set; }
        public long? PurchaseInvoiceDetailsId { get; set; }
        public int? DrugId { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int? PackagingTypeId { get; set; }
        public int? PackagingQuantity { get; set; }
        public int? Quantity { get; set; }
        public int? Returned { get; set; }

        public virtual Drug Drug { get; set; }
        public virtual PackagingType PackagingType { get; set; }
        public virtual PurchaseInvoiceDetail PurchaseInvoiceDetails { get; set; }
        public virtual StoreEntry StoreEntry { get; set; }
    }
}
