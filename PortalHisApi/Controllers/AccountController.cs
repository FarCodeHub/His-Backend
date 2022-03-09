using Business.Common.IServices;
using Business.Common.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalHisApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
   
    public class AccountController : Controller
    {
        private readonly IAccountService accountService;
        private readonly ILogger<ApiController> _logger;
        public AccountController(ILogger<ApiController> logger, IAccountService accountService)
        {

            this.accountService = accountService;
            _logger = logger;
        }
        public async Task<JsonResult> AddPerson(PersonModel personModel)
        {
            var result = await accountService.AddPerson(personModel);
            return Json(result);
        }

        public async Task<JsonResult> GetPersonsBy(int centerId)
        {
            
            var result = await accountService.GetPersonsBy(centerId);
             
            return Json(result);
        }


    }
}
