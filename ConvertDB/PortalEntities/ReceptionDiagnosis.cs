using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class ReceptionDiagnosis
    {
        public ReceptionDiagnosis()
        {
            ReceptionDiagnosisHistories = new HashSet<ReceptionDiagnosisHistory>();
        }

        public long Id { get; set; }
        public int? DiagnosisId { get; set; }
        public long? ReceptionId { get; set; }
        public long? PrescriptionId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Note { get; set; }

        public virtual Diagnosis Diagnosis { get; set; }
        public virtual Prescription Prescription { get; set; }
        public virtual Reception1 Reception { get; set; }
        public virtual ICollection<ReceptionDiagnosisHistory> ReceptionDiagnosisHistories { get; set; }
    }
}
