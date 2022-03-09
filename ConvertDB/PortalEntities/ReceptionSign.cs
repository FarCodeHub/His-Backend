using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class ReceptionSign
    {
        public long Id { get; set; }
        public int? SignId { get; set; }
        public long? ReceptionId { get; set; }

        public virtual Reception1 Reception { get; set; }
        public virtual Sign Sign { get; set; }
    }
}
