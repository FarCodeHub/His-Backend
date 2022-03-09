using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class CompanyAndType
    {
        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public int? CompanyTypeId { get; set; }

        public virtual Company Company { get; set; }
        public virtual CompanyType CompanyType { get; set; }
    }
}
