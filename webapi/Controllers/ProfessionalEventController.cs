using Microsoft.AspNetCore.Mvc;
using webapi.Entities;
using webapi.Interfaces;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfessionalEventController : BaseController
    {
        private readonly IProfessionalEventService _professionalEventService;

        public ProfessionalEventController(IProfessionalEventService professionalEventService)
        {
            _professionalEventService = professionalEventService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllEvents()
        {
            return Ok(await _professionalEventService.GetAllEventsAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEventById(int id)
        {
            var professionalEvent = await _professionalEventService.GetEventByIdAsync(id);
            if (professionalEvent == null) return NotFound();
            return Ok(professionalEvent);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEvent(ProfessionalEvent newEvent)
        {
            await _professionalEventService.CreateEventAsync(newEvent);
            return CreatedAtAction(nameof(GetEventById), new { id = newEvent.Id }, newEvent);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEvent(int id, ProfessionalEvent updatedEvent)
        {
            if (id != updatedEvent.Id) return BadRequest();
            await _professionalEventService.UpdateEventAsync(updatedEvent);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            await _professionalEventService.DeleteEventAsync(id);
            return NoContent();
        }
    }
}
