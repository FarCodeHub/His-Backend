using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class GiftReason
    {
        public GiftReason()
        {
            BuyMessages = new HashSet<BuyMessage>();
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
        public int? ProvinceId { get; set; }

        public virtual Province Province { get; set; }
        public virtual ICollection<BuyMessage> BuyMessages { get; set; }
    }
}
