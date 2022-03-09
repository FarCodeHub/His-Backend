
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;
using System.Threading.Tasks;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
namespace DataAccess.Repositories.EF.His
{


    public class CenterLocationRepository : GenericRepository<CenterLocation>, ICenterLocationRepository
    {

        public CenterLocationRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public Task<CenterLocation> FindByCenterId(long centerId)
        {
          return  this.UnitOfWork.DatabaseContext.CenterLocations.FirstOrDefaultAsync(x => x.CenterId == centerId);
        }
    }

}
