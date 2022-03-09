using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class RelatedTest
    {
        public int Id { get; set; }
        public int? MainServiceId { get; set; }
        public int? SubServiceId { get; set; }

        public virtual Service MainService { get; set; }
        public virtual Service SubService { get; set; }
    }
}
