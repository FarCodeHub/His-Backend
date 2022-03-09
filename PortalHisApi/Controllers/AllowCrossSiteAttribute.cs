using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalHisApi.Controllers
{
    public class AllowCrossSiteAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //filterContext.RequestContext.HttpContext.Response.AddHeader("Access-Control-Allow-Origin", "*");
            //filterContext.RequestContext.HttpContext.Response.AddHeader("Access-Control-Allow-Headers", "*");
            //filterContext.RequestContext.HttpContext.Response.AddHeader("Access-Control-Allow-Credentials", "true");

            base.OnActionExecuting(filterContext);
        }
    }
}
