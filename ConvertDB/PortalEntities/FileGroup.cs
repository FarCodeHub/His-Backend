using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class FileGroup
    {
        public FileGroup()
        {
            Files = new HashSet<File>();
        }

        public int Id { get; set; }
        public int? ParentId { get; set; }
        public int LevelNo { get; set; }
        public string Title { get; set; }
        public string TitleLang2 { get; set; }
        public string Code { get; set; }

        public virtual ICollection<File> Files { get; set; }
    }
}
