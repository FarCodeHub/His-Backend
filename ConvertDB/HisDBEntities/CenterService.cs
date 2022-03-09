using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.HisDBEntities
{
    public partial class CenterService
    {
        public int Id { get; set; }
        public int ServiceTypeId { get; set; }
        public int CenterId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateTime { get; set; }

        public virtual MedicalCenter Center { get; set; }
        public virtual ServiceType ServiceType { get; set; }
    }
}
