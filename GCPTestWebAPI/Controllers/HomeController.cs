using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GCPTestWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetServerTime()
        {
            string currDatetime = "Current UTC Date Time is:" + DateTime.UtcNow.ToLongDateString();
            return Ok(currDatetime);
        }
    }
}