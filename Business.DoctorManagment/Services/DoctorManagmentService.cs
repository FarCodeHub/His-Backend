using Business.DoctorManagment.IServices;
using DataAccess.Repositories.His;

namespace Business.DoctorManagment.Services
{
    public class DoctorManagmentService : IDoctorManagmentService
    {
        private readonly IUnitOfWork unitOfWork;

        public DoctorManagmentService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        // Functions 
    }
}
