
using DataAccess.Entities.His.HisDBEntities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class WorkTimeTypeRepository : GenericRepository<WorkTimeType>, IWorkTimeTypeRepository
    {

        public WorkTimeTypeRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
