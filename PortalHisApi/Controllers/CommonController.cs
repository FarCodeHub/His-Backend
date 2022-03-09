using Business.Common.IServices;
using Business.Common.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace PortalHisApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
 

    public class CommonController : Controller
    {

        private readonly ICommonService commonService;
        private readonly ILogger<ApiController> logger;

        public CommonController(ILogger<ApiController> logger, ICommonService commonService)
        {
             this.commonService = commonService;
             this.logger = logger;
        }
 
         public async Task<JsonResult> GetOwnershipTypes()
        {
            logger.LogInformation("first test");
            var result = await commonService.GetOwnershipTypes();
            return Json(result);
        }
        public async Task<JsonResult> GetWorkTimeTypes()
        {
            var result = await commonService.GetWorkTimeTypes();
            return Json(result);
        }

        public async Task<JsonResult> GetMarriaged()
        {
            var result = await commonService.GetMarriaged();
            return Json(result);
        }
        public async Task<JsonResult> GetSexType()
        {
            var result = await commonService.GetSexType();
            return Json(result);
        }

        public async Task<JsonResult> GetProvinces()
        {
            var result = await commonService.GetProvinces();
            return Json(result);
        }

        public async Task<JsonResult> GetCities()
        {
            var result = await commonService.GetProvinces();
            return Json(result);
        }

        public async Task<JsonResult> GetAreas()
        {
            var result = await commonService.GetProvinces();
            return Json(result);
        }


        public async Task<JsonResult> GetBaseValues()
        {
            var result = await commonService.GetBaseValues();
            return Json(result);
        }


    }
}
