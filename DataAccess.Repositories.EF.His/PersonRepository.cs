using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DataAccess.Repositories.EF.His
{


    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {

        public PersonRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
        public async Task<Person> GetPerson(int personId)
        {
            return await GetAll().FirstOrDefaultAsync(x => x.Id == personId);
        }
    }


}
