using AutoMapper;
using Business.CenterManagment.Services;
using Business.Common.Models;
using DataAccess.Entities.His.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CenterManagment.Models
{
   public class MedicalStaffModel:MedicalStaff,IModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string GrandFatherName { get; set; }
        public string FullNameThree { get; set; }
        public string FullName { get; set; }
        public string TypeName { get; set; }
        public int CenterId { get; set; }
        public int MaritalBaseId { get; set; }
        public short? Age { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Sex { get; set; }
        public int SexId { get; set; }
        public int ExpertiseId { get; set; }
        public string MedicalCenterTitle { get; set; }
        public string Address { get; set; }
        public string WorkTimeTitle { get; set; }
        public string CenterPhone { get; set; }
        public string VisitPhone { get; set; }
        public List<SpecialityModel> Specialities { get; set; }

        public void CreateMap(Profile profile)
        {
            profile.CreateMap<MedicalStaffModel, MedicalStaff>()
                .ForMember(des => des.Person, opt => opt.MapFrom(x => x.Person))
                .ForMember(des => des.EmployeeDate, opt => opt.MapFrom(x => DateTime.Now));



            profile.CreateMap<CenterStaff, MedicalStaffModel>()
                .ForMember(des => des.CenterStaffs, opt => opt.MapFrom(x => x));


            profile.CreateMap<MedicalStaffModel, Person>().ForMember(x=>x.SexBaseId,opt=>opt.MapFrom(src=>src.SexId));


        }
        public void Init()
        {
            if (TypeBaseId == (int)MedicalStaffType.Doctor)
                TypeName = "دکتر";
            if (TypeBaseId == (int)MedicalStaffType.Experts)
                TypeName = "متخصص";
            if (TypeBaseId == (int)MedicalStaffType.Nurse)
                TypeName = "پرستار";
            if (TypeBaseId == (int)MedicalStaffType.Employee)
                TypeName = "کارمند";
           
        }


    }
}
