using AutoMapper;
using Business.Common.Models;
using Core.His.Extensions;
using DataAccess.Entities.His.Entities;
using System;
using System.Collections.Generic;

namespace Business.CenterManagment.Models
{
    public class PatientModel :  IModel
    {
        public string BloodGroupTitle { get; set; }
        public string FullName { get; set; }
        public short? Age { get; set; }
        public string Sex { get; set; }
        public int? SexId { get; set; }
        public int? MaritalBaseId { get; set; }

        public List<AllergiModel> ListAlergies { get; set; }
        public string MobileNumber { get; set; }
        public string MartilTitle { get; set; }
        public DateTime ? BrithDate { get; set; }
        public string MedicalCenterTitle { get;  set; }
        public string DoctorTitle { get;  set; }
        public string Code { get;   set; }
        public string Diet { get;   set; }
        public string Biography { get;   set; }
        public DateTime? PrescriptionDate { get;   set; }

        public int UserId { get; set; }
        public string Email { get;   set; }
        public string FirstName { get;   set; }
        public string LastName { get;   set; }
        public string FatherName { get;   set; }
        public string GrandFatherName { get;   set; }
        public string Phone { get;   set; }
        public string Address { get;   set; }
        public int PersonId { get;   set; }
        public int Id { get;   set; }
        public decimal? Height { get;   set; }
        public decimal? Weight { get;   set; }
        public string Allergies { get;   set; }
        public long? Hisno { get;   set; }
        public string NationalCode { get; set; }
        public string Avatar { get; set; }
        public string PersianBrithDate { get; set; }
        public void CreateMap(Profile profile)
        {
            profile.CreateMap<PatientModel, Patient>();
            profile.CreateMap<Patient, PatientModel>();

 
        }

        public void Init()
        {
            if (string.IsNullOrWhiteSpace(BloodGroupTitle))
                BloodGroupTitle = "There Is No Data";
            
            if (string.IsNullOrWhiteSpace(FullName))
                FullName = "There Is No Data";

            if (string.IsNullOrWhiteSpace(FirstName))
                FirstName = "There Is No Data";

            if (string.IsNullOrWhiteSpace(LastName))
                LastName = "There Is No Data";

            if (string.IsNullOrWhiteSpace(FatherName))
                FatherName = "There Is No Data";

            if (string.IsNullOrWhiteSpace(Phone))
                Phone = "There Is No Data";

            if (string.IsNullOrWhiteSpace(DoctorTitle))
                DoctorTitle = "There Is No Data";

            if (string.IsNullOrWhiteSpace(Address))
                Address = "There Is No Data";
            if (BrithDate != null)
            {
               // PersianBrithDate = ((DateTime)BrithDate.Value.Date).PersianDateFormat();
                PersianBrithDate = (BrithDate.Value.Date).ToShortDateString();
            }
            
        }

 

    }




}
