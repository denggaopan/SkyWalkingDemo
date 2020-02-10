using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Denggaopan.SkywalkingDemo.ServiceC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NihaoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok($"C:你好，我是C！");
        }
    }
}