using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class StoreDrug
    {
        public long Id { get; set; }
        public int? DrugId { get; set; }
        public int? SectionId { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int? Quantity { get; set; }

        public virtual Drug Drug { get; set; }
        public virtual Section Section { get; set; }
    }
}
