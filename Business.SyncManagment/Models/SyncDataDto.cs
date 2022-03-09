using Business.SyncManagment.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SyncManagment.Models
{
    public class SyncDataDto
    {
        public TablesWinAppEnum Table { get; set; }
        public string SerializedData { get; set; }
        public OperationWinAppEnum Operation { get; set; }
        public string ServerId { get; set; }
        public long LocalId { get; set; }
    }
}
