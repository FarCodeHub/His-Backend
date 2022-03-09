using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities.His.Entities
{
    public partial class MedicalStaffSpeciality
    {
        public int Id { get; set; }
        public int SpecialityId { get; set; }
        public int MedicalStaffId { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsDelete { get; set; }

        public virtual MedicalStaff MedicalStaff { get; set; }
        public virtual Speciality Speciality { get; set; }
    }
}
