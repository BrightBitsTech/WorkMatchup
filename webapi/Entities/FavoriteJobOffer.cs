namespace webapi.Entities
{
    public class FavoriteJobOffer
    {
        public int Id { get; set; }
        public Account Account { get; set; }
        public int AccountId { get; set; }
        public JobOffer JobOffer { get; set; }
        public int JobOfferId { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
