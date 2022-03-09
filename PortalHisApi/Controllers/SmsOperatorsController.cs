using Business.SMSManagment.IServices;
using Business.SMSManagment.Models;
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
    public class SmsOperatorsController : ControllerBase
    {
        private readonly IBasicService<SmsOperator> _basicService;
        private readonly ISmsOperators _smsOperators;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="basicService"></param>
        public SmsOperatorsController(IBasicService<SmsOperator> basicService,
            ISmsOperators smsOperators)
        {
            _basicService = basicService;
            _smsOperators = smsOperators;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
   
        [HttpGet("{id}")]
        public async Task<object> GetById(int id)
        {
            return await _smsOperators.GetById(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
       
        [HttpGet("List")]
        public async Task<object> List()
        {
            return await _smsOperators.List();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseRequestPost"></param>
        /// <returns></returns>
        //[CustomAuthorization()]
        //[HttpPost("List")]
        //public async Task<IActionResult> ListPaging(BaseRequestPost<int> baseRequestPost)
        //{
        //    var result = await _basicService.GetListPaging(baseRequestPost);
        //    return new CustomActionResult(result);
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestBaseDto"></param>
        /// <returns></returns>
      
        [HttpPost]
        public async Task<object> Add(SmsOperatorsDto requestBaseDto)
        {
            return await _smsOperators.Add(requestBaseDto);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestBaseDto"></param>
        /// <returns></returns>
      
        [HttpPut]
        public async Task<object> Edit(SmsOperatorsDto requestBaseDto)
        {
            return await _smsOperators.Edit(requestBaseDto);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseRequestPost"></param>
        /// <returns></returns>
       
        [HttpDelete]
        public async Task<object> Delete(BaseRequestPost<int> baseRequestPost)
        {
            return await _smsOperators.Delete(baseRequestPost);
        }
    }
}
