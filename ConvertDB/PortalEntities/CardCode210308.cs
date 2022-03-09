using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class CardCode210308
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string HealthNumber { get; set; }
        public string Token { get; set; }
        public string Serial { get; set; }
        public bool IsUsed { get; set; }
    }
}
