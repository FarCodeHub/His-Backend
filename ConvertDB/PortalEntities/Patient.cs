using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Patient
    {
        public Patient()
        {
            AnswerServices = new HashSet<AnswerService>();
            FileTags = new HashSet<FileTag>();
            PatientExtraInfos = new HashSet<PatientExtraInfo>();
            Reception1s = new HashSet<Reception1>();
        }

        public int Id { get; set; }
        public int? PersonId { get; set; }
        public string Note { get; set; }
        public DateTime? CreateDate { get; set; }
        public long? Hisno { get; set; }
        public string FileNo { get; set; }
        public int? InternalId { get; set; }
        public int? BloodGroupId { get; set; }

        public virtual BloodGroup BloodGroup { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<AnswerService> AnswerServices { get; set; }
        public virtual ICollection<FileTag> FileTags { get; set; }
        public virtual ICollection<PatientExtraInfo> PatientExtraInfos { get; set; }
        public virtual ICollection<Reception1> Reception1s { get; set; }
    }
}
