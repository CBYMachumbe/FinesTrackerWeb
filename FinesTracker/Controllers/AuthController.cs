using BusinessLogic.IService;
using Domain;
using FinesTracker.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinesTracker.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
       [HttpPost]
       [Route("Login")]
       public IActionResult Login([FromBody] LoginDTO user)
       {
            return Ok();
       }
    }
}
