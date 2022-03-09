using Business.CenterManagment.IServices;
using Business.CenterManagment.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PortalHisApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
   
    public class PatientController : Controller
    {

        private readonly IPatientService patientService;

        public PatientController(IPatientService patientService)
        {
            this.patientService = patientService;
        }

        public async Task<JsonResult> GetPatients()
        {
            var result = await patientService.GetPatients();
            return Json(result);
        }


        public async Task<JsonResult> GetPatientPrescriptions()
        {
            var result = await patientService.GetPatientPrescriptions();
            return Json(result);
        }

        public async Task<JsonResult> GetPatientReceptions()
        {
            var result = await patientService.GetPatientReceptions();
            return Json(result);
        }

        public async Task<JsonResult> GetPatientFiles(int patientId)
        {
            var result = await patientService.GetPatientFiles(patientId);
            return Json(result);
        }

        public async Task<JsonResult> GetPatientPrescriptionsBy(int patientId,int centerId=0)
        {
            var result = await patientService.GetPatientPrescriptionsBy(patientId, centerId);
            return Json(result);
        }
        public async Task<JsonResult> EditPatient(PatientModel patient)
        {
            var result = await patientService.EditPatient(patient);
            return Json(result);
        }

    }
}
