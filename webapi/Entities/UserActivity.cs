using webapi.Entities.Enums;

namespace webapi.Entities
{
    public class UserActivity
    {
        public int Id { get; set; }
        public Account User { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public ActivityType Type { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
