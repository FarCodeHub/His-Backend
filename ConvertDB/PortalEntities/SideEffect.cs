using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class SideEffect
    {
        public int Id { get; set; }
        public int? GroupId { get; set; }
        public int? GenericDrugId { get; set; }
        public int? DrugId { get; set; }
        public string Note { get; set; }

        public virtual Drug Drug { get; set; }
        public virtual GenericDrug GenericDrug { get; set; }
        public virtual Group Group { get; set; }
    }
}
