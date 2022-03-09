
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class PatientExtraInfoRepository : GenericRepository<PatientExtraInfo>, IPatientExtraInfoRepository
    {

        public PatientExtraInfoRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
