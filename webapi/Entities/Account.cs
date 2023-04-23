using Microsoft.AspNetCore.Builder;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using webapi.Entities.Enums;

namespace webapi.Entities
{
    public class Account
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        [JsonIgnore]
        public string PasswordHash { get; set; } = string.Empty;
        public int YearsOfExperience { get; set; }
        public string ProgrammingLanguages { get; set; }
        public string OtherSkills { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public ICollection<JobApplication> JobApplications { get; set; }

        [Column("AcceptTerms")]
        public int _AcceptTerms { get; set; }
        [NotMapped]
        public bool AcceptTerms
        {
            get
            {
                return _AcceptTerms != 0;
            }
            set
            {
                _AcceptTerms = value ? 1 : 0;
            }
        }

        public Role Role { get; set; }
        public string VerificationToken { get; set; }
        public DateTime? Verified { get; set; }
        public bool IsVerified => Verified.HasValue || PasswordReset.HasValue;
        public string? ResetToken { get; set; }
        public DateTime? ResetTokenExpires { get; set; }
        public DateTime? PasswordReset { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        [JsonIgnore]
        public List<RefreshToken> RefreshTokens { get; set; }

        public bool OwnsToken(string token)
        {
            return this.RefreshTokens?.Find(x => x.Token == token) != null;
        }
    }
}
