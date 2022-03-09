using AutoMapper;
using Business.Common.Models;
using DataAccess.Entities.His.Entities;
using System.Collections.Generic;

namespace Business.CenterManagment.Models
{
    public class SpecialityModel : IModel
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Title { get; set; }
        public List<SpecialityModel> Children { get; set; }
        public int CenterId { get; set; }
        public int MedicalStaffId { get; set; }

        public void CreateMap(Profile profile)
        {
            profile.CreateMap<SpecialityModel, Speciality>();
            profile.CreateMap<Speciality, SpecialityModel>();
        }

        public void Init()
        {
            
        }
    }
}
