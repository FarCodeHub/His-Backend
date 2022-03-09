using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities.His.Entities
{
    public partial class MedicalCenter
    {
        public MedicalCenter()
        {
            BuyMessages = new HashSet<BuyMessage>();
            CenterLocations = new HashSet<CenterLocation>();
            CenterServices = new HashSet<CenterService>();
            CenterSpecialities = new HashSet<CenterSpeciality>();
            CenterStaffs = new HashSet<CenterStaff>();
            Files = new HashSet<File>();
            InverseParent = new HashSet<MedicalCenter>();
            Prescriptions = new HashSet<Prescription>();
            Receptions = new HashSet<Reception>();
            Schedules = new HashSet<Schedule>();
        }

        public int Id { get; set; }
        public int? ParentId { get; set; }
        public int? CenterTypeId { get; set; }
        public string Title { get; set; }
        public int? BossId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public string AnswerTime { get; set; }
        public string PhoneResponseHourse { get; set; }
        public bool? IsFreeDelivery { get; set; }
        public string Fax { get; set; }
        public string Note { get; set; }
        public string Boss { get; set; }
        public string BossPhone { get; set; }
        public int? OwnerShipBaseId { get; set; }
        public int? WorkTimeBaseId { get; set; }
        public string Code { get; set; }
        public string VisitorPhone { get; set; }
        public DateTime? CreateTime { get; set; }
        public decimal? CostVisit { get; set; }
        public int? LocalId { get; set; }
        public bool? IsHomeDelivery { get; set; }

        public virtual BaseValue CenterType { get; set; }
        public virtual BaseValue OwnerShipBase { get; set; }
        public virtual MedicalCenter Parent { get; set; }
        public virtual BaseValue WorkTimeBase { get; set; }
        public virtual ICollection<BuyMessage> BuyMessages { get; set; }
        public virtual ICollection<CenterLocation> CenterLocations { get; set; }
        public virtual ICollection<CenterService> CenterServices { get; set; }
        public virtual ICollection<CenterSpeciality> CenterSpecialities { get; set; }
        public virtual ICollection<CenterStaff> CenterStaffs { get; set; }
        public virtual ICollection<File> Files { get; set; }
        public virtual ICollection<MedicalCenter> InverseParent { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
        public virtual ICollection<Reception> Receptions { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
