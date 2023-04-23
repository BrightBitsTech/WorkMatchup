using System.ComponentModel.DataAnnotations;

namespace webapi.Entities
{
    public class JobApplication
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int AccountId { get; set; }

        [Required]
        public int JobOfferId { get; set; }

        [Required]
        public DateTime ApplicationDate { get; set; }

        public Account Account { get; set; }

        public JobOffer JobOffer { get; set; }
    }
}
