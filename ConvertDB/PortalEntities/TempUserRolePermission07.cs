using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class TempUserRolePermission07
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
        public int? SectionId { get; set; }
        public int? PermissionId { get; set; }
    }
}
