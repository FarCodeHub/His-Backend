using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class CenterService
    {
        public int Id { get; set; }
        public int? CenterId { get; set; }
        public int? ServiceId { get; set; }

        public virtual Center Center { get; set; }
        public virtual Service Service { get; set; }
    }
}
