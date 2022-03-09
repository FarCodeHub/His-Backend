using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Zone
    {
        public Zone()
        {
            Centers = new HashSet<Center>();
            InverseParent = new HashSet<Zone>();
            People = new HashSet<Person>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string TitleLang2 { get; set; }
        public int? ParentId { get; set; }
        public int? LevelId { get; set; }
        public int? CityId { get; set; }
        public string Note { get; set; }
        public bool? IsAdmin { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public string NoteLang2 { get; set; }
        public bool? IsActive { get; set; }

        public virtual City City { get; set; }
        public virtual Zone Parent { get; set; }
        public virtual ICollection<Center> Centers { get; set; }
        public virtual ICollection<Zone> InverseParent { get; set; }
        public virtual ICollection<Person> People { get; set; }
    }
}
