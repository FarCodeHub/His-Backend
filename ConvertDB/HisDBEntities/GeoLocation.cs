using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.HisDBEntities
{
    public partial class GeoLocation
    {
        public GeoLocation()
        {
            CenterLocationCities = new HashSet<CenterLocation>();
            CenterLocationCountries = new HashSet<CenterLocation>();
            CenterLocationLocations = new HashSet<CenterLocation>();
            CenterLocationProvinces = new HashSet<CenterLocation>();
            CenterLocationZones = new HashSet<CenterLocation>();
            InverseParent = new HashSet<GeoLocation>();
        }

        public int Id { get; set; }
        public int? ParentId { get; set; }
        public int Type { get; set; }
        public string Title { get; set; }
        public string TitleLang2 { get; set; }
        public int? LocalId { get; set; }

        public virtual GeoLocation Parent { get; set; }
        public virtual ICollection<CenterLocation> CenterLocationCities { get; set; }
        public virtual ICollection<CenterLocation> CenterLocationCountries { get; set; }
        public virtual ICollection<CenterLocation> CenterLocationLocations { get; set; }
        public virtual ICollection<CenterLocation> CenterLocationProvinces { get; set; }
        public virtual ICollection<CenterLocation> CenterLocationZones { get; set; }
        public virtual ICollection<GeoLocation> InverseParent { get; set; }
    }
}
