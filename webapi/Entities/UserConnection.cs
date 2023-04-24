using System.Data;
using webapi.Entities.Enums;

namespace webapi.Entities
{
    public class UserConnection
    {
        public int Id { get; set; }
        public Account User { get; set; }
        public int UserId { get; set; }
        public Account ConnectedUser { get; set; }
        public int ConnectedUserId { get; set; }
        public DateTime DateConnected { get; set; }
        public ConnectionStatus Status { get; set; }
    }
}
