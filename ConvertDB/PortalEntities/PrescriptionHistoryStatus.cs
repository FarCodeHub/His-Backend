using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class PrescriptionHistoryStatus
    {
        public PrescriptionHistoryStatus()
        {
            PrescriptionDetailDrugHistories = new HashSet<PrescriptionDetailDrugHistory>();
            PrescriptionDetailServiceHistories = new HashSet<PrescriptionDetailServiceHistory>();
        }

        public int Id { get; set; }
        public string StatusTitle { get; set; }

        public virtual ICollection<PrescriptionDetailDrugHistory> PrescriptionDetailDrugHistories { get; set; }
        public virtual ICollection<PrescriptionDetailServiceHistory> PrescriptionDetailServiceHistories { get; set; }
    }
}
