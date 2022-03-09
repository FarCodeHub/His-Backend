using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities.His.Entities
{
    public partial class CenterLocation
    {
        public int Id { get; set; }
        public int? LocationId { get; set; }
        public string Address { get; set; }
        public int? CenterId { get; set; }
        public int? CountryId { get; set; }
        public int? ProvinceId { get; set; }
        public int? CityId { get; set; }
        public int? ZoneId { get; set; }
        public string PostalCode { get; set; }
        public string AreaCode { get; set; }
        public int? LocalId { get; set; }

        public virtual MedicalCenter Center { get; set; }
        public virtual GeoLocation City { get; set; }
        public virtual GeoLocation Country { get; set; }
        public virtual GeoLocation Location { get; set; }
        public virtual GeoLocation Province { get; set; }
        public virtual GeoLocation Zone { get; set; }
    }
}
