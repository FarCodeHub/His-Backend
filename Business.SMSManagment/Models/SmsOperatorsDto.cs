using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SMSManagment.Models
{
    public class SmsOperatorsResultDto
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public string Errors { get; set; }
        public SmsOperatorsDto Data { get; set; }
    }
    public partial class SmsOperatorsDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string TitleLang2 { get; set; }
        public string LocalCode { get; set; }
        public string Note { get; set; }
        public bool? IsAdmin { get; set; }
        public string NoteLang2 { get; set; }
        public int? IcdCodeId { get; set; }
        public bool? IsActive { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
    }
}
