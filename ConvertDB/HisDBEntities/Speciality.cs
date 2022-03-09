using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.HisDBEntities
{
    public partial class Speciality
    {
        public Speciality()
        {
            CenterSpecialities = new HashSet<CenterSpeciality>();
            MedicalStaffSpecialities = new HashSet<MedicalStaffSpeciality>();
        }

        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Title { get; set; }
        public string AbbreviationTitle { get; set; }
        public int? LocalId { get; set; }

        public virtual ICollection<CenterSpeciality> CenterSpecialities { get; set; }
        public virtual ICollection<MedicalStaffSpeciality> MedicalStaffSpecialities { get; set; }
    }
}
