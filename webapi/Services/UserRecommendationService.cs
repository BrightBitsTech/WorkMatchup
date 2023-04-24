using webapi.Entities;
using webapi.Interfaces;

namespace webapi.Services
{
    public class UserRecommendationService : IUserRecommendationService
    {
        private readonly IAccountService _accountService;
        private readonly IJobOfferService _jobOfferService;

        public UserRecommendationService(IAccountService accountService, IJobOfferService jobOfferService)
        {
            _accountService = accountService;
            _jobOfferService = jobOfferService;
        }

        public async Task<IEnumerable<JobOffer>> GetRecommendedJobsAsync(int userId)
        {
            // Pobierz informacje o użytkowniku i dostępnych ofertach pracy
            var user =  _accountService.GetById(userId);
            var availableJobs = await _jobOfferService.GetAllJobOffersAsync();

            // Zaimplementuj algorytm rekomendacji ofert pracy
            // ...

            // Zwróć rekomendowane oferty pracy
            return availableJobs;
        }
    }
}
