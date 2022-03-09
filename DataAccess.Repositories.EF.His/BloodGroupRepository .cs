
using DataAccess.Entities.His.HisDBEntities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class BloodGroupRepository : GenericRepository<BloodGroup>, IBloodGroupRepository
    {

        public BloodGroupRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
