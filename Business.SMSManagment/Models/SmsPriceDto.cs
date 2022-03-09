using Business.SMSManagment.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SMSManagment.Models
{
    public class SmsPriceDto : IPaging
    {
        public int Id { get; set; }
        public string OperatorTitle { get; set; }
        public int? OperatorId { get; set; }
        public int? MaxCharNumber { get; set; }
        public decimal? Cost { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public DateTime? CostFromDate { get; set; }
        public DateTime? CostToDate { get; set; }
    }
}
