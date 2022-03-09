using Business.Common.IServices;
using Business.Common.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace PortalHisApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
 
    public class UserController : Controller
    {

        private readonly IAccountService accountService;
        private readonly ILogger<ApiController> logger;
        public UserController(ILogger<ApiController> logger, IAccountService accountService)
        {

            this.accountService = accountService;
            this.logger = logger;
        }


        public async Task<JsonResult> AddUser(UserModel userModel)
        {
            var result = await accountService.AddUser(userModel);
            return Json(result);
        }

        public async Task<JsonResult> GetUsers()
        {
            var result = await accountService.GetUsers();
            return Json(result);
        
        }

        public async Task<JsonResult> EditUser(UserModel user)
        {
            var result = await accountService.EditUser(user);
            return Json(result);
        
        }
    }
}
