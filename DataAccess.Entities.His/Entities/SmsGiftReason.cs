using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities.His.Entities
{
    public partial class SmsGiftReason
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string TitleLang2 { get; set; }
        public string LocalCode { get; set; }
        public string Note { get; set; }
        public bool? IsAdmin { get; set; }
        public string NoteLang2 { get; set; }
        public int? IcdCodeId { get; set; }
        public bool? IsActive { get; set; }
    }
}
