using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VirtualClass.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("Get")]
        public IActionResult GetValues() 
        {
            return  Ok( new { value = "Values Ok" });
        }


        [Authorize]
        [HttpGet("Secret")]
        public IActionResult GetSecretValues()
        {
            return Ok(new { value = "Secret Values Ok" });
        }
    }
}
