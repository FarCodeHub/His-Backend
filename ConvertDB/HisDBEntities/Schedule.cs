using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.HisDBEntities
{
    public partial class Schedule
    {
        public Schedule()
        {
            RequestServices = new HashSet<RequestService>();
            ScheduleDetails = new HashSet<ScheduleDetail>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int? CenterId { get; set; }
        public int? MedicalStaffId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? ServiceTypeId { get; set; }
        public string TitleLang2 { get; set; }
        public int? DayQuantity { get; set; }
        public decimal? VisitPrice { get; set; }

        public virtual MedicalCenter Center { get; set; }
        public virtual MedicalStaff MedicalStaff { get; set; }
        public virtual ICollection<RequestService> RequestServices { get; set; }
        public virtual ICollection<ScheduleDetail> ScheduleDetails { get; set; }
    }
}
