using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class GenericDrug
    {
        public GenericDrug()
        {
            DrugInteractionFirstGenericDrugs = new HashSet<DrugInteraction>();
            DrugInteractionSecondGenericDrugs = new HashSet<DrugInteraction>();
            Drugs = new HashSet<Drug>();
            InteractionFirstGenericDrugs = new HashSet<Interaction>();
            InteractionSecondGenericDrugs = new HashSet<Interaction>();
            PrescriptionDetailDrugs = new HashSet<PrescriptionDetailDrug>();
            PrescriptionDrugRoutines = new HashSet<PrescriptionDrugRoutine>();
            ProhibitedUsages = new HashSet<ProhibitedUsage>();
            RequestDetails = new HashSet<RequestDetail>();
            SectionEssentialsGenericDrugs = new HashSet<SectionEssentialsGenericDrug>();
            SideEffects = new HashSet<SideEffect>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string TitleLang2 { get; set; }
        public string Note { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public int? GroupId { get; set; }
        public bool? IsAdmin { get; set; }
        public string NoteLang2 { get; set; }
        public bool? IsActive { get; set; }

        public virtual Group Group { get; set; }
        public virtual ICollection<DrugInteraction> DrugInteractionFirstGenericDrugs { get; set; }
        public virtual ICollection<DrugInteraction> DrugInteractionSecondGenericDrugs { get; set; }
        public virtual ICollection<Drug> Drugs { get; set; }
        public virtual ICollection<Interaction> InteractionFirstGenericDrugs { get; set; }
        public virtual ICollection<Interaction> InteractionSecondGenericDrugs { get; set; }
        public virtual ICollection<PrescriptionDetailDrug> PrescriptionDetailDrugs { get; set; }
        public virtual ICollection<PrescriptionDrugRoutine> PrescriptionDrugRoutines { get; set; }
        public virtual ICollection<ProhibitedUsage> ProhibitedUsages { get; set; }
        public virtual ICollection<RequestDetail> RequestDetails { get; set; }
        public virtual ICollection<SectionEssentialsGenericDrug> SectionEssentialsGenericDrugs { get; set; }
        public virtual ICollection<SideEffect> SideEffects { get; set; }
    }
}
