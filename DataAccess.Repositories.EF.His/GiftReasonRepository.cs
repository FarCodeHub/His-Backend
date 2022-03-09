
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class GiftReasonRepository : GenericRepository<GiftReason>, IGiftReasonRepository
    {

        public GiftReasonRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
