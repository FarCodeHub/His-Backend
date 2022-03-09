using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Illness
    {
        public Illness()
        {
            PatientExtraInfos = new HashSet<PatientExtraInfo>();
            Reception1s = new HashSet<Reception1>();
            SpecialIllnessReceptions = new HashSet<SpecialIllnessReception>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string TitleLang2 { get; set; }
        public bool? IsSpecial { get; set; }
        public string LocalCode { get; set; }
        public int? IcdCodeId { get; set; }
        public string Note { get; set; }
        public string NoteLange2 { get; set; }
        public bool? IsAdmin { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<PatientExtraInfo> PatientExtraInfos { get; set; }
        public virtual ICollection<Reception1> Reception1s { get; set; }
        public virtual ICollection<SpecialIllnessReception> SpecialIllnessReceptions { get; set; }
    }
}
