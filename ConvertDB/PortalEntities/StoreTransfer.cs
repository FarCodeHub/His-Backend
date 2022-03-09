using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class StoreTransfer
    {
        public StoreTransfer()
        {
            StoreTransferDetails = new HashSet<StoreTransferDetail>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? TransferDate { get; set; }
        public int? DeliveryUserId { get; set; }
        public int? SourceStoreId { get; set; }
        public int? ReceiveUserId { get; set; }
        public int? DestinationStoreId { get; set; }
        public int? RoleId { get; set; }

        public virtual Employee DeliveryUser { get; set; }
        public virtual Section DestinationStore { get; set; }
        public virtual Employee ReceiveUser { get; set; }
        public virtual Role Role { get; set; }
        public virtual Section SourceStore { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<StoreTransferDetail> StoreTransferDetails { get; set; }
    }
}
