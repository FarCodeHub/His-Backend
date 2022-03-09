using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class PackagingType
    {
        public PackagingType()
        {
            PurchaseInvoiceDetails = new HashSet<PurchaseInvoiceDetail>();
            StoreEntryDetails = new HashSet<StoreEntryDetail>();
            StoreTransferDetails = new HashSet<StoreTransferDetail>();
        }

        public int Id { get; set; }
        public int? DrugFormId { get; set; }
        public string Title { get; set; }
        public int? ContentCount { get; set; }

        public virtual DrugForm DrugForm { get; set; }
        public virtual ICollection<PurchaseInvoiceDetail> PurchaseInvoiceDetails { get; set; }
        public virtual ICollection<StoreEntryDetail> StoreEntryDetails { get; set; }
        public virtual ICollection<StoreTransferDetail> StoreTransferDetails { get; set; }
    }
}
