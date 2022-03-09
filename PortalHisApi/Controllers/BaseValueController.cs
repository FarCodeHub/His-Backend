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
 

    public class BaseValueController : ControllerBase
    {

        private readonly ICommonService commonService;


        public BaseValueController(ICommonService commonService)
        {
            this.commonService = commonService;

        }

        // GET: api/<BaseValueController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BaseValueController>/5
        [HttpGet("{typeId}")]
        public async Task<ResponseResult> Get(int typeId)
        {
            var result = await commonService.GetBaseValuesBy(typeId);
            return  result ;
        }

        // POST api/<BaseValueController>
        [HttpPost]
        public async Task<ResponseResult> Post([FromBody] BaseValueModel baseValue)
        {
            var result = await commonService.AddBaseValue(baseValue);
            return  result ;
        }

        // PUT api/<BaseValueController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BaseValueController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
