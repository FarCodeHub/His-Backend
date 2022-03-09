using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Company
    {
        public Company()
        {
            CompanyAndTypes = new HashSet<CompanyAndType>();
            Drugs = new HashSet<Drug>();
            PurchaseInvoices = new HashSet<PurchaseInvoice>();
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

        public virtual CompanyPersonality ComponyPersonality { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<CompanyAndType> CompanyAndTypes { get; set; }
        public virtual ICollection<Drug> Drugs { get; set; }
        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; set; }
    }
}
