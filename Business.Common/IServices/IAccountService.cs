
using Business.Common.Models;
using Core.His.Models;
using System.Threading.Tasks;

namespace Business.Common.IServices
{
    public interface IAccountService
    {

        Task<ResponseResult> Login(UserModel userModel);
        /// <summary>
        /// Add Person ----
        /// </summary>
        /// <param name="personModel">Person Model</param>
        /// <returns>ResponseResult(PersonModel)</returns>
        Task<ResponseResult> AddPerson(PersonModel personModel);
        /// <summary>
        /// Add User (First Add Person Then Add User)----
        /// </summary>
        /// <param name="addUser">User Model</param>
        /// <returns>ResponseResult(UserModel)</returns>
        Task<ResponseResult> AddUser(UserModel addUser);
        /// <summary>
        /// Get the list of all users----
        /// </summary>
        /// <returns>ResponseResult(UserModel)</returns>
        Task<ResponseResult> GetUsers();
        /// <summary>
        /// Get the list of all person in a center ----
        /// </summary>
        /// <param name="centerId">centerId</param>
        /// <returns>ResponseResult(PersonModel)</returns>
        Task<ResponseResult> GetPersonsBy(int centerId);
        Task<ResponseResult> ChangeAvatar(string fileName, int personId);
        Task<ResponseResult> EditUser(UserModel user);


    }
  
}
