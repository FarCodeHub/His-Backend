
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class DataTransferConvertRepository : GenericRepository<DataTransferConvert>, IDataTransferConvertRepository
    {

        public DataTransferConvertRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
