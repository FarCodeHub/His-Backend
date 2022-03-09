using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Pcr
    {
        public long Id { get; set; }
        public int? SectionId { get; set; }
        public string AgeRange { get; set; }
        public short? Age { get; set; }
        public DateTime? AnswerDate { get; set; }
        public string Result { get; set; }
    }
}
