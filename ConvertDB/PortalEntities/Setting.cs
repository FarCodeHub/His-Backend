using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Setting
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public bool? IsActive { get; set; }
        public int? CategorySettingId { get; set; }
        public int? CenterId { get; set; }

        public virtual Center Center { get; set; }
    }
}
