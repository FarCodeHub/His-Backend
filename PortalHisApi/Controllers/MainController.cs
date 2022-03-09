using Business.Common.IServices;
using Business.Common.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalHisApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
 
    public class MainController : Controller
    {
        private readonly IMainService mainService;

        public MainController(IMainService mainService)
        {
            this.mainService = mainService;
        }


        public async Task<JsonResult> GetMenuItems(UserModel userModel) 
        {
            var result = await mainService.GetMenuItems(userModel);
            return Json(result);
        }

    }
}
