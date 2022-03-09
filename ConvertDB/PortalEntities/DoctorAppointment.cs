using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class DoctorAppointment
    {
        public DoctorAppointment()
        {
            DoctorAppointmentDetails = new HashSet<DoctorAppointmentDetail>();
            DoctorDayOffs = new HashSet<DoctorDayOff>();
        }

        public long Id { get; set; }
        public int? DoctorId { get; set; }
        public int? DurationTypeId { get; set; }
        public int? AppointmentTypeId { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public int DayQuantity { get; set; }

        public virtual AppointmentType AppointmentType { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual DurationType DurationType { get; set; }
        public virtual ICollection<DoctorAppointmentDetail> DoctorAppointmentDetails { get; set; }
        public virtual ICollection<DoctorDayOff> DoctorDayOffs { get; set; }
    }
}
