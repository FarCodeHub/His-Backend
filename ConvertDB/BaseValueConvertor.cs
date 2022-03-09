
using ConvertDB.HisDBEntities;
using ConvertDB.PortalEntities;
using DataAccess.Entities.His.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseValue = ConvertDB.HisDBEntities.BaseValue;
using BaseValueType = ConvertDB.HisDBEntities.BaseValueType;

namespace ConvertDB
{
    class BaseValueConvertor : IConvertor
    {
        public void Convert()
        {
            var srccontext = new PortalContext();
            var newContext = new HisDBContext();

            var srcCenterType = srccontext.CenterTypes.ToList();
            var srcOwnerShip = srccontext.OwnershipTypes.ToList();
            var srcMarrige = srccontext.MaritalStatuses.ToList();
            var srcExpertise = srccontext.Expertises.ToList();
            var srcSex = srccontext.Sexes.ToList();
            var srcJob = srccontext.Jobs.ToList();
            var srcEducation = srccontext.Educations.ToList();
            var srcBloodGroup = srccontext.BloodGroups.ToList();
            var srcScientificlevel = srccontext.Scientificlevels.ToList();

            var baseValueTypes = newContext.BaseValueTypes.ToList();
            var baseValues = newContext.BaseValues.ToList();


            var centerTypeBaseValueType = baseValueTypes.FirstOrDefault(x => x.TypeName.Equals("CenterType"));
            if (centerTypeBaseValueType == null)
            { 
                  centerTypeBaseValueType = new BaseValueType
            {
                 TypeName = "CenterType",
                 UniqueName = "CenterType",
                 GroupName = null,
                 IsReadOnly = false,
                 SubSystem = ""
            };
          
                newContext.BaseValueTypes.Add(centerTypeBaseValueType);
            }
            foreach (var ct in srcCenterType)
            {
                if (!baseValues.Any(x=>x.Title.Equals(ct.Title)))
               { 
                var newCenterTypeBaseValue = new BaseValue
                {
                    BaseValueType = centerTypeBaseValueType,
                    ParentId = null,
                    Title = ct.Title,
                    UniqueName = ct.Title,
                    Value = "",
                    OldDbid = ct.Id,
                    OrderIndex = 1,
                    IsReadOnly = true,
                     
                };
                newContext.BaseValues.Add(newCenterTypeBaseValue);
                }
            }
            var ownerShipBaseValueType = baseValueTypes.FirstOrDefault(x => x.TypeName.Equals("OwnerShip"));
            if (ownerShipBaseValueType == null)
            {
                ownerShipBaseValueType = new BaseValueType
                {
                    TypeName = "OwnerShip",
                    UniqueName = "OwnerShip",
                    GroupName = null,
                    IsReadOnly = false,
                    SubSystem = ""
                };
                newContext.BaseValueTypes.Add(ownerShipBaseValueType);
            }
            foreach (var os in srcOwnerShip)
            {
                if (!baseValues.Any(x => x.Title.Equals(os.Title)))
                {
                    var newSrcOwnerShipBaseValue = new BaseValue
                    {
                        BaseValueType = ownerShipBaseValueType,
                        ParentId = null,
                        Title = os.Title,
                        UniqueName = os.Title,
                        Value = "",
                        OldDbid = os.Id,
                        OrderIndex = 1,
                        IsReadOnly = true,

                    };

                    newContext.BaseValues.Add(newSrcOwnerShipBaseValue);
                }
            }

            var marrigeBaseValueType = baseValueTypes.FirstOrDefault(x => x.TypeName.Equals("Marrige"));
            if (marrigeBaseValueType == null)
            {

                marrigeBaseValueType = new BaseValueType
                {
                    TypeName = "Marrige",
                    UniqueName = "Marrige",
                    GroupName = null,
                    IsReadOnly = false,
                    SubSystem = ""
                };
                newContext.BaseValueTypes.Add(marrigeBaseValueType);
            }
            foreach (var m in srcMarrige)
            {


                if (!baseValues.Any(x => x.Title.Equals(m.Title)))
                {
                    var newSrcMarrigeBaseValue = new BaseValue
                    {
                        BaseValueType = marrigeBaseValueType,
                        ParentId = null,
                        Title = m.Title,
                        UniqueName = m.Title,
                        Value = "",
                        OldDbid = m.Id,
                        OrderIndex = 1,
                        IsReadOnly = true
                    };

                    newContext.BaseValues.Add(newSrcMarrigeBaseValue);
                }
            }


            var expertiseBaseValueType = baseValueTypes.FirstOrDefault(x => x.TypeName.Equals("Expertise"));
            if (expertiseBaseValueType == null)
            {

                  expertiseBaseValueType = new BaseValueType
                {
                    TypeName = "Expertise",
                    UniqueName = "Expertise",
                    GroupName = null,
                    IsReadOnly = false,
                    SubSystem = ""
                };
                newContext.BaseValueTypes.Add(expertiseBaseValueType);
            }
            foreach (var e in srcExpertise)
            {
                if (!baseValues.Any(x => x.Title.Equals(e.Title)))
                {

                    var newSrcExpertiseBaseValue = new BaseValue
                    {
                        BaseValueType = expertiseBaseValueType,
                        ParentId = null,
                        Title = e.Title,
                        UniqueName = e.Title,
                        Value = "",
                        OldDbid = e.Id,
                        OrderIndex = 1,
                        IsReadOnly = true
                    };
                    newContext.BaseValues.Add(newSrcExpertiseBaseValue);
                }
            }


            var sexBaseValueType = baseValueTypes.FirstOrDefault(x => x.TypeName.Equals("Sex"));
            if (sexBaseValueType == null)
            {
                sexBaseValueType = new BaseValueType
                {
                    TypeName = "Sex",
                    UniqueName = "Sex",
                    GroupName = null,
                    IsReadOnly = false,
                    SubSystem = ""
                };
                newContext.BaseValueTypes.Add(sexBaseValueType);
            }

            foreach (var s in srcSex)
            {
                if (!baseValues.Any(x => x.Title.Equals(s.Title)))
                {
                    var newSrcSexBaseValue = new BaseValue
                    {
                        BaseValueType = sexBaseValueType,
                        ParentId = null,
                        Title = s.Title,
                        UniqueName = s.Title,
                        Value = "",
                        OldDbid = s.Id,
                        OrderIndex = 1,
                        IsReadOnly = true
                    };
                    newContext.BaseValues.Add(newSrcSexBaseValue);
                }
            }


            var jobBaseValueType = baseValueTypes.FirstOrDefault(x => x.TypeName.Equals("Job"));
            if (jobBaseValueType == null)
            {
                jobBaseValueType = new BaseValueType
                {
                    TypeName = "Job",
                    UniqueName = "Job",
                    GroupName = null,
                    IsReadOnly = false,
                    SubSystem = ""
                };
                newContext.BaseValueTypes.Add(jobBaseValueType);
            }
            foreach (var j in srcJob)
            {

                if (!baseValues.Any(x => x.Title.Equals(j.Title)))
                {
                    var newSrcJobBaseValue = new BaseValue
                    {
                        BaseValueType = jobBaseValueType,
                        ParentId = null,
                        Title = j.Title,
                        UniqueName = j.Title,
                        Value = "",
                        OldDbid = j.Id,
                        OrderIndex = 1,
                        IsReadOnly = true
                    };
                    newContext.BaseValues.Add(newSrcJobBaseValue);
                }
            }

            var educationBaseValueType = baseValueTypes.FirstOrDefault(x => x.TypeName.Equals("Education"));
            if (educationBaseValueType == null)
            {

                  educationBaseValueType = new BaseValueType
                {
                    TypeName = "Education",
                    UniqueName = "Education",
                    GroupName = null,
                    IsReadOnly = false,
                    SubSystem = ""
                };
                newContext.BaseValueTypes.Add(educationBaseValueType);
            }
            foreach (var e in srcEducation)
            {
                if (!baseValues.Any(x => x.Title.Equals(e.Title)))
                {

                    var newSrcEducationBaseValue = new BaseValue
                    {
                        BaseValueType = educationBaseValueType,
                        ParentId = null,
                        Title = e.Title,
                        UniqueName = e.Title,
                        Value = "",
                        OldDbid = e.Id,
                        OrderIndex = 1,
                        IsReadOnly = true
                    };
                    newContext.BaseValues.Add(newSrcEducationBaseValue);
                }
            }

            var bloodGroupBaseValueType = baseValueTypes.FirstOrDefault(x => x.TypeName.Equals("BloodGroup"));
            if (bloodGroupBaseValueType == null)
            {

                  bloodGroupBaseValueType = new BaseValueType
                {
                    TypeName = "BloodGroup",
                    UniqueName = "BloodGroup",
                    GroupName = null,
                    IsReadOnly = false,
                    SubSystem = ""
                };
                newContext.BaseValueTypes.Add(bloodGroupBaseValueType);
            }
            foreach (var b in srcBloodGroup)
            {

                if (!baseValues.Any(x => x.Title.Equals(b.Title)))
                {
                    var newSrcBloodGroupBaseValue = new BaseValue
                    {
                        BaseValueType = bloodGroupBaseValueType,
                        ParentId = null,
                        Title = b.Title,
                        UniqueName = b.Title,
                        Value = "",
                        OldDbid = b.Id,
                        OrderIndex = 1,
                        IsReadOnly = true
                    };
                    newContext.BaseValues.Add(newSrcBloodGroupBaseValue);
                }
            }

            var scientificlevelBaseValueType = baseValueTypes.FirstOrDefault(x => x.TypeName.Equals("Scientificlevel"));
            if (scientificlevelBaseValueType == null)
            {
                  scientificlevelBaseValueType = new BaseValueType
                {
                    TypeName = "Scientificlevel",
                    UniqueName = "Scientificlevel",
                    GroupName = null,
                    IsReadOnly = false,
                    SubSystem = ""
                };
                newContext.BaseValueTypes.Add(scientificlevelBaseValueType);
            }
            foreach (var s in srcScientificlevel)
            {
                if (!baseValues.Any(x => x.Title.Equals(s.Title)))
                {
                    var newsrcScientificlevelBaseValue = new BaseValue
                    {
                        BaseValueType = scientificlevelBaseValueType,
                        ParentId = null,
                        Title = s.Title,
                        UniqueName = s.Title,
                        Value = "",
                        OldDbid = s.Id,
                        OrderIndex = 1,
                        IsReadOnly = true
                    };
                    newContext.BaseValues.Add(newsrcScientificlevelBaseValue);
                }
            }
            newContext.SaveChanges();
        }
    }
}
