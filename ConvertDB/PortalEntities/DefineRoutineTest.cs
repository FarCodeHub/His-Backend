using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class DefineRoutineTest
    {
        public int Id { get; set; }
        public int? DefineRoutineId { get; set; }
        public int? ServiceId { get; set; }

        public virtual DefineRoutine DefineRoutine { get; set; }
        public virtual Service Service { get; set; }
    }
}
