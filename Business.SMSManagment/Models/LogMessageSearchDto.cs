using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SMSManagment.Models
{
    public class LogMessageSearchDto
    {
        public int Count { get; set; }
        public int PageSize { get; set; }
        public int Status { get; set; }
        public object Message { get; set; }
        public object Errors { get; set; }
        public List<LogMessageSearchDataDto> Data { get; set; }
    }
    public class LogMessageSearchDataDto
    {
        public DateTime? DateCreated { get; set; }
        public string Body { get; set; }
        public string Title { get; set; }
        public string To { get; set; }
        public int StatusId { get; set; }
    }
}
