
using ConvertDB.PortalEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDB
{
    class DoctorConvertor  : IConvertor
    {
        public void Convert()
        {
            var srccontext = new PortalContext();
            var srcDoctors = srccontext.Doctors.ToList();
            foreach (var doctor in srcDoctors)
            {
                var person = srccontext.People.First(x => x.Id == (int)doctor.PersonId);

                var newPerson = new DataAccess.Entities.His.Entities.Person
                {
                    FirstName = person.FirstName,
                    LastName = person.LastName,
                    FatherName = person.FatherName,
                    GrandFatherName = person.GrandFatherName,
                    GreatGrandFatherName = person.GreatGrandFatherName,
                    //FullName = "" // Must be removed
                    NationalCode = person.NationalCode,
                    SexBaseId = 0,
                    BirthDate = person.BirthDate,
                    MaritalBaseId = 0,
                    Mobile = person.Mobile,
                    Phone = person.Phone,
                    Age = person.Age, // Must be removed, it should be calculated field
                    CityId = person.CityId,//--------Wrong
                    ProvinceId = person.ProvinceId,
                    CountryId = person.CountryId,
                    ZoneId = person.ZoneId,
                    //BirthPlaceId
                    Address = person.Address,

                };
                var medicalStaff = new DataAccess.Entities.His.Entities.MedicalStaff
                {
                    MedicalSystemNo = doctor.MedicalSystemNo,
                    Person = newPerson,
                    EmployeeDate = doctor.CooperationDate != null ? doctor.CooperationDate.Value : DateTime.Now,
                    TypeBaseId = 0,
                    //ExpertiseId
                    //DoctorDegreeId,
                    //AddressClinic
                    //PhoneClinic,
                    //ScientificlevelId
                };
            }
        }
    }
}
