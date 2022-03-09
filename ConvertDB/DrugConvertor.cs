using ConvertDB.HisDBEntities;
using ConvertDB.PortalEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDB
{
    public class DrugConvertor : IConvertor
    {
        public void Convert()
        {

            var srccontext = new PortalContext();
            var newContext = new HisDBContext();


            var srcGroup = srccontext.Groups.ToList();
            var srcDrugs = srccontext.Drugs.ToList();
            var srcGenerics = srccontext.GenericDrugs.ToList();
            var srcDrugForms = srccontext.DrugForms.ToList();
            var srcCompany = srccontext.Companies.ToList();
            var srcStoreCondition = srccontext.StoregConditions.ToList();
            var srcUnit = srccontext.Units.ToList();

            var newGroup = newContext.Groups.ToList();
            var newGeneric = newContext.GenericDrugs.ToList();
            var newCompanies = newContext.Companies.ToList();
            var newBaseValues = newContext.BaseValues.ToList();
            var newDrugForms = newContext.DrugForms.ToList();
            var newUnits = newContext.Units.ToList();

            foreach (var item in srcGroup)
            {
                var group = new HisDBEntities.Group()
                {
                    IsActive = item.IsActive,
                    LocalId = item.Id,
                    ParentId = item.ParentId,
                    Title = item.Title,
                    TitleLang2 = item.TitleLang2
                };
                newContext.Groups.Add(group);
            }

            newContext.SaveChanges();


            foreach (var item in srcGenerics)
            {
                var group = newGroup.Where(x => x.LocalId == item.GroupId).FirstOrDefault();

                var generic = new HisDBEntities.GenericDrug()
                {
                    Group = group,
                    Title = item.Title,
                    TitleLang2 = item.TitleLang2,
                    Note = item.Note,
                    Code1 = item.Code1,
                    Code2 = item.Code2,
                    IsActive = item.IsActive,
                    IsAdmin = item.IsAdmin,
                    NoteLang2 = item.NoteLang2,
                    LocalId = item.Id
                };
                newContext.GenericDrugs.Add(generic);

            }
            newContext.SaveChanges();



            foreach (var item in srcDrugForms)
            {
                var drugForm = new HisDBEntities.DrugForm()
                {
                    Title = item.Title,
                    LocalId = item.Id,
                    TitleLang2 = item.TitleLang2,
                    Note = item.Note,
                    Code1 = item.Code1,
                    Code2 = item.Code2,
                    IsActive = item.IsActive,
                    IsAdmin = item.IsAdmin,
                    NoteLang2 = item.NoteLang2,
                };
                newContext.DrugForms.Add(drugForm);
            }

            newContext.SaveChanges();


            foreach (var item in srcCompany)
            {
                var company = new HisDBEntities.Company()
                {
                    Title = item.Title,
                    LocalId = item.Id,
                };
                newContext.Companies.Add(company);
            }

            newContext.SaveChanges();



           // this data saved into baseValue

            foreach (var item in srcStoreCondition)
            {
                var storeCondition = new HisDBEntities.StoregCondition()
                {
                    Title = item.Title,
                    LocalId = item.Id,
                    TitleLang2 = item.TitleLang2,
                    Note = item.Note,
                    Code1 = item.Code1,
                    Code2 = item.Code2,
                    IsActive = item.IsActive,
                    IsAdmin = item.IsAdmin,
                    NoteLang2 = item.NoteLang2,
                };
                newContext.StoregConditions.Add(storeCondition);
            }

            newContext.SaveChanges();

            foreach (var item in srcUnit)
            {
                var unit = new HisDBEntities.Unit()
                {
                    Title = item.Title,
                    LocalId = item.Id,
                    TitleLang2 = item.TitleLang2,
                    Note = item.Note,
                    Code1 = item.Code1,
                    Code2 = item.Code2,
                    IsActive = item.IsActive,
                    IsAdmin = item.IsAdmin,
                    NoteLang2 = item.NoteLang2,
                };
                newContext.Units.Add(unit);
            }

            newContext.SaveChanges();


            foreach (var item in srcDrugs)
            {
                var drugForm = newDrugForms.Where(x => x.LocalId == item.DrugFormId).FirstOrDefault();
                var generic = newGeneric.Where(x => x.LocalId == item.GenericId).FirstOrDefault();
                var conditionStore = newBaseValues.Where(x => x.OldDbid == item.StoregConditonId && x.BaseValueTypeId == 11).FirstOrDefault();
                var company = newCompanies.Where(x => x.LocalId == item.CompanyId).FirstOrDefault();
                var unit = newUnits.Where(x => x.LocalId == item.UnitId).FirstOrDefault();

                var drug = new HisDBEntities.Drug()
                {
                    Generic = generic,
                    BrandTitle = item.BrandTitle,
                    LocalCode = item.LocalCode,
                    Price = item.Price,
                    DrugCode = item.DrugCode,
                    HisCode = item.HisCode,
                    Company = company,
                    StoregConditon = conditionStore,
                    DrugForm = drugForm,
                    Unit = unit,
                    BrokenConsumptionId = null,
                    BrokenConsumptionBase = item.BrokenConsumptionBase,
                    ContentsOf = item.ContentsOf,
                    StopConsumptionDay = item.StopConsumptionDay,
                    IsHighRisk = item.IsHighRisk,
                    IsNarcotic = item.IsNarcotic,
                    IsSaleWithoutPrescription = item.IsSaleWithoutPrescription,
                    IsOtcRight = item.IsOtcRight,
                    IsTechnicalRight = item.IsTechnicalRight,
                    Note = item.Note,
                    LocalId = item.Id

                };
                newContext.Drugs.Add(drug);
            }

            newContext.SaveChanges();




        }
    }
}
