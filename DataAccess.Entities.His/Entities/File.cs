using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities.His.Entities
{
    public partial class File
    {
        public File()
        {
            PatientFiles = new HashSet<PatientFile>();
        }

        public int Id { get; set; }
        public string FileFolderName { get; set; }
        public int Type { get; set; }
        public int? ParentFolderId { get; set; }
        public DateTime CreateTime { get; set; }
        public bool? IsDeleted { get; set; }
        public int? CenterId { get; set; }
        public int? LocalId { get; set; }

        public virtual MedicalCenter Center { get; set; }
        public virtual ICollection<PatientFile> PatientFiles { get; set; }
    }
}
