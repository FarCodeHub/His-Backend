//using Business.SMSManagment.Extensions;
//using Business.SMSManagment.IServices;
//using Business.SMSManagment.Models;
//using Business.SyncManagment.Extension;
//using Business.SyncManagment.IServices;
//using Business.SyncManagment.Models;
//using DataAccess.Entities.His.Entities;
//using DataAccess.Repositories.His;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Localization;
//using Microsoft.Extensions.Options;
//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Business.SyncManagment.Services
//{
//    public class SyncService : ISyncService
//    {
//        private readonly IUnitOfWork _unitOfWork;
//        private readonly IOutRequestService _requestService;
//        private readonly IOptions<SubSystemUrls> _subSystemUrls;
//        private readonly string[] interNationalCodeVital = new string[] { "271649006", "271650006", "60621009", "78564009", "27113001", "50373000", "737105002", "251075007", "431314004", "251872006", "103579009" };
//        private readonly string[] interNationalCodeHistory = new string[] { "33962009", "422625006", "417662000", "161615003", "254292007", "371441004", "86290005" };
//        private readonly IPrescriptionServiceResultRepository _prescriptionServiceResultRepository;
//        private readonly IPrescriptionDetailDrugRepository _prescriptionDetailDrugRepository;
//        private readonly IPrescriptionDetailServiceRepository _prescriptionDetailService;
//        private readonly IPatientExtraInfoRepository _patientExtraInfoRepository;
//        private readonly IDataTransferConvertRepository _dataTransferConvert;
//        private readonly IPrescriptionRepository _prescriptionRepository;
//        private readonly IMedicalStaffCertificateRepository _doctorCertificate;
//        private readonly IWorkContextService _workContextService;
//        private readonly IServiceRepository _servicesRepository;
//        private readonly IBaseValueRepository _maritalStatusRepository;
//        private readonly ICardCodeRepository _cardCodeRepository;
//        private readonly IUserCardCodeRepository _userCardCode;
//        private readonly IMedicalStaffRepository _doctorRepository;
//        private readonly ICertificateRepository _certificate;
//        private readonly IPersonRepository _personRepository;
//        private readonly IMedicalCenterRepository _centerRepository;
//        private readonly IBaseValueRepository _bloodGroupRepository;
//        private readonly IUserRepository _userRepository;
//        private readonly IPatientRepository _patients;
//        private readonly IBaseValueRepository _sexRepository;
//        private readonly ICenterStaffRepository _centerStaffRepository;
//        private readonly ICenterLocationRepository _centerLocationRepository;
//        private readonly IRhRepository _rh;
//        public SyncService(IUnitOfWork unitOfWork,
//            IOutRequestService requestService,
//            IOptions<SubSystemUrls> subSystemUrls,
//            IStringLocalizer<SharedResource> sharedLocalizer,
//            IBasicService<Certificate> basicService,
//            IBaseValueRepository sexRepository,
//            IPrescriptionDetailDrugRepository prescriptionDetailDrugRepository,
//            IPrescriptionRepository prescriptionRepository,
//            IBaseValueRepository maritalStatusRepository,
//            IMedicalStaffRepository doctorRepository,
//            IPersonRepository personRepository,
//            IMedicalCenterRepository centerRepository,
//            IBaseValueRepository bloodGroupRepository,
//            IUserRepository userRepository,
//            IMedicalStaffCertificateRepository doctorCertificate,
//            IPatientExtraInfoRepository patientExtraInfoRepository,
//            ICardCodeRepository cardCodeRepository,
//            IUserCardCodeRepository userCardCode,
//            ICertificateRepository certificate,
//            IRhRepository rh,
//            IDataTransferConvertRepository dataTransferConvert,
//            IPrescriptionServiceResultRepository prescriptionServiceResultRepository,
//            IPrescriptionDetailServiceRepository prescriptionDetailService,
//            IServiceRepository servicesRepository,
//            ICenterStaffRepository centerStaffRepository,
//            ICenterLocationRepository centerLocationRepository,
//            IWorkContextService workContextService)
//        {
//            _unitOfWork = unitOfWork;
//            _requestService = requestService;
//            _subSystemUrls = subSystemUrls;

//            _workContextService = workContextService;

//            _sexRepository = sexRepository;
//            //_sexRepository.UnitOfWork = unitOfWork;

//            _prescriptionDetailDrugRepository = prescriptionDetailDrugRepository;
//            //_prescriptionDetailDrugRepository.UnitOfWork = unitOfWork;

//            _prescriptionRepository = prescriptionRepository;
//            //_prescriptionRepository.UnitOfWork = unitOfWork;

//            _maritalStatusRepository = maritalStatusRepository;
//            //_maritalStatusRepository.UnitOfWork = unitOfWork;

//            _doctorRepository = doctorRepository;
//            //_doctorRepository.UnitOfWork = unitOfWork;

//            _personRepository = personRepository;
//            //_personRepository.UnitOfWork = unitOfWork;

//            _centerRepository = centerRepository;
//            //_centerRepository.UnitOfWork = unitOfWork;

//            _bloodGroupRepository = bloodGroupRepository;
//            //_bloodGroupRepository.UnitOfWork = unitOfWork;

//            _userRepository = userRepository;
//            //_userRepository.UnitOfWork = unitOfWork;

//            _doctorCertificate = doctorCertificate;
//            //_doctorCertificate.UnitOfWork = unitOfWork;

//            _patientExtraInfoRepository = patientExtraInfoRepository;
//            //_patientExtraInfoRepository.UnitOfWork = unitOfWork;

//            _cardCodeRepository = cardCodeRepository;
//            //_cardCodeRepository.UnitOfWork = unitOfWork;

//            _userCardCode = userCardCode;
//            //_userCardCode.UnitOfWork = unitOfWork;

//            _certificate = certificate;
//            //_certificate.UnitOfWork = unitOfWork;

//            _rh = rh;
//            //_rh.UnitOfWork = unitOfWork;

//            _dataTransferConvert = dataTransferConvert;
//            //_dataTransferConvert.UnitOfWork = unitOfWork;

//            _prescriptionServiceResultRepository = prescriptionServiceResultRepository;
//            //_prescriptionServiceResultRepository.UnitOfWork = unitOfWork;

//            _prescriptionDetailService = prescriptionDetailService;
//            //_prescriptionDetailService.UnitOfWork = unitOfWork;

//            _servicesRepository = servicesRepository;
//            //_servicesRepository.UnitOfWork = unitOfWork;

//            _centerStaffRepository = centerStaffRepository;
//            //_centerStaffRepository.UnitOfWork = unitOfWork;

//            _centerLocationRepository = centerLocationRepository;

//        }


//        public async Task<string> SyncData(SyncDto syncDto, int currentUserId)
//        {
//            var deSerializedData = JsonConvert.DeserializeObject<BaseWinAppDto>(syncDto.Data.SerializedData);

//            if (deSerializedData.Id != null && syncDto.Data.ServerId != null && deSerializedData.Id != syncDto.Data.ServerId)
//            {
//                return $"Sync Data error, Server Id: {syncDto.Data.ServerId} doesn't match serialized Data Id: {deSerializedData.Id}";
//            }

//            var dataIsConvertBeforeId = await CheckDataIsConvertBefore(syncDto.Data.ServerId, syncDto.Data.Table, currentUserId);
//            var message = "No such table to sync!";

//            switch (syncDto.Data.Table)
//            {
//                case TablesWinAppEnum.Doctor:
//                    message = await DoctorUpsert(syncDto, dataIsConvertBeforeId, currentUserId);
//                    break;
//                case TablesWinAppEnum.Patient:
//                    message = await PatientUpsert(syncDto, dataIsConvertBeforeId, currentUserId);
//                    break;
//                case TablesWinAppEnum.Prescription:
//                    message = await PrescriptionsUpsert(syncDto, dataIsConvertBeforeId, currentUserId);
//                    break;
//                case TablesWinAppEnum.Drug:
//                    message = await DrugUpsert(syncDto, dataIsConvertBeforeId, currentUserId);
//                    break;
//                case TablesWinAppEnum.VitalSign:
//                    message = await VitalSignUpsert(syncDto, dataIsConvertBeforeId, currentUserId);
//                    break;
//                case TablesWinAppEnum.PatientHistory:
//                    message = await PatientHistoryUpsert(syncDto, dataIsConvertBeforeId, currentUserId);
//                    break;
//                case TablesWinAppEnum.Radiology:
//                    message = await RadiologyUpsert(syncDto, dataIsConvertBeforeId, currentUserId);
//                    break;
//                    //default: throw new SyncDataMismatchException("No such table to sync to!");
//            }

//            await _unitOfWork.Save();

//            return message;
//        }

//        public async Task<BaseResponseDto> RegisterDoctorAsync(SyncDoctorDto doctorDto)
//        {
//            //  var exsitDoctor = await _userRepository.GetAll().Include(n => n.Person).ThenInclude(n => n.Doctors)
//            var exsitDoctorUser = await _userRepository.GetAll().Include(n => n.Person).ThenInclude(n => n.MedicalStaffs.Where(x => x.TypeBaseId == 13))
//                .FirstOrDefaultAsync(n => n.UserName == doctorDto.UserName);

//            //Why same data with new model?
//            var data = new DoctorWinAppDto
//            {
//                UserName = doctorDto.UserName,
//                Password = doctorDto.Password,
//                Mac = doctorDto.Mac,
//                Email = doctorDto.Email,
//                Phone = doctorDto.Phone
//            };

//            if (exsitDoctorUser != null)
//            {
//                exsitDoctorUser.Password = Utilities.ComputeHashSHA256(data.Password);
//                //exsitDoctor.UserName = data.UserName;

//                _userRepository.Update(exsitDoctorUser);

//                await _unitOfWork.Save();

//                //   var doctorid = await _dataTransferConvert.GetAll().FirstOrDefaultAsync(n => n.TargetTableId == exsitDoctor.Person.Doctors.FirstOrDefault().Id.ToString() && n.TableName == TablesWinAppEnum.Doctor.ToString());
//                // var doctorDataConvert = await _dataTransferConvert.GetAll().FirstOrDefaultAsync(n => n.TargetTableId == exsitDoctorUser.Person.MedicalStaffs.FirstOrDefault().Id.ToString());
//                var doctorMedicalStaff = doctorDto.
//                return new LoginResponseDto
//                {
//                    Status = ResponseStatus.Success,
//                    Data = new
//                    {
//                        DoctorId = doctorDataConvert.TableId,
//                        SmsId = exsitDoctorUser.SmsUserId,
//                        SmsToken = exsitDoctorUser.SmsToken
//                    }
//                };
//            }

//            //var resultValid = CheckValidate.Valid(new SyncDoctorValidation(_sharedLocalizer, _personRepository, _userRepository), doctorDto);
//            //if (resultValid.Status == ResponseStatus.NotValid)
//            //{
//            //    return resultValid;
//            //}

//            //var exsitDoctor = await _userRepository.Include(n => n.Person).ThenInclude(n => n.Doctors)
//            //    //.FirstOrDefaultAsync(n => n.UserName == data.UserName);
//            //    .FirstOrDefaultAsync(n => n.MacAddress == data.Mac);


//            var result = await DoctorNew(data);
//            return new LoginResponseDto { Status = ResponseStatus.Success, Data = result };
//        }


//        private async Task<long> CheckDataIsConvertBefore(string id, TablesWinAppEnum tableName, int currentUserId)
//        {
//            var item = await _dataTransferConvert.GetAll()
//                .Where(n =>
//                n.TableId == id &&
//                n.TableName == tableName.ToString() &&
//                n.UserId == currentUserId //_workContextService.UserId // باید مربوط به دکتر جاری باشد
//                )
//                .ToListAsync();

//            if (item == null)
//            {
//                return 0;
//            }

//            return Convert.ToInt64(item.LastOrDefault()?.TargetTableId);
//        }
//        private async Task DataTransferConvertAdd(string tableId, string tableName, int id, int currentUserId)
//        {
//            var dataTransferConvert = new DataAccess.Entities.His.Entities.DataTransferConvert
//            {
//                UserId = currentUserId, //_workContextService.UserId,
//                CreateDate = DateTime.Now,
//                TargetTableId = id.ToString(),
//                TableId = tableId,
//                TableName = tableName
//            };
//            _dataTransferConvert.Add(dataTransferConvert);
//        }
//        private async Task<Rh> RhGet(PatientWinAppDto data)
//        {
//            var r = await _rh.GetAll().ToListAsync();
//            var rhId = r.FirstOrDefault(n => n.Code1.ToLower() == "unknown");

//            if (data.RH != null)
//            {
//                rhId = r.FirstOrDefault(n => n.Code1.ToLower() == Enum.GetName(typeof(RHWinAppEnum), data.RH).ToLower());
//            }

//            return rhId;
//        }
//        //  private async Task<BloodGroup> BloodGet(PatientWinAppDto data)
//        private async Task<BaseValue> BloodGet(PatientWinAppDto data)
//        {
//            var b = await _bloodGroupRepository.GetAll().Where(x => x.BaseValueTypeId == 1005).ToListAsync();
//            // var bloodId = b.FirstOrDefault(n => n.Code1?.ToLower() == "unknown");
//            var bloodId = b.FirstOrDefault(n => n.UniqueName?.ToLower() == "unknown");

//            if (data.Blood != null)
//            {

//                // bloodId = b.FirstOrDefault(n => n.Code1.ToLower() == Enum.GetName(typeof(BloodWinAppEnum), data.Blood).ToLower());

//                bloodId = b.FirstOrDefault(n => n.UniqueName.ToLower() == Enum.GetName(typeof(BloodWinAppEnum), data.Blood).ToLower());
//            }

//            return bloodId;
//        }
//        // private async Task<Sex> SexGet(PatientWinAppDto data)
//        private async Task<BaseValue> SexGet(PatientWinAppDto data)
//        {
//            // var s = await _sexRepository.GetAll().ToListAsync();
//            var s = await _sexRepository.GetAll().Where(x => x.BaseValueTypeId == 1002).ToListAsync();
//            // var sexId = s.FirstOrDefault(n => n.Code1.ToLower() == "unknown");
//            var sexId = s.FirstOrDefault(n => n.UniqueName.ToLower() == "unknown");
//            return s.FirstOrDefault(n => n.UniqueName.ToLower() == Enum.GetName(typeof(GenderWinAppEnum), data.Gender).ToLower());
//        }
//        // private async Task<MaritalStatus> MaritalStatusGet(PatientWinAppDto data)
//        private async Task<BaseValue> MaritalStatusGet(PatientWinAppDto data)
//        {
//            // var m = await _maritalStatusRepository.GetAll().ToListAsync();
//            var m = await _maritalStatusRepository.GetAll().Where(x => x.BaseValueTypeId == 2).ToListAsync();

//            // var maritalStatusId = m.FirstOrDefault(n => n.Code1.ToLower() == "other");
//            var maritalStatusId = m.FirstOrDefault(n => n.UniqueName.ToLower() == "other");


//            if (data.MartialState != null)
//            {
//                //  maritalStatusId = m.FirstOrDefault(n => n.Code1.ToLower() == Enum.GetName(typeof(MartialStateWinAppEnum), data.MartialState).ToLower());
//                maritalStatusId = m.FirstOrDefault(n => n.UniqueName.ToLower() == Enum.GetName(typeof(MartialStateWinAppEnum), data.MartialState).ToLower());
//            }

//            return maritalStatusId;
//        }

//        //============================================================================== doctor 
//        private async Task<string> DoctorUpsert(SyncDto data, long dataIsConvertBeforeId, int currentUserId)
//        {
//            var deSerializedData = JsonConvert.DeserializeObject<DoctorWinAppDto>(data.Data.SerializedData);
//            return await DoctorUpdate(deSerializedData, currentUserId);

//            // چون ثبت نام دکتر در قسمت دیگری انجام میشود در اینجا فقط اپدیت دکتر رو خواهیم داشت
//            //if (dataIsConvertBeforeId > 0)
//            //{
//            //    await DoctorUpdate(deSerializedData, dataIsConvertBeforeId);
//            //}
//            //else
//            //{
//            //    await DoctorNew(deSerializedData);
//            //}
//        }
//        public async Task<object> DoctorNew(DoctorWinAppDto data)
//        {
//            //TODO user?
//            var user = new User();
//            var person = new Person();
//            // var doctor = new Doctor();

//            //--------------------------------- add person 
//            ModelToPerson(data, person);
//            _personRepository.Add(person);
//            await _unitOfWork.Save();

//            //--------------------------------- add Center 
//            //var center = new Center
//            //{
//            //    IsActive = false,
//            //    CenterTypeId = 4,
//            //    Email = data.Email,
//            //    Phone = data.Phone
//            //};
//            var center = new MedicalCenter
//            {
//                IsActive = false,
//                CenterTypeId = 2,//=clicic
//                Email = data.Email,
//                Phone = data.Phone
//            };

//            _centerRepository.Add(center);
//            await _unitOfWork.Save();

//            // ---------------------------------add senction
//            //var section = new Section
//            //{
//            //    Title = $"DoctorSync-{data.Enname}",
//            //    CenterId = center.Id,
//            //    SectionKindId = 1,
//            //    SectionFieldId = 5,
//            //    IsActive = true
//            //};

//            // await _centerRepository.Add(section);



//            var section = new MedicalCenter
//            {
//                Title = $"DoctorSync-{data.Enname}",
//                ParentId = center.Id,
//                LocalId = data.,
//                CenterTypeId = 2,//=clicic
//                Email = data.Email,
//                Phone = data.Phone,
//                CostVisit = (decimal)data.Visitfee
//            };

//            _centerRepository.Add(section);
//            //--------------------------------- add doctor 
//            var doctor = new MedicalStaff()
//            {
//                PersonId = person.Id,
//                TypeBaseId = 13,
//                EmployeeDate = DateTime.Now
//            };

//            await ModelToDoctor(data, doctor);
//            _doctorRepository.Add(doctor);
//            await _unitOfWork.Save();

//            // -- add medical staff
//            var centerStaff = new CenterStaff()
//            {
//                MedicalStaffId = doctor.Id,
//                CenterId = center.Id
//            };
//            _centerStaffRepository.Add(centerStaff);
//            await _unitOfWork.Save();



//            if (!string.IsNullOrEmpty(data.UserName) && !string.IsNullOrEmpty(data.Password))
//            {
//                user = new User
//                {
//                    IsActive = true,
//                    IsVerify = true,
//                    PersonId = person.Id,
//                    UserName = data.UserName,
//                    MacAddress = data.Mac,
//                    Password = Utilities.ComputeHashSHA256(data.Password)
//                };

//                _userRepository.Add(user);
//            }
//            var doctorid = (Guid.NewGuid()).ToString();
//            await DataTransferConvertAdd(doctorid, TablesWinAppEnum.Doctor.ToString(), doctor.Id, 0);
//            await _unitOfWork.Save();

//            var smsResult = await SyncDataSms(data.UserName);

//            return new
//            {
//                doctorId = doctorid,
//                SmsId = smsResult.Id,
//                SmsToken = smsResult.Token
//            };
//        }

//        public async Task<string> DoctorUpdateRegister(int userid, DoctorWinAppDto data)
//        {

//            return "Update Doctor Success";
//        }
//        public async Task<string> DoctorUpdate(DoctorWinAppDto data, int currentUserId)
//        {
//            //var userid =  _workContextService.UserId;
//            var user = await _userRepository.GetAll().Where(n => n.Id == currentUserId).FirstOrDefaultAsync();
//            if (user == null)
//            {
//                return "User Not Found";
//            }

//            //var person = await _personRepository.GetAll()
//            //    .Include(p => p.Doctors)
//            //    .ThenInclude(p => p.Center)
//            //    .Where(n => n.Id == user.PersonId)
//            //    .FirstOrDefaultAsync();


//            var person = await _personRepository.GetAll()
//                    .Include(p => p.MedicalStaffs.Where(x => x.TypeBaseId == 13))
//                    .ThenInclude(p => p.CenterStaffs)
//                    .ThenInclude(p => p.Center)
//                    .Where(n => n.Id == user.PersonId)
//                    .FirstOrDefaultAsync();

//            if (person == null)
//            {
//                return "Person Not Found";
//            }
//            //  var doctor = person.Doctor.FirstOrDefault();

//            var doctor = person.MedicalStaffs.FirstOrDefault();
//            //this line added
//            var doctorCenter = await _centerRepository.GetAll().Include(x => x.CenterStaffs.Where(c => c.MedicalStaffId == doctor.Id)).FirstOrDefaultAsync();

//            //  if (doctor != null)
//            if (doctorCenter != null)
//            {
//                //   var center = doctor.Center;
//                if (doctorCenter != null)
//                {
//                    // center.Address = data.Address;
//                    doctorCenter.Email = data.Email;
//                    doctorCenter.Phone = data.Phone;
//                    doctorCenter.Title = data.ArName;

//                    _centerRepository.Update(doctorCenter);

//                    var centerLocation = await _centerLocationRepository.FindByCenterId(doctorCenter.Id);

//                    //centerLocation.Center = doctorCenter;
//                    centerLocation.Address = data.Address;
//                    centerLocation.CountryId = 0;//Iraq
//                    centerLocation.ProvinceId = 0;//Baqdad
//                    centerLocation.CityId = 0;//Baqdad
//                    centerLocation.ZoneId = 0;//Baqdad

//                }
//                //else
//                //{
//                //    var centerLocation = new CenterLocation()
//                //    {
//                //        Center = center,
//                //        Address = data.Address,
//                //        CountryId = 0,//Iraq
//                //        ProvinceId = 0,//Baqdad
//                //        CityId = 0,//Baqdad
//                //        ZoneId = 0//Baqdad
//                //    };
//                //    _centerLocationRepository.Add(centerLocation);
//                //}


//            }

//            ModelToPerson(data, person);

//            await ModelToDoctor(data, doctor);

//            _personRepository.Update(person);

//            await _unitOfWork.Save();

//            return "Update Doctor Success";
//        }

//        //============================================================================== patient 
//        private async Task<string> PatientUpsert(SyncDto data, long dataIsConvertBeforeId, int currentUserId)
//        {
//            var deSerializedData = JsonConvert.DeserializeObject<PatientWinAppDto>(data.Data.SerializedData);

//            if (dataIsConvertBeforeId > 0)
//            {
//                return await PatientUpdate(deSerializedData, dataIsConvertBeforeId, currentUserId);
//            }
//            else
//            {
//                return await PatientNew(deSerializedData, 0, currentUserId);
//            }
//        }
//        public async Task<string> PatientNew(PatientWinAppDto data, long personId = 0, int currentUserId = 0)
//        {
//            //برای زمانی که دکتر دیگری مریض تکراری را سینک میکند 
//            if (!string.IsNullOrEmpty(data.NHS_Number))
//            {
//                var nhs = await _cardCodeRepository.GetAll().FirstOrDefaultAsync(n => n.HealthNumber == data.NHS_Number);
//                if (nhs != null)
//                {
//                    var userCardCode = await _userCardCode.GetAll().FirstOrDefaultAsync(n => n.CardCodeId == nhs.Id);
//                    if (userCardCode != null)//قبلا این کد توسط دکتر دیگر فعال سازی شده
//                    {
//                        var _patient = await _userRepository.GetAll()
//                            .Include(x => x.Person)
//                            .ThenInclude(x => x.Patients)
//                            .FirstOrDefaultAsync(x => x.Id == userCardCode.UserId);

//                        var addBefor = await _dataTransferConvert.GetAll().FirstOrDefaultAsync(n =>
//                            n.UserId == currentUserId && //_workContextService.UserId &&
//                            n.TargetTableId == _patient.Person.Patients.FirstOrDefault().Id.ToString() &&
//                            n.TableId == data.Id.ToString() &&
//                            n.TableName == TablesWinAppEnum.Patient.ToString()
//                         );

//                        if (addBefor == null)
//                        {
//                            await DataTransferConvertAdd(data.Id.ToString(), TablesWinAppEnum.Patient.ToString(), _patient.Person.Patients.FirstOrDefault().Id, currentUserId);
//                            await _unitOfWork.Save();
//                        }
//                        await PatientUpdate(data, _patient.Person.Patients.FirstOrDefault().Id, currentUserId);
//                    }
//                }
//            }

//            //TODO user id_card --> users.CardCodeId,?
//            var person = new Person();
//            var patient = new Patient();
//            var patientExtraInfo = new PatientExtraInfo();

//            //--------------------------------- add person 
//            if (personId == 0)
//            {
//                await ModelToPerson(data, person);
//                _personRepository.Add(person);
//                await _unitOfWork.Save();
//                personId = person.Id;
//            }

//            //--------------------------------- add patient 
//            patient.PersonId = (int)personId;
//            //patient.FileNo = data.NHS_Number;
//            ModelToPatient(data, patient);
//            _patients.Add(patient);

//            await CheckNhsActiveBefore(data, personId);
//            //--------------------------------- add PatientExtraInfo 
//            patientExtraInfo.PatientId = patient.Id;
//            await ModelToPatientExtraInfo(data, patientExtraInfo);

//            _patientExtraInfoRepository.Add(patientExtraInfo);
//            await DataTransferConvertAdd(data.Id.ToString(), TablesWinAppEnum.Patient.ToString(), patient.Id, currentUserId);

//            await _unitOfWork.Save();

//            return "Add Patient Success";

//        }

//        private async Task CheckNhsActiveBefore(PatientWinAppDto data, long personId)
//        {
//            if (!string.IsNullOrEmpty(data.NHS_Number))
//            {
//                var nhs = await _cardCodeRepository.GetAll().FirstOrDefaultAsync(n => n.HealthNumber == data.NHS_Number);
//                if (nhs != null)
//                {
//                    var userCardCode = await _userCardCode.GetAll().FirstOrDefaultAsync(n => n.CardCodeId == nhs.Id);

//                    //قبلا کاربر فعال سازی را انجام نداده
//                    if (userCardCode == null)
//                    {
//                        var user = new User
//                        {
//                            IsActive = true,
//                            PersonId = (int)personId,
//                            CardCodeId = nhs.Id,
//                            UserCardCodes = new List<UserCardCode>
//                            {
//                                new UserCardCode
//                                {
//                                   CardCodeId = nhs.Id,
//                                    IsCurrent = true,
//                                    CreateDate = DateTime.Now
//                                }
//                            }
//                        };

//                        _userRepository.Add(user);
//                        await _unitOfWork.Save();
//                    }
//                    else
//                    {
//                        // یوزر جاری 
//                        var userId = userCardCode.UserId.GetValueOrDefault();
//                        var user = await _userRepository.GetAll()
//                            .Include(x => x.Person)
//                            .ThenInclude(x => x.Patients)
//                            .ThenInclude(n => n.PatientExtraInfos)
//                            .FirstOrDefaultAsync(x => x.Id == userId);

//                        if (user.Person.Patients.TryAny())
//                        {
//                            //  _patientExtraInfoRepository.RemoveRange(user.Person.Patients.First().PatientExtraInfos);
//                            _patientExtraInfoRepository.RemoveRange((user.Person.Patients.First().PatientExtraInfos).ToList());
//                            _patients.Delete(user.Person.Patients.First());
//                        }

//                        //TODO
//                        // آپدیت فایل منیجر
//                        // هنوز انجام نشده

//                        user.PersonId = (int)personId;
//                        user.IsSync = true;

//                        _userRepository.Update(user);

//                        //TODO
//                        // باید تمام جداول مرتبظ حذف شود 
//                        //_personRepository.Remove(user.Person);
//                    }
//                }
//            }

//            await _unitOfWork.Save();
//        }
//        private async Task CheckNhsActiveBefore_Update(PatientWinAppDto data, long personId)
//        {
//            if (!string.IsNullOrEmpty(data.NHS_Number))
//            {
//                var nhs = await _cardCodeRepository.GetAll().FirstOrDefaultAsync(n => n.HealthNumber == data.NHS_Number);
//                if (nhs != null)
//                {
//                    var userCardCode = await _userCardCode.GetAll().FirstOrDefaultAsync(n => n.CardCodeId == nhs.Id);

//                    var currenntUser = await _userRepository.GetAll().FirstOrDefaultAsync(n => n.PersonId == personId);

//                    if (currenntUser == null || userCardCode.UserId == currenntUser.Id)
//                    {
//                        return;
//                    }

//                    //قبلا کاربر فعال سازی را انجام نداده
//                    if (userCardCode == null)
//                    {
//                        var ucc = new UserCardCode
//                        {
//                            CardCodeId = nhs.Id,
//                            IsCurrent = true,
//                            UserId = currenntUser.Id,
//                            CreateDate = DateTime.Now
//                        };

//                        _userCardCode.Add(ucc);
//                    }
//                    else
//                    {
//                        // یوزر جاری 
//                        var userId = userCardCode.UserId.GetValueOrDefault();
//                        var user = await _userRepository.GetAll()
//                            .Include(x => x.Person)
//                            .ThenInclude(x => x.Patients)
//                            .ThenInclude(n => n.PatientExtraInfos)
//                            .FirstOrDefaultAsync(x => x.Id == userId);

//                        if (user.Person.Patients.TryAny())
//                        {
//                            // _patientExtraInfoRepository.RemoveRange(user.Person.Patients.First().PatientExtraInfos);
//                            _patientExtraInfoRepository.RemoveRange(user.Person.Patients.First().PatientExtraInfos.ToList());
//                            _patients.Delete(user.Person.Patients.First());
//                        }


//                        // آپدیت فایل منیجر
//                        // هنوز انجام نشده

//                        user.PersonId = (int)personId;
//                        user.IsSync = true;
//                        _userRepository.Update(user);

//                        _personRepository.Delete(user.Person);
//                    }
//                }
//            }

//            await _unitOfWork.Save();
//        }

//        public async Task<string> PatientUpdate(PatientWinAppDto data, long patientId, int currentUserId)
//        {
//            var patient = await _patients.GetAll()
//             .Where(n => n.Id == patientId)
//             .FirstOrDefaultAsync();

//            if (patient == null)
//            {
//                await PatientNew(data, 0, currentUserId);
//            }
//            //---------------------------------------- person
//            var person = await _personRepository.GetAll()
//                .Where(n => n.Id == patient.PersonId)
//                .FirstOrDefaultAsync();

//            if (person == null)
//            {
//                return await PatientNew(data);
//            }

//            //---------------------------------------- patient

//            await ModelToPerson(data, person);
//            ModelToPatient(data, patient);

//            await CheckNhsActiveBefore_Update(data, person.Id);

//            //---------------------------------------- extraInfo
//            var patientExtraInfo = await _patientExtraInfoRepository.GetAll()
//               .Where(n => n.PatientId == patient.Id)
//               .FirstOrDefaultAsync();

//            if (patientExtraInfo == null)
//            {
//                patientExtraInfo = new PatientExtraInfo
//                {
//                    PatientId = patient.Id
//                };
//                await ModelToPatientExtraInfo(data, patientExtraInfo);
//                _patientExtraInfoRepository.Add(patientExtraInfo);
//            }
//            else
//            {
//                await ModelToPatientExtraInfo(data, patientExtraInfo);
//                _patientExtraInfoRepository.Update(patientExtraInfo);
//            }

//            _personRepository.Update(person);
//            _patients.Update(patient);

//            await _unitOfWork.Save();

//            return "Update Patient Success";
//        }

//        //============================================================================== Prescriptions 
//        private async Task<string> PrescriptionsUpsert(SyncDto data, long dataIsConvertBeforeId, int currentUserId)
//        {
//            var deSerializedData = JsonConvert.DeserializeObject<PrescriptionWinAppDto>(data.Data.SerializedData);

//            if (dataIsConvertBeforeId > 0)
//            {
//                return await PrescriptionsUpdate(deSerializedData, dataIsConvertBeforeId, currentUserId);
//            }
//            else
//            {
//                var result = await PrescriptionsNew(deSerializedData, currentUserId);
//                return result.message;
//            }
//        }
//        public async Task<(string message, int id)> PrescriptionsNew(PrescriptionWinAppDto data, int currentUserId)
//        {
//            var patient = await _dataTransferConvert.GetAll().FirstOrDefaultAsync(n => n.TableId == data.PatientId && n.TableName == TablesWinAppEnum.Patient.ToString() && n.UserId == currentUserId /*_workContextService.UserId*/);

//            if (!int.TryParse(patient?.TargetTableId, out int patientId))
//            {
//                return ("Patient Not Found", 0);
//            }

//            var doctorId = await GetDoctorId(data.DoctorId);
//            if (doctorId == 0)
//            {
//                return ("Doctor Not Found", 0);
//            }
//            //--------------------------------- add reception 
//            var tempReception = new Reception
//            {
//                CreateTime = data.Date,
//                PatientId = patientId,
//                DoctorId = doctorId,
//                Note = data.Notes,
//                //   SectionId = 1 // -- remove by farahd
//            };
//            //--------------------------------- add Prescriptions 
//            var tempPrescription = new Prescription
//            {
//                Reception = tempReception,
//                CreateDate = data.Date,
//                MedicalStaffId = doctorId,
//                Note = data.Notes
//            };

//            _prescriptionRepository.Add(tempPrescription);
//            await _unitOfWork.Save();

//            await DataTransferConvertAdd(data.Id, TablesWinAppEnum.Prescription.ToString(), (int)tempPrescription.Id, currentUserId);
//            await _unitOfWork.Save();

//            return ("Add Prescription Success", (int)tempPrescription.Id);

//        }
//        public async Task<string> PrescriptionsUpdate(PrescriptionWinAppDto data, long id, int currentUserId)
//        {
//            var temp = await _prescriptionRepository.GetAll()
//                .Where(n => n.Id == id)
//                .FirstOrDefaultAsync();

//            if (temp == null)
//            {
//                var result = await PrescriptionsNew(data, currentUserId);
//                return result.message;
//            }

//            temp.Note = data.Notes;

//            _prescriptionRepository.Update(temp);
//            await _unitOfWork.Save();

//            return "Update Prescriptions Success";
//        }

//        //============================================================================== Drug 
//        private async Task<string> DrugUpsert(SyncDto data, long dataIsConvertBeforeId, int currentUserId)
//        {
//            var deSerializedData = JsonConvert.DeserializeObject<DrugWinAppDto>(data.Data.SerializedData);

//            if (dataIsConvertBeforeId > 0)
//            {
//                return await DrugUpdate(deSerializedData, dataIsConvertBeforeId);
//            }
//            else
//            {
//                return await DrugNew(deSerializedData, currentUserId);
//            }
//        }
//        public async Task<string> DrugNew(DrugWinAppDto data, int currentUserId)
//        {
//            var prescription = await _dataTransferConvert.GetAll().Where(n => n.TableId == data.PrescriptionId && n.TableName == TablesWinAppEnum.Prescription.ToString() && n.UserId == currentUserId /*_workContextService.UserId*/).ToListAsync();

//            if (!int.TryParse(prescription.LastOrDefault()?.TargetTableId, out int prescriptionId))
//            {
//                return "Prescription Not Found";
//            }

//            //--------------------------------- add drug 
//            var temp = new PrescriptionDetailDrug
//            {
//                PrescriptionId = prescriptionId
//            };

//            ModelToDrug(data, temp);
//            _prescriptionDetailDrugRepository.Add(temp);
//            await _unitOfWork.Save();

//            await DataTransferConvertAdd(data.Id.ToString(), TablesWinAppEnum.Drug.ToString(), (int)temp.Id, currentUserId);
//            await _unitOfWork.Save();

//            return "Add Drug Success";

//        }
//        public async Task<string> DrugUpdate(DrugWinAppDto data, long id)
//        {
//            var temp = await _prescriptionDetailDrugRepository.GetAll()
//                .Where(n => n.Id == id)
//                .FirstOrDefaultAsync();

//            if (temp == null)
//            {
//                return "Drug Not Found";
//            }

//            ModelToDrug(data, temp);

//            _prescriptionDetailDrugRepository.Update(temp);
//            await _unitOfWork.Save();

//            return "Update Drug Success";
//        }

//        //============================================================================== VitalSign 
//        private async Task<string> VitalSignUpsert(SyncDto data, long dataIsConvertBeforeId, int currentUserId)
//        {
//            var deSerializedData = JsonConvert.DeserializeObject<VitalSignWinAppDto>(data.Data.SerializedData);

//            if (dataIsConvertBeforeId > 0)
//            {
//                return await VitalSignUpdate(deSerializedData, dataIsConvertBeforeId);
//            }
//            else
//            {
//                return await VitalSignNew(deSerializedData, currentUserId);
//            }
//        }
//        public async Task<string> VitalSignNew(VitalSignWinAppDto data, int currentUserId)
//        {
//            long prescriptionId = 0;
//            var prescription = await _prescriptionRepository.GetAll().FirstOrDefaultAsync(n => n.PrescriptionDate == data.Date);

//            if (prescription == null)
//            {
//                var prescriptionNew = await PrescriptionsNew(new PrescriptionWinAppDto
//                {
//                    Id = $"CreatForVitalSing:{data.Id}",
//                    PatientId = data.PatientId,
//                    DoctorId = data.DoctorId,
//                    Notes = data.Notes,
//                    Date = data.Date
//                }, currentUserId);

//                prescriptionId = prescriptionNew.id;
//            }
//            else
//            {
//                prescriptionId = prescription.Id;
//            }

//            if (prescriptionId == 0)
//            {
//                return "Prescription Not Found";
//            }
//            //--------------------------------- Get Service
//            List<PrescriptionServiceResult> listAdd = await ModelToVitalSign(data, prescriptionId);

//            _prescriptionServiceResultRepository.AddRange(listAdd);

//            await DataTransferConvertAdd(data.Id, TablesWinAppEnum.VitalSign.ToString(), (int)prescriptionId, currentUserId);
//            await _unitOfWork.Save();

//            return "Add Vital singn Success";
//        }

//        public async Task<string> VitalSignUpdate(VitalSignWinAppDto data, long id)// this id = prescriptionId
//        {
//            var removeList = await _prescriptionServiceResultRepository.GetAll()
//                .Where(n => n.PrescriptionId == id && interNationalCodeVital.Contains(n.ServiceId.ToString()))
//                .ToListAsync();

//            // حذف رکوردهای قبلی ویتال
//            _prescriptionServiceResultRepository.RemoveRange(removeList);
//            // دریافت سرویس های جدید ویتال
//            List<PrescriptionServiceResult> listAdd = await ModelToVitalSign(data, id);
//            // await _prescriptionServiceResultRepository.AddRangeAsync(listAdd);
//            _prescriptionServiceResultRepository.AddRange(listAdd);
//            await _unitOfWork.Save();

//            return "Update Vital singn Success";
//        }

//        //============================================================================== PatientHistory 
//        private async Task<string> PatientHistoryUpsert(SyncDto data, long dataIsConvertBeforeId, int currentUserId)
//        {
//            var deSerializedData = JsonConvert.DeserializeObject<PatientHistoryWinAppDto>(data.Data.SerializedData);

//            if (dataIsConvertBeforeId > 0)
//            {
//                return await PatientHistoryUpdate(deSerializedData, dataIsConvertBeforeId);
//            }
//            else
//            {
//                return await PatientHistoryNew(deSerializedData, currentUserId);
//            }
//        }
//        public async Task<string> PatientHistoryNew(PatientHistoryWinAppDto data, int currentUserId)
//        {
//            long prescriptionId = 0;
//            var prescription = await _prescriptionRepository.GetAll().FirstOrDefaultAsync(n => n.PrescriptionDate == data.Date);

//            if (prescription == null)
//            {
//                var prescriptionNew = await PrescriptionsNew(new PrescriptionWinAppDto
//                {
//                    Id = $"CreatForPatientHistory:{data.Id}",
//                    PatientId = data.PatientId,
//                    DoctorId = data.DoctorId,
//                    Date = data.Date,
//                    Notes = ""
//                }, currentUserId);

//                prescriptionId = prescriptionNew.id;
//            }
//            else
//            {
//                prescriptionId = prescription.Id;
//            }

//            if (prescriptionId == 0)
//            {
//                return "Prescription Not Found";
//            }

//            //--------------------------------- Get Service
//            List<PrescriptionServiceResult> listAdd = await ModelToPatientHistory(data, prescriptionId);
//            //   await _prescriptionServiceResultRepository.AddRangeAsync(listAdd);
//            _prescriptionServiceResultRepository.AddRange(listAdd);

//            await DataTransferConvertAdd(data.Id, TablesWinAppEnum.PatientHistory.ToString(), (int)prescriptionId, currentUserId);
//            await _unitOfWork.Save();

//            return "Add Patient History Success";
//        }
//        public async Task<string> PatientHistoryUpdate(PatientHistoryWinAppDto data, long id)// this id = prescriptionId
//        {

//            var removeList = await _prescriptionServiceResultRepository.GetAll()
//                .Where(n => n.PrescriptionId == id && interNationalCodeHistory.Contains(n.ServiceId.ToString()))
//                .ToListAsync();

//            // حذف رکوردهای قبلی ویتال
//            _prescriptionServiceResultRepository.RemoveRange(removeList);
//            // دریافت سرویس های جدید ویتال
//            List<PrescriptionServiceResult> listAdd = await ModelToPatientHistory(data, id);

//            _prescriptionServiceResultRepository.AddRange(listAdd);
//            await _unitOfWork.Save();

//            return "Update Patient History Success";
//        }

//        //============================================================================== Radiology 
//        private async Task<string> RadiologyUpsert(SyncDto data, long dataIsConvertBeforeId, int currentUserId)
//        {
//            var deSerializedData = JsonConvert.DeserializeObject<RadiologyWinAppDto>(data.Data.SerializedData);

//            if (dataIsConvertBeforeId > 0)
//            {
//                return await RadiologyUpdate(deSerializedData, dataIsConvertBeforeId);
//            }
//            else
//            {
//                return await RadiologyNew(deSerializedData, currentUserId);
//            }
//        }
//        public async Task<string> RadiologyNew(RadiologyWinAppDto data, int currentUserId)
//        {
//            long prescriptionId = 0;
//            var prescription = await _prescriptionRepository.GetAll().FirstOrDefaultAsync(n => n.PrescriptionDate == data.Date);

//            if (prescription == null)
//            {
//                var prescriptionNew = await PrescriptionsNew(new PrescriptionWinAppDto
//                {
//                    Id = $"CreatForRadiology:{data.Id}",
//                    PatientId = data.PatientId,
//                    Date = data.Date ?? DateTime.Now,
//                    DoctorId = data.DoctorId,
//                    Notes = ""
//                }, currentUserId);

//                prescriptionId = prescriptionNew.id;
//            }
//            else
//            {
//                prescriptionId = prescription.Id;
//            }

//            if (prescriptionId == 0)
//            {
//                return "Prescription Not Found";
//            }

//            var service = await _servicesRepository.GetAll().Where(n => n.LocalCode == "rad").FirstOrDefaultAsync();

//            var temp = new PrescriptionDetailService
//            {
//                PrescriptionId = prescriptionId,
//                ServiceId = service.Id
//            };

//            var note = "";
//            if (!string.IsNullOrEmpty(data.Type))
//            {
//                note += $"\"Name\":\"{data.Type}\",";
//            }
//            if (!string.IsNullOrEmpty(data.Report))
//            {
//                note += $"\"Note\":\"{data.Report}\",";
//            }
//            if (!string.IsNullOrEmpty(note))
//            {
//                note = $"{{{note.Trim(',')}}}";
//            }

//            if (note == null)
//            {
//                return "Radiology data was Empty";
//            }

//            temp.Note = note;

//            _prescriptionDetailService.Add(temp);

//            await DataTransferConvertAdd(data.Id, TablesWinAppEnum.Radiology.ToString(), (int)prescriptionId, currentUserId);
//            await _unitOfWork.Save();

//            return "Add Radiology Success";
//        }
//        public async Task<string> RadiologyUpdate(RadiologyWinAppDto data, long id)// this id = prescriptionId
//        {

//            var temp = await _prescriptionDetailService.GetAll()
//                .Where(n => n.PrescriptionId == id)
//                .FirstOrDefaultAsync();

//            temp.Note = "";
//            if (!string.IsNullOrEmpty(data.Type))
//            {
//                temp.Note += $"\"Name\":\"{data.Type}\",";
//            }
//            if (!string.IsNullOrEmpty(data.Report))
//            {
//                temp.Note += $"\"Note\":\"{data.Report}\",";
//            }
//            if (!string.IsNullOrEmpty(temp.Note))
//            {
//                temp.Note = $"{{{temp.Note.Trim(',')}}}";
//            }

//            if (temp == null)
//            {
//                return "Radiology data was Empty";
//            }

//            _prescriptionDetailService.Update(temp);
//            await _unitOfWork.Save();

//            return "Update Radiology Success";
//        }

//        #region mapModel

//        private void ModelToPerson(DoctorWinAppDto data, Person person)
//        {
//            var names = ((data.ArName) ?? "").Split(' ');
//            person.LatinName = data.Enname;
//            person.FirstName = GetName(names, 0);
//            person.FatherName = GetName(names, 1);
//            person.GrandFatherName = GetName(names, 2);
//            person.LastName = GetName(names, 3);
//            person.Address = data.Address;
//            person.Phone = data.Phone;
//            person.Email = data.Email;
//            person.Note = data.Enspecialty;
//        }

//        private async Task ModelToPerson(PatientWinAppDto data, Person person)
//        {
//            // MaritalStatus maritalStatusId = await MaritalStatusGet(data);
//            BaseValue maritalStatusId = await MaritalStatusGet(data);
//            // Sex sexId = await SexGet(data);
//            BaseValue sexId = await SexGet(data);
//            var names = (data.Name ?? "").Split(' ');

//            person.Phone = data.Phone;
//            person.FirstName = GetName(names, 0);
//            person.FatherName = GetName(names, 1);
//            person.GrandFatherName = GetName(names, 2);
//            person.LastName = GetName(names, 3);
//            person.Address = data.Address;
//            person.BirthDate = data.Birthday;
//            //  person.MaritalStatusId = maritalStatusId?.Id;
//            person.MaritalBaseId = maritalStatusId?.Id;
//            // person.SexId = sexId?.Id;
//            person.SexBaseId = sexId?.Id;
//        }

//        private string GetName(string[] names, int index)
//        {
//            if (names == null || names.Count() <= index)
//            {
//                return "";
//            }

//            if (index == 3)
//            {
//                var name = "";
//                for (int i = 3; i < names.Count(); i++)
//                {
//                    name += $" {names[i]}";
//                }

//                return name;
//            }

//            return names[index];
//        }

//        private void ModelToPatient(PatientWinAppDto data, Patient patient)
//        {
//            int.TryParse(data.NHS_Number, out int nhsNo);

//            // patient.HISNo = nhsNo;
//            patient.Hisno = nhsNo;
//        }

//        private async Task ModelToPatientExtraInfo(PatientWinAppDto data, PatientExtraInfo person)
//        {
//            if (person == null)
//            {
//                return;
//            }
//            //TODO json Format ???
//            //  BloodGroup bloodId = await BloodGet(data);
//            BaseValue bloodId = await BloodGet(data);
//            Rh rhId = await RhGet(data);

//            person.Note = "";
//            if (!string.IsNullOrEmpty(data.chronic))
//            {
//                person.Note += $"\"Chronic\": \"{data.chronic}\",";
//            }
//            if (!string.IsNullOrEmpty(data.note))
//            {
//                person.Note += $"\"Note\": \"{data.note}\",";
//            }
//            if (!string.IsNullOrEmpty(data.Allergy))
//            {
//                person.Note += $"\"Allergy\": \"{data.Allergy}\",";
//            }
//            if (!string.IsNullOrEmpty(data.Work))
//            {
//                person.Note += $"\"Work\": \"{data.Work}\",";
//            }
//            if (!string.IsNullOrEmpty(person.Note))
//            {
//                person.Note = $"{{{person.Note.Trim(',')}}}";
//            }


//            person.RhId = rhId?.Id;
//            person.BloodGroupId = bloodId?.Id;
//            person.IsDrinking = data.Drinking;
//            person.IsSmoking = data.Smoking;
//        }

//        private async Task ModelToDoctor(DoctorWinAppDto data, MedicalStaff doctor)
//        {
//            doctor.Note = "";
//            //  doctor.CostVisit = (decimal)data.Visitfee;

//            if (!string.IsNullOrEmpty(data.Enspecialty))
//            {
//                doctor.Note += $"\"Enspecialty\":\"{data.Enspecialty}\",";
//            }

//            if (doctor.Note != "")
//            {
//                doctor.Note = $"{{{doctor.Note.Trim(',')}}}";
//            }
//            if (!string.IsNullOrEmpty(data.Encertificates_1))
//            {
//                doctor.Note += $"\"Encertificates_1\":\"{data.Encertificates_1}\",";
//            }
//            if (!string.IsNullOrEmpty(data.Encertificates_2))
//            {
//                doctor.Note += $"\"Encertificates_2\":\"{data.Encertificates_2}\",";
//            }
//            if (!string.IsNullOrEmpty(data.Encertificates_3))
//            {
//                doctor.Note += $"\"Encertificates_3\":\"{data.Encertificates_3}\",";
//            }
//            if (!string.IsNullOrEmpty(data.Arcertificates_1))
//            {
//                doctor.Note += $"\"Arcertificates_1\":\"{data.Arcertificates_1}\",";
//            }
//            if (!string.IsNullOrEmpty(data.Arcertificates_2))
//            {
//                doctor.Note += $"\"Arcertificates_2\":\"{data.Arcertificates_2}\",";
//            }
//            if (!string.IsNullOrEmpty(data.Arcertificates_3))
//            {
//                doctor.Note += $"\"Arcertificates_3\":\"{data.Arcertificates_3}\",";
//            }

//            if (doctor.Id > 0)// زمان ویرایش ، سرتفیکیت های قبلی حذف میشوند 
//            {
//                var doctorCertificates = await _doctorCertificate.GetAll().Where(n => n.MedicalStaffId == doctor.Id).ToListAsync();
//                _doctorCertificate.RemoveRange(doctorCertificates);
//            }

//            doctor.MedicalStaffCertificates = new List<MedicalStaffCertificate>();

//            var cer1 = await AddCertificate(data.Arcertificates_1, data.Encertificates_1);
//            if (cer1 != null)
//            {
//                AddCertificateToDoctor(doctor, (int)cer1, data.Arcertificates_1, data.Encertificates_1);
//            }

//            var cer2 = await AddCertificate(data.Arcertificates_2, data.Encertificates_2);
//            if (cer2 != null)
//            {
//                AddCertificateToDoctor(doctor, (int)cer2, data.Arcertificates_2, data.Encertificates_2);
//            }

//            var cer3 = await AddCertificate(data.Arcertificates_3, data.Encertificates_3);
//            if (cer3 != null)
//            {
//                AddCertificateToDoctor(doctor, (int)cer3, data.Arcertificates_3, data.Encertificates_3);
//            }
//        }

//        private static void AddCertificateToDoctor(MedicalStaff doctor, int id, string ar, string en)
//        {
//            if (id == 0)
//            {
//                doctor.MedicalStaffCertificates.Add(
//                        new MedicalStaffCertificate
//                        {
//                            Certificate = new Certificate
//                            {
//                                Title = ar,
//                                TitleLang2 = en,
//                                IsActive = true
//                            }
//                        });
//            }
//            else
//            {
//                doctor.MedicalStaffCertificates.Add(
//                       new MedicalStaffCertificate
//                       {
//                           CertificateId = id
//                       });
//            }
//        }

//        private async Task<int?> AddCertificate(string ar, string en)
//        {
//            if (!string.IsNullOrEmpty(ar) || !string.IsNullOrEmpty(en))
//            {
//                var cer = await _certificate.GetAll().Where(n => n.Title == ar || n.TitleLang2 == en).FirstOrDefaultAsync();
//                if (cer == null)
//                {
//                    return 0;
//                }

//                return cer.Id;
//            }

//            return null;
//        }

//        private static void ModelToDrug(DrugWinAppDto data, PrescriptionDetailDrug temp)
//        {
//            temp.Note = "";
//            if (!string.IsNullOrEmpty(data.Name))
//            {
//                temp.Note = $"\"DrugName\":\"{data.Name}\",";
//            }
//            if (!string.IsNullOrEmpty(data.Details))
//            {
//                temp.Note += $"\"Details\":\"{data.Details}\",";
//            }
//            if (!string.IsNullOrEmpty(data.Notes))
//            {
//                temp.Note += $"\"Notes\":\"{data.Notes}\",";
//            }
//            if (!string.IsNullOrEmpty(data.Meal))
//            {
//                temp.Note += $"\"Meal\":\"{data.Meal}\",";
//            }

//            if (!string.IsNullOrEmpty(temp.Note))
//            {
//                temp.Note = $"{{{temp.Note.TrimEnd(',')}}}";
//            }
//        }

//        private async Task<List<PrescriptionServiceResult>> ModelToVitalSign(VitalSignWinAppDto data, long prescriptionId)
//        {
//            var services = await _servicesRepository.GetAll()
//                .Where(n => interNationalCodeVital.Contains(n.InterNationalCode))
//                .Select(n => new
//                {
//                    n.Id,
//                    n.InterNationalCode
//                }).ToListAsync();

//            //--------------------------------- add VitalSign 
//            var bp = data.BP.Split('/');
//            var listAdd = new List<PrescriptionServiceResult>();
//            foreach (var item in interNationalCodeVital)
//            {
//                var result = "";
//                switch (item)
//                {
//                    case "271649006": result = bp[0]; break;
//                    case "271650006": result = bp.Length > 1 ? bp[1] : ""; break;
//                    case "60621009": result = data.BMI; break;
//                    case "78564009": result = data.PR; break;
//                    case "27113001": result = data.WT; break;
//                    case "50373000": result = data.HT; break;
//                    case "737105002": result = data.GFR; break;
//                    case "251075007": result = data.Mean; break;
//                    case "431314004": result = data.SPO; break;
//                    case "251872006": result = data.Creatinine; break;
//                    case "103579009": result = data.SkinRace; break;
//                        //case "33962009": result = data.cc; break;
//                        //case "422625006": result = data.phi; break;
//                        //case "417662000": result = data.pmh; break;
//                        //case "161615003": result = data.PSH; break;
//                        //case "254292007": result = data.CancerStage; break;
//                        //case "371441004": result = data.Cancer Type; break;
//                        //case "86290005": result = data.rr; break;
//                }

//                if (string.IsNullOrEmpty(result))
//                {
//                    continue;
//                }

//                var _serviceId = services.FirstOrDefault(n => n.InterNationalCode == item)?.Id;
//                if (_serviceId != null)
//                {
//                    listAdd.Add(new PrescriptionServiceResult { PrescriptionId = prescriptionId, CreateDate = data.Date, Result = result, ServiceId = _serviceId });
//                }
//            }

//            var note = "";
//            if (!string.IsNullOrEmpty(data.Notes))
//            {
//                note += $"\"Notes\":\"{data.Notes}\",";
//            }
//            if (!string.IsNullOrEmpty(note))
//            {
//                listAdd.Add(new PrescriptionServiceResult { PrescriptionId = prescriptionId, CreateDate = data.Date, Result2 = $"{{{note.TrimEnd(',')}}}", ServiceId = 9328 });
//            }
//            return listAdd;
//        }

//        private async Task<List<PrescriptionServiceResult>> ModelToPatientHistory(PatientHistoryWinAppDto data, long prescriptionId)
//        {
//            var services = await _servicesRepository.GetAll()
//                .Where(n => interNationalCodeHistory.Contains(n.InterNationalCode))
//                .Select(n => new
//                {
//                    n.Id,
//                    n.InterNationalCode
//                }).ToListAsync();

//            var listAdd = new List<PrescriptionServiceResult>();
//            foreach (var item in interNationalCodeHistory)
//            {
//                var result = "";
//                switch (item)
//                {
//                    case "33962009": result = data.CC; break;
//                    case "422625006": result = data.PHI; break;
//                    case "417662000": result = data.PMH; break;
//                    case "161615003": result = data.PSH; break;
//                    case "254292007": result = data.CancerStage; break;
//                    case "371441004": result = data.CancerType; break;
//                    case "86290005": result = data.RR; break;
//                }

//                if (string.IsNullOrEmpty(result))
//                {
//                    continue;
//                }

//                var _serviceId = services.FirstOrDefault(n => n.InterNationalCode == item)?.Id;
//                if (_serviceId != null)
//                {
//                    listAdd.Add(new PrescriptionServiceResult { PrescriptionId = prescriptionId, CreateDate = data.Date, Result = result, ServiceId = _serviceId });
//                }
//            }

//            var note = "";
//            if (!string.IsNullOrEmpty(data.Note))
//            {
//                note += $"\"Note\":\"{data.Note}\",";
//            }
//            if (!string.IsNullOrEmpty(data.II))
//            {
//                note += $"\"ii\":\"{data.II}\",";
//            }
//            if (!string.IsNullOrEmpty(data.POM))
//            {
//                note += $"\"POM\":\"{data.POM}\",";
//            }
//            if (!string.IsNullOrEmpty(note))
//            {
//                listAdd.Add(new PrescriptionServiceResult { PrescriptionId = prescriptionId, CreateDate = data.Date, Result2 = $"{{{note.TrimEnd(',')}}}", ServiceId = 9328 });
//            }

//            return listAdd;
//        }

//        private async Task<int> GetDoctorId(string doctorId)
//        {
//            var doctor = await _dataTransferConvert.GetAll().FirstOrDefaultAsync(n => n.TableId == doctorId && n.TableName == TablesWinAppEnum.Doctor.ToString());

//            int.TryParse(doctor?.TargetTableId, out int id);

//            return id;

//        }

//        public async Task LogData(string tableId, string tableName, bool isOk, string message)
//        {
//            //var convert = await _dataTransferConvert
//            //    .Where(n => n.TableId == tableId && n.TableName == tableName && n.UserId == _workContextService.UserId)
//            //    .FirstOrDefaultAsync();

//            //if (convert != null)
//            //{
//            //    convert.IsSyncOk = isOk;
//            //    convert.SyncMessage = message;

//            //    _dataTransferConvert.Update(convert);

//            //    await _unitOfWork.SaveChangesAsync();
//            //}
//        }

//        private async Task<SMSManagment.Models.SMSPortalDataDto> SyncDataSms(string name)
//        {
//            var result = await _requestService.Request<SMSManagment.Models.SMSPortalDto>(new OutRequestDto
//            {
//                ApiUrl = $"{_subSystemUrls.Value.SmsUrl}/api/User",
//                RequestType = OutRequestTypeEnum.Post,
//                Parameters = new
//                {
//                    Name = name
//                }
//            }, _subSystemUrls.Value.SmsToken);

//            return result.Data;
//        }


//        public async Task<int> GetCurrentUserId(string syncUserId)
//        {
//            var datatransfer = await _dataTransferConvert.GetAll().FirstOrDefaultAsync(n => n.TableId == syncUserId);

//            if (datatransfer != null)
//            {
//                return 0;
//            }

//            int.TryParse(datatransfer.TargetTableId, out int userid);
//            var user = await _doctorRepository.GetAll()
//                .Include(p => p.Person.Users)
//                .FirstOrDefaultAsync(n => n.Id == userid);

//            return user.Id;
//        }


//        public async Task<BaseResponseDto> SmsInfoAsync()
//        {
//            var user = await _userRepository.GetAll()
//                .FirstOrDefaultAsync(n => n.Id == _workContextService.UserId.GetValueOrDefault());

//            if (user == null)
//            {
//                return new ListResponseDto
//                {
//                    Status = ResponseStatus.Fail,
//                    Message = "User Not Found"
//                };
//            }

//            if (string.IsNullOrEmpty(user.SmsToken))
//            {
//                var smsResult = await SyncDataSms(user.UserName);

//                if (smsResult.Id > 0)
//                {
//                    user.SmsToken = smsResult.Token;
//                    user.SmsUserId = smsResult.Id;

//                    _userRepository.Update(user);
//                    await _unitOfWork.Save();
//                }

//                return new ListResponseDto
//                {
//                    Status = ResponseStatus.Success,
//                    Data = new
//                    {
//                        SmsId = smsResult.Id,
//                        SmsToken = smsResult.Token
//                    }
//                };
//            }

//            return new ListResponseDto
//            {
//                Status = ResponseStatus.Success,
//                Data = new
//                {
//                    SmsId = user.SmsUserId,
//                    SmsToken = user.SmsToken
//                }
//            };
//        }
//        #endregion

//    }
//}
