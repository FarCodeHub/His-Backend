
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class GeoLocationRepository : GenericRepository<GeoLocation>, IGeoLocationRepository
    {

        public GeoLocationRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
