using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class CenterSellingType
    {
        public int Id { get; set; }
        public int? CenterId { get; set; }
        public int? SellingTypeId { get; set; }

        public virtual Center Center { get; set; }
        public virtual SellingType SellingType { get; set; }
    }
}
