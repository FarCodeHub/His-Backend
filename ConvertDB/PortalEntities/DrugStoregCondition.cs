using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class DrugStoregCondition
    {
        public int Id { get; set; }
        public int? StoregConditonId { get; set; }
        public int? DrugId { get; set; }

        public virtual Drug Drug { get; set; }
        public virtual StoregCondition StoregConditon { get; set; }
    }
}
