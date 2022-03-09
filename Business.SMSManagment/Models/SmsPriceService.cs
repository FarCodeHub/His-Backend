using Business.SMSManagment.Extensions;
using Business.SMSManagment.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SMSManagment.Models
{
    public class SmsPriceService : ISmsPriceService
    {
        private readonly IOutRequestService _outRequest;

        public SmsPriceService(IOutRequestService outRequest)
        {
            _outRequest = outRequest;
        }

        public async Task<object> GetById(int id) => await _outRequest.OutRequestSMS<object>($"/api/SmsPrice/{id}", null, OutRequestTypeEnum.Get);

        //public async Task<BaseResponseDto> Setting()
        //{
        //    var query = await _smsPriceRepository
        //        .OrderByDescending(n => n.Cost)
        //        .AsNoTracking()
        //        .FirstOrDefaultAsync();

        //    return new BaseResponseDto
        //    {
        //        Status = ResponseStatus.Success,
        //        Data = query
        //    };
        //}
        public async Task<object> Search(SmsPriceDto dto) => await _outRequest.OutRequestSMS<object>($"/api/SmsPrice/List", dto, OutRequestTypeEnum.Post);

        public async Task<object> Add(SmsPriceDto dto) => await _outRequest.OutRequestSMS<object>($"/api/SmsPrice", dto, OutRequestTypeEnum.Post);

        public async Task<object> Edit(SmsPriceDto dto) => await _outRequest.OutRequestSMS<object>($"/api/SmsPrice", dto, OutRequestTypeEnum.Put);

        public async Task<object> Delete(BaseRequestPost<int> dto) => await _outRequest.OutRequestSMS<object>($"/api/SmsPrice", dto, OutRequestTypeEnum.Delete);

    }
}
