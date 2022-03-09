using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.HisDBEntities
{
    public partial class MedicalStaffCertificate
    {
        public int Id { get; set; }
        public int? MedicalStaffId { get; set; }
        public int? CertificateId { get; set; }
        public int? LocalId { get; set; }

        public virtual Certificate Certificate { get; set; }
        public virtual MedicalStaff MedicalStaff { get; set; }
    }
}
