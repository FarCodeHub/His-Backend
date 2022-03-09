using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class DoctorDayOff
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public long? DoctorAppointmentId { get; set; }

        public virtual DoctorAppointment DoctorAppointment { get; set; }
    }
}
