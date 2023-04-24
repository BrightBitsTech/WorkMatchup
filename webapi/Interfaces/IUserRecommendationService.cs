using webapi.Entities;

namespace webapi.Interfaces
{
    public interface IUserRecommendationService
    {
        Task<IEnumerable<JobOffer>> GetRecommendedJobsAsync(int userId);
    }
}
