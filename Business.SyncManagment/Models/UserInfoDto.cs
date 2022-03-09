using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SyncManagment.Models
{
    public class UserInfoDto
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string RoleId { get; set; }
        public string SectionId { get; set; }
        public string RoleName { get; set; }
        public string RoleCode { get; set; }
        public string NhsNumber { get; set; }
        public string CardExpireDate { get; set; }
        public int? CenterId { get; set; }
        public object Permissions { get; set; }
    }
}
