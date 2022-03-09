using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class FileTag
    {
        public int Id { get; set; }
        public int? PatientId { get; set; }
        public int? UserId { get; set; }
        public int? FileId { get; set; }
        public string TagName { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual File File { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual User User { get; set; }
    }
}
