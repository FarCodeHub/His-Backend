using Business.SMSManagment.Extensions;
using Business.SMSManagment.Models;
using Business.SMSManagment.Services;
using Business.SyncManagment.Extension;
using Business.SyncManagment.IServices;
using Business.SyncManagment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace PortalHisApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SyncController : ControllerBase
    {
        private readonly ISyncService _syncService;
        private readonly ILogger<SyncController> _logger;

        public SyncController(ISyncService syncService, ILogger<SyncController> logger)
        {
            _syncService = syncService;
            _logger = logger;
        }

        [HttpPost("SyncDoctor")]
        public async Task<IActionResult> RegisterDoctorAsync([FromBody] SyncDoctorDto doctorDto)
        {
            _logger.LogInformation("SyncDoctor", Newtonsoft.Json.JsonConvert.SerializeObject(doctorDto));

            try
            {
                return new CustomActionResult(await _syncService.RegisterDoctorAsync(doctorDto));
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"SyncDoctor_ex_{ex.Message}", Newtonsoft.Json.JsonConvert.SerializeObject(doctorDto));
                return new CustomActionResult(new LoginResponseDto
                {
                    Status = ResponseStatus.Fail,
                    Errors = ex.Message
                });
            }
        }

        [HttpPost("SyncData")]
       
        public async Task<IActionResult> SyncDataAsync([FromBody] SyncDto syncDto)
        {
            //var message = "";
            //try
            //{
            //    message = await _syncService.SyncData(syncDto);
            //}
            //catch (Exception ex)
            //{
            //    message = ex.Message;
            //}
            //finally
            //{
            //    _logger.LogInformation($"SyncData_{syncDto.Data.Table}_{syncDto.Data.ServerId}_{message}", Newtonsoft.Json.JsonConvert.SerializeObject(syncDto));
            //}
            //return new CustomActionResult(new LoginResponseDto
            //{
            //    Status = message.Contains("Success") ? ResponseStatus.Success : ResponseStatus.Fail,
            //    Message = message
            //});

            if (syncDto.Data.Table == TablesWinAppEnum.Doctor ||
                syncDto.Data.Table == TablesWinAppEnum.Prescription ||
                syncDto.Data.Table == TablesWinAppEnum.Patient ||
                syncDto.Data.Table == TablesWinAppEnum.Drug ||
                syncDto.Data.Table == TablesWinAppEnum.VitalSign ||
                syncDto.Data.Table == TablesWinAppEnum.Radiology ||
                syncDto.Data.Table == TablesWinAppEnum.PatientHistory)
            {
                _logger.LogInformation($"SyncDataOffline_{syncDto.Data.Table}_{syncDto.Data.ServerId}", Newtonsoft.Json.JsonConvert.SerializeObject(syncDto));

                return new CustomActionResult(new LoginResponseDto
                {
                    Status = ResponseStatus.Success,
                    Message = "Success"
                });
            }
            else
            {
                return new CustomActionResult(new LoginResponseDto
                {
                    Status = ResponseStatus.Fail,
                    Message = "No such table to sync!"
                });
            }




        }

        [HttpGet("SMSInfo")]
      
        public async Task<IActionResult> SmsInfoAsync()
        {
            var result = await _syncService.SmsInfoAsync();

            return new CustomActionResult(result);
        }

        [HttpPost("SyncDataOffline")]
   
        public async Task<IActionResult> SyncDataOfflineAsync([FromBody] SyncDto syncDto)
        {
            var message = "";
            try
            {
                var userid = await _syncService.GetCurrentUserId(syncDto.UserId.ToString());

                message = await _syncService.SyncData(syncDto, userid);
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            finally
            {
                _logger.LogInformation($"SyncData_{syncDto.Data.Table}_{syncDto.Data.ServerId}_{message}", Newtonsoft.Json.JsonConvert.SerializeObject(syncDto));
                await _syncService.LogData(syncDto.Data.ServerId, syncDto.Data.Table.ToString(), message.Contains("Success"), message);
            }

            return new CustomActionResult(new LoginResponseDto
            {
                Status = message.Contains("Success") ? ResponseStatus.Success : ResponseStatus.Fail,
                Message = message
            });
        }

    }

}
