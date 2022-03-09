using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Person
    {
        public Person()
        {
            Doctors = new HashSet<Doctor>();
            Employees = new HashSet<Employee>();
            Passports = new HashSet<Passport>();
            Patients = new HashSet<Patient>();
            Reception1s = new HashSet<Reception1>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string GrandFatherName { get; set; }
        public string NationalCode { get; set; }
        public int? SexId { get; set; }
        public string ShNo { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? MaritalStatusId { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public short? Age { get; set; }
        public string Email { get; set; }
        public int? BirthPlaceId { get; set; }
        public string Address { get; set; }
        public int? EducationId { get; set; }
        public int? JobId { get; set; }
        public int? ProvinceId { get; set; }
        public int? CityId { get; set; }
        public int? ZoneId { get; set; }
        public string Note { get; set; }
        public string GreatGrandFatherName { get; set; }
        public string MotherName { get; set; }
        public string LatinName { get; set; }
        public int? CountryId { get; set; }

        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual MaritalStatus MaritalStatus { get; set; }
        public virtual Province Province { get; set; }
        public virtual Sex Sex { get; set; }
        public virtual Zone Zone { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Passport> Passports { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
        public virtual ICollection<Reception1> Reception1s { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
