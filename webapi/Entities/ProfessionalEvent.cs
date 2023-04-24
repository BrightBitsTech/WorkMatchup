namespace webapi.Entities
{
    public class ProfessionalEvent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Account Organizer { get; set; }
        public int OrganizerId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Location { get; set; }
        public List<UserEventParticipation> Participants { get; set; }
    }
}
