using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class ReceptionDetail
    {
        public ReceptionDetail()
        {
            Samplings = new HashSet<Sampling>();
        }

        public long Id { get; set; }
        public long? ReceptionCode { get; set; }
        public long? ReceptionId { get; set; }
        public int? PrescriptionDoctorId { get; set; }
        public int? PatoDoctorId { get; set; }
        public int? StatusId { get; set; }
        public int? SectionId { get; set; }
        public bool? IsNoSample { get; set; }
        public bool? IsPregnant { get; set; }
        public DateTime? PrescriptionDate { get; set; }
        public DateTime? ReceptionDate { get; set; }
        public DateTime? AnswerDate { get; set; }
        public DateTime? LmpDate { get; set; }
        public string Note { get; set; }
        public int? AnswerPrintCount { get; set; }
        public long? RequestId { get; set; }

        public virtual Doctor PatoDoctor { get; set; }
        public virtual Doctor PrescriptionDoctor { get; set; }
        public virtual Reception1 Reception { get; set; }
        public virtual Section Section { get; set; }
        public virtual ReceptionServiceStatus Status { get; set; }
        public virtual ICollection<Sampling> Samplings { get; set; }
    }
}
