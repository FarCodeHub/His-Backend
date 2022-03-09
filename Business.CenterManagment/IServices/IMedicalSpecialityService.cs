using Business.CenterManagment.Models;
using Core.His.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CenterManagment.IServices
{
    public interface IMedicalSpecialityService
    {
        #region Medical Speciality Functions ---

        /// <number>
        /// function number : 1
        /// </number>
        /// <summary>
        /// Get All Spaciality ----
        /// </summary>
        /// <returns>ResponseResult(SpacialityModel)</returns>
        Task<ResponseResult> GetSpecialities();

        /// <number>
        /// function number : 2
        /// </number>
        /// <summary>
        /// Get All Spaciality for tree selection ----
        /// </summary>
        /// <returns>ResponseResult(SpacialityModel)</returns>
        Task<ResponseResult> GetSpecialityTree();

        /// <number>
        /// function number : 3
        /// </number>
        /// <summary>
        /// Add Speciality ----
        /// </summary>
        /// <param name="specialityModel">list of specialityModel</specialityModel></param>
        /// <returns>ResponseResult(specialityModel)</returns>
        Task<ResponseResult> AddCenterSpecialities(List<SpecialityModel> specialityModel);
        Task<ResponseResult> AddSpeciality(SpecialityModel specialityModel);
        #endregion

    }
}
