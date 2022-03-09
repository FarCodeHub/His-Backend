using ConvertDB.HisDBEntities;
using ConvertDB.PortalEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDB
{
    public class PrescriptionConvertor : IConvertor
    {
        public void Convert()
        {
            var srccontext = new PortalContext();
            var newContext = new HisDBContext();

            var srcPatientExtras = srccontext.PatientExtraInfos.ToList();
            var srcReceptions = srccontext.Receptions1.ToList();
            var srcPrescriptions = srccontext.Prescriptions.ToList();
            var srcDrugDetail = srccontext.PrescriptionDetailDrugs.ToList();
            var srcFiles = srccontext.Files.ToList();


            var srcPatient = srccontext.Patients.ToList();

            var persons = newContext.People.ToList();


            //foreach(var item in srcFiles)
            //{
            //    if (item.TableName.Equals("AnswerService"))
            //    {
            //        var centerId = srccontext.AnswerServices.
            //    }
            //}
       

            //foreach (var item in srcPatient)
            //{

            //    var person = persons.Where(x => x.LocalId == item.PersonId).FirstOrDefault();
            //    var extra = srcPatientExtras.Where(x => x.PatientId == item.Id).FirstOrDefault();
                
            //    var patient = new HisDBEntities.Patient()
            //    {
            //        Person = person,
            //        Note = item.Note,
            //        CreateDate = item.CreateDate,
            //        Hisno = item.Hisno,
            //        FileNo = item.FileNo,
            //        Allergies = null,
            //        LocalId = item.Id
            //    };

            //    newContext.Patients.Add(patient);
            //}

            //newContext.SaveChanges();

            //foreach(var item in srcReceptions)
            //{
            //    var patient = newContext.Patients.Where(x => x.LocalId == item.PatientId).FirstOrDefault();
            //    var medicalStaff = newContext.MedicalStaffs.Where(x => x.LocalId == item.DoctorId).FirstOrDefault();

            //    var reception = new HisDBEntities.Reception()
            //    {
            //        Patient = patient,
            //        CreateTime = item.ReceptionDate,
            //        CenterId = 71,
            //        Doctor = medicalStaff,
            //        Note = item.Note,
            //        LocalId = item.Id
            //    };
            //    newContext.Receptions.Add(reception);
            //}
            //newContext.SaveChanges();


            //foreach(var item in srcPrescriptions)
            //{
            //    var reception = newContext.Receptions.Where(x => x.LocalId == item.ReceptionId).FirstOrDefault();
            //    var medicalStaff = newContext.MedicalStaffs.Where(x => x.LocalId == item.DoctorId).FirstOrDefault();

            //    var prescrioption = new HisDBEntities.Prescription()
            //    {
            //        CreateDate = item.CreateDate,
            //        Reception = reception,
            //        MedicalStaff = medicalStaff,
            //        Note = item.Note,
            //        LocalId = item.Id
            //    };
            //    newContext.Prescriptions.Add(prescrioption);
            //}

            //newContext.SaveChanges();

            //foreach(var item in srcDrugDetail)
            //{
            //    var prescription = newContext.Prescriptions.Where(x => x.LocalId == item.PrescriptionId).FirstOrDefault();

            //    var drugDetail = new HisDBEntities.PrescriptionDetailDrug()
            //    {
            //        Prescription = prescription,
            //        Note = item.Note,
            //        LocalId = item.Id
            //    };
            //    newContext.PrescriptionDetailDrugs.Add(drugDetail);
            //}
            //newContext.SaveChanges();





        }
    }
}
