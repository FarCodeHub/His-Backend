using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class TempPationlist
    {
        public int PatientId { get; set; }
        public bool IsActivationAccount { get; set; }
        public string NhsNumber { get; set; }
        public DateTime? AccountExpirationDate { get; set; }
        public string PatientName { get; set; }
        public string Mobile { get; set; }
        public DateTime? PortalRegisterDate { get; set; }
        public string DoctorName { get; set; }
        public string DoctorLatinName { get; set; }
        public DateTime? SyncDate { get; set; }
        public string PatientId2 { get; set; }
        public long? Id { get; set; }
        public string Introduced { get; set; }
        public string PatientTypeTitle { get; set; }
        public int? TotalRows { get; set; }
    }
}
