using Business.CenterManagment.Models;
using Business.Common.IServices;
using Core.His.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PortalHisApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
 

    public class GeoLocationController : ControllerBase
    {
        private readonly ICommonService commonService;
        public GeoLocationController(ICommonService commonService)
        {
            this.commonService = commonService;
        }
        // GET: api/<GeoLocationController>
        [HttpGet]
        public async Task<ResponseResult> Get()
        {
            var result = await commonService.GetGeoLocations();
            return  result;
        }

        // GET api/<GeoLocationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GeoLocationController>
        [HttpPost]
        public async Task<ResponseResult> Post([FromBody] GeoLocationModel geoLocation)
        {
            var result = await commonService.AddGeoLocation(geoLocation);
            return result;
        }
        // PUT api/<GeoLocationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GeoLocationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
