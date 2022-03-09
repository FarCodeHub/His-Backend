using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.HisDBEntities
{
    public partial class Permission
    {
        public Permission()
        {
            MenuItems = new HashSet<MenuItem>();
            RolePermissions = new HashSet<RolePermission>();
        }

        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string PermissionTitle { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MenuItem> MenuItems { get; set; }
        public virtual ICollection<RolePermission> RolePermissions { get; set; }
    }
}
