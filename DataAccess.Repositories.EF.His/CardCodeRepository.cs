
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class CardCodeRepository : GenericRepository<CardCode>, ICardCodeRepository
    {

        public CardCodeRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
