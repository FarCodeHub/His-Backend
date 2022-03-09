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
 
    public class MedicalSpecialityController : Controller
    {

        private readonly IMedicalSpecialityService medicalSpecialtyService;
        private readonly ILogger<ApiController> logger;

        public MedicalSpecialityController(ILogger<ApiController> logger, IMedicalSpecialityService medicalSpecialtyService)
        {

            this.medicalSpecialtyService = medicalSpecialtyService;

            this.logger = logger;
        }
        public async Task<JsonResult> GetSpecialities()
        {
            var result = await medicalSpecialtyService.GetSpecialities();
            return Json(result);
        }

        public async Task<JsonResult> GetSpecialityTree()
        {
            var result = await medicalSpecialtyService.GetSpecialityTree();
            return Json(result);
        }

        public async Task<JsonResult> AddCenterSpecialities(List<SpecialityModel> specialityModel)
        {
            var result = await medicalSpecialtyService.AddCenterSpecialities(specialityModel);
            return Json(result);
        }

        public async Task<JsonResult> AddSpeciality(SpecialityModel specialityModel)
        {
            var result = await medicalSpecialtyService.AddSpeciality(specialityModel);
            return Json(result);
        }

    }
}
