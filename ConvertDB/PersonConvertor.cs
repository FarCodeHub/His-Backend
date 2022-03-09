using ConvertDB.HisDBEntities;
using ConvertDB.PortalEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDB
{
    public class PersonConvertor :IConvertor
    {
        public void Convert()
        {
            var srccontext = new PortalContext();
            var newContext = new HisDBContext();

            var srcPerson = srccontext.People.ToList();
            var srcSex = srccontext.Sexes.ToList();
            var srcEducation = srccontext.Educations.ToList();
            var srcMarrige = srccontext.MaritalStatuses.ToList();
            var srcExpertise = srccontext.Expertises.ToList();
            var srcJob = srccontext.Jobs.ToList();
            var srcProvince = srccontext.Provinces.ToList();

            var baseValues = newContext.BaseValues.ToList();
            var geolocaions = newContext.GeoLocations.ToList();
            foreach (var p in srcPerson)
            {
                var sex = srcSex.Where(x => x.Id == p.SexId).FirstOrDefault();

                var sexId = 0;
                if (sex != null)
                     sexId = baseValues.Where(x => x.OldDbid == sex.Id && x.BaseValueTypeId==5).Select(x => x.Id).FirstOrDefault();
                else
                    sexId = 0;


                var edu = srcEducation.Where(x => x.Id == p.EducationId).FirstOrDefault();
                var eduId = 0;
                if (edu != null)
                      eduId = baseValues.Where(x => x.OldDbid == edu.Id && x.BaseValueTypeId == 7).Select(x => x.Id).FirstOrDefault();
                else
                    eduId = 0;

                var marigge = srcMarrige.Where(x => x.Id == p.MaritalStatusId).FirstOrDefault();
                var mariggeId = 0;
                if (marigge != null)
                      mariggeId = baseValues.Where(x => x.OldDbid == marigge.Id && x.BaseValueTypeId == 3).Select(x => x.Id).FirstOrDefault();
                else
                    mariggeId = 0;


                var job = srcJob.Where(x => x.Id == p.JobId).FirstOrDefault();
                var jobId = 0;
                if (job != null)
                      jobId = baseValues.Where(x => x.OldDbid == job.Id && x.BaseValueTypeId == 6).Select(x => x.Id).FirstOrDefault();
                else
                    jobId = 0;


                var location = srcProvince.Where(x => x.Id == p.ProvinceId).FirstOrDefault();
                var locationId = 0;
                if (location != null)
                    locationId = geolocaions.Where(x => x.LocalId == location.Id).Select(x => x.Id).FirstOrDefault();
                else
                    locationId = 0;
                //var expert = srcExpertise.Where(x => x.Id == p.ex).FirstOrDefault();
                //var expertId = baseValues.Where(x => x.LocalId == job.Id).Select(x => x.Id).FirstOrDefault();

                var person = new HisDBEntities.Person()
                {
                    FirstName = p.FirstName,
                    LastName =p.LastName,
                    FatherName =p.FatherName,
                    GrandFatherName =p.GrandFatherName,
                    FullNameThree =p.FirstName + " " + p.LastName + " "+ p.FatherName,
                    FullName = p.FirstName + " " + p.LastName + " " + p.FatherName,
                    MotherName =p.MotherName,
                    GreatGrandFatherName =p.GreatGrandFatherName,
                    LatinName =p.LatinName,
                    NationalCode =p.NationalCode,
                    BirthDate =p.BirthDate,
                    GeoLocationId = locationId != 0 ? locationId : null,
                    Address = p.Address,
                    SexBaseId = sexId != 0 ? sexId : null,
                    ShNo = p.ShNo,
                    Mobile =p.Mobile,
                    Phone =p.Phone,
                    MaritalBaseId = mariggeId != 0 ? mariggeId : null,
                    EducationId = eduId != 0 ? eduId : null,
                    JobId = jobId != 0 ? jobId : null,
                    Age = p.Age,
                    Email =p.Email,
                    Note =p.Note,
                    ExpertiseId =null,
                    LocalId = p.Id

                };
                newContext.People.Add(person);
            }

            newContext.SaveChanges();
        }
    }
}