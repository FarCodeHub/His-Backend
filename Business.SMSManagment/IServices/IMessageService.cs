using Business.SMSManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SMSManagment.IServices
{
    public interface IMessageService
    {
        Task<BaseResponseDto> GetById(int id);
        Task<BaseResponseDto> Add(MessageDto dtos);
        Task<ListResponseDto> Search(MessageFilterDto filterDto);
        Task<ListResponseDto> TransactionSearch(MessageFilterDto filterDto);
        Task<ListResponseDto> LogMessageSearch(LogMessageFilterDto filterDto);
        Task<BaseResponseDto> BalanceMax();
        Task<BaseResponseDto> General(string pageName);
    }
}
