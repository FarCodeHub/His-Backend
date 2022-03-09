using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SyncManagment.IServices
{
    public interface IWorkContextService
    {
        string Token { get; }
        string UserName { get; }
        int? UserId { get; }
        int? RoleId { get; }
        int? SectionId { get; }
        int? CenterId { get; }
        string Language { get; }
    }
}
