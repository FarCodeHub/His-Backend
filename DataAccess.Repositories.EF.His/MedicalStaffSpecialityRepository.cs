
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class MedicalStaffSpecialityRepository : GenericRepository<MedicalStaffSpeciality>, IMedicalStaffSpecialityRepository
    {

        public MedicalStaffSpecialityRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
