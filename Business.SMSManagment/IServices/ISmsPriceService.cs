using Business.SMSManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SMSManagment.IServices
{
    public interface ISmsPriceService
    {
        //Task<BaseResponseDto> Setting();
        //Task<BaseResponseDto> GetById(int id);
        //Task<BaseResponseDto> Add(SmsPriceDto dto);
        //Task<BaseResponseDto> Edit(SmsPriceDto dto);
        //Task<ListResponseDto> Search(SmsPriceDto dto);
        //Task<BaseResponseDto> Delete(BaseRequestPost<int> dto);


        Task<object> GetById(int id);
        Task<object> Add(SmsPriceDto dto);
        Task<object> Edit(SmsPriceDto dto);
        Task<object> Search(SmsPriceDto dto);
        Task<object> Delete(BaseRequestPost<int> dto);

    }
}
