using DataAccess.Entities.His.Entities;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities.His.HisEntities
{
     
    public class AppUser : IdentityUser<int>
    {
        public int PersonId { get; set; }
        public long CardCodeId { get; set; }
        public int SmsUserId { get; set; }
        public string SmsToken { get; set; }




    }
}
