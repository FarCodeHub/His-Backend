using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Group
    {
        public Group()
        {
            DrugInteractionFirstGroups = new HashSet<DrugInteraction>();
            DrugInteractionSecondGroups = new HashSet<DrugInteraction>();
            GenericDrugs = new HashSet<GenericDrug>();
            InteractionFirstGroups = new HashSet<Interaction>();
            InteractionSecondGroups = new HashSet<Interaction>();
            ProhibitedUsages = new HashSet<ProhibitedUsage>();
            SideEffects = new HashSet<SideEffect>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string TitleLang2 { get; set; }
        public int? ParentId { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<DrugInteraction> DrugInteractionFirstGroups { get; set; }
        public virtual ICollection<DrugInteraction> DrugInteractionSecondGroups { get; set; }
        public virtual ICollection<GenericDrug> GenericDrugs { get; set; }
        public virtual ICollection<Interaction> InteractionFirstGroups { get; set; }
        public virtual ICollection<Interaction> InteractionSecondGroups { get; set; }
        public virtual ICollection<ProhibitedUsage> ProhibitedUsages { get; set; }
        public virtual ICollection<SideEffect> SideEffects { get; set; }
    }
}
