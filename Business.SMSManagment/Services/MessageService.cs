//using Business.SMSManagment.Extensions;
//using Business.SMSManagment.IServices;
//using Business.SMSManagment.Models;
//using DataAccess.Entities.His.Entities;
//using DataAccess.Repositories.His;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Localization;
//using Microsoft.Extensions.Options;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Business.SMSManagment.Services
//{
//    public class MessageService : IMessageService
//    {
//        private readonly IUnitOfWork _unitOfWork;
//        private readonly IOutRequestService _requestService;
//        private readonly IOptions<SubSystemUrls> _subSystemUrls;
//        private readonly IBuyMessageRepository _buyMessage;
//        private readonly IGiftReasonRepository _giftReason;
//        private readonly IMedicalCenterRepository _center;
//        private readonly IMedicalStaffRepository _doctor;
//        private readonly IUserRepository _user;
//        private readonly IStringLocalizer<SharedResource> _sharedLocalizer;

//        public MessageService(IUnitOfWork unitOfWork,
//            IOutRequestService requestService,
//            IOptions<SubSystemUrls> subSystemUrls,
//            IStringLocalizer<SharedResource> sharedLocalizer,
//            IBuyMessageRepository buyMessage,
//            IGiftReasonRepository giftReason,
//            IMedicalCenterRepository center,
//            IMedicalStaffRepository doctor,
//            IUserRepository user

//            )
//        {
//            _unitOfWork = unitOfWork;
//            _requestService = requestService;
//            _subSystemUrls = subSystemUrls;
//            _sharedLocalizer = sharedLocalizer;

//            _buyMessage = buyMessage;
//            _buyMessage.UnitOfWork = unitOfWork;

//            _giftReason = giftReason;
//            _giftReason.UnitOfWork = unitOfWork;

//            _center = center;
//            _center.UnitOfWork = unitOfWork;

//            _doctor = doctor;
//            _doctor.UnitOfWork = unitOfWork;

//            _user = user;
//            _user.UnitOfWork = unitOfWork;


//        }


//        public async Task<BaseResponseDto> GetById(int id)
//        {
//            var result = await _buyMessage.GetAll().Where(d => d.Id == id).FirstOrDefaultAsync();

//            return new BaseResponseDto
//            {
//                Status = ResponseStatus.Success,
//                Data = result
//            };
//        }

//        public async Task<BaseResponseDto> Add(MessageDto dtos)
//        {
//            var resultValid = CheckValidate.Valid(new SmsCenterValidation(_sharedLocalizer), dtos);
//            if (resultValid.Status == ResponseStatus.NotValid) return resultValid;
//            var user = new User();
//            if (dtos.DoctorId > 0)
//            {
//                user = await _doctor.GetAll()
//               .Include(d => d.Person.Users)
//               .Where(n => n.Id == dtos.DoctorId)
//               .Select(s => s.Person.Users.FirstOrDefault())
//               .FirstOrDefaultAsync();
//            }
//            else
//            {
//                user = await _center.GetAll()
//                //.Include(d => d.Sections)
//                //.Include(d => d.UserRolePermissions)
//                //.Include(d => d.User)
//                .Where(n => n.Id == dtos.CenterId)
//                .Select(s => s.CenterStaffs.FirstOrDefault().MedicalStaff.FirstOrDefault().User)
//                .FirstOrDefaultAsync();
//            }

//            if (user == null || user.Id == 0)
//            {
//                return new BaseResponseDto
//                {
//                    Message = _sharedLocalizer["Center.Response.UserNotRegister"],
//                    Status = ResponseStatus.Fail
//                };
//            }

//            if (string.IsNullOrEmpty(user.SmsToken))
//            {
//                var addsmsUser = await _requestService.Request<SMSPortalDto>(new OutRequestDto
//                {
//                    ApiUrl = $"{_subSystemUrls.Value.SmsUrl}/api/User",
//                    RequestType = OutRequestTypeEnum.Post,
//                    Parameters = new
//                    {
//                        Name = user.SmsToken
//                    }
//                }, _subSystemUrls.Value.SmsToken);

//                if (addsmsUser.Data != null && addsmsUser.Data.Id > 0)
//                {
//                    user.SmsToken = addsmsUser.Data.Token;
//                    user.SmsUserId = addsmsUser.Data.Id;

//                    await _unitOfWork.Save();
//                }
//                else
//                {
//                    return new BaseResponseDto
//                    {
//                        Message = _sharedLocalizer["Center.Response.UserSmsRegisterFaild"],
//                        Status = ResponseStatus.Fail
//                    };
//                }
//            }

//            var result = await _requestService.Request<SMSPortalDto>(new OutRequestDto
//            {
//                ApiUrl = $"{_subSystemUrls.Value.SmsUrl}/api/Balance/BalanceRecharge",
//                RequestType = OutRequestTypeEnum.Post,
//                Parameters = new
//                {
//                    UserId = user.SmsUserId,
//                    Amount = dtos.Cost,
//                    SmsGiftReasonId = dtos.GiftReasonId,
//                    SmsGiftReason = dtos.GiftReasonTitle
//                }
//            }, _subSystemUrls.Value.SmsToken);


//            return new BaseResponseDto
//            {
//                Message = result.Message,
//                Errors = result.Errors,
//                Status = result.Status == 2 ? ResponseStatus.Success : ResponseStatus.Fail
//            };
//        }

//        public async Task<BaseResponseDto> Add_old(MessageDto dtos)
//        {
//            var resultValid = CheckValidate.Valid(new SmsCenterValidation(_sharedLocalizer), dtos);
//            if (resultValid.Status == ResponseStatus.NotValid) return resultValid;

//            var isExsistMessage = await _giftReason.GetAll().FirstOrDefaultAsync(n => n.Title == dtos.GiftReasonTitle.Trim());

//            if (isExsistMessage == null)
//            {
//                isExsistMessage = new GiftReason
//                {
//                    Title = dtos.GiftReasonTitle.Trim()
//                };

//                _giftReason.Add(isExsistMessage);
//            }

//            await _buyMessage.AddRange(new BuyMessage
//            {
//                CenterId = dtos.CenterId,
//                Cost = dtos.Cost,
//                CreateDate = DateTime.Now,
//                GitReason = isExsistMessage
//            });

//            await _unitOfWork.Save();

//            return new BaseResponseDto
//            {
//                Message = _sharedLocalizer["Center.Response.AddBuyMessageSuccess"],
//                Status = ResponseStatus.Success
//            };
//        }

//        public async Task<ListResponseDto> TransactionSearch(MessageFilterDto filterDto)
//        {
//            int? userid = null;
//            if (filterDto.CenterId > 0)
//            {
//                if (filterDto.CenterTypeId == (int)CenterTypeEnum.DoctorOffice)
//                {
//                    var doctor = await _doctor.GetAll().Include(n => n.Person.Users)
//                        .FirstOrDefaultAsync(n => n.Id == filterDto.CenterId);

//                    userid = doctor.Person.Users.FirstOrDefault()?.SmsUserId;
//                }
//                else
//                {
//                    var center = await _center.GetAll()
//                        .Include(c => c.CenterType)
//                        // .Include(d => d.Sections)
//                        .ThenInclude(d => d.UserRolePermissions)
//                        .ThenInclude(d => d.User)
//                        .FirstOrDefaultAsync(n => n.Id == filterDto.CenterId);

//                    userid = center.Sections.FirstOrDefault()?.UserRolePermissions.FirstOrDefault()?.User?.SmsUserId;
//                }
//            }

//            var result = await _requestService.Request<TransactionVM>(new OutRequestDto
//            {
//                ApiUrl = $"{_subSystemUrls.Value.SmsUrl}/api/Transaction/Search",
//                RequestType = OutRequestTypeEnum.Post,
//                Parameters = new
//                {
//                    PageNumber = filterDto.PageNumber,
//                    PageSize = filterDto.PageSize,
//                    UserId = userid
//                }
//            }, _subSystemUrls.Value.SmsToken);

//            var userList = result.Data.Where(n => n.UserId != null).Select(s => s.UserId).ToList();

//            var centerList = await _user.GetAll()
//                    .Include(p => p.Person)
//                    .Include(d => d.UserRolePermissions)
//                    .ThenInclude(d => d.Section.Center.CenterType)
//                    .Where(n => userList.Contains(n.SmsUserId ?? 0))
//                    //.Select(s=>s.UserRolePermission.FirstOrDefault().Section.Center)
//                    .ToListAsync();

//            return new ListResponseDto
//            {
//                Status = ResponseStatus.Success,
//                Data = result.Data.Select(s => new
//                {
//                    Id = s.UserId ?? 0,
//                    Amount = s.Amount ?? 0,
//                    s.TransactionDate,
//                    s.Status,
//                    s.SmsGiftReason,
//                    CenterTitle = centerList.FirstOrDefault(c => c.SmsUserId == s.UserId)?.Person.FullName,
//                    CenterTypeTitle = GetCenterTypeTitle(centerList, s.UserId)
//                }),
//                Count = result.Count
//            };
//        }

//        private string GetCenterTypeTitle(List<User> centerList, int? userid)
//        {
//            var center = centerList.FirstOrDefault(c => c.SmsUserId == userid);
//            var name = center?.Person.FullName;
//            var type = center?.UserRolePermissions.FirstOrDefault()?.Section?.Center?.CenterType.Title;

//            return !string.IsNullOrEmpty(type) ? type : (string.IsNullOrWhiteSpace(name) ? "" : "Doctor");
//        }
//        public async Task<ListResponseDto> Search(MessageFilterDto filterDto)
//        {
//            int? userid = null;
//            if (filterDto.CenterId > 0)
//            {
//                if (filterDto.CenterTypeId == (int)CenterTypeEnum.DoctorOffice)
//                {
//                    var doctor = await _doctor.GetAll().Include(n => n.Person.Users)
//                        .FirstOrDefaultAsync(n => n.Id == filterDto.CenterId);

//                    userid = doctor.Person.Users.FirstOrDefault()?.SmsUserId;
//                }
//                else
//                {
//                    var center = await _center.GetAll()
//                    .Include(c => c.CenterType)
//                    // .Include(d => d.Sections)
//                    .ThenInclude(d => d.UserRolePermissions)
//                    .ThenInclude(d => d.User)
//                    .FirstOrDefaultAsync(n => n.Id == filterDto.CenterId);

//                    userid = center.Sections.FirstOrDefault()?.UserRolePermissions.FirstOrDefault()?.User?.SmsUserId;
//                }
//            }

//            var result = await _requestService.Request<ListTransactionVM>(new OutRequestDto
//            {
//                ApiUrl = $"{_subSystemUrls.Value.SmsUrl}/api/User/ListTransaction",
//                RequestType = OutRequestTypeEnum.Post,
//                Parameters = new
//                {
//                    PageNumber = filterDto.PageNumber,
//                    PageSize = filterDto.PageSize,
//                    UserId = userid
//                }
//            }, _subSystemUrls.Value.SmsToken);

//            var userList = result.Data.Select(s => s.Id).ToList();

//            var centerList = await _user.GetAll()
//                    .Include(p => p.Person)
//                    .Include(d => d.UserRolePermissions)
//                    .ThenInclude(d => d.Section.Center.CenterType)
//                    .Where(n => userList.Contains(n.SmsUserId ?? 0))
//                    //.Select(s=>s.UserRolePermission.FirstOrDefault().Section.Center)
//                    .ToListAsync();

//            return new ListResponseDto
//            {
//                Status = ResponseStatus.Success,
//                Data = result.Data.Select(s => new
//                {
//                    s.Id,
//                    s.Remaining,
//                    s.TotalSend,
//                    s.TotalPaymented,
//                    s.TotalGift,
//                    CenterTitle = centerList.FirstOrDefault(c => c.SmsUserId == s.Id)?.Person.FullName,
//                    CenterTypeTitle = GetCenterTypeTitle(centerList, s.Id)
//                }),
//                Count = result.Count
//            };
//        }
//        public async Task<ListResponseDto> LogMessageSearch(LogMessageFilterDto filterDto)
//        {
//            var result = await _requestService.Request<LogMessageSearchDto>(new OutRequestDto
//            {
//                ApiUrl = $"{_subSystemUrls.Value.SmsUrl}/api/LogMessage/CurrentUser",
//                RequestType = OutRequestTypeEnum.Post,
//                Parameters = new
//                {
//                    PageNumber = filterDto.PageNumber,
//                    PageSize = filterDto.PageSize,
//                    Id = filterDto.Id
//                }
//            }, _subSystemUrls.Value.SmsToken);

//            return new ListResponseDto
//            {
//                Status = ResponseStatus.Success,
//                Data = result.Data,
//                Count = result.Count
//            };
//        }

//        public async Task<BaseResponseDto> General(string pageName)
//        {

//            var result = await _requestService.Request<GeneralInfoDto>(new OutRequestDto
//            {
//                ApiUrl = $"{_subSystemUrls.Value.SmsUrl}/api/General?pageName={pageName}",
//                RequestType = OutRequestTypeEnum.Get
//            }, _subSystemUrls.Value.SmsToken);

//            return new BaseResponseDto
//            {
//                Data = result.Data,
//                Message = result.Message,
//                Status = result.Status == 2 ? ResponseStatus.Success : ResponseStatus.Fail
//            };
//        }

//        public async Task<BaseResponseDto> BalanceMax()
//        {

//            var result = await _requestService.Request<SMSBalanceMaxDto>(new OutRequestDto
//            {
//                ApiUrl = $"{_subSystemUrls.Value.SmsUrl}/api/Balance/BalanceMax",
//                RequestType = OutRequestTypeEnum.Post
//            }, _subSystemUrls.Value.SmsToken);

//            return new BaseResponseDto
//            {
//                Data = result.Data,
//                Message = result.Message,
//                Status = result.Status == 2 ? ResponseStatus.Success : ResponseStatus.Fail
//            };
//        }

//    }
//}
