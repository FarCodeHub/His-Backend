
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class BaseValueRepository : GenericRepository<BaseValue>, IBaseValueRepository
    {

        public BaseValueRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
