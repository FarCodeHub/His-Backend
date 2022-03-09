
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class RhRepository : GenericRepository<Rh>, IRhRepository
    {

        public RhRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
