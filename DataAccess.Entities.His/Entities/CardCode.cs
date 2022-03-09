using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Entities.His.Entities
{
    public partial class CardCode
    {
        public CardCode()
        {
            AspNetUsers = new HashSet<AspNetUser>();
            UserCardCodes = new HashSet<UserCardCode>();
            Users = new HashSet<User>();
        }

        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string HealthNumber { get; set; }
        public string Token { get; set; }
        public string Serial { get; set; }
        public bool IsUsed { get; set; }
        public bool? IsPrint { get; set; }
        public long? LocalId { get; set; }

        public virtual ICollection<AspNetUser> AspNetUsers { get; set; }
        public virtual ICollection<UserCardCode> UserCardCodes { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
