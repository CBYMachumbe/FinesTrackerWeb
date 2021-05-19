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
    public class VoteController : ControllerBase
    {
        private readonly IVotesService _voteService;

        public VoteController(IVotesService _voteService)
        {
            this._voteService = _voteService;
        }

        [HttpPost("AddNewVote")]
        public IActionResult PostVost([FromBody] Vote vote)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            _voteService.InsertVote(vote);
            return Ok();
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult DeleteFine([FromRoute] int id)
        {

            _voteService.DeleteVote(id);

            return Ok();
        }

    }
}
