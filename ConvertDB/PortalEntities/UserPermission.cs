using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class UserPermission
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int SectionId { get; set; }
        public int? PermissionId { get; set; }
        public int? RoleId { get; set; }

        public virtual Permission Permission { get; set; }
        public virtual Role Role { get; set; }
        public virtual Section Section { get; set; }
        public virtual User User { get; set; }
    }
}
