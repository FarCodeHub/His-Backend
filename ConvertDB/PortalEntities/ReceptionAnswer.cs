using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class ReceptionAnswer
    {
        public long Id { get; set; }
        public int? AnswerId { get; set; }
        public int? QuestionId { get; set; }
        public long? ReceptionId { get; set; }
        public DateTime? InfoDate { get; set; }

        public virtual Answer Answer { get; set; }
        public virtual Question Question { get; set; }
        public virtual Reception1 Reception { get; set; }
    }
}
