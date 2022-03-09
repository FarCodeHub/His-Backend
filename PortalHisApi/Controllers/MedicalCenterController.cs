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
  
    public class MedicalCenterController : Controller
    {
        private readonly IMedicalCenterService medicalCenterService;
        private readonly ILogger<ApiController> logger;

        public MedicalCenterController(ILogger<ApiController> logger,   IMedicalCenterService medicalCenterService )
        {
          
            this.medicalCenterService = medicalCenterService;
          
            this.logger = logger;
        }
        [HttpPost]
        public async Task<JsonResult> AddMedicalCenter(MedicalCenterModel medicalCenterModel)
        {
            var result = await medicalCenterService.AddMedicalCenter(medicalCenterModel);
            return Json(result);
        }
        public async Task<JsonResult> GetMedicalCentersBy(int personId)
        {
            var result = await medicalCenterService.GetMedicalCentersBy(personId);
            return Json(result);
        }
        public async Task<JsonResult> GetMedicalCenterLocation(int centerId)
        {
            var result = await medicalCenterService.GetMedicalCenterLocation(centerId);
            return Json(result);
        }
        public async Task<JsonResult> GetMedicalCenter(int centerId)
        {
            var result = await medicalCenterService.GetMedicalCenter(centerId);
            return Json(result);
        }
        public async Task<JsonResult> EditMedicalCenter(MedicalCenterModel medicalCenterModel)
        {
            var result = await medicalCenterService.EditMedicalCenter(medicalCenterModel);
            return Json(result);
        }
        public async Task<JsonResult> GetCenterTypes()
        {
            var result = await medicalCenterService.GetCenterTypes();
            return Json(result);
        }

        public async Task<JsonResult> GetMedicalCenters()
        {
            var result = await medicalCenterService.GetMedicalCenters();
            return Json(result);
        }

        public async Task<JsonResult> SearchCenter(int centerTypeId)
        {
            var result = await medicalCenterService.SearchCenter(centerTypeId);
            return Json(result);
        }

        public async Task<JsonResult> SearchCentersBy(CenterFilter centerFilter)
        {
            var result = await medicalCenterService.SearchCentersBy(centerFilter);
            return Json(result);
        }

        public async Task<JsonResult> SearchPharmaciesBy(PharmacyFilter pharmacyFilter)
        {
            var result = await medicalCenterService.SearchPharmaciesBy(pharmacyFilter);
            return Json(result);
        }
        public async Task<JsonResult> SearchRadiologiesBy(RadiologyFilter radiologyFilter)
        {
            var result = await medicalCenterService.SearchRadiologiesBy(radiologyFilter);
            return Json(result);
        }
        public async Task<JsonResult> SearchLabsBy(LabFilter labFilter)
        {
            var result = await medicalCenterService.SearchLabsBy(labFilter);
            return Json(result);
        }


    }
}
