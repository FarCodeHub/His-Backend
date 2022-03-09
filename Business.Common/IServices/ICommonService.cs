using Business.CenterManagment.Models;
using Business.Common.Models;
using Core.His.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Common.IServices
{
    public interface ICommonService
    {
        /// <summary>
        /// Get All Locations (cuntries , provinces , cities , zones) for select address----
        /// </summary>
        /// <returns>ResponseResult(GeoLocationModel)</returns>
        Task<ResponseResult> GetGeoLocations();
        /// <summary>
        /// Get Ownership Types ----
        /// </summary>
        /// <returns>ResponseResult(OwnershipType)</returns>
        Task<ResponseResult> GetOwnershipTypes();
        /// <summary>
        /// Get Work Time Type ----
        /// </summary>
        /// <returns>ResponseResult(WorkTimeType)</returns>
        Task<ResponseResult> GetWorkTimeTypes();
        /// <summary>
        /// Type of marriaged ----
        /// </summary>
        /// <returns>ResponseResult(BaseValue)</returns>
        Task<ResponseResult> GetMarriaged();
        /// <summary>
        /// Type of sex ----
        /// </summary>
        /// <returns>ResponseResult(BaseValue)</returns>
        Task<ResponseResult> GetSexType();

        Task<ResponseResult> GetProvinces();

        Task<ResponseResult> GetCities(int provinceId);

        Task<ResponseResult> GetAreas(int citiyId);

        Task<ResponseResult> GetBaseValues();

        Task<ResponseResult> GetBaseValueTypes();

        Task<ResponseResult> GetBaseValuesBy(int typeId);

        Task<ResponseResult> AddBaseValueType(BaseValueTypeModel baseValueType);
        Task<ResponseResult> AddBaseValue(BaseValueModel baseValue);

        Task<ResponseResult> AddGeoLocation(GeoLocationModel geoLocation);
    }
}
