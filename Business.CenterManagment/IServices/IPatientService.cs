using Business.CenterManagment.Models;
using Business.Common.Models;
using Core.His.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CenterManagment.IServices
{
    public interface IPatientService 
    {
        Task<ResponseResult> GetPatientPrescriptions();
        Task<ResponseResult> GetPatientReceptions();
        Task<ResponseResult> GetPatients();
        Task<ResponseResult> SavePatientFile(string fileName, int patientId);
        Task<ResponseResult> GetPatientFiles(int patientId);
        Task<ResponseResult> EditPatient(PatientModel patient);
        Task<ResponseResult> LoginPatient(UserModel userModel);
        Task<ResponseResult> GetPatientPrescriptionsBy(int patientId,int centerId);
    }
}
