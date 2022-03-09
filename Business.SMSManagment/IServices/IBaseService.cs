using Business.SMSManagment.Models;
using DataAccess.Repositories.His;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.SMSManagment.IServices
{
 
    public interface IBasicService <T> :IRepository <T>  where T : class, new()
    {
        Task<BaseResponseDto> GetById(int id);
        Task<ListResponseDto> Search(RequestBaseFilterDto requestFilterBaseDto);
        Task<BaseResponseDto> GetAll(bool? isActive = null);
        Task<ListResponseDto> GetListPaging(IPaging paging);
        Task<BaseResponseDto> AddAsync(RequestBaseDto baseDto);
        Task<BaseResponseDto> DeleteAsync(BaseRequestPost<int> baseRequestPost);
        Task<BaseResponseDto> EditAsync(RequestBaseDto baseDto);
        
    }
}
