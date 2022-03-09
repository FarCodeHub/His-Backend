using DataAccess.Entities.His.Entities;
using System.Threading.Tasks;

namespace DataAccess.Repositories.His
{
    public interface IPersonRepository : IRepository<Person>
    {
        Task<Person> GetPerson(int personId);
    }
}
