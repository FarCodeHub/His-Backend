using Business.Common.Models;
using Core.His.Models;
using System.Threading.Tasks;

namespace Business.Common.IServices
{
    public interface IMainService
    {
        Task<ResponseResult> GetMenuItems(UserModel userModel);
    }
}
