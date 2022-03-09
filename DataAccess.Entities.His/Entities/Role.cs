using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities.His.Entities
{
    public partial class Role
    {
        public Role()
        {
            RolePermissions = new HashSet<RolePermission>();
            UserRoles = new HashSet<UserRole>();
        }

        public int Id { get; set; }
        public string RoleTitle { get; set; }
        public string UniqueName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<RolePermission> RolePermissions { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
