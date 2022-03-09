using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class PrescriptionChartActionType
    {
        public PrescriptionChartActionType()
        {
            PrescriptionDrugCharts = new HashSet<PrescriptionDrugChart>();
            PrescriptionServiceCharts = new HashSet<PrescriptionServiceChart>();
        }

        public int Id { get; set; }
        public string ActionTitle { get; set; }

        public virtual ICollection<PrescriptionDrugChart> PrescriptionDrugCharts { get; set; }
        public virtual ICollection<PrescriptionServiceChart> PrescriptionServiceCharts { get; set; }
    }
}
