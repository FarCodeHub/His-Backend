using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SMSManagment.Models
{
    public class ListResponseDto : BaseResponseDto
    {
        public int Count { get; set; }
        public int PageSize { get; set; }

        public new static ListResponseDto Success(string message = "")
        {
            return new ListResponseDto
            {
                Status = ResponseStatus.Success,
                Message = message
            };
        }
    }
}
