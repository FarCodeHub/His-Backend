using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.HisDBEntities
{
    public partial class RolePermission
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreateTime { get; set; }

        public virtual Permission Permission { get; set; }
        public virtual Role Role { get; set; }
    }
}
