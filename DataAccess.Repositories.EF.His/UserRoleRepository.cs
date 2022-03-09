
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class UserRoleRepository : GenericRepository<UserRole>, IUserRoleRepository
    {

        public UserRoleRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
