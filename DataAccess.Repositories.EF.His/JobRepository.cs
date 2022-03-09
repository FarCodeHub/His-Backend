
using DataAccess.Entities.His.HisDBEntities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class JobRepository : GenericRepository<Job>, IJobRepository
    {

        public JobRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
