using Microsoft.AspNetCore.Mvc;
using webapi.Interfaces;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CVController : ControllerBase
    {
        private readonly ICVParserService _cvParserService;

        public CVController(ICVParserService cvParserService)
        {
            _cvParserService = cvParserService;
        }

        [HttpGet("parse")]
        public async Task<ActionResult<(string FirstName, string LastName)>> ParseCV([FromQuery] string cvUrl)
        {
            if (string.IsNullOrWhiteSpace(cvUrl))
            {
                return BadRequest("URL do CV jest wymagany.");
            }

            var result = await _cvParserService.ExtractNameFromCVAsync(cvUrl);

            if (result.FirstName == null || result.LastName == null)
            {
                return NotFound("Nie udało się znaleźć imienia i nazwiska w CV.");
            }

            return Ok(result);
        }
    }
}
