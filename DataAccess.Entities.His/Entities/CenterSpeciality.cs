using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities.His.Entities
{
    public partial class CenterSpeciality
    {
        public int Id { get; set; }
        public int SpecialityId { get; set; }
        public int CenterId { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreateTime { get; set; }

        public virtual MedicalCenter Center { get; set; }
        public virtual Speciality Speciality { get; set; }
    }
}
