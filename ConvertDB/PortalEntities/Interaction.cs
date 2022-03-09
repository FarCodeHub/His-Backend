using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Interaction
    {
        public int Id { get; set; }
        public int? FirstGroupId { get; set; }
        public int? FirstGenericDrugId { get; set; }
        public int? FirstDrugId { get; set; }
        public int? SecondGroupId { get; set; }
        public int? SecondGenericDrugId { get; set; }
        public int? SecondDrugId { get; set; }
        public string Note { get; set; }

        public virtual Drug FirstDrug { get; set; }
        public virtual GenericDrug FirstGenericDrug { get; set; }
        public virtual Group FirstGroup { get; set; }
        public virtual Drug SecondDrug { get; set; }
        public virtual GenericDrug SecondGenericDrug { get; set; }
        public virtual Group SecondGroup { get; set; }
    }
}
