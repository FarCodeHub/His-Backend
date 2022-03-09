using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class SubSystem
    {
        public SubSystem()
        {
            ShortLinks = new HashSet<ShortLink>();
        }

        public int Id { get; set; }
        public string SubSystem1 { get; set; }
        public string Token { get; set; }

        public virtual ICollection<ShortLink> ShortLinks { get; set; }
    }
}
