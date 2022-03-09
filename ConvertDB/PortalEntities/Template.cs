using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Template
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string TemplateBody { get; set; }
        public string Code { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsAdmin { get; set; }

        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
