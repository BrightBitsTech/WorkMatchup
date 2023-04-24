using Microsoft.AspNetCore.Mvc;
using webapi.Interfaces;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserServiceController : BaseController
    {
        private readonly IUserRecommendationService _userRecommendationService;

        public UserServiceController(IUserRecommendationService userRecommendationService)
        {
            _userRecommendationService = userRecommendationService;
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetRecommendedJobs(int userId)
        { 
            var recommendedJobs = await _userRecommendationService.GetRecommendedJobsAsync(userId);
            if (recommendedJobs == null) return NotFound();
            return Ok(recommendedJobs);
        }
    }
}

