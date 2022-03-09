using AutoMapper;
using Business.Common.IServices;
using Business.Common.Models;
using Core.His.Models;
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Business.Common.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IPersonRepository personRepository;
        private readonly IUserRepository userRepository;
        private readonly IMedicalStaffRepository medicalStaffRepository;
        private readonly ICenterStaffRepository centerStaffRepository;
        private readonly IMedicalCenterRepository medicalCenterRepository;
        private readonly IUserRoleRepository userRoleRepository;
        private readonly IRoleRepository roleRepository;
 
        private IMapper mapper; 

        public AccountService(IUnitOfWork unitOfWork,
            IMapper mapper ,
            IPersonRepository personRepository,
            IUserRepository userRepository,
            IMedicalStaffRepository medicalStaffRepository,
            ICenterStaffRepository centerStaffRepository ,
            IMedicalCenterRepository medicalCenterRepository,
            IUserRoleRepository userRoleRepository,
            IRoleRepository roleRepository
            ) 
        {
            this.unitOfWork = unitOfWork;
            this.personRepository = personRepository;
            this.personRepository.UnitOfWork = this.unitOfWork;
            this.userRepository = userRepository;
            this.userRepository.UnitOfWork = this.unitOfWork;
            this.medicalStaffRepository = medicalStaffRepository;
            this.medicalStaffRepository.UnitOfWork = this.unitOfWork;
            this.centerStaffRepository = centerStaffRepository;
            this.centerStaffRepository.UnitOfWork = this.unitOfWork;
            this.medicalCenterRepository = medicalCenterRepository;
            this.medicalCenterRepository.UnitOfWork = this.unitOfWork;

            this.userRoleRepository = userRoleRepository;
            this.userRoleRepository.UnitOfWork = this.unitOfWork;

            this.roleRepository = roleRepository;
            this.roleRepository.UnitOfWork = this.unitOfWork;

 

            this.mapper = mapper; ;
        }



        // --- autorization must be complete
        public async Task<ResponseResult> Login(UserModel login)
        {
            var user = await (from u in userRepository.GetAll()
                              join p in personRepository.GetAll() on u.PersonId equals p.Id
                              where u.UserName.Equals(login.UserName)
                              && u.Password.Equals(login.Password)
                              select new UserModel
                              {
                                  Email = p.Email,
                                  FullName = p.FullName,
                                  UserName = u.UserName,
                                  PersonId = p.Id,
                                  Id = u.Id,
                                  Avatar = p.Avatar
                                  
                              }
                 ).FirstOrDefaultAsync();

            
            if (user == null)
            {
                return new ResponseResult { Status = ResponseStatus.NotValid, Message = "Username or password is incorrect" };
            }
            var roles = await (from ur in userRoleRepository.GetAll()
                               join r in roleRepository.GetAll() on ur.RoleId equals r.Id
                               where ur.UserId == user.Id
                               select new RoleModel
                               {
                                   RoleId = r.Id,
                                   RoleTitle = r.RoleTitle
                               }).ToListAsync();
            user.Roles = roles;
            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = user
              
            };
        }






        /// <summary>
        /// Add Person ----
        /// </summary>
        /// <param name="personModel">Person Model</param>
        /// <returns>ResponseResult(PersonModel)</returns>
        public async Task<ResponseResult> AddPerson(PersonModel personModel)
        {
            // var isValid = Validation.IsValid(new PersonValidation(person));
          //  if (resultVaild.Status == ResponseStatus.NotValid)
            var person = mapper.Map<PersonModel, Person>(personModel);
            personRepository.Add(person);
            await unitOfWork.Save();
            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = personModel
                
            };

        }

        /// <summary>
        /// Add User (First Add Person Then Add User)----
        /// </summary>
        /// <param name="addUser">User Model</param>
        /// <returns>ResponseResult(UserModel)</returns>
        public async Task<ResponseResult> AddUser(UserModel addUser)
        {
            // var isValid = Validation.IsValid(new LoginValidation(person));
           
                 var user = mapper.Map<UserModel, User>(addUser);
                 userRepository.Add(user);
                 
            if (addUser.Roles != null)
            {
                addUser = mapper.Map<User, UserModel>(user);
                var addUserRole = mapper.Map<UserModel, UserRole>(addUser);
                userRoleRepository.Add(addUserRole);
            }
                 await unitOfWork.Save();

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = new
                {
                    Token = addUser.Token,
                    userModel = addUser
                }
            };

        }

        /// <summary>
        /// Get the list of all users----
        /// </summary>
        /// <returns>ResponseResult(UserModel)</returns>
        public async Task<ResponseResult> GetUsers()
        {
            var users = await (from p in personRepository.GetAll()
                               join u in userRepository.GetAll() on p.Id equals u.PersonId
                               orderby u.Id descending
                               select new UserModel
                               {
                                   Id = u.Id,
                                   PersonId = p.Id,
                                   UserName = u.UserName,
                                   Mobile = p.Mobile,
                                   FullName = p.FullName,
                                   NationalCode = p.NationalCode

                               }).Take(40).ToListAsync();


            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = users
            };


        }

        public async Task<ResponseResult> EditUser(UserModel user)
        {
            var userPerson = await (from p in personRepository.GetAll()
                               join u in userRepository.GetAll() on p.Id equals u.PersonId
                               where u.Id == user.Id
                               orderby u.Id descending
                               select new
                               { p,u }).FirstOrDefaultAsync();

            userPerson.u.UserName = user.UserName;
            userPerson.p.Mobile = user.Mobile;
            userPerson.p.FullName = user.FullName;
            userPerson.p.NationalCode = user.NationalCode;
            userPerson.u.Password = user.Password;
          
             

            await unitOfWork.Save();

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = user
            };


        }



        /// <summary>
        /// Get the list of all person in a center ----
        /// </summary>
        /// <param name="centerId">centerId</param>
        /// <returns>ResponseResult(PersonModel)</returns>
        public async Task<ResponseResult> GetPersonsBy(int centerId)
        {
            var users = await (from u in userRepository.GetAll()
                               join p in personRepository.GetAll() on u.PersonId equals p.Id
                               join ms in medicalStaffRepository.GetAll() on p.Id equals ms.PersonId
                               join cs in centerStaffRepository.GetAll() on ms.Id equals cs.MedicalStaffId
                               join mc in medicalCenterRepository.GetAll() on cs.CenterId equals mc.Id
                               where mc.Id == centerId || mc.ParentId == centerId
                               select p.Id).ToListAsync();

            var persons = await (from p in personRepository.GetAll()
                               join ms in medicalStaffRepository.GetAll() on p.Id equals ms.PersonId
                               join cs in centerStaffRepository.GetAll() on ms.Id equals cs.MedicalStaffId
                               join mc in medicalCenterRepository.GetAll() on cs.CenterId equals mc.Id
                               where mc.Id == centerId || mc.ParentId == centerId && !users.Contains(p.Id)
                               orderby p.Id descending
                               select new PersonModel
                               {
                                    Id = p.Id,
                                    FullName = p.FullName,

                               }).ToListAsync();
           // var personIds = persons.Select(x => x.Id).ToList();

    

            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = persons
            };
        }


        public async Task<ResponseResult> ChangeAvatar(string fileName, int personId)
        {
            var person = await personRepository.GetAll().Where(x => x.Id == personId).FirstOrDefaultAsync();
            person.Avatar = fileName;
            await unitOfWork.Save();
            return new ResponseResult
            {
                Status = ResponseStatus.Success,
                Data = fileName
            };
        }

    }
    public enum RoleTitle
    {
        Doctor = 1,
        Drugs = 2,
        Lab = 3
    }
}
