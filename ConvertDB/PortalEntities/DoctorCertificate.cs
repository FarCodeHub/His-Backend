using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class DoctorCertificate
    {
        public int Id { get; set; }
        public int? DoctorId { get; set; }
        public int? CertificateId { get; set; }

        public virtual Certificate Certificate { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
