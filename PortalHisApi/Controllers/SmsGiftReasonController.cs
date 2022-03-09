using Business.SMSManagment.Extensions;
using Business.SMSManagment.IServices;
using Business.SMSManagment.Models;
using Business.SMSManagment.Services;
using DataAccess.Entities.His.Entities;
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
    public class SmsGiftReasonController : ControllerBase
    {
        private readonly IBasicService<SmsGiftReason> _basicService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="basicService"></param>
        public SmsGiftReasonController(IBasicService<SmsGiftReason> basicService)
        {
            _basicService = basicService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
       
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _basicService.GetById(id);
            return new CustomActionResult(result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
      
        [HttpGet("List")]
        public async Task<IActionResult> List()
        {
            var result = await _basicService.GetAll();
            return new CustomActionResult(result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseRequestPost"></param>
        /// <returns></returns>
        
        [HttpPost("List")]
        public async Task<IActionResult> ListPaging(BaseRequestPost<int> baseRequestPost)
        {
            var result = await _basicService.GetListPaging(baseRequestPost);
            return new CustomActionResult(result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestBaseDto"></param>
        /// <returns></returns>
         
        [HttpPost]
        public async Task<IActionResult> Add(RequestBaseDto requestBaseDto)
        {
            var result = await _basicService.AddAsync(requestBaseDto);
            return new CustomActionResult(result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestBaseDto"></param>
        /// <returns></returns>
      
        [HttpPut]
        public async Task<IActionResult> Edit(RequestBaseDto requestBaseDto)
        {
            var result = await _basicService.EditAsync(requestBaseDto);
            return new CustomActionResult(result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseRequestPost"></param>
        /// <returns></returns>
      
        [HttpDelete]
        public async Task<IActionResult> Delete(BaseRequestPost<int> baseRequestPost)
        {
            var result = await _basicService.DeleteAsync(baseRequestPost);
            return new CustomActionResult(result);
        }
    }
}
