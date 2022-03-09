using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities.His.Entities
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
        public long? LocalId { get; set; }

        public virtual CardCode CardCode { get; set; }
        public virtual User User { get; set; }
    }
}
