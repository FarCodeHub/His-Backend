using AutoMapper;
using Business.CenterManagment.Models;
using Business.Common.IServices;
using Business.Common.Models;
using Core.His.Models;
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business.Common.Services
{
    public class CommonService : ICommonService
    {

        private readonly IUnitOfWork unitOfWork;
        private readonly IGeoLocationRepository geoLocationRepository;
      //  private readonly IWorkTimeTypeRepository workTimeTypeRepository;
        private readonly IOwnershipTypeRepository ownershipTypeRepository;
        private readonly IBaseValueRepository baseValueRepository;
        private readonly IBaseValueTypeRepository baseValueTypeRepository;
        private readonly IPatientRepository patientRepository;
        private readonly IPersonRepository personRepository;

        private IMapper mapper;


        public CommonService(IUnitOfWork unitOfWork,
            IMapper mapper,
            IGeoLocationRepository geoLocationRepository,
       //     IWorkTimeTypeRepository workTimeTypeRepository,
            IOwnershipTypeRepository ownershipTypeRepository,
            IBaseValueRepository baseValueRepository,
            IPatientRepository patientRepository,
            IPersonRepository personRepository,
            IBaseValueTypeRepository baseValueTypeRepository
            )
        {
            this.unitOfWork = unitOfWork;

            this.geoLocationRepository = geoLocationRepository;
            this.geoLocationRepository.UnitOfWork = this.unitOfWork;

         //   this.workTimeTypeRepository = workTimeTypeRepository;
         //   this.workTimeTypeRepository.UnitOfWork = this.unitOfWork;

            this.ownershipTypeRepository = ownershipTypeRepository;
            this.ownershipTypeRepository.UnitOfWork = this.unitOfWork;

            this.baseValueRepository = baseValueRepository;
            this.baseValueRepository.UnitOfWork = this.unitOfWork;


            this.patientRepository = patientRepository;
            this.patientRepository.UnitOfWork = this.unitOfWork;

            this.personRepository = personRepository;
            this.personRepository.UnitOfWork = this.unitOfWork;

            this.baseValueTypeRepository = baseValueTypeRepository;
            this.baseValueTypeRepository.UnitOfWork = this.unitOfWork;

            this.mapper = mapper; ;
        }

        /// <summary>
        /// Get All Locations (cuntries , provinces , cities , zones) for select address----
        /// </summary>
        /// <returns>ResponseResult(GeoLocationModel)</returns>
        public async Task<ResponseResult> GetGeoLocations()
        {
            var getLocations = await (from g in geoLocationRepository.GetAll()
                                      select new GeoLocationModel
                                      {
                                      Id = g.Id,
                                      ParentId = g.ParentId,
                                      Title = g.Title,
                                      Type = g.Type
                                      }).ToListAsync();
            var locations = new List<GeoLocationModel>();

          


         //   foreach (var location in getLocations)
          //      locations.Add(mapper.Map<GeoLocation, GeoLocationModel>(location));
            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data =   getLocations
                
            };
        }


        public async Task<ResponseResult> AddGeoLocation(GeoLocationModel geoLocation)
        {

            var gl = mapper.Map<GeoLocationModel, GeoLocation>(geoLocation);
            geoLocationRepository.Add(gl);
            await unitOfWork.Save();
            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = gl
            };
        }


        /// <summary>
        /// Get Ownership Types ----
        /// </summary>
        /// <returns>ResponseResult(OwnershipType)</returns>
        public async Task<ResponseResult> GetOwnershipTypes()
        {
            // 1006 is the type of OwnerShip in BaseValueTypeId
            var ownershipTypes = await baseValueRepository.GetAll().Where(x => x.BaseValueTypeId == 1006).ToListAsync();
            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data =   ownershipTypes
            };
        }
       
        /// <summary>
        /// Get Work Time Type ----
        /// </summary>
        /// <returns>ResponseResult(WorkTimeType)</returns>
        public async Task<ResponseResult> GetWorkTimeTypes()
        {
           // 1007 is the type of WorkTime in BaseValueTypeId
            var workTimeTypes = await baseValueRepository.GetAll().Where(x=>x.BaseValueTypeId == 1007 ).ToListAsync();

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data =  workTimeTypes
              
            };
        }
       
        /// <summary>
        /// Type of marriaged ----
        /// </summary>
        /// <returns>ResponseResult(BaseValue)</returns>
        public async Task<ResponseResult> GetMarriaged()
        {
            var marriaged = await baseValueRepository.GetAll().Where(x=>x.BaseValueTypeId == 2).ToListAsync();
            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = marriaged

            };
        }
        
        /// <summary>
        /// Get Sex Type ----
        /// </summary>
        /// <returns>ResponseResult(BaseValue)</returns>
        public async Task<ResponseResult> GetSexType()
        {

            // 1002 is the type of SexType in BaseValueTypeId
            var marriaged = await baseValueRepository.GetAll().Where(x=>x.BaseValueTypeId == 1002).ToListAsync();
            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = marriaged

            };
        }

        public async Task<ResponseResult> GetProvinces()
        {
            var provinces = await (from gl in geoLocationRepository.GetAll()
                                   where gl.Type == (int)Location.Province
                                   select gl).ToListAsync();

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = provinces

            };
        }


        public async Task<ResponseResult> GetCities(int provinceId)
        {
            var cities = await (from gl in geoLocationRepository.GetAll()
                                   where gl.Type == (int)Location.City && gl.ParentId == provinceId
                                   select gl).ToListAsync();

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = cities

            };
        }

        public async Task<ResponseResult> GetAreas(int citiyId)
        {
            var areas = await (from gl in geoLocationRepository.GetAll()
                                   where gl.Type == (int)Location.Area && gl.ParentId == citiyId
                                select gl).ToListAsync();

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = areas

            };
        }


        public async Task<ResponseResult> GetBaseValues()
        {
            var baseValues = await baseValueRepository.GetAll().ToListAsync();

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = baseValues

            };


        }

        public async Task<ResponseResult> GetBaseValueTypes()
        {
            var baseValueTypes = await baseValueTypeRepository.GetAll().ToListAsync();

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data =  baseValueTypes

            };

        }
        public async Task<ResponseResult> GetBaseValuesBy(int typeId)
        {
            var baseValues = await baseValueRepository.GetAll().Where(x=>x.BaseValueTypeId == typeId).ToListAsync();

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = baseValues

            };

        }

        public async Task<ResponseResult> AddBaseValueType(BaseValueTypeModel baseValueType)
        {
            var bvt = mapper.Map<BaseValueTypeModel, BaseValueType>(baseValueType);
            baseValueTypeRepository.Add(bvt);

            foreach(var item in baseValueType.BaseValues)
            {
                var baseValue = mapper.Map<BaseValueModel, BaseValue>(item);
                baseValue.BaseValueType = bvt;
                baseValueRepository.Add(baseValue);
            }

            await unitOfWork.Save();
            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = bvt
            };
        }

        public async Task<ResponseResult> AddBaseValue(BaseValueModel baseValue)
        {

            var bv = mapper.Map<BaseValueModel, BaseValue>(baseValue);
            baseValueRepository.Add(bv);
            await unitOfWork.Save();
            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = bv
            };
        }


    }

    public enum Location
    {
        Country = 1,
        Province = 2,
        City = 3,
        Area = 4
    }

}
