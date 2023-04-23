using Microsoft.AspNetCore.Builder;
using System.ComponentModel.DataAnnotations;

namespace webapi.Entities
{
    public class JobOffer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [StringLength(500)]
        public string RequiredSkills { get; set; }

        public int YearsOfExperienceRequired { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        [StringLength(100)]
        public string Country { get; set; }

        public ICollection<JobApplication> JobApplications { get; set; }
    }
}
