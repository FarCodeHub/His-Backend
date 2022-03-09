using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class UserCardCode
    {
        public long Id { get; set; }
        public int? UserId { get; set; }
        public long? CardCodeId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public bool? IsCurrent { get; set; }
        public int? ValidityPeriodId { get; set; }

        public virtual CardCode CardCode { get; set; }
        public virtual User User { get; set; }
        public virtual ValidityPeriod ValidityPeriod { get; set; }
    }
}
