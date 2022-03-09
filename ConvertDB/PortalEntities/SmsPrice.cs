using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class SmsPrice
    {
        public int Id { get; set; }
        public int? OperatorId { get; set; }
        public int? MaxCharNumber { get; set; }
        public decimal? Cost { get; set; }
        public DateTime? CostFromDate { get; set; }
        public DateTime? CostToDate { get; set; }

        public virtual SmsOperator Operator { get; set; }
    }
}
