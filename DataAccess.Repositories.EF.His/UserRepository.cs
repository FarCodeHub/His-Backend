using DataAccess.Entities.His.Entities;
 
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }

}
