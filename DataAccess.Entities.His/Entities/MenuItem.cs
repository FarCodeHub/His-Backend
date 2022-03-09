using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities.His.Entities
{
    public partial class MenuItem
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public int? PermissionId { get; set; }
        public string MenuTitle { get; set; }
        public string Description { get; set; }
        public string RoutePath { get; set; }
        public string IconUrl { get; set; }

        public virtual Permission Permission { get; set; }
    }
}
