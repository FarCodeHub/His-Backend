
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class BaseValueTypeRepository : GenericRepository<BaseValueType>, IBaseValueTypeRepository
    {

        public BaseValueTypeRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
