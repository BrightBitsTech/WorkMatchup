using webapi.Entities;

namespace webapi.Interfaces
{
    public interface IMessageService
    {
        Task<IEnumerable<Message>> GetAllMessagesAsync();
        Task<Message> GetMessageByIdAsync(int id);
        Task<Message> CreateMessageAsync(Message newMessage);
        Task UpdateMessageAsync(Message updatedMessage);
        Task DeleteMessageAsync(int id);
    }
}
