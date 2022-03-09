using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{
    public class ReceptionRepository : GenericRepository<Reception>, IReceptionRepository
    {

        public ReceptionRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
