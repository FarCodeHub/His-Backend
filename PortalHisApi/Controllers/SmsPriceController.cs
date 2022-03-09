using Business.SMSManagment.IServices;
using Business.SMSManagment.Models;
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
    public class SmsPriceController : ControllerBase
    {
        private readonly ISmsPriceService _smsPriceService;

        public SmsPriceController(ISmsPriceService smsPriceService)
        {
            _smsPriceService = smsPriceService;
        }

  
        [HttpGet("{id}")]
        public async Task<object> GetById(int id)
        {
            return await _smsPriceService.GetById(id);
        }

       
        [HttpPost]
        public async Task<object> Add(SmsPriceDto dto)
        {
            return await _smsPriceService.Add(dto);
        }

    
        [HttpPut("")]
        public async Task<object> Edit(SmsPriceDto dto)
        {
            return await _smsPriceService.Edit(dto);
        }

        [HttpDelete]
        public async Task<object> Delete(BaseRequestPost<int> baseRequestPost)
        {
            return await _smsPriceService.Delete(baseRequestPost);
        }

        [HttpPost("Search")]
        public async Task<object> Search(SmsPriceDto dto)
        {
            return await _smsPriceService.Search(dto);
        }
    }
}
