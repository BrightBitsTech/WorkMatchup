using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using webapi.Authorization;
using webapi.Entities;
using webapi.Helpers;
using webapi.Interfaces;

namespace webapi.Services
{
    public class JobOfferService: IJobOfferService
    {
        private readonly DataContext _context;
        public JobOfferService(DataContext context)
        {
            _context = context;
        }

        public async Task<JobOffer> CreateJobOfferAsync(JobOffer newJobOffer)
        {
            _context.JobOffers.Add(newJobOffer);
            await _context.SaveChangesAsync();
            return newJobOffer;
        }

        public async Task DeleteJobOfferAsync(int id)
        {
            var jobOffer = await _context.JobOffers.FindAsync(id);
            _context.JobOffers.Remove(jobOffer);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<JobOffer>> GetAllJobOffersAsync()
        {
            return await _context.JobOffers.ToListAsync();
        }

        public async Task<JobOffer> GetJobOfferByIdAsync(int id)
        {
            return await _context.JobOffers.FindAsync(id);
        }

        public async Task UpdateJobOfferAsync(JobOffer updatedJobOffer)
        {
            _context.Entry(updatedJobOffer).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
