using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities.His.Entities
{
    public partial class Group
    {
        public Group()
        {
            GenericDrugs = new HashSet<GenericDrug>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string TitleLang2 { get; set; }
        public int? ParentId { get; set; }
        public bool? IsActive { get; set; }
        public int? LocalId { get; set; }

        public virtual ICollection<GenericDrug> GenericDrugs { get; set; }
    }
}
