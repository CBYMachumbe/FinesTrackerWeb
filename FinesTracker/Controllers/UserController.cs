using BusinessLogic.IService;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinesTracker.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService _userService)
        {
            this._userService = _userService;
        }

        [HttpGet("GetAllUsers")]
        public IActionResult GetUsers([FromQuery] int page, int pageLength)
        {
            return Ok(_userService.GetUsers(page, pageLength));
        }

        [HttpGet("GetById/{id}")]
        public IActionResult FindById([FromRoute] int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var user = _userService.FindUserById(id);

            if (user == null) return NotFound();

            return Ok(user);
        }

        [HttpPut("UpdateUser")]
        public IActionResult UpdateFine([FromBody] User user)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            _userService.UpdateUser(user);

            return Ok();
        }

        [HttpPost]
        public IActionResult PostUser([FromBody] User user)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            _userService.InsertUser(user);

            return Ok();
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult DeleteFine([FromRoute] int id)
        {
            _userService.DeleteUser(id);
            return Ok();
        }

    }
}
