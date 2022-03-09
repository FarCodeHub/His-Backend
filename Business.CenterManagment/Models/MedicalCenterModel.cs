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
    public class MedicalCenterModel : MedicalCenter,IModel
    { 
        public int CenterId { get; set; }
        public int PersonId { get; set; }
        public CenterLocationModel CenterLocation { get; set; }
         public string OwnerShipTypeName { get; set; }
         public string WorkTimeTypeName { get; set; }
        public string TypeName { get; set; }

        public void CreateMap(Profile profile)
        {
            profile.CreateMap<MedicalCenterModel, MedicalCenter>()
                .ForMember(des => des.IsActive, opt => opt.MapFrom(x => 1))
                .ForMember(des => des.AnswerTime, opt => opt.MapFrom(x => "10"))
                .ForMember(des => des.CreateTime, opt => opt.MapFrom(x => DateTime.Now));

            profile.CreateMap<MedicalCenter, MedicalCenterModel>();
        }

        public void Init()
        {
            if (CenterTypeId == (int)MedicalCenterType.Hospital)
                TypeName = "بیمارستان";
             if (CenterTypeId == (int)MedicalCenterType.Clinic)
                TypeName = "کلینیک";
             if (CenterTypeId == (int)MedicalCenterType.Section)
                TypeName = "بخش";
            if (CenterTypeId == (int)MedicalCenterType.Lab)
                TypeName = "بخش";


        }

    }
}
