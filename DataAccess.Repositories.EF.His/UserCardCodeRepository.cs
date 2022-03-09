
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class UserCardCodeRepository : GenericRepository<UserCardCode>, IUserCardCodeRepository
    {

        public UserCardCodeRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
