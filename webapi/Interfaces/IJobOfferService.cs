using webapi.Entities;

namespace webapi.Interfaces
{
    public interface IJobOfferService
    {
        Task<IEnumerable<JobOffer>> GetAllJobOffersAsync();
        Task<JobOffer> GetJobOfferByIdAsync(int id);
        Task<JobOffer> CreateJobOfferAsync(JobOffer newJobOffer);
        Task UpdateJobOfferAsync(JobOffer updatedJobOffer);
        Task DeleteJobOfferAsync(int id);
    }
}
