using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SMSManagment.Models
{
    public class ListTransactionVM
    {
        public int Count { get; set; }
        public int PageSize { get; set; }
        public int Status { get; set; }
        public object Message { get; set; }
        public object Errors { get; set; }
        public List<ListTransactionDataVM> Data { get; set; }
    }

    public class ListTransactionDataVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Remaining { get; set; }
        public int TotalSend { get; set; }
        public double TotalPaymented { get; set; }
        public double TotalGift { get; set; }
    }
}
