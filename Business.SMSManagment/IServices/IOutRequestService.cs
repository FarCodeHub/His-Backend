using Business.SMSManagment.Extensions;
using Business.SMSManagment.Models;
using System.Threading.Tasks;

namespace Business.SMSManagment.IServices
{
    public interface IOutRequestService
    {
        Task<T> Request<T>(OutRequestDto outRequest);
        Task<T> OutRequestSMS<T>(string url, object param, OutRequestTypeEnum request);
        Task<T> Request<T>(OutRequestDto outRequest, string token);
    }
}
