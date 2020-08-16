using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreakStreet.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreakStreet.Server.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login(LoginModel model)
        {
            return Ok(model);
        }
    }
}