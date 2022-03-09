using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.HisDBEntities
{
    public partial class BuyMessage
    {
        public int Id { get; set; }
        public long? Cost { get; set; }
        public int? CenterId { get; set; }
        public int? GitReasonId { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual MedicalCenter Center { get; set; }
    }
}
