using System.ComponentModel.DataAnnotations;

namespace webapi.Models.Accounts
{
    public class RegisterRequest
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(50)]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Range(typeof(bool), "true", "true")]
        public bool AcceptTerms { get; set; }

        public int YearsOfExperience { get; set; }

        [StringLength(500)]
        public string ProgrammingLanguages { get; set; }

        [StringLength(500)]
        public string OtherSkills { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        [StringLength(100)]
        public string Country { get; set; }
        [Required]
        public string Phone { get; set; }

    }
}
