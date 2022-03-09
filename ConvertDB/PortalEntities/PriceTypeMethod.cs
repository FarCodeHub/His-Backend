using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class PriceTypeMethod
    {
        public PriceTypeMethod()
        {
            ReceptionDrugs = new HashSet<ReceptionDrug>();
            ReceptionServices = new HashSet<ReceptionService>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string TitleLang2 { get; set; }
        public string Note { get; set; }
        public string NoteLang2 { get; set; }
        public bool? IsActive { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public bool? IsAdmin { get; set; }

        public virtual ICollection<ReceptionDrug> ReceptionDrugs { get; set; }
        public virtual ICollection<ReceptionService> ReceptionServices { get; set; }
    }
}
