
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class CenterTypeRepository : GenericRepository<CenterType>, ICenterTypeRepository
    {

        public CenterTypeRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
