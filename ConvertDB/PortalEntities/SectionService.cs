using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class SectionService
    {
        public int Id { get; set; }
        public int? ServiceId { get; set; }
        public int? SectionId { get; set; }

        public virtual Section Section { get; set; }
        public virtual Service Service { get; set; }
    }
}
