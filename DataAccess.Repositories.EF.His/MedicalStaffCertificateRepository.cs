
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class MedicalStaffCertificateRepository : GenericRepository<MedicalStaffCertificate>, IMedicalStaffCertificateRepository
    {

        public MedicalStaffCertificateRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
