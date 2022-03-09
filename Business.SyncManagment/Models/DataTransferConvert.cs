using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SyncManagment.Models
{
    public partial class DataTransferConvert
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
