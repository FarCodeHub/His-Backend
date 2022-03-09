using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class PrescriptionDrugChart
    {
        public long Id { get; set; }
        public DateTime? PrescriptionDoDate { get; set; }
        public int? UserId { get; set; }
        public int? FunctorId { get; set; }
        public int? WitnessId { get; set; }
        public long? PrescriptionDetailDrugId { get; set; }
        public int? PrescriptionChartCancelationReasonId { get; set; }
        public int? PrescriptionChartActionTypeId { get; set; }
        public DateTime? DoneDate { get; set; }
        public int? DrugId { get; set; }
        public string Note { get; set; }
        public int? RoleId { get; set; }

        public virtual Drug Drug { get; set; }
        public virtual User Functor { get; set; }
        public virtual PrescriptionChartActionType PrescriptionChartActionType { get; set; }
        public virtual PrescriptionChartCancelationReason PrescriptionChartCancelationReason { get; set; }
        public virtual PrescriptionDetailDrug PrescriptionDetailDrug { get; set; }
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
        public virtual User Witness { get; set; }
    }
}
