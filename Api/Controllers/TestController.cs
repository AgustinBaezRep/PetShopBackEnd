using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyCors")]

    public class TestController : ControllerBase
    {
        [HttpGet("GetTest")]
        public ActionResult<Data.Context.Test> Get()
        {
            var ret = new List<Data.Context.Test>();
            using (var ctx = new Data.Context.ecommerceContext())
            {
                ret = ctx.Tests.ToList();
            }

            return Ok(ret);
        }
    }
}
