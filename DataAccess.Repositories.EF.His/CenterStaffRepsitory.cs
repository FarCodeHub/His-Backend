
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;
using System;

namespace DataAccess.Repositories.EF.His
{


    public class CenterStaffRepository : GenericRepository<CenterStaff>, ICenterStaffRepository
    {

        public CenterStaffRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public override void Add(CenterStaff entity)
        {
            entity.EmployeeType = 1;
            entity.IsActive = true;
            entity.IsDelete = false;
            entity.ActiveTime = DateTime.Now;
            base.Add(entity);
        }

    }
}
