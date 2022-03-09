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
    public interface IMedicalCenterService
    {
        #region Medical Center Functions ---

        /// <number>
        /// function number : 1
        /// </number>
        /// <summary>
        /// Add Medical Center ----
        /// </summary>
        /// <param name="medicalCenterModel">Medical Center Model</param>
        /// <returns>ResponseResult(MedicalCenterModel)</returns>
        Task<ResponseResult> AddMedicalCenter(MedicalCenterModel medicalCenterModel);

        /// <number>
        /// function number : 2
        /// </number>
        /// <summary>
        /// Get Location of Every Center----
        /// </summary>
        /// <param name="centerId">Center Id</param>
        /// <returns>ResponseResult(CenterLocationModel)</returns>
        Task<ResponseResult> GetMedicalCenterLocation(int centerId);

        Task<ResponseResult> GetMedicalCenters();

        /// <number>
        /// function number : 3
        /// </number>
        /// <summary>
        /// Get Medical Centers After Login  ----
        /// </summary>
        /// <param name="personId">send personId after login</param>
        /// <returns>ResponseResult(MedicalCenterModel)</returns>
        Task<ResponseResult> GetMedicalCentersBy(int personId);
       
        /// <number>
        /// function number : 4
        /// </number>
        /// <summary>
        /// Get Location of Every Center----
        /// </summary>
        /// <param name="centerId">Center Id</param>
        /// <returns>ResponseResult(CenterLocationModel)</returns>
        Task<ResponseResult> GetMedicalCenter(int centerId);
       
        /// <number>
        /// function number : 5
        /// </number>
        /// <summary>
        /// Edit Medical Center ----
        /// </summary>
        /// <param name="medicalCenterModel">model of medicalCenter</param>
        /// <returns>ResponseResult(MedicalCenterModel)</returns>
        Task<ResponseResult> EditMedicalCenter(MedicalCenterModel medicalCenterModel);

        /// <number>
        /// function number : 6
        /// </number>
        /// <summary>
        /// Get All Center Type  ----
        /// </summary>
        /// <returns>ResponseResult(CenterTypeModel)</returns>
        Task<ResponseResult> GetCenterTypes();

        Task<ResponseResult> SearchCenter(int centerTypeId);

        Task<ResponseResult> SearchCentersBy(CenterFilter centerFilter);

        Task<ResponseResult> SearchPharmaciesBy(PharmacyFilter pharmacyFilter);

        Task<ResponseResult> SearchRadiologiesBy(RadiologyFilter radiologyFilter);
        Task<ResponseResult> SearchLabsBy(LabFilter labFilter);

        #endregion





        #region Medical Section Functions ---
        /// <number>
        /// function number : 1
        /// </number>
        /// <summary>
        /// Add Section ----
        /// </summary>
        /// <param name="medicalCenterModel">medicalCenterModel</specialityModel></param>
        /// <returns>ResponseResult(medicalCenterModel)</returns>
        Task<ResponseResult> AddSection(MedicalCenterModel medicalCenterModel);

        /// <number>
        /// function number : 2
        /// </number>
        /// <summary>
        /// Get Sections By CenterId----
        /// </summary>
        /// <param name="centerId"> int centerId</specialityModel></param>
        /// <returns>ResponseResult(list MedicalCenterModel)</returns>
        Task<ResponseResult> GetSectionsBy(int centerId);

        #endregion

    }
}
