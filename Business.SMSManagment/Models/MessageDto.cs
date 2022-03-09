using Business.SMSManagment.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SMSManagment.Models
{
    public class MessageDto
    {
        public int DoctorId { get; set; }
        public int CenterId { get; set; }
        public int Cost { get; set; }
        public string GiftReasonTitle { get; set; }
        public int? GiftReasonId { get; set; }
    }

    public class MessageFilterDto : IPaging
    {
        public int CenterId { get; set; }
        public int CenterTypeId { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
    }

    public class LogMessageFilterDto : IPaging
    {
        public int Id { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
    }

    public class GeneralInfoDto
    {
        public GeneralInfoDataDto Data { get; set; }
        public string Message { get; set; }
        public int Status { get; set; }
    }

    public class GeneralInfoDataDto
    {
        public List<BaseInfoDto> SmsGiftReasons { get; set; }
        public List<BaseInfoDto> Operators { get; set; }
    }

    public class BaseInfoDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
