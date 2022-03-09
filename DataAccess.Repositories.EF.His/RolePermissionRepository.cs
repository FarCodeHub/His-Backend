
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{
    public class RolePermissionRepository : GenericRepository<RolePermission>, IRolePermissionRepository
    {
        public RolePermissionRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
