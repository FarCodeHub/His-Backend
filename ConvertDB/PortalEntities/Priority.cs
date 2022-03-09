using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Priority
    {
        public Priority()
        {
            PrescriptionDetailDrugs = new HashSet<PrescriptionDetailDrug>();
            PrescriptionDetailServices = new HashSet<PrescriptionDetailService>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string TitleLang2 { get; set; }
        public string Note { get; set; }
        public int? Arrange { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public bool? IsAdmin { get; set; }
        public bool? IsActive { get; set; }
        public string NoteLang2 { get; set; }

        public virtual ICollection<PrescriptionDetailDrug> PrescriptionDetailDrugs { get; set; }
        public virtual ICollection<PrescriptionDetailService> PrescriptionDetailServices { get; set; }
    }
}
