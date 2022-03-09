using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class ReceptionServiceStatus
    {
        public ReceptionServiceStatus()
        {
            ReceptionDetails = new HashSet<ReceptionDetail>();
            ReceptionServices = new HashSet<ReceptionService>();
        }

        public int Id { get; set; }
        public int? SectionId { get; set; }
        public string Title { get; set; }
        public string TitleLang2 { get; set; }
        public string Note { get; set; }
        public string NoteLang2 { get; set; }
        public bool? IsActive { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public bool? IsAdmin { get; set; }

        public virtual Section Section { get; set; }
        public virtual ICollection<ReceptionDetail> ReceptionDetails { get; set; }
        public virtual ICollection<ReceptionService> ReceptionServices { get; set; }
    }
}
