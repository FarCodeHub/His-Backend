
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class PermissionRepository : GenericRepository<Permission>, IPermissionRepository
    {

        public PermissionRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
