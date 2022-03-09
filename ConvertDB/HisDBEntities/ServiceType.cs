using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.HisDBEntities
{
    public partial class ServiceType
    {
        public ServiceType()
        {
            CenterServices = new HashSet<CenterService>();
            Receptions = new HashSet<Reception>();
            RequestServices = new HashSet<RequestService>();
            Services = new HashSet<Service>();
        }

        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public string LocalCode { get; set; }
        public string InternationalCode { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CenterService> CenterServices { get; set; }
        public virtual ICollection<Reception> Receptions { get; set; }
        public virtual ICollection<RequestService> RequestServices { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }
}
