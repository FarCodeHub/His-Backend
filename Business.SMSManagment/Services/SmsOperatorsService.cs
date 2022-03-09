using Business.SMSManagment.Extensions;
using Business.SMSManagment.IServices;
using Business.SMSManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SMSManagment.Services
{
    public class SmsOperatorsService : ISmsOperators
    {
        private readonly IOutRequestService _outRequest;

        public SmsOperatorsService(IOutRequestService outRequest)
        {
            _outRequest = outRequest;
        }

        public async Task<object> GetById(int id) => await _outRequest.OutRequestSMS<object>($"/api/SmsOperator/{id}", null, OutRequestTypeEnum.Get);
        public async Task<object> List() => await _outRequest.OutRequestSMS<object>($"/api/SmsOperator/List", null, OutRequestTypeEnum.Get);

        public async Task<object> Add(SmsOperatorsDto requestBaseDto)
        {
            return await _outRequest.OutRequestSMS<object>($"/api/SmsOperator", requestBaseDto, OutRequestTypeEnum.Post);
        }

        public async Task<object> Edit(SmsOperatorsDto requestBaseDto)
        {
            return await _outRequest.OutRequestSMS<object>($"/api/SmsOperator", requestBaseDto, OutRequestTypeEnum.Put);
        }

        public async Task<object> Delete(BaseRequestPost<int> baseRequestPost)
        {
            return await _outRequest.OutRequestSMS<object>($"/api/SmsOperator", baseRequestPost, OutRequestTypeEnum.Delete);
        }

    }
}
