using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class SmsCenterCharge
    {
        public int Id { get; set; }
        public int? CenterId { get; set; }
        public long? Cost { get; set; }
        public int? GiftReasonId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UserId { get; set; }

        public virtual Center Center { get; set; }
        public virtual SmsGiftReason GiftReason { get; set; }
        public virtual User User { get; set; }
    }
}
