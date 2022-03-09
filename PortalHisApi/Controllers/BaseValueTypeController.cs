using Business.Common.IServices;
using Business.Common.Models;
using Core.His.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PortalHisApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class BaseValueTypeController : ControllerBase
    {
        private readonly ICommonService commonService;

        public BaseValueTypeController(ICommonService commonService)
        {
            this.commonService = commonService;
        }

        // GET: api/<BaseValueTypeController>
        [HttpGet]
        public async Task<ResponseResult> Get()
        {
            var result = await commonService.GetBaseValueTypes();
            return  result ;
        }

        // GET api/<BaseValueTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BaseValueTypeController>
        [HttpPost]
        public async Task<ResponseResult> Post([FromBody] BaseValueTypeModel baseValueType)
        {
            var result = await commonService.AddBaseValueType(baseValueType);
            return  result ;
        }

        // PUT api/<BaseValueTypeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BaseValueTypeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
