using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.PortalEntities
{
    public partial class Center
    {
        public Center()
        {
            BuyMessages = new HashSet<BuyMessage>();
            CenterExamPlaces = new HashSet<CenterExamPlace>();
            CenterSellingTypes = new HashSet<CenterSellingType>();
            CenterServices = new HashSet<CenterService>();
            CenterWorkItems = new HashSet<CenterWorkItem>();
            Doctors = new HashSet<Doctor>();
            Sections = new HashSet<Section>();
            Settings = new HashSet<Setting>();
            SmsCenterBalances = new HashSet<SmsCenterBalance>();
            SmsCenterCharges = new HashSet<SmsCenterCharge>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public int? EconomicalId { get; set; }
        public string Boss { get; set; }
        public string BossPhone { get; set; }
        public string VisitorOrManaging { get; set; }
        public string VisitorPhone { get; set; }
        public int? CenterTypeId { get; set; }
        public int? WorkTimeTypeId { get; set; }
        public int? OwnershipTypeId { get; set; }
        public int? CityId { get; set; }
        public int? CountryId { get; set; }
        public int? ProvinceId { get; set; }
        public int? ZoneId { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string PostalCode { get; set; }
        public string AreaCode { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string WorkingHours { get; set; }
        public string PhoneResponseHourse { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsFreeDelivery { get; set; }
        public string ExamTime { get; set; }
        public string AnswerTime { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Note { get; set; }
        public bool? IsHomeDelivery { get; set; }
        public bool? IsOnlineService { get; set; }
        public bool? IsOfflineService { get; set; }
        public int? ParentId { get; set; }

        public virtual CenterType CenterType { get; set; }
        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual OwnershipType OwnershipType { get; set; }
        public virtual Province Province { get; set; }
        public virtual WorkTimeType WorkTimeType { get; set; }
        public virtual Zone Zone { get; set; }
        public virtual ICollection<BuyMessage> BuyMessages { get; set; }
        public virtual ICollection<CenterExamPlace> CenterExamPlaces { get; set; }
        public virtual ICollection<CenterSellingType> CenterSellingTypes { get; set; }
        public virtual ICollection<CenterService> CenterServices { get; set; }
        public virtual ICollection<CenterWorkItem> CenterWorkItems { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
        public virtual ICollection<Section> Sections { get; set; }
        public virtual ICollection<Setting> Settings { get; set; }
        public virtual ICollection<SmsCenterBalance> SmsCenterBalances { get; set; }
        public virtual ICollection<SmsCenterCharge> SmsCenterCharges { get; set; }
    }
}
