using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Sign
    {
        public Sign()
        {
            PrescriptionSigns = new HashSet<PrescriptionSign>();
            ReceptionSigns = new HashSet<ReceptionSign>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string TitleLang2 { get; set; }
        public string LocalCode { get; set; }
        public string Note { get; set; }
        public string NoteLange2 { get; set; }
        public bool? IsAdmin { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<PrescriptionSign> PrescriptionSigns { get; set; }
        public virtual ICollection<ReceptionSign> ReceptionSigns { get; set; }
    }
}
