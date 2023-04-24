using webapi.Entities;

namespace webapi.Interfaces
{
    public interface IProfessionalEventService
    {
        Task<IEnumerable<ProfessionalEvent>> GetAllEventsAsync();
        Task<ProfessionalEvent> GetEventByIdAsync(int id);
        Task<ProfessionalEvent> CreateEventAsync(ProfessionalEvent newEvent);
        Task UpdateEventAsync(ProfessionalEvent updatedEvent);
        Task DeleteEventAsync(int id);
    }
}
