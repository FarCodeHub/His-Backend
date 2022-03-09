using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.HisDBEntities
{
    public partial class ScheduleDetail
    {
        public int Id { get; set; }
        public int? ScheduleId { get; set; }
        public int? MedicalStaffId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        public virtual MedicalStaff MedicalStaff { get; set; }
        public virtual Schedule Schedule { get; set; }
    }
}
