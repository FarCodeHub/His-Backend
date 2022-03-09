using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities.His.Entities
{
    public partial class PrescriptionDetailDrug
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public long? PrescriptionId { get; set; }
        public int? PrescriberNurseId { get; set; }
        public int? GenericDrugId { get; set; }
        public int? PrescriptionTypeId { get; set; }
        public int? PriorityId { get; set; }
        public int? DrugFormId { get; set; }
        public int? Quantity { get; set; }
        public int? RequestFromSectionId { get; set; }
        public int? PrescriptionInstructionId { get; set; }
        public int? WayOfPrescriptionId { get; set; }
        public DateTime? ActionDate { get; set; }
        public int? Period { get; set; }
        public long? PanelId { get; set; }
        public DateTime? StartDate { get; set; }
        public bool? IsJustOnTime { get; set; }
        public string Note { get; set; }
        public int? FrequencyId { get; set; }
        public int? DrugId { get; set; }
        public int? DurationNumber { get; set; }
        public int? DurationTypeId { get; set; }
        public long? LocalId { get; set; }

        public virtual Drug Drug { get; set; }
        public virtual Prescription Prescription { get; set; }
    }
}
