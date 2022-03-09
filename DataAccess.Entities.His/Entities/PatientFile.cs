using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities.His.Entities
{
    public partial class PatientFile
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int FileId { get; set; }

        public virtual File File { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
