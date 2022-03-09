using AutoMapper;
using Business.CenterManagment.IServices;
using Business.CenterManagment.Models;
using Core.His.Models;
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Business.CenterManagment.Services
{
    public class MedicalSpecialityService : IMedicalSpecialityService
    {

        private readonly IUnitOfWork unitOfWork;
        private readonly ISpecialityRepository specialityRepository;
        private readonly ICenterSpecialityRepository centerSpecialityRepository;
        private IMapper mapper;


        public MedicalSpecialityService(IUnitOfWork unitOfWork,
            IMapper mapper,
            ISpecialityRepository specialityRepository,
            ICenterSpecialityRepository centerSpecialityRepository 
            )
        {
            this.unitOfWork = unitOfWork;
            this.specialityRepository = specialityRepository;
            this.specialityRepository.UnitOfWork = this.unitOfWork;
            this.centerSpecialityRepository = centerSpecialityRepository;
            this.centerSpecialityRepository.UnitOfWork = this.unitOfWork;
            this.mapper = mapper; ;
        }


        #region Medical Spaciality Functions ---
        /// <number>
        /// function number : 1
        /// </number>
        /// <summary>
        /// Get All Spaciality ----
        /// </summary>
        /// <returns>ResponseResult(SpacialityModel)</returns>
        public async Task<ResponseResult> GetSpecialities()
        {
            var getSpecialities = await (from s in specialityRepository.GetAll()
                                         select s).ToListAsync();
            var specialities = new List<SpecialityModel>();
            if (getSpecialities != null && getSpecialities.Count != 0)
                foreach (var s in getSpecialities)
                    specialities.Add(mapper.Map<Speciality, SpecialityModel>(s));

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = specialities

            };

        }

        /// <number>
        /// function number : 2
        /// </number>
        /// <summary>
        /// Get All Spaciality for tree selection ----
        /// </summary>
        /// <returns>ResponseResult(SpacialityModel)</returns>
        public async Task<ResponseResult> GetSpecialityTree()
        {
            var getSpecialties = await (from s in specialityRepository.GetAll()
                                        select new SpecialityModel
                                        {
                                            Id = s.Id,
                                            Title = s.Title,
                                            ParentId = s.ParentId
                                        }).Take(100).ToListAsync();
            var parentSpecialities = new List<SpecialityModel>();
            parentSpecialities = getSpecialties.Where(x => x.ParentId == null).ToList();


            foreach (var s in parentSpecialities)
                s.Children = getSpecialties.Where(x => x.ParentId == s.Id).ToList();

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = parentSpecialities
            };
        }

        /// <number>
        /// function number : 3
        /// </number>
        /// <summary>
        /// Add Speciality ----
        /// </summary>
        /// <param name="specialityModel">list of specialityModel</specialityModel></param>
        /// <returns>ResponseResult(specialityModel)</returns>
        public async Task<ResponseResult> AddCenterSpecialities(List<SpecialityModel> specialityModel)
        {
            foreach (var s in specialityModel)
            {
                var speciality = new CenterSpeciality()
                {
                    CenterId = s.CenterId,
                    CreateTime = DateTime.Now,
                    IsActive = true,
                    SpecialityId = s.Id
                };

                centerSpecialityRepository.Add(speciality);
            }
            await unitOfWork.Save();

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = specialityModel

            };

        }


        public async Task<ResponseResult> AddSpeciality(SpecialityModel specialityModel)
        {

            var speciality = mapper.Map<SpecialityModel, Speciality>(specialityModel);
            specialityRepository.Add(speciality);

           
            await unitOfWork.Save();

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = specialityModel

            };

        }

        #endregion

    }
}
