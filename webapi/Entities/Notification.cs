using webapi.Entities.Enums;

namespace webapi.Entities
{
    public class Notification
    {
        public int Id { get; set; }
        public Account Recipient { get; set; }
        public int RecipientId { get; set; }
        public string Message { get; set; }
        public DateTime DateSent { get; set; }
        public bool IsRead { get; set; }
        public NotificationType Type { get; set; }
    }
}
