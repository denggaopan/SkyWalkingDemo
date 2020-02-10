using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Denggaopan.SkywalkingDemo.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Denggaopan.SkywalkingDemo.ServiceA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HiController : ControllerBase
    {
        [HttpGet]
        public IActionResult Hi()
        {
            var res = HttpHelper.Get("http://localhost:60800/api/nihao");
            return Ok($"A:Hi,I am Service A!{res}");
        }
    }
}