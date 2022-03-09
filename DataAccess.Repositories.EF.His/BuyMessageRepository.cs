
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class BuyMessageRepository : GenericRepository<BuyMessage>, IBuyMessageRepository
    {

        public BuyMessageRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
