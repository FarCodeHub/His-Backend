using AutoMapper;
using Business.CenterManagment.IServices;
using Business.CenterManagment.Models;
using Core.His.Models;
using DataAccess.Repositories.His;
using Newtonsoft.Json;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Entities.His.Entities;
using System;
using System.IO;
using File = DataAccess.Entities.His.Entities.File;
using Business.Common.Models;

namespace Business.CenterManagment.Services
{
    public class PatientService :IPatientService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IPersonRepository personRepository;
        private readonly IMedicalStaffRepository medicalStaffRepository;
        private readonly ICenterStaffRepository centerStaffRepository;
        private readonly IMedicalCenterRepository medicalCenterRepository;
      
        private readonly IBaseValueRepository baseValueRepository;
        private readonly IGeoLocationRepository geoLocationRepository;
        private readonly ISpecialityRepository specialityRepository;
        private readonly ICenterLocationRepository centerLocationRepository;
        private readonly IPatientRepository patientRepository;
        private readonly IDrugRepository drugRepository;
        private readonly IPrescriptionRepository prescriptionRepository;
        private readonly IPrescriptionDetailDrugRepository prescriptionDetailDrugRepository;
        private readonly IReceptionRepository receptionRepository;
        private readonly IServiceTypeRepository serviceTypeRepository;
        private readonly IFileRepository fileRepository;
        private readonly IPatientFileRepository patientFileRepository;

        private readonly IUserRepository userRepository;

        private IMapper mapper;

        public PatientService(IUnitOfWork unitOfWork,
            IPersonRepository personRepository,
            IMedicalStaffRepository medicalStaffRepository,
            ICenterStaffRepository centerStaffRepository,
            IMedicalCenterRepository medicalCenterRepository,
         
            IBaseValueRepository baseValueRepository,
            IGeoLocationRepository geoLocationRepository,
            ISpecialityRepository specialityRepository,
            ICenterLocationRepository centerLocationRepository,
            IPatientRepository patientRepository,
            IDrugRepository drugRepository,
            IPrescriptionRepository prescriptionRepository,
            IPrescriptionDetailDrugRepository prescriptionDetailDrugRepository,
            IReceptionRepository receptionRepository,
            IServiceTypeRepository serviceTypeRepository,
            IFileRepository fileRepository,
            IPatientFileRepository patientFileRepository,
             IUserRepository userRepository,

        IMapper mapper)
        {
            this.unitOfWork = unitOfWork;

            this.personRepository = personRepository;
            this.personRepository.UnitOfWork = unitOfWork;

            this.medicalStaffRepository = medicalStaffRepository;
            this.medicalStaffRepository.UnitOfWork = unitOfWork;

            this.centerStaffRepository = centerStaffRepository;
            this.centerStaffRepository.UnitOfWork = unitOfWork;

            this.medicalCenterRepository = medicalCenterRepository;
            this.medicalCenterRepository.UnitOfWork = unitOfWork;

            this.baseValueRepository = baseValueRepository;
            this.baseValueRepository.UnitOfWork = unitOfWork;

            this.geoLocationRepository = geoLocationRepository;
            this.geoLocationRepository.UnitOfWork = unitOfWork;

            this.specialityRepository = specialityRepository;
            this.specialityRepository.UnitOfWork = unitOfWork;

            this.centerLocationRepository = centerLocationRepository;
            this.centerLocationRepository.UnitOfWork = unitOfWork;

            this.patientRepository = patientRepository;
            this.patientRepository.UnitOfWork = unitOfWork;

            this.drugRepository = drugRepository;
            this.drugRepository.UnitOfWork = unitOfWork;

            this.prescriptionRepository = prescriptionRepository;
            this.prescriptionRepository.UnitOfWork = unitOfWork;

            this.prescriptionDetailDrugRepository = prescriptionDetailDrugRepository;
            this.prescriptionDetailDrugRepository.UnitOfWork = unitOfWork;

            this.receptionRepository = receptionRepository;
            this.receptionRepository.UnitOfWork = unitOfWork;

            this.serviceTypeRepository = serviceTypeRepository;
            this.serviceTypeRepository.UnitOfWork = unitOfWork;

            this.fileRepository = fileRepository;
            this.fileRepository.UnitOfWork = unitOfWork;

            this.patientFileRepository = patientFileRepository;
            this.patientFileRepository.UnitOfWork = unitOfWork;

             this.userRepository = userRepository;
             this.userRepository.UnitOfWork = unitOfWork;

            this.mapper = mapper;
        }
        public async Task<ResponseResult> LoginPatient(UserModel login)
        {
            var userPatient = await (from p in patientRepository.GetAll()
                              join prs in personRepository.GetAll() on p.PersonId equals prs.Id
                              join u in userRepository.GetAll() on prs.Id equals u.PersonId
                               where u.UserName.Equals(login.UserName) && u.Password.Equals(login.Password)
                               
                              select new PatientModel
                              {
                                  Email = prs.Email,
                                  FullName = prs.FullName,
                                  PersonId = prs.Id,
                                  Id = p.Id,
                                  UserId = u.Id,
                                  FirstName = prs.FirstName,
                                  LastName = prs.LastName,
                                  FatherName = prs.FatherName,
                                  GrandFatherName=prs.GrandFatherName,
                                  Phone=prs.Phone,
                                  Address=prs.Address,
                                  Age = prs.Age,
                                  Hisno = p.Hisno,
                                  Height = p.Height,
                                  Weight = p.Weight,
                                  SexId = prs.SexBaseId,
                                  MaritalBaseId = prs.MaritalBaseId,
                                  MobileNumber = prs.Mobile,
                                  BrithDate = prs.BirthDate,
                                  NationalCode = prs.NationalCode,
                                  Avatar = prs.Avatar
                                  
                              }).FirstOrDefaultAsync();

          

            if (userPatient == null)
                return new ResponseResult
                {
                    Message = "UserName Or Password is Wrong!!",
                    Status = ResponseStatus.NotValid,
                    Data = userPatient
                };

            userPatient.Init();

            return new ResponseResult
                { 
                 
                Status = ResponseStatus.Success,
                Data = userPatient

            };
        }

        public async Task<ResponseResult> GetPatients()
        {
            var patients = await (from p in patientRepository.GetAll()
                                  join prs in personRepository.GetAll() on p.PersonId equals prs.Id
                                  join sbv in baseValueRepository.GetAll() on prs.SexBaseId equals sbv.Id into sbvNULL
                                  from sex in sbvNULL.DefaultIfEmpty()
                                  join mbv in baseValueRepository.GetAll() on prs.MaritalBaseId equals mbv.Id into mvbNULL
                                  from martial in mvbNULL.DefaultIfEmpty()
                                  join bv in baseValueRepository.GetAll() on p.BloodGroupBaseId equals bv.Id into bvNULL
                                  from blood in bvNULL.DefaultIfEmpty()
                                  orderby p.Id descending
                                  select new PatientModel
                                  {
                                      Id = p.Id,
                                      Age = prs.Age,
                                      FullName = prs.FullName,
                                      BloodGroupTitle = blood.Title,
                                      Height = p.Height,
                                      Weight = p.Weight,
                                      Allergies = p.Allergies,
                                      Hisno = p.Hisno,
                                      Sex = sex.Title,
                                      SexId = sex.Id,
                                      MartilTitle = martial.Title,
                                      MobileNumber = prs.Mobile,
                                      MaritalBaseId = martial.Id,
                                      BrithDate = (DateTime)prs.BirthDate,
                                      PersonId = prs.Id

                                  }).Take(20).ToListAsync();

            patients.ForEach(x => x.Init());

            patients.Where(x=>x.Allergies !=null)
           .ToList().ForEach(x => x.ListAlergies = JsonConvert.DeserializeObject<List<AllergiModel>>(x.Allergies));

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = patients

            };
        }

        public async Task<ResponseResult> GetPatientReceptions()
        {
            var receptions =await (from r in receptionRepository.GetAll()
                              join p in patientRepository.GetAll() on r.PatientId equals p.Id
                              join c in medicalCenterRepository.GetAll() on r.CenterId equals c.Id
                              join prs in personRepository.GetAll() on p.PersonId equals prs.Id
                              join st in serviceTypeRepository.GetAll() on r.ServiceTypeId equals st.Id
                              select r).ToListAsync();
            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = receptions

            };

        }


        public async Task<ResponseResult> GetPatientPrescriptions()
        {
            var prescriptions =  await (from p in patientRepository.GetAll()
                                  join ps in prescriptionRepository.GetAll() on p.Id equals ps.PatientId
                                  join c in medicalCenterRepository.GetAll() on ps.CenterId equals c.Id
                                  join ms in medicalStaffRepository.GetAll() on ps.MedicalStaffId equals ms.Id
                                  join pms in personRepository.GetAll() on ms.PersonId equals pms.Id
                                  join prs in personRepository.GetAll() on p.PersonId equals prs.Id
                                  select new PrescriptionModel
                                  {
                                      Id = ps.Id,
                                      CenterId = c.Id,
                                      FullName = prs.FullName,
                                      MobileNumber = prs.Mobile,
                                      MedicalCenterTitle = c.Title,
                                      DoctorTitle = pms.FullName,
                                      PrescriptionCode = ps.Code,
                                      PrescriptionDate = ps.PrescriptionDate,
                                      Note = ps.Note,
                                      CenterTitle = c.Title
                                  }).ToListAsync();

            var prescriptionIds = prescriptions.Select(x => x.Id).ToList();


            var drugs =await (from pdd in prescriptionDetailDrugRepository.GetAll()
                         join d in drugRepository.GetAll() on pdd.DrugId equals d.Id
                         where prescriptionIds.Contains(pdd.PrescriptionId)
                         select new DrugModel
                         {
                             Id=pdd.PrescriptionId,
                             BrandTitle = d.BrandTitle,
                             Quantity = pdd.Quantity,
                         }
                         ).ToListAsync();


            foreach (var item in prescriptions)
                item.Drugs = drugs.Where(x => x.Id == item.Id).ToList();


            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = prescriptions

            };

        }
        public async Task<ResponseResult> GetPatientPrescriptionsBy(int patientId,int centerId)
        {


            var receptions = await (from p in patientRepository.GetAll()
                                   join prs in personRepository.GetAll() on p.PersonId equals prs.Id
                                   join re in receptionRepository.GetAll() on p.Id equals re.PatientId
                                   join c in medicalCenterRepository.GetAll() on re.CenterId equals c.Id
                                   where (p.Id == patientId) && (c.Id == centerId || centerId == 0)
                                   select new ReceptionModel
                                   { 
                                   Id = re.Id,
                                   PatientId = re.PatientId,
                                   CenterId = c.Id,
                                   CenterTitle = c.Title,
                                   }).ToListAsync();

            var receptionIds = receptions.Select(x => x.Id).ToList();



            var prescriptions = await (from re in receptionRepository.GetAll() 
                                       join ps in prescriptionRepository.GetAll() on re.Id equals ps.ReceptionId
                                       join mc in medicalCenterRepository.GetAll() on re.CenterId equals mc.Id
                                       join ms in medicalStaffRepository.GetAll() on ps.MedicalStaffId equals ms.Id
                                       join pms in personRepository.GetAll() on ms.PersonId equals pms.Id
                                       where receptionIds.Contains((long)ps.ReceptionId)
                                       select new PrescriptionModel
                                       {
                                           Id = ps.Id,
                                           CenterId = mc.Id,
                                           MedicalCenterTitle = mc.Title,
                                           DoctorTitle = pms.FullName,
                                           PrescriptionCode = ps.Code,
                                           PrescriptionDate = ps.PrescriptionDate,
                                           Note = ps.Note,
                                       
                                       }).ToListAsync();
            if(prescriptions.Count == 0)
            return new ResponseResult { Status = ResponseStatus.NotFound, Message = "There Is No Prescription" };

            prescriptions.ForEach(x => x.Init());

            var prescriptionIds = prescriptions.Select(x => x.Id).ToList();


            var drugs = await (from pdd in prescriptionDetailDrugRepository.GetAll()
                               where prescriptionIds.Contains(pdd.PrescriptionId)
                               select new DrugModel
                               {
                                   Id = pdd.PrescriptionId,
                                   Note = pdd.Note,
                                   Quantity = pdd.Quantity,
                               }
                         ).ToListAsync();
            drugs.Where(x => x.Note != null)
                    .ToList().ForEach(x => x.DrugDetails = JsonConvert.DeserializeObject<DrugDetailsModel>(x.Note));

            foreach (var item in prescriptions)
                item.Drugs = drugs.Where(x => x.Id == item.Id).ToList();


            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = prescriptions

            };

        }

        public async Task<ResponseResult> SavePatientFile(string fileName,int patientId)
        {
            int type = 0;
            
            if (Path.GetExtension(fileName) == ".png")
                type = 1;
            else if(Path.GetExtension(fileName) == ".jpg" || Path.GetExtension(fileName) == ".jpeg")
                type = 2;
            else if(Path.GetExtension(fileName) == ".pdf")
                    type = 3;
            else
                type = 4;

            var file = new File()
            {
                CreateTime = DateTime.Now,
                FileFolderName = fileName,
                IsDeleted = false,
                ParentFolderId = null,
                Type = type,
            };
            fileRepository.Add(file);
            var patientFile = new PatientFile()
            {
                PatientId = patientId,
                File = file
            };
            patientFileRepository.Add(patientFile);

            await unitOfWork.Save();

            var fileModel = mapper.Map<File, FileModel>(file);

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = fileModel

            };


        }

        public async Task<ResponseResult> GetPatientFiles(int patientId)
        {
            var patientFiles = await (from pf in patientFileRepository.GetAll()
                                      join f in fileRepository.GetAll() on pf.FileId equals f.Id
                                      where pf.PatientId == patientId
                                      select new FileModel { Id = f.Id,
                                          CreateTime = f.CreateTime,
                                          FileFolderName = f.FileFolderName,
                                          ParentFolderId = f.ParentFolderId,
                                          IsDeleted = f.IsDeleted,
                                          Type = f.Type,
                                          ExtensionFile = Path.GetExtension(f.FileFolderName)
                                      }).ToListAsync();


            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = patientFiles

            };
        }

        public async Task<ResponseResult> EditPatient(PatientModel patient)
        {
            var getPatient =await (from p in patientRepository.GetAll()
                                   where p.Id == patient.Id
                                   select p).FirstOrDefaultAsync();
            if (getPatient == null)
                return new ResponseResult { Status = ResponseStatus.NotFound, Message = "Not Found" };

            var getPerson =await (from prs in personRepository.GetAll()
                                  where prs.Id == patient.PersonId
                                  select prs).FirstOrDefaultAsync();



            {
                getPerson.FirstName = patient.FirstName;
                getPerson.LastName = patient.LastName;
                getPerson.FatherName = patient.FatherName;
                getPerson.GrandFatherName = patient.GrandFatherName;
                getPerson.NationalCode = patient.NationalCode;
                getPerson.Mobile = patient.MobileNumber;
                getPerson.Email = patient.Email;
                getPerson.Address = patient.Address;
                getPerson.FirstName = patient.FirstName;
                getPerson.FullName = patient.FullName;
                getPerson.Age = patient.Age;
                getPerson.SexBaseId = patient.SexId;
                getPerson.MaritalBaseId = patient.MaritalBaseId;
                getPerson.BirthDate = patient.BrithDate;
                getPatient.Height = patient.Height;
                getPatient.Weight = patient.Weight;
            }

            await unitOfWork.Save();
            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = patient
            };

        }

    }



    public enum Extensions
    {
        png = 1,
        jpg = 2,
        pdf = 3,
        folder = 4
    }

}
