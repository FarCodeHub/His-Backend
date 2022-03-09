using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class DoctorDegree
    {
        public DoctorDegree()
        {
            Doctors = new HashSet<Doctor>();
        }

        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int DegreeId { get; set; }
        public DateTime? DateOfIssue { get; set; }

        public virtual Degree Degree { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}
