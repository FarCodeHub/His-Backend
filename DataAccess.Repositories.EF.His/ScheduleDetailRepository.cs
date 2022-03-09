using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{
    public class ScheduleDetailRepository : GenericRepository<ScheduleDetail>, IScheduleDetailRepository
    {
        public ScheduleDetailRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
