
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class CenterSpecialityRepository : GenericRepository<CenterSpeciality>, ICenterSpecialityRepository
    {

        public CenterSpecialityRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
