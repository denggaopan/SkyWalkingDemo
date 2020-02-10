using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Denggaopan.SkywalkingDemo.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Denggaopan.SkywalkingDemo.ServiceB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(int sleepSeconds)
        {
            Thread.Sleep(sleepSeconds * 1000);
            var res = HttpHelper.Get("http://localhost:54495/api/hi");
            return Ok($"B:Hello, I am Service B.{res}");
        }
    }
}