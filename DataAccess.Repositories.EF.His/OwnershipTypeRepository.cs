
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class OwnershipTypeRepository : GenericRepository<OwnershipType>, IOwnershipTypeRepository
    {

        public OwnershipTypeRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
