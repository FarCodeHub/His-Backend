
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class PrescriptionDetailDrugRepository : GenericRepository<PrescriptionDetailDrug>, IPrescriptionDetailDrugRepository
    {

        public PrescriptionDetailDrugRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }

}
