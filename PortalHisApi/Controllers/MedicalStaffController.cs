using Business.CenterManagment.IServices;
using Business.CenterManagment.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace PortalHisApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
 
    public class MedicalStaffController : Controller
    {
        private readonly IMedicalStaffService medicalStaffService;
        private readonly ILogger<ApiController> logger;

        public MedicalStaffController(ILogger<ApiController> logger, IMedicalStaffService medicalStaffService)
        {
            this.medicalStaffService = medicalStaffService;
            this.logger = logger;
        }

        public async Task<JsonResult> AddMedicalStaff(MedicalStaffModel medicalStaffModel)
        {
            var result = await medicalStaffService.AddMedicalStaff(medicalStaffModel);
            return Json(result);
        }


        public async Task<JsonResult> GetMedicalStaffBy(int centerId)
        {
            var result = await medicalStaffService.GetMedicalStaffBy(centerId);
            return Json(result);
        }


        // it must be move
        public async Task<JsonResult> AddServiceType(ServiceTypeModel serviceTypeModel)
        {
            var result = await medicalStaffService.AddServiceType(serviceTypeModel);
            return Json(result);

        }
        public async Task<JsonResult>  SearchDoctor()
        {
            var result = await medicalStaffService.SearchDoctor();
            return Json(result);

        }

        public async Task<JsonResult> SearchDoctorBy(DoctorFilter doctorFilter)
        {
            var result = await medicalStaffService.SearchDoctorBy(doctorFilter);
            return Json(result);

        }

        public async Task<JsonResult>  GetStaffTypes()
        {
            var result = await medicalStaffService.GetStaffTypes();
            return Json(result);
        }

        public async Task<JsonResult> GetExpertises()
        {
            var result = await medicalStaffService.GetExpertises();
            return Json(result);

        }

        public async Task<JsonResult> ScientificLevels()
        {
            var result = await medicalStaffService.ScientificLevels();
            return Json(result);

        }
    }
}
