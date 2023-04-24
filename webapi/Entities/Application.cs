using webapi.Entities.Enums;

namespace webapi.Entities
{
    public class Application
    {
        public int Id { get; set; }
        public Account Account { get; set; }
        public int AccountId { get; set; }
        public JobOffer JobOffer { get; set; }
        public int JobOfferId { get; set; }
        public DateTime ApplicationDate { get; set; }
        public ApplicationStatus Status { get; set; }
    }
}
