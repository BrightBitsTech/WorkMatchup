using Microsoft.AspNetCore.Builder;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using webapi.Entities.AccountDetails;
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
        public string? PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? City { get; set; }
        public int? Experience { get; set; }
        public string? Education { get; set; }
        public Decimal? ExpectedSalary { get; set; }
        public EmploymentType? EmploymentType { get; set; }
        public byte[]? Cv { get; set; }
        public byte[]? Photo { get; set; }

        // Additional navigation properties
        public List<UserLanguage>? UserLanguages { get; set; }
        public List<UserSkill>? UserSkills { get; set; }
        public List<UserInterest>? UserInterests { get; set; }
        public List<Application>? JobApplications { get; set; }
        public List<Message>? Messages { get; set; }
        public List<FavoriteJobOffer>? FavoriteJobOffers { get; set; }
        public List<Interview>? Interviews { get; set; }
        public List<Notification>? Notifications { get; set; }
        public List<SavedJobSearch>? SavedJobSearches { get; set; }
        public List<UserConnection>? UserConnections { get; set; }
        public List<UserEndorsement>? UserEndorsements { get; set; }
        public List<UserGroup>? UserGroups { get; set; }
        public List<UserEventParticipation>? UserEventParticipations { get; set; }





        [JsonIgnore]
        public string PasswordHash { get; set; } = string.Empty;



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
