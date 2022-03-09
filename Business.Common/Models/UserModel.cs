

using AutoMapper;
using DataAccess.Entities.His.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Business.Common.Models
{


    public class UserModel: IModel
    {
        public int Id { get; set; }
        public int? PersonId { get; set; }
        public int? CardCodeId { get; set; }
        public bool IsActive { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsVerify { get; set; }
        public string MacAddress { get; set; }
        public bool? IsSync { get; set; }
        public int? SmsUserId { get; set; }
        public string SmsToken { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public string FullName { get; set; }
        public string LastPassword { get; set; }
        public List<RoleModel> Roles { get; set; }
        public string Mobile { get; set; }
        public string NationalCode { get; set; }
        public bool ChangePassword { get; set; }
        public string Avatar { get; set; }
        public void CreateMap(Profile profile)
        {
            profile.CreateMap<UserModel, User>().ForMember(des => des.CreateDate, opt => opt.MapFrom(x => DateTime.Now)); ;
            profile.CreateMap<User, UserModel>();
            profile.CreateMap<UserModel, UserRole>();
        }

        public void Init()
        {
            throw new System.NotImplementedException();
        }
    }
}
