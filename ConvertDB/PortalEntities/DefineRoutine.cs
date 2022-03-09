using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class DefineRoutine
    {
        public DefineRoutine()
        {
            DefineRoutineTests = new HashSet<DefineRoutineTest>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<DefineRoutineTest> DefineRoutineTests { get; set; }
    }
}
