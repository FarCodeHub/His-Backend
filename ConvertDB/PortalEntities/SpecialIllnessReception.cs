using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class SpecialIllnessReception
    {
        public int Id { get; set; }
        public long? ReceptionId { get; set; }
        public int? SpecialIllnessId { get; set; }

        public virtual Reception1 Reception { get; set; }
        public virtual Illness SpecialIllness { get; set; }
    }
}
