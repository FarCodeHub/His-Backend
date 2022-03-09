using Business.SMSManagment.Extensions;
using Business.SMSManagment.IServices;
using Business.SMSManagment.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Business.SMSManagment.Services
{
    public class OutRequestService : IOutRequestService
    {
        private readonly HttpClient _httpClient;
        private readonly IOptions<SubSystemUrls> _subSystemUrls;

        public OutRequestService(HttpClient httpClient,
            IOptions<SubSystemUrls> subSystemUrls)
        {
            _httpClient = httpClient;
            _subSystemUrls = subSystemUrls;
        }

        public async Task<T> Request<T>(OutRequestDto outRequest) => await Request<T>(outRequest, null);

        public async Task<T> Request<T>(OutRequestDto outRequest, string token = null)
        {
            HttpResponseMessage result = null;

            if (token != null)
            {
                _httpClient.DefaultRequestHeaders.AddTokenAuthorization(token);
            }

            switch (outRequest.RequestType)
            {
                case OutRequestTypeEnum.Get: result = await _httpClient.GetAsync(outRequest.ApiUrl); break;
                case OutRequestTypeEnum.Post: result = await _httpClient.PostAsJsonAsync(outRequest.ApiUrl, outRequest.Parameters); break;
                case OutRequestTypeEnum.Put: result = await _httpClient.PutAsJsonAsync(outRequest.ApiUrl, outRequest.Parameters); break;
                case OutRequestTypeEnum.Delete: result = await _httpClient.DeleteAsJsonAsync(outRequest.ApiUrl, outRequest.Parameters); break;
            }

            if (result == null) return default;

            var response = await result.Content.ReadAsStringAsync();
            return JsonMapper.Map<T>(response);
        }

        public async Task<T> OutRequestSMS<T>(string url, object param, OutRequestTypeEnum request = OutRequestTypeEnum.Post)
        {
            var result = await Request<T>(new OutRequestDto
            {
                ApiUrl = $"{_subSystemUrls.Value.SmsUrl}{url}",
                RequestType = request,
                Parameters = param
            }, _subSystemUrls.Value.SmsToken);

            return result;
        }
    }
}
