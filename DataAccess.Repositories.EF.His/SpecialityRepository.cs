
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{
    public class SpecialityRepository : GenericRepository<Speciality>, ISpecialityRepository
    {

        public SpecialityRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }
}
