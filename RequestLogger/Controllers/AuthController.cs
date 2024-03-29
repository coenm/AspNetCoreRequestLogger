﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RequestLogger.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Get()
        {
            return Ok("OK");
        }
    }
}
