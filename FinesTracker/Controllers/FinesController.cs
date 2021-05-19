using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.IService;
using Domain;
using FinesTracker.DTO;
using FinesTracker.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using Persistence;

namespace FinesTracker.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FinesController : ControllerBase
    {
        private readonly FinesTrackerContext _context;
        private readonly IFinesService _finesService;



        public FinesController(FinesTrackerContext context, IFinesService finesService)
        {
            _context = context;
            _finesService = finesService;
        }

        [HttpGet("GetAllFines")]
        public IActionResult GetFines([FromQuery] int page, int pageLength)
        {
            return Ok(_finesService.GetFines(page, pageLength));
        }

        [HttpGet("GetById/{id}")]
        public IActionResult FindById([FromRoute] int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var fines = _finesService.FindFineById(id);

            if (fines == null) return NotFound();

            return Ok(fines);
        }

        [HttpPut("UpdateFine/{id}")]
        public IActionResult UpdateFine([FromRoute] int id, [FromBody] FinesDTO finesDTO)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            _finesService.UpdateFine(FinesMapper.MapToFines(finesDTO));

            return Ok();
        }

        [HttpPost]
        public IActionResult PostFines ([FromBody] FinesDTO finesDTO)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            _finesService.InsertFine(FinesMapper.MapToFines(finesDTO));

            return Ok();
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult DeleteFine([FromRoute] int id)
        {

     
            _finesService.DeleteFine(id);

            return Ok();
        }
    }
}
