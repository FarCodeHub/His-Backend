using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class TestAnswerTime
    {
        public int Id { get; set; }
        public int? ServiceId { get; set; }
        public bool? IsEveryDay { get; set; }
        public int? DayOfWeek { get; set; }
        public int? DayOfMonth { get; set; }

        public virtual Service Service { get; set; }
    }
}
