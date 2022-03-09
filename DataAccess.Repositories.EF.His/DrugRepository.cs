
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class DrugRepository : GenericRepository<Drug>, IDrugRepository
    {

        public DrugRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
