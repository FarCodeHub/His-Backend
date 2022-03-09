using Business.SMSManagment.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SMSManagment.Models
{
    public class OutRequestDto
    {
        public OutRequestTypeEnum RequestType { get; set; }
        public string ApiUrl { get; set; }
        public object Parameters { get; set; }
    }
}
