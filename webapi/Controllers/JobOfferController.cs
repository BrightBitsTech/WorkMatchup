using Microsoft.AspNetCore.Mvc;
using webapi.Entities;
using webapi.Interfaces;

namespace webapi.Controllers
{
    [ApiController]
    [Route("JobOffer/[controller]")]
    public class JobOfferController : BaseController
    {
        private readonly IJobOfferService _jobOfferService;
        public JobOfferController(IJobOfferService jobOfferService)
        {
            _jobOfferService = jobOfferService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllJobOffers()
        {
            return Ok(await _jobOfferService.GetAllJobOffersAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetJobOfferById(int id)
        {
            var jobOffer = await _jobOfferService.GetJobOfferByIdAsync(id);
            if (jobOffer == null) return NotFound();
            return Ok(jobOffer);
        }
        [HttpPost]
        public async Task<IActionResult> CreateJobOffer(JobOffer newJobOffer)
        {
            await _jobOfferService.CreateJobOfferAsync(newJobOffer);
            return CreatedAtAction(nameof(GetJobOfferById), new { id = newJobOffer.Id }, newJobOffer);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateJobOffer(int id, JobOffer updatedJobOffer)
        {
            if (id != updatedJobOffer.Id) return BadRequest();
            await _jobOfferService.UpdateJobOfferAsync(updatedJobOffer);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJobOffer(int id)
        {
            await _jobOfferService.DeleteJobOfferAsync(id);
            return NoContent();
        }
    }
}
