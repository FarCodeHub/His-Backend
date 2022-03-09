﻿
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class PrescriptionServiceResultRepository : GenericRepository<PrescriptionServiceResult>, IPrescriptionServiceResultRepository
    {

        public PrescriptionServiceResultRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
