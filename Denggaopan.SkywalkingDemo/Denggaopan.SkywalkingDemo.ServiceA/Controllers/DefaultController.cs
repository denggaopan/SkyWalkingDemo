using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Denggaopan.SkywalkingDemo.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Denggaopan.SkywalkingDemo.ServiceA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {

        public IActionResult Get()
        {
            using(HttpClient client = new HttpClient())
            {
                var res1 = HttpHelper.Get("http://localhost:55247/api/hello?sleepSeconds=1");
                var res2 = HttpHelper.Get("http://localhost:55247/api/hello?sleepSeconds=2");
                var res3 = HttpHelper.Get2("http://localhost:55247/api/hello?sleepSeconds=3");
                var res4 = HttpHelper.Get2("http://localhost:55247/api/hello?sleepSeconds=7");
                var res5 = HttpHelper.Get3("http://localhost:55247/api/hello?sleepSeconds=6");
                var res6 = HttpHelper.Get3("http://localhost:55247/api/hello?sleepSeconds=1");
                var data = new { res1, res2, res3, res4, res5 ,res6};
                return Ok(data) ;
            }

        }

        
    }
}