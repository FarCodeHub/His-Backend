using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{
    public class RequestServiceRepository : GenericRepository<RequestService>, IRequestServiceRepository
    {
        public RequestServiceRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }
}
