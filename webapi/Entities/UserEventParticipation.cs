using webapi.Entities.Enums;

namespace webapi.Entities
{
    public class UserEventParticipation
    {
        public int Id { get; set; }
        public ProfessionalEvent Event { get; set; }
        public int EventId { get; set; }
        public Account Participant { get; set; }
        public int ParticipantId { get; set; }
        public DateTime DateRegistered { get; set; }
        public ParticipationStatus Status { get; set; }
    }
}
