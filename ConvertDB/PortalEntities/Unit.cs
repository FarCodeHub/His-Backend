using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Unit
    {
        public Unit()
        {
            PrescriptionServiceCharts = new HashSet<PrescriptionServiceChart>();
            PrescriptionServiceResults = new HashSet<PrescriptionServiceResult>();
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

        public virtual ICollection<PrescriptionServiceChart> PrescriptionServiceCharts { get; set; }
        public virtual ICollection<PrescriptionServiceResult> PrescriptionServiceResults { get; set; }
    }
}
