using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class RichLongAnswer
    {
        public RichLongAnswer()
        {
            Services = new HashSet<Service>();
        }

        public int Id { get; set; }
        public string Answer { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public int? ServiceId { get; set; }

        public virtual Service Service { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }
}
