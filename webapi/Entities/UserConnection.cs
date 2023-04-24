using System.Data;
using webapi.Entities.Enums;

namespace webapi.Entities
{
    public class UserConnection
    {
        public int Id { get; set; }
        public Account Requestor { get; set; }
        public int RequestorId { get; set; }
        public Account Requested { get; set; }
        public int RequestedId { get; set; }
        public DateTime ConnectionDate { get; set; }
        public ConnectionStatus Status { get; set; }
    }
}
