using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class ImportedDicom
    {
        public int Id { get; set; }
        public int? PatientId { get; set; }
        public Guid? FileId { get; set; }
        public int? FileNumber { get; set; }
        public int? FileSize { get; set; }
    }
}
