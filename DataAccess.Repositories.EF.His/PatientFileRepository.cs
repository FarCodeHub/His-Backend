
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class PatientFileRepository : GenericRepository<PatientFile>, IPatientFileRepository
    {

        public PatientFileRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
