using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities.His.Entities
{
    public partial class Person
    {
        public Person()
        {
            AspNetUsers = new HashSet<AspNetUser>();
            MedicalStaffs = new HashSet<MedicalStaff>();
            Patients = new HashSet<Patient>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string GrandFatherName { get; set; }
        public string FullNameThree { get; set; }
        public string FullName { get; set; }
        public string MotherName { get; set; }
        public string GreatGrandFatherName { get; set; }
        public string LatinName { get; set; }
        public string NationalCode { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Avatar { get; set; }
        public int? GeoLocationId { get; set; }
        public string Address { get; set; }
        public int? CountryId { get; set; }
        public int? ProvinceId { get; set; }
        public int? CityId { get; set; }
        public int? ZoneId { get; set; }
        public int? SexBaseId { get; set; }
        public string ShNo { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public int? MaritalBaseId { get; set; }
        public int? EducationId { get; set; }
        public int? JobId { get; set; }
        public short? Age { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public int? ExpertiseId { get; set; }
        public int? LocalId { get; set; }

        public virtual BaseValue Expertise { get; set; }
        public virtual BaseValue MaritalBase { get; set; }
        public virtual BaseValue SexBase { get; set; }
        public virtual ICollection<AspNetUser> AspNetUsers { get; set; }
        public virtual ICollection<MedicalStaff> MedicalStaffs { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
