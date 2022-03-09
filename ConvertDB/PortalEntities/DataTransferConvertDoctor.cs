using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class DataTransferConvertDoctor
    {
        public long Id { get; set; }
        public string TableId { get; set; }
        public string TargetTableId { get; set; }
        public string TableName { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UserId { get; set; }
        public bool? IsSyncOk { get; set; }
        public string SyncMessage { get; set; }
    }
}
