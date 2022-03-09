using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class ShortLink
    {
        public string Id { get; set; }
        public string Link { get; set; }
        public int? SubSystemId { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual SubSystem SubSystem { get; set; }
    }
}
