using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities.His.Entities
{
    public partial class BaseValue
    {
        public BaseValue()
        {
            Drugs = new HashSet<Drug>();
            MedicalCenterCenterTypes = new HashSet<MedicalCenter>();
            MedicalCenterOwnerShipBases = new HashSet<MedicalCenter>();
            MedicalCenterWorkTimeBases = new HashSet<MedicalCenter>();
            MedicalStaffs = new HashSet<MedicalStaff>();
            Patients = new HashSet<Patient>();
            PersonExpertises = new HashSet<Person>();
            PersonMaritalBases = new HashSet<Person>();
            PersonSexBases = new HashSet<Person>();
        }

        public int Id { get; set; }
        public int BaseValueTypeId { get; set; }
        public int? ParentId { get; set; }
        public string Title { get; set; }
        public string TitleLang2 { get; set; }
        public string UniqueName { get; set; }
        public string Value { get; set; }
        public short OrderIndex { get; set; }
        public bool? IsReadOnly { get; set; }
        public long? OldDbid { get; set; }
        public int? LocalId { get; set; }

        public virtual BaseValueType BaseValueType { get; set; }
        public virtual ICollection<Drug> Drugs { get; set; }
        public virtual ICollection<MedicalCenter> MedicalCenterCenterTypes { get; set; }
        public virtual ICollection<MedicalCenter> MedicalCenterOwnerShipBases { get; set; }
        public virtual ICollection<MedicalCenter> MedicalCenterWorkTimeBases { get; set; }
        public virtual ICollection<MedicalStaff> MedicalStaffs { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
        public virtual ICollection<Person> PersonExpertises { get; set; }
        public virtual ICollection<Person> PersonMaritalBases { get; set; }
        public virtual ICollection<Person> PersonSexBases { get; set; }
    }
}
