using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class SectionStore
    {
        public int Id { get; set; }
        public int? SectionId { get; set; }
        public int? StoreId { get; set; }
        public int? SectionKindId { get; set; }

        public virtual Section Section { get; set; }
        public virtual SectionKind SectionKind { get; set; }
        public virtual Section Store { get; set; }
    }
}
