using DataAccess.Entities.His;
using DataAccess.Entities.His.Entities;
using System.Threading.Tasks;

namespace DataAccess.Repositories.His
{
    public interface IUnitOfWork
    {
        PortalHisContext DatabaseContext { get; }

        void ResetDatabaseContext();

        Task Save();
    }
}
