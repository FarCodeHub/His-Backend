using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class ClearanceType
    {
        public ClearanceType()
        {
            ReceptionHistories = new HashSet<ReceptionHistory>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string TitleLang2 { get; set; }
        public string Note { get; set; }
        public bool? IsAdmin { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public string NoteLang2 { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<ReceptionHistory> ReceptionHistories { get; set; }
    }
}
