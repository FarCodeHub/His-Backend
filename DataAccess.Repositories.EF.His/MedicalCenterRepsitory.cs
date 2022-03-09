
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;
using System;

namespace DataAccess.Repositories.EF.His
{



    public class MedicalCenterRepository : GenericRepository<MedicalCenter>, IMedicalCenterRepository
    {

        public MedicalCenterRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }


    }


}
