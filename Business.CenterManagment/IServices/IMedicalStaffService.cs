using Business.CenterManagment.Models;
using Core.His.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CenterManagment.IServices
{
    public interface IMedicalStaffService
    {


        #region Medical Staff Functions ---

        /// <number>
        /// function number : 1
        /// </number>
        /// <summary>
        /// Add Medical Staff (First Add Person Then Add Medical Staff) ----
        /// </summary>
        /// <param name="medicalCenterModel">Medical Center Model</param>
        /// <returns>ResponseResult(MedicalStaffModel)</returns>
        Task<ResponseResult> AddMedicalStaff(MedicalStaffModel medicalStaffModel);

        /// <number>
        /// function number : 2
        /// </number>
        /// <summary>
        /// Add Service Type  ----
        /// </summary>
        /// <param name="serviceTypeModel">ServiceTypeModel for Insert</param>
        /// <returns>ResponseResult(ServiceTypeModel)</returns>
        Task<ResponseResult> AddServiceType(ServiceTypeModel serviceTypeModel);

        /// <number>
        /// function number : 2
        /// </number>
        /// <summary>
        /// Get Medical Staff By CenterId ----
        /// </summary>
        /// <param name="centerId">centerId</param>
        /// <returns>ResponseResult(MedicalStaffModel)</returns>
        Task<ResponseResult> GetMedicalStaffBy(int centerId);
      //  int sexId, int specialtyId, int workTimeId, int locationId
        Task<ResponseResult> SearchDoctor();

        Task<ResponseResult> GetStaffTypes();
        Task<ResponseResult> ScientificLevels();
        Task<ResponseResult> GetExpertises();

        Task<ResponseResult> SearchDoctorBy(DoctorFilter doctorFilter);
        #endregion


    }
}
