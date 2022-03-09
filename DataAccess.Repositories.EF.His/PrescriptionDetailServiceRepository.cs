
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class PrescriptionDetailServiceRepository : GenericRepository<PrescriptionDetailService>, IPrescriptionDetailServiceRepository
    {

        public PrescriptionDetailServiceRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
