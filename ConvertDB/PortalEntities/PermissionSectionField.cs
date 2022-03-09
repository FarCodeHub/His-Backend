using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class PermissionSectionField
    {
        public int Id { get; set; }
        public int? SectionFieldId { get; set; }
        public int? PermissionId { get; set; }

        public virtual Permission Permission { get; set; }
        public virtual SectionField SectionField { get; set; }
    }
}
