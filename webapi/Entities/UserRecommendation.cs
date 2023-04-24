using webapi.Entities.Enums;

namespace webapi.Entities
{
    public class UserRecommendation
    {
        public int Id { get; set; }
        public Account User { get; set; }
        public int UserId { get; set; }
        public JobOffer RecommendedJobOffer { get; set; }
        public int RecommendedJobOfferId { get; set; }
        public DateTime DateGenerated { get; set; }
        public RecommendationReason Reason { get; set; }
    }
}
