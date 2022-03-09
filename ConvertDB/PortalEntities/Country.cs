using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Country
    {
        public Country()
        {
            Centers = new HashSet<Center>();
            Companies = new HashSet<Company>();
            People = new HashSet<Person>();
            Provinces = new HashSet<Province>();
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

        public virtual ICollection<Center> Centers { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<Province> Provinces { get; set; }
    }
}
