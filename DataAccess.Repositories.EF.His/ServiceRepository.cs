
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class ServiceRepository : GenericRepository<Service>, IServiceRepository
    {

        public ServiceRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
