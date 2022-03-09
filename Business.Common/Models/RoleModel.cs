using AutoMapper;
using DataAccess.Entities.His.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Common.Models
{
    public class RoleModel : IModel
    {
        public int RoleId { get; set; }
        public string RoleTitle { get; set; }
        public void CreateMap(Profile profile)
        {
            profile.CreateMap<RoleModel, Role>();
            profile.CreateMap<Role, RoleModel>();
        }

        public void Init()
        {
         
        }
    }
}
