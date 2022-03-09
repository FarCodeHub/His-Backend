using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class CenterExamPlace
    {
        public int Id { get; set; }
        public int? CenterId { get; set; }
        public int? ExamplaceId { get; set; }

        public virtual Center Center { get; set; }
        public virtual Examplace Examplace { get; set; }
    }
}
