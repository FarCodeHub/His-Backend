using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Setting1
    {
        public int Id { get; set; }
        public string KeyName { get; set; }
        public string KeyValue { get; set; }
        public bool? IsActive { get; set; }
        public int? CategorySettingId { get; set; }
    }
}
