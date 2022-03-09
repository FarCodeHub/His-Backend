
using DataAccess.Entities.His.HisDBEntities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class EducationRepository : GenericRepository<Education>, IEducationRepository
    {

        public EducationRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
