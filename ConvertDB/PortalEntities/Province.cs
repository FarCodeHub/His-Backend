using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Province
    {
        public Province()
        {
            Centers = new HashSet<Center>();
            Cities = new HashSet<City>();
            GiftReasons = new HashSet<GiftReason>();
            People = new HashSet<Person>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string TitleLang2 { get; set; }
        public string Note { get; set; }
        public bool? IsAdmin { get; set; }
        public string Code1 { get; set; }
        public string Code2 { get; set; }
        public string NoteLang2 { get; set; }
        public bool? IsActive { get; set; }
        public int? CountryId { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Center> Centers { get; set; }
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<GiftReason> GiftReasons { get; set; }
        public virtual ICollection<Person> People { get; set; }
    }
}
