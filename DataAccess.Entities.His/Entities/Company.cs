using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities.His.Entities
{
    public partial class Company
    {
        public Company()
        {
            Drugs = new HashSet<Drug>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public string NationalId { get; set; }
        public int? EconomicalId { get; set; }
        public string Boss { get; set; }
        public string Visitor { get; set; }
        public string BossPhone { get; set; }
        public string VisitorPhone { get; set; }
        public int? CountryId { get; set; }
        public string Phone { get; set; }
        public string PostalCode { get; set; }
        public string Fax { get; set; }
        public int? ComponyPersonalityId { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
        public int? LocalId { get; set; }

        public virtual ICollection<Drug> Drugs { get; set; }
    }
}
