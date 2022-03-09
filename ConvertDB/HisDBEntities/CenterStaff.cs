using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.HisDBEntities
{
    public partial class CenterStaff
    {
        public int Id { get; set; }
        public int MedicalStaffId { get; set; }
        public int? CenterId { get; set; }
        public int? EmployeeType { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? ActiveTime { get; set; }
        public int? LocalId { get; set; }

        public virtual MedicalCenter Center { get; set; }
        public virtual MedicalStaff MedicalStaff { get; set; }
    }
}
