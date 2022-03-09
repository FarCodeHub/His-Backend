using System;
using System.Collections.Generic;

#nullable disable

namespace ConvertDB.HisDBEntities
{
    public partial class User
    {
        public User()
        {
            Prescriptions = new HashSet<Prescription>();
            UserCardCodes = new HashSet<UserCardCode>();
            UserRoles = new HashSet<UserRole>();
        }

        public int Id { get; set; }
        public int? PersonId { get; set; }
        public long? CardCodeId { get; set; }
        public bool? IsActive { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsVerify { get; set; }
        public string MacAddress { get; set; }
        public bool? IsSync { get; set; }
        public int? SmsUserId { get; set; }
        public string SmsToken { get; set; }
        public int? LocalId { get; set; }

        public virtual CardCode CardCode { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
        public virtual ICollection<UserCardCode> UserCardCodes { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
