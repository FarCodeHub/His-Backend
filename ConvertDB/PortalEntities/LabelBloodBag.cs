using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class LabelBloodBag
    {
        public int Id { get; set; }
        public int? BloodBankLabelingId { get; set; }
        public int? BloodBankLabelStyleId { get; set; }
        public bool? IsBarcode { get; set; }
        public int? Arrange { get; set; }

        public virtual LabelSampleTestStyle BloodBankLabelStyle { get; set; }
        public virtual BloodBankLabeling BloodBankLabeling { get; set; }
    }
}
