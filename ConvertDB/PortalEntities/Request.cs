using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Request
    {
        public Request()
        {
            ReceptionDrugs = new HashSet<ReceptionDrug>();
            ReceptionServices = new HashSet<ReceptionService>();
            RequestHistories = new HashSet<RequestHistory>();
        }

        public long Id { get; set; }
        public long? ReceptionId { get; set; }
        public long? PrescriptionId { get; set; }
        public long? RequestCode { get; set; }
        public int? RequestTypeId { get; set; }
        public int? SourceSectionId { get; set; }
        public int? TargetSectionId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UserId { get; set; }
        public int? DoctorId { get; set; }
        public int? PriorityId { get; set; }
        public DateTime? PrescriptionDate { get; set; }
        public DateTime? DoneDate { get; set; }
        public string Note { get; set; }
        public int? RoleId { get; set; }

        public virtual Doctor Doctor { get; set; }
        public virtual Prescription Prescription { get; set; }
        public virtual Reception1 Reception { get; set; }
        public virtual RequestType RequestType { get; set; }
        public virtual Role Role { get; set; }
        public virtual Section SourceSection { get; set; }
        public virtual Section TargetSection { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ReceptionDrug> ReceptionDrugs { get; set; }
        public virtual ICollection<ReceptionService> ReceptionServices { get; set; }
        public virtual ICollection<RequestHistory> RequestHistories { get; set; }
    }
}
