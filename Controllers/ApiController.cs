using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewApp.Controllers
{        
    [Route("api/[controller]")]
    [ApiController]

    public class ApiController : Controller
    {
        public IActionResult Random()
        {
            return View();
        }
        

        [HttpGet("GetValue")]
        public int GetValue()
        {
            Random rnd = new Random();
            return rnd.Next(20)+1;
        }
    }
}
