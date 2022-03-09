using AutoMapper;
using Business.Common.Models;
using DataAccess.Entities.His.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CenterManagment.Models
{
   public class ServiceTypeModel:IModel
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public string LocalCode { get; set; }
        public string InternationalCode { get; set; }
        public string Description { get; set; }

        public void CreateMap(Profile profile)
        {
            profile.CreateMap<ServiceTypeModel, ServiceType>();
            profile.CreateMap<ServiceType, ServiceTypeModel>();
        }

        public void Init()
        {
         
        }
    }
}
