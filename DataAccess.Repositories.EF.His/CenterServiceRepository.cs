
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class CenterServiceRepository : GenericRepository<CenterService>, ICenterServiceRepository
    {

        public CenterServiceRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
