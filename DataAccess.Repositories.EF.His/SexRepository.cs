
using DataAccess.Entities.His.HisDBEntities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class SexRepository : GenericRepository<Sex>, ISexRepository
    {

        public SexRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
