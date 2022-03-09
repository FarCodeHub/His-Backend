using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SMSManagment.Models
{
    public class SMSPortalDto
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public string Errors { get; set; }
        public SMSPortalDataDto Data { get; set; }
    }
    public class SMSPortalDataDto
    {
        public int Id { get; set; }
        public string Token { get; set; }
    }

    public class SMSBalanceMaxDto
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public object Errors { get; set; }
        public SMSBalanceMaxDataDto Data { get; set; }
    }
    public class SMSBalanceMaxDataDto
    {
        public int maxCharNumber { get; set; }
        public string cost { get; set; }
    }
}
