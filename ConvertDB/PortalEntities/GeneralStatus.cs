using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class GeneralStatus
    {
        public GeneralStatus()
        {
            Reception1s = new HashSet<Reception1>();
            ReceptionHistories = new HashSet<ReceptionHistory>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string TitleLang2 { get; set; }
        public string Note { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public bool? IsAdmin { get; set; }
        public string NoteLang2 { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Reception1> Reception1s { get; set; }
        public virtual ICollection<ReceptionHistory> ReceptionHistories { get; set; }
    }
}
