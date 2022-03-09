using Business.SMSManagment.Models;
using Business.SyncManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SyncManagment.IServices
{
    public interface ISyncService
    {
        Task<string> SyncData(SyncDto syncDto, int currentUserId);
        Task<BaseResponseDto> RegisterDoctorAsync(SyncDoctorDto doctorDto);
        Task<BaseResponseDto> SmsInfoAsync();
        Task<int> GetCurrentUserId(string syncUserId);
        Task LogData(string tableId, string tableName, bool isOk, string message);
    }
}
