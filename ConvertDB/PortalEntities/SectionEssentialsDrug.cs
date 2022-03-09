using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class SectionEssentialsDrug
    {
        public int Id { get; set; }
        public int? DrugId { get; set; }
        public int? OrderPoint { get; set; }
        public int? SectionId { get; set; }

        public virtual Drug Drug { get; set; }
        public virtual Section Section { get; set; }
    }
}
