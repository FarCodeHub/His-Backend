using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.HisDBEntities
{
    public partial class GenericDrug
    {
        public GenericDrug()
        {
            Drugs = new HashSet<Drug>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string TitleLang2 { get; set; }
        public string Note { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public int? GroupId { get; set; }
        public bool? IsAdmin { get; set; }
        public string NoteLang2 { get; set; }
        public bool? IsActive { get; set; }
        public int? LocalId { get; set; }

        public virtual Group Group { get; set; }
        public virtual ICollection<Drug> Drugs { get; set; }
    }
}
