using AutoMapper;
using Business.CenterManagment.IServices;
using Business.CenterManagment.Models;
using Core.His.Models;
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 

namespace Business.CenterManagment.Services
{
    public class MedicalStaffService : IMedicalStaffService
    {

        private readonly IUnitOfWork unitOfWork;
        private readonly IPersonRepository personRepository;
        private readonly IMedicalStaffRepository medicalStaffRepository;
        private readonly ICenterStaffRepository centerStaffRepository;
        private readonly IMedicalCenterRepository medicalCenterRepository;
        private readonly IServiceTypeRepository serviceTypeRepository;
 
        private readonly IMedicalStaffSpecialityRepository medicalStaffSpecialityRepository;
        private readonly IBaseValueRepository baseValueRepository;
        private readonly IGeoLocationRepository geoLocationRepository;
        private readonly ISpecialityRepository specialityRepository;
        private readonly ICenterLocationRepository centerLocationRepository;
        private IMapper mapper;

        public MedicalStaffService(IUnitOfWork unitOfWork,
            IMapper mapper,
            IPersonRepository personRepository,
            IMedicalStaffRepository medicalStaffRepository,
            ICenterStaffRepository centerStaffRepository,
            IMedicalCenterRepository medicalCenterRepository,
            IServiceTypeRepository serviceTypeRepository,
         
            IMedicalStaffSpecialityRepository medicalStaffSpecialityRepository,
            IBaseValueRepository baseValueRepository,
            IGeoLocationRepository geoLocationRepository,
            ISpecialityRepository specialityRepository,
            ICenterLocationRepository centerLocationRepository
            )
        {
            this.unitOfWork = unitOfWork;

            this.personRepository = personRepository;
            this.personRepository.UnitOfWork = this.unitOfWork;

            this.medicalStaffRepository = medicalStaffRepository;
            this.medicalStaffRepository.UnitOfWork = this.unitOfWork;

            this.centerStaffRepository = centerStaffRepository;
            this.centerStaffRepository.UnitOfWork = this.unitOfWork;

            this.medicalCenterRepository = medicalCenterRepository;
            this.medicalCenterRepository.UnitOfWork = this.unitOfWork;

            this.serviceTypeRepository = serviceTypeRepository;
            this.serviceTypeRepository.UnitOfWork = this.unitOfWork;

            this.medicalStaffSpecialityRepository = medicalStaffSpecialityRepository;
            this.medicalStaffSpecialityRepository.UnitOfWork = this.unitOfWork;

            this.baseValueRepository = baseValueRepository;
            this.baseValueRepository.UnitOfWork = this.unitOfWork;

            this.geoLocationRepository = geoLocationRepository;
            this.geoLocationRepository.UnitOfWork = this.unitOfWork;

            this.specialityRepository = specialityRepository;
            this.specialityRepository.UnitOfWork = this.unitOfWork;

            this.centerLocationRepository = centerLocationRepository;
            this.centerLocationRepository.UnitOfWork = this.unitOfWork;
            this.mapper = mapper; ;
        }


        #region Medical Staff Functions ---

        /// <number>
        /// function number : 1
        /// </number>
        /// <summary>
        /// Add Medical Staff (First Add Person Then Add Medical Staff) ----
        /// </summary>
        /// <param name="medicalCenterModel">Medical Center Model</param>
        /// <returns>ResponseResult(MedicalStaffModel)</returns>
        public async Task<ResponseResult> AddMedicalStaff(MedicalStaffModel medicalStaffModel)
        {
            // var isValid = Validation.IsValid(new PersonValidation(person));
            //  if (resultVaild.Status == ResponseStatus.NotValid)

             var person = mapper.Map<MedicalStaffModel, Person>(medicalStaffModel);

            //var person = new Person()
            //{
            //    FirstName = medicalStaffModel.FirstName,
            //    LastName = medicalStaffModel.LastName,
            //    FullName = medicalStaffModel.FullName,
            //    FullNameThree = medicalStaffModel.FullNameThree,
            //    FatherName = medicalStaffModel.FatherName,
            //    GrandFatherName = medicalStaffModel.GrandFatherName,
            //    MaritalBaseId = medicalStaffModel.MaritalBaseId,
            //    Age = medicalStaffModel.Age,
            //    BirthDate = medicalStaffModel.BirthDate,
            //    ExpertiseId = medicalStaffModel.ExpertiseId,
            //    SexBaseId = medicalStaffModel.SexId

            //};
            personRepository.Add(person);

            //    medicalStaffModel.Person = person;
            var medicalStaff = mapper.Map<MedicalStaffModel, MedicalStaff>(medicalStaffModel);

            medicalStaff.Person = person;
            medicalStaff.EmployeeDate = DateTime.Now;

            medicalStaffRepository.Add(medicalStaff);




            var centerStaff = mapper.Map<MedicalStaffModel, CenterStaff>(medicalStaffModel);
            centerStaff.MedicalStaff = medicalStaff;


            centerStaffRepository.Add(centerStaff);




            await unitOfWork.Save();
            //should change to auto mapper
            medicalStaffModel.Id = medicalStaff.Id;
            medicalStaffModel.Init();

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = medicalStaffModel

            };
        }

        /// <number>
        /// function number : 2
        /// </number>
        /// <summary>
        /// Add Service Type  ----
        /// </summary>
        /// <param name="serviceTypeModel">ServiceTypeModel for Insert</param>
        /// <returns>ResponseResult(ServiceTypeModel)</returns>
        public async Task<ResponseResult> AddServiceType(ServiceTypeModel serviceTypeModel)
        {
            var serviceType = mapper.Map<ServiceTypeModel, ServiceType>(serviceTypeModel);
            serviceTypeRepository.Add(serviceType);
            await unitOfWork.Save();
            serviceTypeModel = mapper.Map<ServiceType, ServiceTypeModel>(serviceType);
            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = serviceTypeModel

            };


        }

        /// <number>
        /// function number : 3
        /// </number>
        /// <summary>
        /// Get Medical Staff By CenterId ----
        /// </summary>
        /// <param name="centerId">centerId</param>
        /// <returns>ResponseResult(MedicalStaffModel)</returns>
        public async Task<ResponseResult> GetMedicalStaffBy(int centerId)
        {
            var medicalStaffs =  await (from mc in medicalCenterRepository.GetAll()
                                       join cs in centerStaffRepository.GetAll() on mc.Id equals cs.CenterId 
                                       join ms in medicalStaffRepository.GetAll() on cs.MedicalStaffId equals ms.Id
                                       join p in personRepository.GetAll() on ms.PersonId equals p.Id
                                       join s in baseValueRepository.GetAll() on p.SexBaseId equals s.Id into sNull
                                       from sbv in sNull.DefaultIfEmpty()
                                       where mc.Id == centerId
                                       select new MedicalStaffModel
                                       {
                                           Id = ms.Id,
                                           PersonId = ms.PersonId,
                                           FirstName = p.FirstName,
                                           LastName = p.LastName,
                                           FullName = p.FullName,
                                           FatherName = p.FatherName,
                                           FullNameThree = p.FullNameThree,
                                           TypeBaseId = ms.TypeBaseId,
                                           Age = p.Age,
                                           Sex = sbv.Title,
                                           SexId = sbv.Id,
                                           BirthDate = p.BirthDate


                                       }).ToListAsync();

            medicalStaffs.ForEach(x => x.Init());


            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = medicalStaffs

            };
        }


      //  int sexId, int specialtyId, int workTimeId, int locationId
        public async Task<ResponseResult> SearchDoctor()
        {
            var doctors =   (from ms in medicalStaffRepository.GetAll()
                                 join cs in centerStaffRepository.GetAll() on ms.Id equals cs.MedicalStaffId
                                 join c in medicalCenterRepository.GetAll() on cs.CenterId equals c.Id
                                 join wbv in baseValueRepository.GetAll() on c.WorkTimeBaseId equals wbv.Id into wbvNull
                                 from workTim in wbvNull.DefaultIfEmpty()
                                 join cl in centerLocationRepository.GetAll() on c.Id equals cl.CenterId into clNull
                                 from centerLocation in clNull.DefaultIfEmpty()
                                 join p in personRepository.GetAll() on ms.PersonId equals p.Id
                                 join sbv in baseValueRepository.GetAll() on p.SexBaseId equals sbv.Id into sbvNull
                                 from sex in sbvNull.DefaultIfEmpty()
                                 join l in geoLocationRepository.GetAll() on p.GeoLocationId equals l.Id into lNull
                                 from geo in lNull.DefaultIfEmpty()
                                 select new MedicalStaffModel
                                 {
                                     Id = ms.Id,
                                     FullName = p.FullName,
                                     Address = centerLocation.Address,
                                     MedicalCenterTitle = c.Title,
                                     WorkTimeTitle = workTim.Title,
                                     CenterPhone = c.Phone,
                                     VisitPhone = c.VisitorPhone
                                 }).ToList ();

            var doctorsId = doctors.Select(x => x.Id).ToList();

            var specialties = await (from ss in medicalStaffSpecialityRepository.GetAll()
                                     join sp in specialityRepository.GetAll() on ss.SpecialityId equals sp.Id
                                     where doctorsId.Contains(ss.MedicalStaffId)// && ss.SpecialityId == specialtyId
                                     select new SpecialityModel
                                     {
                                         Id = sp.Id,
                                         Title = sp.Title,
                                         MedicalStaffId = ss.MedicalStaffId
                                         
                                     }).ToListAsync();

            foreach (var d in doctors)
                d.Specialities = specialties.Where(x => x.MedicalStaffId == d.Id).ToList();

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = doctors
            };

        }


        public async Task<ResponseResult> SearchDoctorBy(DoctorFilter doctorFilter)
        {
            var expertIds = doctorFilter.Experties.Select(x => x.Id).ToList();
            bool isExpert = true; 
            if (expertIds == null || expertIds.Count == 0) isExpert = false;

            var sexIds = doctorFilter.Sex.Select(x => x.Id).ToList();
            bool isSex = true;
            if (sexIds == null || sexIds.Count == 0) isSex = false;

            var workingTimeIds = doctorFilter.WorkingTime.Select(x => x.Id).ToList();
            bool isWorkingTime = true;
            if (workingTimeIds == null || workingTimeIds.Count == 0) isWorkingTime = false;


            var doctors =   (from ms in medicalStaffRepository.GetAll()
                                 join cs in centerStaffRepository.GetAll() on ms.Id equals cs.MedicalStaffId
                                 join c in medicalCenterRepository.GetAll() on cs.CenterId equals c.Id
                                 join wbv in baseValueRepository.GetAll() on c.WorkTimeBaseId equals wbv.Id into wbvNull
                                 from workTim in wbvNull.DefaultIfEmpty()
                                 join cl in centerLocationRepository.GetAll() on c.Id equals cl.CenterId into clNull
                                 from centerLocation in clNull.DefaultIfEmpty()
                                 join p in personRepository.GetAll() on ms.PersonId equals p.Id
                                 join sbv in baseValueRepository.GetAll() on p.SexBaseId equals sbv.Id into sbvNull
                                 from sex in sbvNull.DefaultIfEmpty()
                                 join ebv in baseValueRepository.GetAll() on p.ExpertiseId equals ebv.Id into ebvNull
                                 from expert in ebvNull.DefaultIfEmpty()
                                 join l in geoLocationRepository.GetAll() on p.GeoLocationId equals l.Id into lNull
                                 from geo in lNull.DefaultIfEmpty()
                                 where (expertIds.Contains(expert.Id) || isExpert == false) 
                                       && (sexIds.Contains(sex.Id) || isSex == false)
                                       && (workingTimeIds.Contains(workTim.Id) || isWorkingTime == false)
                                       && (p.FullName.Contains(doctorFilter.FullName) || doctorFilter.FullName.Equals(""))
                             select new MedicalStaffModel
                                 {
                                     Id = ms.Id,
                                     FullName = p.FullName,
                                     Address = centerLocation.Address,
                                     MedicalCenterTitle = c.Title,
                                     WorkTimeTitle = workTim.Title,
                                     CenterPhone = c.Phone,
                                     VisitPhone = c.VisitorPhone
                                 }).ToList ();

            var doctorsId = doctors.Select(x => x.Id).ToList();

            var specialties = await (from ss in medicalStaffSpecialityRepository.GetAll()
                                     join sp in specialityRepository.GetAll() on ss.SpecialityId equals sp.Id
                                     where doctorsId.Contains(ss.MedicalStaffId)// && ss.SpecialityId == specialtyId
                                     select new SpecialityModel
                                     {
                                         Id = sp.Id,
                                         Title = sp.Title,
                                         MedicalStaffId = ss.MedicalStaffId
                                         
                                     }).ToListAsync();

            foreach (var d in doctors)
                d.Specialities = specialties.Where(x => x.MedicalStaffId == d.Id).ToList();

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = doctors
            };

        }
        public async Task<ResponseResult> GetStaffTypes()
        {
            var staffTypes = await baseValueRepository.GetAll().Where(x => x.BaseValueTypeId == 1003).ToListAsync();
            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = staffTypes
            };
        }

        public async Task<ResponseResult> ScientificLevels()
        {
            var scientificLevels = await baseValueRepository.GetAll().Where(x => x.BaseValueTypeId == 2007).ToListAsync();
            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = scientificLevels
            };
        }

        public async Task<ResponseResult> GetExpertises()
        {
            var expertises = await baseValueRepository.GetAll().Where(x => x.BaseValueTypeId == 3).ToListAsync();
            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = expertises
            };
        }


        #endregion
    }





}
