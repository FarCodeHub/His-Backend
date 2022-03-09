using Business.CenterManagment.IServices;
using Business.CenterManagment.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalHisApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    
    public class MedicalSectionController : Controller
    {

        private readonly IMedicalCenterService medicalCenterService;
        private readonly ILogger<ApiController> logger;

        public MedicalSectionController(ILogger<ApiController> logger, IMedicalCenterService medicalCenterService)
        {

            this.medicalCenterService = medicalCenterService;

            this.logger = logger;
        }

        public async Task<JsonResult> AddSection(MedicalCenterModel medicalCenter)
        {
            var result = await medicalCenterService.AddSection(medicalCenter);
            return Json(result);
        }

        public async Task<JsonResult> GetSectionsBy(int centerId)
        {
            var result = await medicalCenterService.GetSectionsBy(centerId);
            return Json(result);
        }
    }
}
