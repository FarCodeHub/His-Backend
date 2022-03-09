
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class PrescriptionRepository : GenericRepository<Prescription>, IPrescriptionRepository
    {

        public PrescriptionRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
