using webapi.Entities.Enums;

namespace webapi.Entities
{
    public class Incident
    {
        public int Id { get; set; }
        public Account Account { get; set; }
        public int AccountId { get; set; }
        public string Description { get; set; }
        public IncidentType Type { get; set; }
        public DateTime DateOfIncident { get; set; }
    }
}
