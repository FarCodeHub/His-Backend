using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SMSManagment.Models
{
    public class TransactionVM
    {
        public int Count { get; set; }
        public int PageSize { get; set; }
        public int Status { get; set; }
        public object Message { get; set; }
        public object Errors { get; set; }
        public List<TransactionDataVM> Data { get; set; }
    }

    public class TransactionDataVM
    {
        public int? UserId { get; set; }
        public decimal? Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Status { get; set; }
        public string SmsGiftReason { get; set; }
    }
}
