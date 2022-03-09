using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class StoreEntry
    {
        public StoreEntry()
        {
            StoreEntryDetails = new HashSet<StoreEntryDetail>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UserId { get; set; }
        public int? PurchaseInvoiceId { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? StoreId { get; set; }
        public int? RoleId { get; set; }

        public virtual PurchaseInvoice PurchaseInvoice { get; set; }
        public virtual Role Role { get; set; }
        public virtual Section Store { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<StoreEntryDetail> StoreEntryDetails { get; set; }
    }
}
