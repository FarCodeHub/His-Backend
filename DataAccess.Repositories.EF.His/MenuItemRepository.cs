
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;

namespace DataAccess.Repositories.EF.His
{


    public class MenuItemRepository : GenericRepository<MenuItem>, IMenuItemRepository
    {

        public MenuItemRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

    }

}
