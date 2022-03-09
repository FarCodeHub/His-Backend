
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class FileRepository : GenericRepository<File>, IFileRepository
    {

        public FileRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
