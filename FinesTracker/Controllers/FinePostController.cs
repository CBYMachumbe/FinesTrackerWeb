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
    public class FinePostController : ControllerBase
    {
        private readonly IFinePostService _finePostService;
        public FinePostController(IFinePostService finePostService)
        {
            _finePostService = finePostService;
        }

        [HttpGet("GetAllFinePosts")]
        public IActionResult GetAllFinePosts([FromQuery] int page, int pageLength)
        {
            return Ok(_finePostService.GetFinePosts(page, pageLength));
        }

        [HttpGet("GetById/{id}")]
        public IActionResult FindById([FromRoute] int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var fines = _finePostService.FindFineById(id);

            if (fines == null) return NotFound();

            return Ok(fines);
        }

        [HttpGet("GetTally")]
        public IActionResult GetTally()
        {
            return Ok(_finePostService.GetTallyObjects());
        }


        [HttpPut("UpdateFine")]
        public IActionResult UpdateFine([FromBody] FinePost finePost)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

           _finePostService.UpdateFinePost(finePost);

            return Ok();
        }

        [HttpPost("AddNewFine")]
        public IActionResult PostFinePost([FromBody] FinePost finePost)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            _finePostService.InsertFinePost(finePost);

            return Ok();
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult DeleteFine([FromRoute] int id)
        {

            _finePostService.DeleteFinePost(id);

            return Ok();
        }
    }
}
