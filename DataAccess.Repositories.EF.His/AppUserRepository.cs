
using DataAccess.Entities.His.Entities;
using DataAccess.Entities.His.HisEntities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class AppUserRepository : GenericRepository<AppUser>, IAppUserRepository
    {

        public AppUserRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
