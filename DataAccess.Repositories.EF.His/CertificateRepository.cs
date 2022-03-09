
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class CertificateRepository : GenericRepository<Certificate>, ICertificateRepository
    {

        public CertificateRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
