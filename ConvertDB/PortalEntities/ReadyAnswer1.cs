using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class ReadyAnswer1
    {
        public ReadyAnswer1()
        {
            Answer1s = new HashSet<Answer1>();
            GroupReadyAnswer1s = new HashSet<GroupReadyAnswer1>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string TitleLang2 { get; set; }
        public string Note { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public bool? IsAdmin { get; set; }
        public string NoteLang2 { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Answer1> Answer1s { get; set; }
        public virtual ICollection<GroupReadyAnswer1> GroupReadyAnswer1s { get; set; }
    }
}
