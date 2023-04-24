using Microsoft.EntityFrameworkCore;
using webapi.Entities;
using webapi.Helpers;
using webapi.Interfaces;

namespace webapi.Services
{
    public class ProfessionalEventService : IProfessionalEventService
    {
        private readonly DataContext _context;
        public ProfessionalEventService (DataContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ProfessionalEvent>> GetAllEventsAsync()
        {
            return await _context.ProfessionalEvents.ToListAsync();
        }

        public async Task<ProfessionalEvent> GetEventByIdAsync(int id)
        {
            return await _context.ProfessionalEvents.FindAsync(id);
        }

        public async Task<ProfessionalEvent> CreateEventAsync(ProfessionalEvent newEvent)
        {
            _context.ProfessionalEvents.Add(newEvent);
            await _context.SaveChangesAsync();
            return newEvent;
        }

        public async Task UpdateEventAsync(ProfessionalEvent updatedEvent)
        {
            _context.Entry(updatedEvent).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteEventAsync(int id)
        {
            var eventToDelete = await _context.ProfessionalEvents.FindAsync(id);
            _context.ProfessionalEvents.Remove(eventToDelete);
            await _context.SaveChangesAsync();
        }
    }
}
