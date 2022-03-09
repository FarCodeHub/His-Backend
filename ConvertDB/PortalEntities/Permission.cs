using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Permission
    {
        public Permission()
        {
            Menus = new HashSet<Menu>();
            PermissionSectionFields = new HashSet<PermissionSectionField>();
            RolePermissions = new HashSet<RolePermission>();
            UserPermissions = new HashSet<UserPermission>();
            UserRolePermissions = new HashSet<UserRolePermission>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string TitleLang2 { get; set; }
        public string Note { get; set; }
        public string NoteLang2 { get; set; }
        public string PageAddress { get; set; }
        public string ModuleName { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }
        public virtual ICollection<PermissionSectionField> PermissionSectionFields { get; set; }
        public virtual ICollection<RolePermission> RolePermissions { get; set; }
        public virtual ICollection<UserPermission> UserPermissions { get; set; }
        public virtual ICollection<UserRolePermission> UserRolePermissions { get; set; }
    }
}
