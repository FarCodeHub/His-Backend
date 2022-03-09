using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{
    public class ServiceTypeRepository : GenericRepository<ServiceType>, IServiceTypeRepository
    {
        public ServiceTypeRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }
}
