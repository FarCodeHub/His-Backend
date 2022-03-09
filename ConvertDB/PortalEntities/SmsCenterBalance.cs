using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class SmsCenterBalance
    {
        public int Id { get; set; }
        public int? CenterId { get; set; }
        public long? Balance { get; set; }
        public int? SmsCount { get; set; }

        public virtual Center Center { get; set; }
    }
}
