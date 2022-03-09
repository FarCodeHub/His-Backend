using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class ValidityPeriod
    {
        public ValidityPeriod()
        {
            UserCardCodes = new HashSet<UserCardCode>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string TitleLang2 { get; set; }
        public int? Minute { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<UserCardCode> UserCardCodes { get; set; }
    }
}
