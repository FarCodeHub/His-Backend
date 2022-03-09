using AutoMapper;
using Business.CenterManagment.IServices;
using Business.CenterManagment.Models;
using Core.His.Models;
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business.CenterManagment.Services
{
    public class MedicalCenterService : IMedicalCenterService
    {
        private readonly IUnitOfWork unitOfWork;
 
 
        private readonly IMedicalStaffRepository medicalStaffRepository;
        private readonly ICenterStaffRepository centerStaffRepository;
        private readonly IMedicalCenterRepository medicalCenterRepository;
 
        private readonly ICenterLocationRepository centerLocationRepository;
        private readonly IGeoLocationRepository geoLocationRepository;
    
        private readonly IOwnershipTypeRepository ownershipTypeRepository;
        private readonly IBaseValueRepository baseValueRepository;

        private readonly ICenterTypeRepository centerTypeRepository;
     
 


        private IMapper mapper;


        public MedicalCenterService(IUnitOfWork unitOfWork,
            IMapper mapper,
            IMedicalStaffRepository medicalStaffRepository,
            ICenterStaffRepository centerStaffRepository,
            IMedicalCenterRepository medicalCenterRepository,
            ICenterLocationRepository centerLocationRepository,
            IGeoLocationRepository geoLocationRepository,
       
            IOwnershipTypeRepository ownershipTypeRepository,
            ICenterTypeRepository centerTypeRepository,
            IBaseValueRepository baseValueRepository
            )
        {
            this.unitOfWork = unitOfWork;

            this.medicalStaffRepository = medicalStaffRepository;
            this.medicalStaffRepository.UnitOfWork = this.unitOfWork;

            this.centerStaffRepository = centerStaffRepository;
            this.centerStaffRepository.UnitOfWork = this.unitOfWork;

            this.medicalCenterRepository = medicalCenterRepository;
            this.medicalCenterRepository.UnitOfWork = this.unitOfWork;
 

            this.centerLocationRepository = centerLocationRepository;
            this.centerLocationRepository.UnitOfWork = this.unitOfWork;

            this.geoLocationRepository = geoLocationRepository;
            this.geoLocationRepository.UnitOfWork = this.unitOfWork;


            this.ownershipTypeRepository = ownershipTypeRepository;
            this.ownershipTypeRepository.UnitOfWork = this.unitOfWork;

            this.centerTypeRepository = centerTypeRepository;
            this.centerTypeRepository.UnitOfWork = this.unitOfWork;

            this.baseValueRepository = baseValueRepository;
            this.baseValueRepository.UnitOfWork = this.unitOfWork;

            this.mapper = mapper; ;
        }

        #region Medical Center Functions ---

        /// <number>
        /// function number : 1
        /// </number>
        /// <summary>
        /// Add Medical Center ----
        /// </summary>
        /// <param name="medicalCenterModel">Medical Center Model</param>
        /// <returns>ResponseResult(MedicalCenterModel)</returns>
        public async Task<ResponseResult> AddMedicalCenter(MedicalCenterModel medicalCenterModel)
        {
            // var isValid = Validation.IsValid(new PersonValidation(person));
            //  if (resultVaild.Status == ResponseStatus.NotValid)
            var medicalCenter = mapper.Map<MedicalCenterModel, MedicalCenter>(medicalCenterModel);
            medicalCenterRepository.Add(medicalCenter);
            await unitOfWork.Save();
            medicalCenterModel  = mapper.Map<MedicalCenter, MedicalCenterModel>(medicalCenter);  
            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data =   medicalCenterModel
               
            };
        }
        
        /// <number>
        /// function number : 2
        /// </number>
        /// <summary>
        /// Get Location of Every Center----
        /// </summary>
        /// <param name="centerId">Center Id</param>
        /// <returns>ResponseResult(CenterLocationModel)</returns>
        public async Task<ResponseResult> GetMedicalCenterLocation(int centerId)
        {
            var centerLocation = await (from mc in medicalCenterRepository.GetAll()
                                        join cl in centerLocationRepository.GetAll() on mc.Id equals cl.CenterId into clNull
                                        from centerlocation in clNull.DefaultIfEmpty()
                                        join os in baseValueRepository.GetAll() on mc.OwnerShipBaseId equals os.Id into osNull
                                        from owner in osNull.DefaultIfEmpty()
                                        join wt in baseValueRepository.GetAll() on mc.WorkTimeBaseId equals wt.Id into wtNull
                                        from workTime in wtNull.DefaultIfEmpty()
                                        join glCuntry in geoLocationRepository.GetAll() on centerlocation.CountryId equals glCuntry.Id into glcNull
                                        from cuntry in glcNull.DefaultIfEmpty()
                                        join glProvince in geoLocationRepository.GetAll() on centerlocation.ProvinceId equals glProvince.Id into glpNull
                                        from province in glpNull.DefaultIfEmpty()
                                        join glCity in geoLocationRepository.GetAll() on centerlocation.CityId equals glCity.Id into glpiNull
                                        from city in glpiNull.DefaultIfEmpty()
                                        join glZone in geoLocationRepository.GetAll() on centerlocation.ZoneId equals glZone.Id into glzNull
                                        from zone in glzNull.DefaultIfEmpty()
                                        where mc.Id == centerId
                                        select new CenterLocationModel
                                        {
                                            CountryName =cuntry.Title,
                                            ProvinceName =province.Title,
                                            CityName = city.Title,
                                            ZoneName =zone.Title
                                        }
                                       ).FirstOrDefaultAsync();

            if (centerLocation == null)
                return new ResponseResult { Status = ResponseStatus.NotFound, Message = "Not Found" };
             

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = centerLocation
               
            };
        }
        
        /// <number>
        /// function number : 3
        /// </number>
        /// <summary>
        /// Get Medical Centers After Login  ----
        /// </summary>
        /// <param name="personId">send personId after login</param>
        /// <returns>ResponseResult(MedicalCenterModel)</returns>
        public async Task<ResponseResult> GetMedicalCentersBy(int personId)
        {
            var medicalCenters = await (from ms in medicalStaffRepository.GetAll()
                                        join cs in centerStaffRepository.GetAll() on ms.Id equals cs.MedicalStaffId
                                        join mc in medicalCenterRepository.GetAll() on cs.CenterId equals mc.Id
                                        join cl in centerLocationRepository.GetAll() on mc.Id equals cl.CenterId
                                        join glCuntry in geoLocationRepository.GetAll() on cl.CountryId equals glCuntry.Id into glCuntryNull
                                        from glc in glCuntryNull.DefaultIfEmpty()
                                        join glProvince in geoLocationRepository.GetAll() on cl.ProvinceId equals glProvince.Id into glProvinceNull
                                        from glp in glProvinceNull.DefaultIfEmpty()
                                        join glCity in geoLocationRepository.GetAll() on cl.CityId equals glCity.Id into glCityNull
                                        from glci in glCityNull.DefaultIfEmpty()
                                        join glZone in geoLocationRepository.GetAll() on cl.ZoneId equals glZone.Id into glZoneNull
                                        from glz in glZoneNull.DefaultIfEmpty()
                                        where ms.PersonId == personId
                                        select new MedicalCenterModel
                                        {
                                            Id = mc.Id,
                                            Title = mc.Title,
                                            CenterTypeId = mc.CenterTypeId,
                                            Fax = mc.Fax,
                                            AnswerTime = mc.AnswerTime,
                                            Boss = mc.Boss,
                                            BossPhone = mc.BossPhone,
                                            Email = mc.Email,
                                            IsActive = mc.IsActive,
                                            IsFreeDelivery = mc.IsFreeDelivery,
                                            Note = mc.Note,
                                            ParentId = mc.ParentId,
                                            Phone = mc.Phone,
                                            PhoneResponseHourse = mc.PhoneResponseHourse,
                                            OwnerShipBaseId = mc.OwnerShipBaseId,
                                            WorkTimeBaseId = mc.WorkTimeBaseId,
                                            Code = mc.Code,
                                            VisitorPhone = mc.VisitorPhone,

                                            CenterLocation = new CenterLocationModel
                                            {
                                                Address = cl.Address,
                                                CountryName = glc.Title,
                                                CountryId = glc.Id,

                                                ProvinceName = glp.Title,
                                                ProvinceId = glp.Id,

                                                CityName = glci.Title,
                                                CityId = glci.Id,

                                                ZoneName = glz.Title,
                                                ZoneId = glz.Id,

                                                PostalCode = cl.PostalCode,
                                                AreaCode = cl.AreaCode

                                            }
                                        }).ToListAsync();

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data =   medicalCenters
                 
            };
        }
       
        /// <number>
        /// function number : 4
        /// </number>
        /// <summary>
        /// Get Location of Every Center----
        /// </summary>
        /// <param name="centerId">Center Id</param>
        /// <returns>ResponseResult(CenterLocationModel)</returns>
        public async Task<ResponseResult> GetMedicalCenter(int centerId)
        {
            var medicalCenter = await (from mc in medicalCenterRepository.GetAll()
                                       join cl in centerLocationRepository.GetAll() on mc.Id equals cl.CenterId into clNull
                                       from centerlocation in clNull.DefaultIfEmpty()
                                       join os in baseValueRepository.GetAll() on mc.OwnerShipBaseId equals os.Id into osNull
                                       from owner in osNull.DefaultIfEmpty()
                                       join wt in baseValueRepository.GetAll() on mc.WorkTimeBaseId equals wt.Id into wtNull
                                       from workTime in wtNull.DefaultIfEmpty()
                                       join glCuntry in geoLocationRepository.GetAll() on centerlocation.CountryId equals glCuntry.Id into glcNull
                                       from cuntry in glcNull.DefaultIfEmpty()
                                       join glProvince in geoLocationRepository.GetAll() on centerlocation.ProvinceId equals glProvince.Id into glpNull
                                       from province in glpNull.DefaultIfEmpty()
                                       join glCity in geoLocationRepository.GetAll() on centerlocation.CityId equals glCity.Id into glpiNull
                                       from city in glpiNull.DefaultIfEmpty()
                                       join glZone in geoLocationRepository.GetAll() on centerlocation.ZoneId equals glZone.Id into glzNull
                                       from zone in glzNull.DefaultIfEmpty()
                                       where mc.Id == centerId || centerId == 0 // --- centerId == 0 show all centers
                                       select new MedicalCenterModel
                                       {
                                           Id = mc.Id,
                                           Title = mc.Title,
                                           CenterTypeId = mc.CenterTypeId,
                                           Fax = mc.Fax,
                                           AnswerTime = mc.AnswerTime,
                                           Boss = mc.Boss,
                                           BossPhone = mc.BossPhone,
                                           Email = mc.Email,
                                           IsActive = mc.IsActive,
                                           IsFreeDelivery = mc.IsFreeDelivery,
                                           Note = mc.Note,
                                           ParentId = mc.ParentId,
                                           Phone = mc.Phone,
                                           PhoneResponseHourse = mc.PhoneResponseHourse,
                                           OwnerShipBaseId = mc.OwnerShipBaseId,
                                           WorkTimeBaseId = mc.WorkTimeBaseId,
                                           WorkTimeTypeName = workTime.Title,
                                           OwnerShipTypeName = owner.Title,
                                           Code = mc.Code,
                                           VisitorPhone = mc.VisitorPhone,

                                           CenterLocation = new CenterLocationModel
                                           {
                                               Address = centerlocation.Address,
                                               CountryName = cuntry.Title,
                                               CountryId = cuntry.Id,

                                               ProvinceName = province.Title,
                                               ProvinceId = province.Id,

                                               CityName = city.Title,
                                               CityId = city.Id,

                                               ZoneName = zone.Title,
                                               ZoneId = zone.Id,
                                               PostalCode = centerlocation.PostalCode,
                                               AreaCode = centerlocation.AreaCode
                                           }
                                       }).FirstOrDefaultAsync();

            if (medicalCenter == null)
            {
                return new ResponseResult { Status = ResponseStatus.NotFound, Message = "Not Found" };
            }


            medicalCenter.Init();

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data =  medicalCenter
                
            };
        }
        
        public async Task<ResponseResult> GetMedicalCenters()
        {
            var medicalCenter = await (from mc in medicalCenterRepository.GetAll()
                                       join cl in centerLocationRepository.GetAll() on mc.Id equals cl.CenterId into clNull
                                       from centerlocation in clNull.DefaultIfEmpty()
                                       join os in baseValueRepository.GetAll() on mc.OwnerShipBaseId equals os.Id into osNull
                                       from owner in osNull.DefaultIfEmpty()
                                       join wt in baseValueRepository.GetAll() on mc.WorkTimeBaseId equals wt.Id into wtNull
                                       from workTime in wtNull.DefaultIfEmpty()
                                       join glCuntry in geoLocationRepository.GetAll() on centerlocation.CountryId equals glCuntry.Id into glcNull
                                       from cuntry in glcNull.DefaultIfEmpty()
                                       join glProvince in geoLocationRepository.GetAll() on centerlocation.ProvinceId equals glProvince.Id into glpNull
                                       from province in glpNull.DefaultIfEmpty()
                                       join glCity in geoLocationRepository.GetAll() on centerlocation.CityId equals glCity.Id into glpiNull
                                       from city in glpiNull.DefaultIfEmpty()
                                       join glZone in geoLocationRepository.GetAll() on centerlocation.ZoneId equals glZone.Id into glzNull
                                       from zone in glzNull.DefaultIfEmpty()
                                       select new MedicalCenterModel
                                       {
                                           Id = mc.Id,
                                           Title = mc.Title,
                                           CenterTypeId = mc.CenterTypeId,
                                           Fax = mc.Fax,
                                           AnswerTime = mc.AnswerTime,
                                           Boss = mc.Boss,
                                           BossPhone = mc.BossPhone,
                                           Email = mc.Email,
                                           IsActive = mc.IsActive,
                                           IsFreeDelivery = mc.IsFreeDelivery,
                                           Note = mc.Note,
                                           ParentId = mc.ParentId,
                                           Phone = mc.Phone,
                                           PhoneResponseHourse = mc.PhoneResponseHourse,
                                           OwnerShipBaseId = mc.OwnerShipBaseId,
                                           WorkTimeBaseId = mc.WorkTimeBaseId,
                                           WorkTimeTypeName = workTime.Title,
                                           OwnerShipTypeName = owner.Title,
                                           Code = mc.Code,
                                           VisitorPhone = mc.VisitorPhone,

                                           CenterLocation = new CenterLocationModel
                                           {
                                               Address = centerlocation.Address,
                                               CountryName = cuntry.Title,
                                               CountryId = cuntry.Id,

                                               ProvinceName = province.Title,
                                               ProvinceId = province.Id,

                                               CityName = city.Title,
                                               CityId = city.Id,

                                               ZoneName = zone.Title,
                                               ZoneId = zone.Id,
                                               PostalCode = centerlocation.PostalCode,
                                               AreaCode = centerlocation.AreaCode
                                           }
                                       }).ToListAsync();

            if (medicalCenter == null)
            {
                return new ResponseResult { Status = ResponseStatus.NotFound, Message = "Not Found" };
            }

            medicalCenter.ForEach(x=>x.Init());

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = medicalCenter

            };
        }

        /// <number>
        /// function number : 5
        /// </number>
        /// <summary>
        /// Edit Medical Center ----
        /// </summary>
        /// <param name="medicalCenterModel">model of medicalCenter</param>
        /// <returns>ResponseResult(MedicalCenterModel)</returns>
        public async Task<ResponseResult> EditMedicalCenter(MedicalCenterModel medicalCenterModel)
        {
            var center = await (from mc in medicalCenterRepository.GetAll()
                                       join cl in centerLocationRepository.GetAll() on mc.Id equals cl.CenterId
                                       where mc.Id == medicalCenterModel.Id
                                       select  mc ).FirstOrDefaultAsync();

            if (center == null)
                return new ResponseResult { Status = ResponseStatus.NotFound, Message = "Not Found" };


            {

                center.Title = medicalCenterModel.Title;
                center.CenterTypeId = medicalCenterModel.CenterTypeId;
                center.Fax = medicalCenterModel.Fax;
                center.AnswerTime = medicalCenterModel.AnswerTime;
                center.Boss = medicalCenterModel.Boss;
                center.BossPhone = medicalCenterModel.BossPhone;
                center.Email = medicalCenterModel.Email;
                center.IsActive = medicalCenterModel.IsActive;
                center.IsFreeDelivery = medicalCenterModel.IsFreeDelivery;
                center.Note = medicalCenterModel.Note;
                center.Phone = medicalCenterModel.Phone;
                center.PhoneResponseHourse = medicalCenterModel.PhoneResponseHourse;
                center.OwnerShipBaseId = medicalCenterModel.OwnerShipBaseId;
                center.WorkTimeBaseId = medicalCenterModel.WorkTimeBaseId;
                center.Code = medicalCenterModel.Code;
                center.VisitorPhone = medicalCenterModel.VisitorPhone;
            }

           await unitOfWork.Save();

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data =  center
               
            };




        }

     

        /// <number>
        /// function number : 6
        /// </number>
        /// <summary>
        /// Get All Center Type  ----
        /// </summary>
        /// <returns>ResponseResult(CenterTypeModel)</returns>
        public async Task<ResponseResult> GetCenterTypes()
        {
            var centerTypes = await (from ct in centerTypeRepository.GetAll()
                                     select new CenterTypeModel { Id = ct.Id, Title = ct.Title }).ToListAsync();

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = centerTypes

            };
        }

        public async Task<ResponseResult> SearchCenter(int centerTypeId)
        {
            var medicalCenters = await (from mc in medicalCenterRepository.GetAll()
                                       join cl in centerLocationRepository.GetAll() on mc.Id equals cl.CenterId into clNull
                                       from centerlocation in clNull.DefaultIfEmpty()
                                       join os in baseValueRepository.GetAll() on mc.OwnerShipBaseId equals os.Id into osNull
                                       from owner in osNull.DefaultIfEmpty()
                                       join wt in baseValueRepository.GetAll() on mc.WorkTimeBaseId equals wt.Id into wtNull
                                       from workTime in wtNull.DefaultIfEmpty()
                                       join glCuntry in geoLocationRepository.GetAll() on centerlocation.CountryId equals glCuntry.Id into glcNull
                                       from cuntry in glcNull.DefaultIfEmpty()
                                       join glProvince in geoLocationRepository.GetAll() on centerlocation.ProvinceId equals glProvince.Id into glpNull
                                       from province in glpNull.DefaultIfEmpty()
                                       join glCity in geoLocationRepository.GetAll() on centerlocation.CityId equals glCity.Id into glpiNull
                                       from city in glpiNull.DefaultIfEmpty()
                                       join glZone in geoLocationRepository.GetAll() on centerlocation.ZoneId equals glZone.Id into glzNull
                                       from zone in glzNull.DefaultIfEmpty()
                                        where mc.CenterTypeId == centerTypeId || centerTypeId == 0  
                                       select new MedicalCenterModel
                                       {
                                           Id = mc.Id,
                                           Title = mc.Title,
                                           CenterTypeId = mc.CenterTypeId,
                                           Fax = mc.Fax,
                                           AnswerTime = mc.AnswerTime,
                                           Boss = mc.Boss,
                                           BossPhone = mc.BossPhone,
                                           Email = mc.Email,
                                           IsActive = mc.IsActive,
                                           IsFreeDelivery = mc.IsFreeDelivery,
                                           Note = mc.Note,
                                           ParentId = mc.ParentId,
                                           Phone = mc.Phone,
                                           PhoneResponseHourse = mc.PhoneResponseHourse,
                                           OwnerShipBaseId = mc.OwnerShipBaseId,
                                           WorkTimeBaseId = mc.WorkTimeBaseId,
                                           WorkTimeTypeName = workTime.Title,
                                           OwnerShipTypeName = owner.Title,
                                           Code = mc.Code,
                                           VisitorPhone = mc.VisitorPhone,

                                           CenterLocation = new CenterLocationModel
                                           {
                                               Address = centerlocation.Address,
                                               CountryName = cuntry.Title,
                                               CountryId = cuntry.Id,

                                               ProvinceName = province.Title,
                                               ProvinceId = province.Id,

                                               CityName = city.Title,
                                               CityId = city.Id,

                                               ZoneName = zone.Title,
                                               ZoneId = zone.Id,
                                               PostalCode = centerlocation.PostalCode,
                                               AreaCode = centerlocation.AreaCode
                                           }
                                       }).ToListAsync();

            if (medicalCenters == null)
            {
                return new ResponseResult { Status = ResponseStatus.NotFound, Message = "Not Found" };
            }


            medicalCenters.ForEach(x=>x.Init());

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = medicalCenters

            };
        }
        
        public async Task<ResponseResult> SearchCentersBy(CenterFilter centerFilter)
        {
            int centerTypeId = 29;
            var ownerShipIds = centerFilter.OwnerShips.Select(x => x.Id).ToList();
            bool isOwnerShip = true;
            if (ownerShipIds == null || ownerShipIds.Count == 0) isOwnerShip = false;

            var medicalCenters = await (from mc in medicalCenterRepository.GetAll()
                                       join cl in centerLocationRepository.GetAll() on mc.Id equals cl.CenterId into clNull
                                       from centerlocation in clNull.DefaultIfEmpty()
                                       join os in baseValueRepository.GetAll() on mc.OwnerShipBaseId equals os.Id into osNull
                                       from owner in osNull.DefaultIfEmpty()
                                       join wt in baseValueRepository.GetAll() on mc.WorkTimeBaseId equals wt.Id into wtNull
                                       from workTime in wtNull.DefaultIfEmpty()
                                       join glCuntry in geoLocationRepository.GetAll() on centerlocation.CountryId equals glCuntry.Id into glcNull
                                       from cuntry in glcNull.DefaultIfEmpty()
                                       join glProvince in geoLocationRepository.GetAll() on centerlocation.ProvinceId equals glProvince.Id into glpNull
                                       from province in glpNull.DefaultIfEmpty()
                                       join glCity in geoLocationRepository.GetAll() on centerlocation.CityId equals glCity.Id into glpiNull
                                       from city in glpiNull.DefaultIfEmpty()
                                       join glZone in geoLocationRepository.GetAll() on centerlocation.ZoneId equals glZone.Id into glzNull
                                       from zone in glzNull.DefaultIfEmpty()
                                        where (mc.CenterTypeId == centerTypeId)
                                       && (ownerShipIds.Contains(owner.Id) || isOwnerShip == false)
                                       && (mc.Title.Contains(centerFilter.Title) || centerFilter.Title.Equals(""))
                                        select new MedicalCenterModel
                                       {
                                           Id = mc.Id,
                                           Title = mc.Title,
                                           CenterTypeId = mc.CenterTypeId,
                                           Fax = mc.Fax,
                                           AnswerTime = mc.AnswerTime,
                                           Boss = mc.Boss,
                                           BossPhone = mc.BossPhone,
                                           Email = mc.Email,
                                           IsActive = mc.IsActive,
                                           IsFreeDelivery = mc.IsFreeDelivery,
                                           Note = mc.Note,
                                           ParentId = mc.ParentId,
                                           Phone = mc.Phone,
                                           PhoneResponseHourse = mc.PhoneResponseHourse,
                                           OwnerShipBaseId = mc.OwnerShipBaseId,
                                           WorkTimeBaseId = mc.WorkTimeBaseId,
                                           WorkTimeTypeName = workTime.Title,
                                           OwnerShipTypeName = owner.Title,
                                           Code = mc.Code,
                                           VisitorPhone = mc.VisitorPhone,

                                           CenterLocation = new CenterLocationModel
                                           {
                                               Address = centerlocation.Address,
                                               CountryName = cuntry.Title,
                                               CountryId = cuntry.Id,

                                               ProvinceName = province.Title,
                                               ProvinceId = province.Id,

                                               CityName = city.Title,
                                               CityId = city.Id,

                                               ZoneName = zone.Title,
                                               ZoneId = zone.Id,
                                               PostalCode = centerlocation.PostalCode,
                                               AreaCode = centerlocation.AreaCode
                                           }
                                       }).ToListAsync();

            if (medicalCenters == null)
            {
                return new ResponseResult { Status = ResponseStatus.NotFound, Message = "Not Found" };
            }


            medicalCenters.ForEach(x=>x.Init());

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = medicalCenters

            };
        }
       
        public async Task<ResponseResult> SearchPharmaciesBy(PharmacyFilter pharmacyFilter) 
        {
            int centerTypeId = 27;
            var workingTimeIds = pharmacyFilter.WorkingTime.Select(x => x.Id).ToList();
            bool isWorkingTime = true;
            if (workingTimeIds == null || workingTimeIds.Count == 0) isWorkingTime = false;

            var medicalCenters = await (from mc in medicalCenterRepository.GetAll()
                                       join cl in centerLocationRepository.GetAll() on mc.Id equals cl.CenterId into clNull
                                       from centerlocation in clNull.DefaultIfEmpty()
                                       join os in baseValueRepository.GetAll() on mc.OwnerShipBaseId equals os.Id into osNull
                                       from owner in osNull.DefaultIfEmpty()
                                       join wt in baseValueRepository.GetAll() on mc.WorkTimeBaseId equals wt.Id into wtNull
                                       from workTime in wtNull.DefaultIfEmpty()
                                       join glCuntry in geoLocationRepository.GetAll() on centerlocation.CountryId equals glCuntry.Id into glcNull
                                       from cuntry in glcNull.DefaultIfEmpty()
                                       join glProvince in geoLocationRepository.GetAll() on centerlocation.ProvinceId equals glProvince.Id into glpNull
                                       from province in glpNull.DefaultIfEmpty()
                                       join glCity in geoLocationRepository.GetAll() on centerlocation.CityId equals glCity.Id into glpiNull
                                       from city in glpiNull.DefaultIfEmpty()
                                       join glZone in geoLocationRepository.GetAll() on centerlocation.ZoneId equals glZone.Id into glzNull
                                       from zone in glzNull.DefaultIfEmpty()
                                       where (mc.CenterTypeId == centerTypeId)
                                       && (workingTimeIds.Contains(workTime.Id) || isWorkingTime == false)
                                       && (mc.Title.Contains(pharmacyFilter.Title) || pharmacyFilter.Title.Equals(""))
                                       && (mc.IsHomeDelivery == pharmacyFilter.IsHomeDelivery || pharmacyFilter.IsHomeDelivery == null)
                                        select new MedicalCenterModel
                                       {
                                           Id = mc.Id,
                                           Title = mc.Title,
                                           CenterTypeId = mc.CenterTypeId,
                                           Fax = mc.Fax,
                                           AnswerTime = mc.AnswerTime,
                                           Boss = mc.Boss,
                                           BossPhone = mc.BossPhone,
                                           Email = mc.Email,
                                           IsActive = mc.IsActive,
                                           IsFreeDelivery = mc.IsFreeDelivery,
                                           Note = mc.Note,
                                           ParentId = mc.ParentId,
                                           Phone = mc.Phone,
                                           PhoneResponseHourse = mc.PhoneResponseHourse,
                                           OwnerShipBaseId = mc.OwnerShipBaseId,
                                           WorkTimeBaseId = mc.WorkTimeBaseId,
                                           WorkTimeTypeName = workTime.Title,
                                           OwnerShipTypeName = owner.Title,
                                           Code = mc.Code,
                                           VisitorPhone = mc.VisitorPhone,

                                           CenterLocation = new CenterLocationModel
                                           {
                                               Address = centerlocation.Address,
                                               CountryName = cuntry.Title,
                                               CountryId = cuntry.Id,

                                               ProvinceName = province.Title,
                                               ProvinceId = province.Id,

                                               CityName = city.Title,
                                               CityId = city.Id,

                                               ZoneName = zone.Title,
                                               ZoneId = zone.Id,
                                               PostalCode = centerlocation.PostalCode,
                                               AreaCode = centerlocation.AreaCode
                                           }
                                       }).ToListAsync();

            if (medicalCenters == null)
            {
                return new ResponseResult { Status = ResponseStatus.NotFound, Message = "Not Found" };
            }


            medicalCenters.ForEach(x=>x.Init());

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = medicalCenters

            };
        }
         public async Task<ResponseResult> SearchRadiologiesBy(RadiologyFilter radiologyFilter) 
        {
            int centerTypeId = 26;
            var workingTimeIds = radiologyFilter.WorkingTime.Select(x => x.Id).ToList();
            bool isWorkingTime = true;
            if (workingTimeIds == null || workingTimeIds.Count == 0) isWorkingTime = false;

            var medicalCenters = await (from mc in medicalCenterRepository.GetAll()
                                       join cl in centerLocationRepository.GetAll() on mc.Id equals cl.CenterId into clNull
                                       from centerlocation in clNull.DefaultIfEmpty()
                                       join os in baseValueRepository.GetAll() on mc.OwnerShipBaseId equals os.Id into osNull
                                       from owner in osNull.DefaultIfEmpty()
                                       join wt in baseValueRepository.GetAll() on mc.WorkTimeBaseId equals wt.Id into wtNull
                                       from workTime in wtNull.DefaultIfEmpty()
                                       join glCuntry in geoLocationRepository.GetAll() on centerlocation.CountryId equals glCuntry.Id into glcNull
                                       from cuntry in glcNull.DefaultIfEmpty()
                                       join glProvince in geoLocationRepository.GetAll() on centerlocation.ProvinceId equals glProvince.Id into glpNull
                                       from province in glpNull.DefaultIfEmpty()
                                       join glCity in geoLocationRepository.GetAll() on centerlocation.CityId equals glCity.Id into glpiNull
                                       from city in glpiNull.DefaultIfEmpty()
                                       join glZone in geoLocationRepository.GetAll() on centerlocation.ZoneId equals glZone.Id into glzNull
                                       from zone in glzNull.DefaultIfEmpty()
                                       where (mc.CenterTypeId == centerTypeId)
                                       && (workingTimeIds.Contains(workTime.Id) || isWorkingTime == false)
                                       && (mc.Title.Contains(radiologyFilter.Title) || radiologyFilter.Title.Equals(""))
                                        select new MedicalCenterModel
                                       {
                                           Id = mc.Id,
                                           Title = mc.Title,
                                           CenterTypeId = mc.CenterTypeId,
                                           Fax = mc.Fax,
                                           AnswerTime = mc.AnswerTime,
                                           Boss = mc.Boss,
                                           BossPhone = mc.BossPhone,
                                           Email = mc.Email,
                                           IsActive = mc.IsActive,
                                           IsFreeDelivery = mc.IsFreeDelivery,
                                           Note = mc.Note,
                                           ParentId = mc.ParentId,
                                           Phone = mc.Phone,
                                           PhoneResponseHourse = mc.PhoneResponseHourse,
                                           OwnerShipBaseId = mc.OwnerShipBaseId,
                                           WorkTimeBaseId = mc.WorkTimeBaseId,
                                           WorkTimeTypeName = workTime.Title,
                                           OwnerShipTypeName = owner.Title,
                                           Code = mc.Code,
                                           VisitorPhone = mc.VisitorPhone,

                                           CenterLocation = new CenterLocationModel
                                           {
                                               Address = centerlocation.Address,
                                               CountryName = cuntry.Title,
                                               CountryId = cuntry.Id,

                                               ProvinceName = province.Title,
                                               ProvinceId = province.Id,

                                               CityName = city.Title,
                                               CityId = city.Id,

                                               ZoneName = zone.Title,
                                               ZoneId = zone.Id,
                                               PostalCode = centerlocation.PostalCode,
                                               AreaCode = centerlocation.AreaCode
                                           }
                                       }).ToListAsync();

            if (medicalCenters == null)
            {
                return new ResponseResult { Status = ResponseStatus.NotFound, Message = "Not Found" };
            }


            medicalCenters.ForEach(x=>x.Init());

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = medicalCenters

            };
        }
      
                 public async Task<ResponseResult> SearchLabsBy(LabFilter labFilter)
        {
            int centerTypeId = 1;
            var workingTimeIds = labFilter.WorkingTime.Select(x => x.Id).ToList();
            bool isWorkingTime = true;
            if (workingTimeIds == null || workingTimeIds.Count == 0) isWorkingTime = false;

            var medicalCenters = await (from mc in medicalCenterRepository.GetAll()
                                       join cl in centerLocationRepository.GetAll() on mc.Id equals cl.CenterId into clNull
                                       from centerlocation in clNull.DefaultIfEmpty()
                                       join os in baseValueRepository.GetAll() on mc.OwnerShipBaseId equals os.Id into osNull
                                       from owner in osNull.DefaultIfEmpty()
                                       join wt in baseValueRepository.GetAll() on mc.WorkTimeBaseId equals wt.Id into wtNull
                                       from workTime in wtNull.DefaultIfEmpty()
                                       join glCuntry in geoLocationRepository.GetAll() on centerlocation.CountryId equals glCuntry.Id into glcNull
                                       from cuntry in glcNull.DefaultIfEmpty()
                                       join glProvince in geoLocationRepository.GetAll() on centerlocation.ProvinceId equals glProvince.Id into glpNull
                                       from province in glpNull.DefaultIfEmpty()
                                       join glCity in geoLocationRepository.GetAll() on centerlocation.CityId equals glCity.Id into glpiNull
                                       from city in glpiNull.DefaultIfEmpty()
                                       join glZone in geoLocationRepository.GetAll() on centerlocation.ZoneId equals glZone.Id into glzNull
                                       from zone in glzNull.DefaultIfEmpty()
                                       where (mc.CenterTypeId == centerTypeId)
                                       && (workingTimeIds.Contains(workTime.Id) || isWorkingTime == false)
                                       && (mc.Title.Contains(labFilter.Title) || labFilter.Title.Equals(""))
                                        select new MedicalCenterModel
                                       {
                                           Id = mc.Id,
                                           Title = mc.Title,
                                           CenterTypeId = mc.CenterTypeId,
                                           Fax = mc.Fax,
                                           AnswerTime = mc.AnswerTime,
                                           Boss = mc.Boss,
                                           BossPhone = mc.BossPhone,
                                           Email = mc.Email,
                                           IsActive = mc.IsActive,
                                           IsFreeDelivery = mc.IsFreeDelivery,
                                           Note = mc.Note,
                                           ParentId = mc.ParentId,
                                           Phone = mc.Phone,
                                           PhoneResponseHourse = mc.PhoneResponseHourse,
                                           OwnerShipBaseId = mc.OwnerShipBaseId,
                                           WorkTimeBaseId = mc.WorkTimeBaseId,
                                           WorkTimeTypeName = workTime.Title,
                                           OwnerShipTypeName = owner.Title,
                                           Code = mc.Code,
                                           VisitorPhone = mc.VisitorPhone,

                                           CenterLocation = new CenterLocationModel
                                           {
                                               Address = centerlocation.Address,
                                               CountryName = cuntry.Title,
                                               CountryId = cuntry.Id,

                                               ProvinceName = province.Title,
                                               ProvinceId = province.Id,

                                               CityName = city.Title,
                                               CityId = city.Id,

                                               ZoneName = zone.Title,
                                               ZoneId = zone.Id,
                                               PostalCode = centerlocation.PostalCode,
                                               AreaCode = centerlocation.AreaCode
                                           }
                                       }).ToListAsync();

            if (medicalCenters == null)
            {
                return new ResponseResult { Status = ResponseStatus.NotFound, Message = "Not Found" };
            }


            medicalCenters.ForEach(x=>x.Init());

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = medicalCenters

            };
        }
        
        
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
        public async Task<ResponseResult> AddSection(MedicalCenterModel medicalCenterModel)
        {
            //  var section = mapper.Map<MedicalCenterModel, MedicalCenter>(medicalCenterModel);

            var getCenterId = await (from c in medicalCenterRepository.GetAll()
                                   where medicalCenterModel.Id == c.Id
                                   select c.Id).FirstOrDefaultAsync();

            medicalCenterModel.ParentId = getCenterId;

            var section = mapper.Map<MedicalCenterModel, MedicalCenter>(medicalCenterModel);

            //var section = new MedicalCenter()
            //{
            //    ParentId = getCenter.Id,
            //    Title = medicalCenterModel.Title,
            //    Code = medicalCenterModel.Code,
            //    CenterTypeId = medicalCenterModel.CenterTypeId,
            //    OwnerShipTypeId = medicalCenterModel.OwnerShipTypeId,
            //    BossPhone = medicalCenterModel.BossPhone,
            //    Phone = medicalCenterModel.Phone,
            //    VisitorPhone = medicalCenterModel.VisitorPhone,
            //    Email = medicalCenterModel.Email,
            //    Fax = medicalCenterModel.Fax,
            //    IsActive = true,
            //    AnswerTime = "10",
            //    WorkTimeTypeId = 1
            //};



            medicalCenterRepository.Add(section);
            await unitOfWork.Save();
            medicalCenterModel = mapper.Map<MedicalCenter , MedicalCenterModel > (section);
            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = medicalCenterModel

            };
        }

        /// <number>
        /// function number : 2
        /// </number>
        /// <summary>
        /// Get Sections By CenterId----
        /// </summary>
        /// <param name="centerId"> int centerId</specialityModel></param>
        /// <returns>ResponseResult(list MedicalCenterModel)</returns>
        public async Task<ResponseResult> GetSectionsBy(int centerId)
        {
            var getSections = await (from mc in medicalCenterRepository.GetAll()
                                     join os in baseValueRepository.GetAll() on mc.OwnerShipBaseId equals os.Id into osNull
                                     from bos in osNull.DefaultIfEmpty()
                                     join wt in baseValueRepository.GetAll() on mc.WorkTimeBaseId equals wt.Id into wtNull
                                     from bwt in wtNull.DefaultIfEmpty()

                                     where mc.ParentId == centerId
                                     select new MedicalCenterModel
                                     {
                                         Id = mc.Id,
                                         Title = mc.Title,
                                         CenterTypeId = mc.CenterTypeId,
                                         Fax = mc.Fax,
                                         AnswerTime = mc.AnswerTime,
                                         Boss = mc.Boss,
                                         BossPhone = mc.BossPhone,
                                         Email = mc.Email,
                                         IsActive = mc.IsActive,
                                         IsFreeDelivery = mc.IsFreeDelivery,
                                         Note = mc.Note,
                                         ParentId = mc.ParentId,
                                         Phone = mc.Phone,
                                         PhoneResponseHourse = mc.PhoneResponseHourse,
                                         OwnerShipBaseId = mc.OwnerShipBaseId,
                                         WorkTimeBaseId = mc.WorkTimeBaseId,
                                         WorkTimeTypeName = bwt.Title,
                                         OwnerShipTypeName = bos.Title,
                                         Code = mc.Code,
                                         VisitorPhone = mc.VisitorPhone,

                                     }).ToListAsync();



            getSections.ForEach(x => x.Init());




            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = getSections

            };

        }

        #endregion

    }


    public enum MedicalStaffType
    {
        Doctor = 1,
        Nurse = 2,
        Experts = 3,
        Employee = 4
    }

    public enum MedicalCenterType
    {
        Hospital = 29,
        Clinic = 2,
        Section = 3,
        Lab = 1,
        Radiology = 26,
        Pharmacy = 27,
        DoctorOffice = 28,

    }

}
