using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class RolePermission
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public int? SectionId { get; set; }
        public int? PermissionId { get; set; }

        public virtual Permission Permission { get; set; }
        public virtual Role Role { get; set; }
        public virtual Section Section { get; set; }
    }
}
