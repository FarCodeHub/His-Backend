
using ConvertDB.HisDBEntities;
using ConvertDB.PortalEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDB
{
    class CenterConvertor : IConvertor
    {
        public void Convert()
        {
            var srccontext = new PortalContext();
            var newContext = new HisDBContext();

            var srcOwnerShip = srccontext.OwnershipTypes.ToList();
            var srcWorkTime = srccontext.WorkTimeTypes.ToList();
            var srcCenters = srccontext.Centers.ToList();
            var srcDoctors = srccontext.Doctors.ToList();
            var srcServices = srccontext.Services.ToList();
            


            var baseValues = newContext.BaseValues.ToList();
            var geoLocation = newContext.GeoLocations.ToList();
            var persons = newContext.People.ToList();

            // ---add specialities
            foreach (var item in srcServices)
            {

                // start insert services into speciality
                var speciality = new Speciality()
                {
                    Title = item.Title,
                    AbbreviationTitle = item.AbbreviationTitle,
                    ParentId = null,
                    LocalId = item.Id
                };
                newContext.Specialities.Add(speciality);
            }
            newContext.SaveChanges();



            /// 1) add centers
            /// 2) add centerLocations
            /// 3) add sections
            /// 4) add medicalStaff (just doctors ; other staff' tables were empty)
            /// 5) add centerStaff
            /// also MedicalStaffSpecialities and CenterSpecialities must convert but there is no data into old db (portal) for them

            foreach (var center in srcCenters)
            {

                // load all sections of center
                var srcSections = srccontext.Sections.Where(x => x.CenterId == center.Id).ToList();


                // ------------ start insert centers into medicalCenter

                // find ownerShip
                var ownerShipBaseId = 0;
                var ownerShip = baseValues.Where(x => x.OldDbid == center.OwnershipTypeId && x.BaseValueTypeId == 2).FirstOrDefault();
                if (ownerShip != null)
                    ownerShipBaseId = ownerShip.Id;

                // find workTime
                var workTimeBaseId = 0;
                var workTime = baseValues.Where(x => x.OldDbid == center.WorkTimeTypeId && x.BaseValueTypeId == 10).FirstOrDefault();
                if (workTime != null)
                    workTimeBaseId = workTime.Id;


                // find centerType
                var centerTypeBaseId = 0;
                var centerType = baseValues.Where(x => x.OldDbid == center.CenterTypeId && x.BaseValueTypeId == 1).FirstOrDefault();
                if (centerType != null)
                    centerTypeBaseId = centerType.Id;

                // add center
                var newCenter = new HisDBEntities.MedicalCenter
                {
                    Title = center.Title != null ? center.Title :" ",
                    Code = center.Code,
                    BossId = 0,
                    CenterTypeId = centerTypeBaseId,
                    AnswerTime = "",
                    Boss = center.Boss,
                    BossPhone = center.BossPhone,
                    Email = center.Email,
                    Fax = center.Fax,
                    CreateTime = DateTime.Now,
                    IsActive = center.IsActive == false ? false : true,
                    IsFreeDelivery = center.IsFreeDelivery,
                    Note = center.Note,
                    OwnerShipBaseId = ownerShipBaseId != 0 ? ownerShipBaseId : null,
                    Phone = center.Phone,
                    PhoneResponseHourse = center.PhoneResponseHourse,
                    VisitorPhone = center.VisitorPhone,
                    WorkTimeBaseId = workTimeBaseId != 0 ? workTimeBaseId : null,
                    LocalId = center.Id
                };

                newContext.MedicalCenters.Add(newCenter);

                // --- start insert centerLocations

                // find country
                var countryId = 0;
                var country = geoLocation.Where(x => x.LocalId == center.CountryId).FirstOrDefault();
                if (country != null)
                    countryId = country.Id;

                // find province
                var provinceId = 0;
                var province = geoLocation.Where(x => x.LocalId == center.ProvinceId).FirstOrDefault();
                if (province != null)
                    provinceId = province.Id;

                // find city
                var cityId = 0;
                var city = geoLocation.Where(x => x.LocalId == center.CityId).FirstOrDefault();
                if (city != null)
                    cityId = city.Id;

                // find zone
                var zoneId = 0;
                var zone = geoLocation.Where(x => x.LocalId == center.ZoneId).FirstOrDefault();
                if (zone != null)
                    zoneId = zone.Id;


                // find GeoLocationId ; start from zone , if it has Id we set it as GeoLocationId and if it was null we check city ...
                var locationId = 0;
                if (zoneId != 0)
                    locationId = zoneId;
                else if (cityId != 0)
                    locationId = cityId;
                else if (provinceId != 0)
                    locationId = provinceId;
                else
                    locationId = countryId;


                // --- add centerLocation
                var centerLocation = new HisDBEntities.CenterLocation
                {
                    Center = newCenter,
                    Address = center.Address,
                    AreaCode = center.AreaCode,
                    CityId = cityId != 0 ? cityId : null,
                    CountryId = countryId != 0 ? countryId : null,
                    PostalCode = center.PostalCode,
                    ProvinceId = provinceId != 0 ? provinceId : null,
                    ZoneId = zoneId != 0 ? zoneId : null,
                    LocationId = locationId != 0 ? locationId : null
                };

                newContext.CenterLocations.Add(centerLocation);

                // -------------------------------- start insert sections  -----------

                foreach(var item in srcSections)
                {

                    // -- insert section into into medicalCenter
                    var section = new HisDBEntities.MedicalCenter
                    {
                        Parent = newCenter,
                        Title = item.Title,
                        Code = item.LocalCode,
                        BossId = 0,
                        CenterTypeId = null,
                        AnswerTime = "",
                        Boss = center.Boss,
                        BossPhone = null,
                        Email = null,
                        Fax = null,
                        CreateTime = DateTime.Now,
                        IsActive =  true,
                        IsFreeDelivery = center.IsFreeDelivery,
                        Note = item.Note,
                        OwnerShipBaseId =  null,
                        Phone = item.Phone,
                        PhoneResponseHourse = center.PhoneResponseHourse,
                        VisitorPhone =null,
                        WorkTimeBaseId = null,
                        LocalId = item.Id
                    };

                    newContext.MedicalCenters.Add(section);
                }

                // ---------------------------------start insert doctor 

                // find doctor by centerId
                var doctors = srcDoctors.Where(x => x.CenterId == center.Id).ToList();

                if (doctors.Count>0)
                {
                    foreach(var item in doctors)
                    {
                        // find personId
                        var person = persons.Where(x => x.LocalId == item.PersonId).First();

                        // add doctors into MedicalStaff
                        var medicalStaff = new MedicalStaff()
                        {
                            PersonId = person.Id,
                            TypeBaseId = 1,
                            EmployeeDate = DateTime.Now,
                            MedicalSystemNo = item.MedicalSystemNo,
                            Note = item.Note,
                            LocalId = item.Id
                        };
                        newContext.MedicalStaffs.Add(medicalStaff);

                        // add centerStaffs

                        var centerStaff = new CenterStaff()
                        {
                            MedicalStaff = medicalStaff,
                            Center = newCenter,
                            EmployeeType = 1,
                            IsActive = item.IsActive,
                            IsDelete = false,
                            ActiveTime = DateTime.Now,
                        };
                        newContext.CenterStaffs.Add(centerStaff);

                    }
                }



            }

            newContext.SaveChanges();


        }
    }
}
