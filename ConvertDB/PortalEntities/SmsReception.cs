using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class SmsReception
    {
        public long Id { get; set; }
        public long? ReceptionId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? SendDate { get; set; }
        public string Mobile { get; set; }
        public int? SendsmsStatusId { get; set; }
        public string SmsContent { get; set; }
        public string FileName { get; set; }

        public virtual Reception1 Reception { get; set; }
        public virtual SendSmsStatus SendsmsStatus { get; set; }
    }
}
