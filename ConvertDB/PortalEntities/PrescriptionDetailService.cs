using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class PrescriptionDetailService
    {
        public PrescriptionDetailService()
        {
            PrescriptionDetailServiceHistories = new HashSet<PrescriptionDetailServiceHistory>();
            PrescriptionServiceCharts = new HashSet<PrescriptionServiceChart>();
            ReceptionServices = new HashSet<ReceptionService>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public long? PrescriptionId { get; set; }
        public int? PrescriberNurseId { get; set; }
        public int? ServiceId { get; set; }
        public int? PrescriptionTypeId { get; set; }
        public int? Quantity { get; set; }
        public int? RequestFromSectionId { get; set; }
        public int? PrescriptionInstructionId { get; set; }
        public DateTime? ActionDate { get; set; }
        public int? PriorityId { get; set; }
        public int? Period { get; set; }
        public long? PanelId { get; set; }
        public DateTime? StartDate { get; set; }
        public bool? IsJustOnTime { get; set; }
        public string Note { get; set; }
        public int? FrequencyId { get; set; }

        public virtual Frequency Frequency { get; set; }
        public virtual PrescriptionPanel Panel { get; set; }
        public virtual User PrescriberNurse { get; set; }
        public virtual Prescription Prescription { get; set; }
        public virtual PrescriptionType PrescriptionType { get; set; }
        public virtual Priority Priority { get; set; }
        public virtual Section RequestFromSection { get; set; }
        public virtual Service Service { get; set; }
        public virtual ICollection<PrescriptionDetailServiceHistory> PrescriptionDetailServiceHistories { get; set; }
        public virtual ICollection<PrescriptionServiceChart> PrescriptionServiceCharts { get; set; }
        public virtual ICollection<ReceptionService> ReceptionServices { get; set; }
    }
}
