
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class SmsGiftReasonRepository : GenericRepository<SmsGiftReason>, ISmsGiftReasonRepository
    {

        public SmsGiftReasonRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
