
using DataAccess.Entities.His.Entities;
using DataAccess.Repositories.His;
using System.Data.Entity;
using System.Threading.Tasks;

namespace DataAccess.Repositories.EF.His
{


    public class PatientRepository : GenericRepository<Patient>, IPatientRepository
    {
     
        public PatientRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
          
        }
 

 
    }

}
