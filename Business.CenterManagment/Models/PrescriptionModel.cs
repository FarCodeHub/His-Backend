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
    public class PrescriptionModel:IModel
    {
 
        public string MedicalStaffName { get; set; }
        public int CenterId { get; set; }
        public int MedicalStaffId { get; set; }
        public long? Id { get;  set; }
        public string FullName { get;  set; }
        public string MobileNumber { get;  set; }
        public string MedicalCenterTitle { get;  set; }
        public string DoctorTitle { get;  set; }
        public string PrescriptionCode { get;  set; }
        public DateTime? PrescriptionDate { get;  set; }
        public string Note { get;  set; }
        public List<DrugModel> Drugs { get; set; }
        public string CenterTitle { get;   set; }
        public string PersianPrescriptionDate { get; set; }

        public void CreateMap(Profile profile)
        {
            profile.CreateMap<PrescriptionModel, Prescription>();
            profile.CreateMap<Prescription, PrescriptionModel>();
        }

        public void Init()
        {
            if (PrescriptionDate != null)
                PersianPrescriptionDate = (PrescriptionDate.Value.Date).ToShortDateString();
            else
                PersianPrescriptionDate = " - ";
        }
    }
}
