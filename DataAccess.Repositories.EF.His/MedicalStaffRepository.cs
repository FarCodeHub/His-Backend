
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class MedicalStaffRepository : GenericRepository<MedicalStaff>, IMedicalStaffRepository
    {

        public MedicalStaffRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
