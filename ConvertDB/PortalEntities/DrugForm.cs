using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class DrugForm
    {
        public DrugForm()
        {
            Drugs = new HashSet<Drug>();
            PackagingTypes = new HashSet<PackagingType>();
            PrescriptionDetailDrugs = new HashSet<PrescriptionDetailDrug>();
            RequestDetails = new HashSet<RequestDetail>();
            SectionEssentialsGenericDrugs = new HashSet<SectionEssentialsGenericDrug>();
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

        public virtual ICollection<Drug> Drugs { get; set; }
        public virtual ICollection<PackagingType> PackagingTypes { get; set; }
        public virtual ICollection<PrescriptionDetailDrug> PrescriptionDetailDrugs { get; set; }
        public virtual ICollection<RequestDetail> RequestDetails { get; set; }
        public virtual ICollection<SectionEssentialsGenericDrug> SectionEssentialsGenericDrugs { get; set; }
    }
}
