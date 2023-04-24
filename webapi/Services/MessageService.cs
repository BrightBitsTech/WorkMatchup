using Microsoft.EntityFrameworkCore;
using webapi.Entities;
using webapi.Helpers;
using webapi.Interfaces;

namespace webapi.Services
{
    public class MessageService : IMessageService
    {
        private readonly DataContext _context;
        public MessageService(DataContext context)
        {
            _context = context;
        }
        public async Task<Message> CreateMessageAsync(Message newMessage)
        {
            _context.Messages.Add(newMessage);
            await _context.SaveChangesAsync();
            return newMessage;
        }

        public async Task DeleteMessageAsync(int id)
        {
            var message = await _context.Messages.FindAsync(id);
            _context.Messages.Remove(message);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Message>> GetAllMessagesAsync()
        {
            return await _context.Messages.ToListAsync();
        }

        public async Task<Message> GetMessageByIdAsync(int id)
        {
            return await _context.Messages.FindAsync(id);
        }

        public async Task UpdateMessageAsync(Message updatedMessage)
        {
            _context.Entry(updatedMessage).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
